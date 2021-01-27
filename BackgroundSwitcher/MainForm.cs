using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using Windows.Native;
using Microsoft.Win32;
using System.Linq;

namespace BackgroundSwitcher {
    public partial class MainForm : Form {
        public static List<string> ImageExtensions = new List<string>();
        public List<string> SlideShowFiles = new List<string>();
        public List<string> SlideShowHistory = new List<string>();
        public System.Timers.Timer cycleTimer = new System.Timers.Timer();

        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "DesktopSlideshow";

        public BackgroundWorker scanBW;
        public int dirFiles;
        public int curFile;
        public int imageFiles;

        public MainForm() {
            InitializeComponent();
            scanBW = new BackgroundWorker();
            scanBW.DoWork += new DoWorkEventHandler(scanBW_DoWork);
            scanBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(scanBW_Completed);
            cycleTimer.Elapsed += new System.Timers.ElapsedEventHandler(CycleTimer);
        }


        public void ProcessDirectory(string targetDirectory) {
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public void ProcessFile(string path) {
            curFile++;
            if (ImageExtensions.Contains(Path.GetExtension(path).ToUpperInvariant())) {
                imageFiles++;
                SlideShowFiles.Add(path);
            }
            this.Invoke((MethodInvoker)delegate () {
                auxLabelScanDesc.Text = "Scanning " + curFile + " of " + dirFiles + " files. Found " + imageFiles + " usable image files.";
                int progPerc = (curFile * 100) / dirFiles;
                if (progPerc > 100) progPerc = 100;
                scanProgress.Value = progPerc;
            });
        }

        private void folderBrowserInvokeButton_Click(object sender, EventArgs e) {
            DialogResult dlgResult = folderBrowser.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK)) {
                folderBox.Text = folderBrowser.SelectedPath;
            }
        }

        private void scanFolderButton_Click(object sender, EventArgs e) {
            if (SlideShowFiles.Count > 0) SlideShowFiles.Clear();
            if (queueListView.Items.Count > 0) queueListView.Items.Clear();
            if (pngBox.Checked != true && tiffBox.Checked != true && jpgBox.Checked != true && bmpBox.Checked != true) {
                MessageBox.Show("You must choose atleast one image format.", "No image format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (scanBW.IsBusy) {
                MessageBox.Show("There is already a scan in progress.", "Scan in progress", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Directory.Exists(folderBox.Text)) {
                PopulateFormatList();
                dirFiles = GetFileCount(folderBox.Text, "*", SearchOption.AllDirectories);
                scanBW.RunWorkerAsync(folderBox.Text);
            } else MessageBox.Show("Invalid folder specified.", "Invalid folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            startButton.Enabled = false;
        }

        private void scanBW_DoWork(object sender, DoWorkEventArgs e) {
            string workingDirectory = (string)e.Argument;
            curFile = 1;
            imageFiles = 0;
            SlideShowFiles.Clear();
            ProcessDirectory(workingDirectory);
        }

        private void scanBW_Completed(object sender, RunWorkerCompletedEventArgs e) {
            //MessageBox.Show(SlideShowFiles.Count.ToString());
            if (SlideShowFiles.Count == 0) {
                this.Invoke((MethodInvoker)delegate () { auxLabelScanDesc.Text = "Done - found no usable images."; });
                MessageBox.Show("No usable image files were found. Please search again.", "No image files found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                this.Invoke((MethodInvoker)delegate () {
                    auxLabelScanDesc.Text = "Done - found " + SlideShowFiles.Count.ToString() + " usable images.";
                    startButton.Enabled = true;

                    int index = 1;
                    foreach (string SlideShowFile in SlideShowFiles) {

                        ListViewItem listvI = new ListViewItem(index.ToString());
                        listvI.SubItems.Add(Path.GetFileName(SlideShowFile));
                        listvI.SubItems.Add(SlideShowFile);
                        queueListView.Items.Add(listvI);
                        index++;
                    }
                });
            }
        }
        private void nextButton_Click(object sender, EventArgs e) {
            CycleWallpaper();
        }

        private void backButton_Click(object sender, EventArgs e) {
            CycleWallpaper(true);
        }

        public static int GetFileCount(string path, string searchPattern, SearchOption searchOption) {
            var fileCount = 0;
            var fileIter = Directory.EnumerateFiles(path, searchPattern, searchOption);
            foreach (var file in fileIter)
                fileCount++;
            return fileCount;
        }

        public void PopulateFormatList() {
            ImageExtensions.Clear();
            if (pngBox.Checked)
                ImageExtensions.Add(".PNG");
            if (tiffBox.Checked)
                ImageExtensions.Add(".TIFF");
            if (jpgBox.Checked)
                ImageExtensions.Add(".JPG");
            if (bmpBox.Checked)
                ImageExtensions.Add(".BMP");
            Properties.Settings.Default.ImageTypes = String.Join(",", ImageExtensions.ToArray());
        }

        private void startButton_Click(object sender, EventArgs e) {
            if (!startButton.Enabled) return; // Hacky workaround for toolbar hits.
            double n = GetMinsFromInterVal(switchInterval.Value);
            int multVal = 0;
            if (secRadio.Checked) multVal = 1000;
            else if (minRadio.Checked) multVal = 60000;
            else if (hourRadio.Checked) multVal = 3600000;
            cycleTimer.Interval = n * multVal;
            cycleTimer.Enabled = true;
            auxLabelScanDesc.Text = "Started slideshow of " + SlideShowFiles.Count + " files switching every " + n + " minutes.";

            startButton.Enabled = false;
            stopButton.Enabled = true;
            CycleWallpaper();
        }
        private void stopButton_Click(object sender, EventArgs e) {
            if (!stopButton.Enabled) return; // Hacky workaround for toolbar hits.
            if (cycleTimer.Enabled) // Kill the timer, and switch enabled buttons.
                cycleTimer.Enabled = false;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            SlideShowHistory.Clear();
            auxLabelScanDesc.Text = "Slideshow stopped. Ready.";
        }

        private void CycleTimer(object sender, System.Timers.ElapsedEventArgs e) {
            this.Invoke((MethodInvoker)delegate () { CycleWallpaper(); });
        }

        public void CycleWallpaper(bool backwards = false) {
            if (SlideShowFiles.Count < 2) {   // If there are no more images in the queue
                cycleTimer.Enabled = false;
                SlideShowFiles.Clear();
                SlideShowHistory.Clear();
                startButton.Enabled = false;
                stopButton.Enabled = false;
                MessageBox.Show("The slideshow has completed - there are no images left in the queue. Please scan again to fill the queue.", "Slideshow finished.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!backwards) {
                int offset = SlideShowFiles.Count - 1;

                IActiveDesktop iad = shlobj.GetActiveDesktop();
                iad.SetWallpaper(SlideShowFiles[offset], 0);
                iad.ApplyChanges(AD_Apply.ALL | AD_Apply.FORCE | AD_Apply.BUFFERED_REFRESH);

                pictureBox1.ImageLocation = SlideShowFiles[offset];

                SlideShowHistory.Add(SlideShowFiles[offset]);
                SlideShowFiles.RemoveAt(offset);

                return;
            } else {
                if (SlideShowHistory.Count < 2) {
                    MessageBox.Show("There are no images to skip backwards to.", "Cannot skip backward.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int offset = SlideShowHistory.Count - 2;

                IActiveDesktop iad = shlobj.GetActiveDesktop();
                iad.SetWallpaper(SlideShowHistory[offset], 0);
                iad.ApplyChanges(AD_Apply.ALL | AD_Apply.FORCE | AD_Apply.BUFFERED_REFRESH);

                pictureBox1.ImageLocation = SlideShowHistory[offset];

                string item = SlideShowHistory[offset];
                SlideShowHistory.Add(item);
                SlideShowHistory.RemoveAt(offset);
                return;
            }

        }

        private void backwardToolStripMenuItem_Click(object sender, EventArgs e) {
            CycleWallpaper(true);
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e) {
            CycleWallpaper();
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            trayIcon.BalloonTipTitle = "Minimized to tray...";
            trayIcon.BalloonTipText = "Desktop Slideshow has been minimized to your app tray.";

            if (FormWindowState.Minimized == this.WindowState) {
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(500);
                this.Hide();
            } else if (FormWindowState.Normal == this.WindowState) {
                trayIcon.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private Double GetMinsFromInterVal(int value) {
            var timeValues = new double[] {
                0.5, 1.0, 2.0, 3.0, 5.0, 10.0, 15.0, 30.0, 45.0, 60.0, 90.0
            };
            return timeValues[value];
        }

        private void hideQueueButton_Click(object sender, EventArgs e) {
            if (queueGroupBox.Visible) {
                queueGroupBox.Visible = false;
                MainForm.ActiveForm.Width = 400;
                hideQueueButton.Text = "SHOW QUEUE";
            } else {
                MainForm.ActiveForm.Width = 940;
                queueGroupBox.Visible = true;
                hideQueueButton.Text = "HIDE QUEUE";
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void launchOnStartupToolStripMenuItem_Click(object sender, EventArgs e) {
            SetStartup(launchOnStartupToolStripMenuItem.Checked);
        }

        private void CheckStartup() {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);

            if (key.GetValue(StartupValue) == null) {
                launchOnStartupToolStripMenuItem.Checked = false;
            } else launchOnStartupToolStripMenuItem.Checked = true;
        }

        private static void SetStartup(bool startup) {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            switch (startup) {
                case true: {
                        key.SetValue(StartupValue, Application.ExecutablePath.ToString());
                        break;
                    }
                case false: {
                        key.DeleteValue(StartupValue);
                        break;
                    }
            }

        }

        private void LoadSettings() {
            ImageExtensions = Properties.Settings.Default.ImageTypes.Split(',').ToList();
            if (ImageExtensions.Contains(".PNG")) pngBox.Checked = true;
            else pngBox.Checked = false;
            if (ImageExtensions.Contains(".JPG")) jpgBox.Checked = true;
            else jpgBox.Checked = false;
            if (ImageExtensions.Contains(".TIFF")) tiffBox.Checked = true;
            else tiffBox.Checked = false;
            if (ImageExtensions.Contains(".BMP")) bmpBox.Checked = true;
            else bmpBox.Checked = false;

            folderBox.Text = Properties.Settings.Default.ImageFolder;
            switchInterval.Value = (int)Properties.Settings.Default.TimeAmount;
            
            switch(Properties.Settings.Default.TimeType) {
                case 1: {
                        secRadio.Checked = true;
                        break;
                    }
                case 2: {
                        minRadio.Checked = true;
                        break;
                    }
                case 3: {
                        hourRadio.Checked = true;
                        break;
                    }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            CheckStartup();
            LoadSettings();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            string ImageTypesString = "";
            if (pngBox.Checked) ImageTypesString += ".PNG,";
            if (jpgBox.Checked) ImageTypesString += ".JPG,";
            if (tiffBox.Checked) ImageTypesString += ".TIFF,";
            if (bmpBox.Checked) ImageTypesString += ".BMP";
            Properties.Settings.Default.ImageTypes = ImageTypesString;

            Properties.Settings.Default.ImageFolder = folderBox.Text;
            Properties.Settings.Default.TimeAmount = switchInterval.Value;
            Properties.Settings.Default.TimeType = minRadio.Checked ? 1 : (secRadio.Checked ? 2 : (hourRadio.Checked ? 3 : 0));

            Properties.Settings.Default.Save();
        }

        private void shuffleToolStripMenuItem_Click(object sender, EventArgs e) {
            if(SlideShowFiles.Count > 0) {
                SlideShowFiles.Shuffle();
            }
        }
    }

    public static class ListExtension {
        public static void Shuffle<T>(this IList<T> list) {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }



}
