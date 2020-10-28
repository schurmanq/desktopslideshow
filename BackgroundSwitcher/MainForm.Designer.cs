namespace BackgroundSwitcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSlideshowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.skipCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.scanProgress = new System.Windows.Forms.ProgressBar();
            this.auxLabelScanDesc = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserInvokeButton = new System.Windows.Forms.Button();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.auxLabelImgFolder = new System.Windows.Forms.Label();
            this.auxLabelSwitchInterval = new System.Windows.Forms.Label();
            this.scanFolderButton = new System.Windows.Forms.Button();
            this.auxLabelImageFormat = new System.Windows.Forms.Label();
            this.pngBox = new System.Windows.Forms.CheckBox();
            this.jpgBox = new System.Windows.Forms.CheckBox();
            this.tiffBox = new System.Windows.Forms.CheckBox();
            this.bmpBox = new System.Windows.Forms.CheckBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.skipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backwardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.switchInterval = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Slideshow = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hideQueueButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.queueGroupBox = new System.Windows.Forms.GroupBox();
            this.queueListView = new System.Windows.Forms.ListView();
            this.queueHeaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queueHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queueHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip.SuspendLayout();
            this.trayIconContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Slideshow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.queueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(928, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSlideshowToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startSlideshowToolStripMenuItem
            // 
            this.startSlideshowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator1,
            this.skipCurrentToolStripMenuItem});
            this.startSlideshowToolStripMenuItem.Name = "startSlideshowToolStripMenuItem";
            this.startSlideshowToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.startSlideshowToolStripMenuItem.Text = "Slideshow...";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.startToolStripMenuItem.Text = "Start...";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.stopToolStripMenuItem.Text = "Stop...";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // skipCurrentToolStripMenuItem
            // 
            this.skipCurrentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forwardToolStripMenuItem,
            this.backwardToolStripMenuItem});
            this.skipCurrentToolStripMenuItem.Name = "skipCurrentToolStripMenuItem";
            this.skipCurrentToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.skipCurrentToolStripMenuItem.Text = "Skip...";
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.forwardToolStripMenuItem.Text = "Forward...";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // backwardToolStripMenuItem
            // 
            this.backwardToolStripMenuItem.Name = "backwardToolStripMenuItem";
            this.backwardToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.backwardToolStripMenuItem.Text = "Backward...";
            this.backwardToolStripMenuItem.Click += new System.EventHandler(this.backwardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.BackColor = System.Drawing.Color.LawnGreen;
            this.startButton.Enabled = false;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(13, 350);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(158, 38);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopButton.BackColor = System.Drawing.Color.Red;
            this.stopButton.Enabled = false;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(188, 350);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(163, 38);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // scanProgress
            // 
            this.scanProgress.Location = new System.Drawing.Point(6, 146);
            this.scanProgress.Name = "scanProgress";
            this.scanProgress.Size = new System.Drawing.Size(345, 23);
            this.scanProgress.TabIndex = 3;
            // 
            // auxLabelScanDesc
            // 
            this.auxLabelScanDesc.AutoSize = true;
            this.auxLabelScanDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auxLabelScanDesc.Location = new System.Drawing.Point(6, 123);
            this.auxLabelScanDesc.Name = "auxLabelScanDesc";
            this.auxLabelScanDesc.Size = new System.Drawing.Size(98, 16);
            this.auxLabelScanDesc.TabIndex = 4;
            this.auxLabelScanDesc.Text = "Ready to scan.";
            // 
            // folderBrowserInvokeButton
            // 
            this.folderBrowserInvokeButton.Location = new System.Drawing.Point(321, 36);
            this.folderBrowserInvokeButton.Name = "folderBrowserInvokeButton";
            this.folderBrowserInvokeButton.Size = new System.Drawing.Size(33, 20);
            this.folderBrowserInvokeButton.TabIndex = 5;
            this.folderBrowserInvokeButton.Text = "...";
            this.folderBrowserInvokeButton.UseVisualStyleBackColor = true;
            this.folderBrowserInvokeButton.Click += new System.EventHandler(this.folderBrowserInvokeButton_Click);
            // 
            // folderBox
            // 
            this.folderBox.Location = new System.Drawing.Point(6, 36);
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(309, 20);
            this.folderBox.TabIndex = 6;
            // 
            // auxLabelImgFolder
            // 
            this.auxLabelImgFolder.AutoSize = true;
            this.auxLabelImgFolder.Location = new System.Drawing.Point(3, 20);
            this.auxLabelImgFolder.Name = "auxLabelImgFolder";
            this.auxLabelImgFolder.Size = new System.Drawing.Size(68, 13);
            this.auxLabelImgFolder.TabIndex = 7;
            this.auxLabelImgFolder.Text = "Image folder:";
            // 
            // auxLabelSwitchInterval
            // 
            this.auxLabelSwitchInterval.AutoSize = true;
            this.auxLabelSwitchInterval.Location = new System.Drawing.Point(7, 277);
            this.auxLabelSwitchInterval.Name = "auxLabelSwitchInterval";
            this.auxLabelSwitchInterval.Size = new System.Drawing.Size(125, 13);
            this.auxLabelSwitchInterval.TabIndex = 8;
            this.auxLabelSwitchInterval.Text = "Switch Interval (minutes):";
            // 
            // scanFolderButton
            // 
            this.scanFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanFolderButton.Location = new System.Drawing.Point(6, 175);
            this.scanFolderButton.Name = "scanFolderButton";
            this.scanFolderButton.Size = new System.Drawing.Size(348, 38);
            this.scanFolderButton.TabIndex = 11;
            this.scanFolderButton.Text = "SCAN FOLDER";
            this.scanFolderButton.UseVisualStyleBackColor = true;
            this.scanFolderButton.Click += new System.EventHandler(this.scanFolderButton_Click);
            // 
            // auxLabelImageFormat
            // 
            this.auxLabelImageFormat.AutoSize = true;
            this.auxLabelImageFormat.Location = new System.Drawing.Point(3, 59);
            this.auxLabelImageFormat.Name = "auxLabelImageFormat";
            this.auxLabelImageFormat.Size = new System.Drawing.Size(79, 13);
            this.auxLabelImageFormat.TabIndex = 12;
            this.auxLabelImageFormat.Text = "Image Formats:";
            // 
            // pngBox
            // 
            this.pngBox.AutoSize = true;
            this.pngBox.Checked = true;
            this.pngBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pngBox.Location = new System.Drawing.Point(6, 75);
            this.pngBox.Name = "pngBox";
            this.pngBox.Size = new System.Drawing.Size(49, 17);
            this.pngBox.TabIndex = 13;
            this.pngBox.Text = "PNG";
            this.pngBox.UseVisualStyleBackColor = true;
            // 
            // jpgBox
            // 
            this.jpgBox.AutoSize = true;
            this.jpgBox.Checked = true;
            this.jpgBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jpgBox.Location = new System.Drawing.Point(6, 96);
            this.jpgBox.Name = "jpgBox";
            this.jpgBox.Size = new System.Drawing.Size(46, 17);
            this.jpgBox.TabIndex = 14;
            this.jpgBox.Text = "JPG";
            this.jpgBox.UseVisualStyleBackColor = true;
            // 
            // tiffBox
            // 
            this.tiffBox.AutoSize = true;
            this.tiffBox.Location = new System.Drawing.Point(196, 75);
            this.tiffBox.Name = "tiffBox";
            this.tiffBox.Size = new System.Drawing.Size(48, 17);
            this.tiffBox.TabIndex = 15;
            this.tiffBox.Text = "TIFF";
            this.tiffBox.UseVisualStyleBackColor = true;
            // 
            // bmpBox
            // 
            this.bmpBox.AutoSize = true;
            this.bmpBox.Location = new System.Drawing.Point(196, 96);
            this.bmpBox.Name = "bmpBox";
            this.bmpBox.Size = new System.Drawing.Size(49, 17);
            this.bmpBox.TabIndex = 16;
            this.bmpBox.Text = "BMP";
            this.bmpBox.UseVisualStyleBackColor = true;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "trayIcon";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // trayIconContextMenu
            // 
            this.trayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.startToolStripMenuItem1,
            this.stopToolStripMenuItem1,
            this.toolStripSeparator3,
            this.skipToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem2});
            this.trayIconContextMenu.Name = "trayIconContextMenu";
            this.trayIconContextMenu.Size = new System.Drawing.Size(219, 132);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openToolStripMenuItem.Text = "Open Background Switcher";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            this.startToolStripMenuItem1.Text = "Start...";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            this.stopToolStripMenuItem1.Text = "Stop...";
            this.stopToolStripMenuItem1.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // skipToolStripMenuItem
            // 
            this.skipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forwardToolStripMenuItem1,
            this.backwardToolStripMenuItem1});
            this.skipToolStripMenuItem.Name = "skipToolStripMenuItem";
            this.skipToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.skipToolStripMenuItem.Text = "Skip...";
            // 
            // forwardToolStripMenuItem1
            // 
            this.forwardToolStripMenuItem1.Name = "forwardToolStripMenuItem1";
            this.forwardToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.forwardToolStripMenuItem1.Text = "Forward...";
            this.forwardToolStripMenuItem1.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // backwardToolStripMenuItem1
            // 
            this.backwardToolStripMenuItem1.Name = "backwardToolStripMenuItem1";
            this.backwardToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.backwardToolStripMenuItem1.Text = "Backward...";
            this.backwardToolStripMenuItem1.Click += new System.EventHandler(this.backwardToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(215, 6);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(218, 22);
            this.exitToolStripMenuItem2.Text = "Exit...";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // switchInterval
            // 
            this.switchInterval.Location = new System.Drawing.Point(10, 293);
            this.switchInterval.Name = "switchInterval";
            this.switchInterval.Size = new System.Drawing.Size(341, 45);
            this.switchInterval.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.folderBox);
            this.groupBox1.Controls.Add(this.folderBrowserInvokeButton);
            this.groupBox1.Controls.Add(this.scanProgress);
            this.groupBox1.Controls.Add(this.auxLabelScanDesc);
            this.groupBox1.Controls.Add(this.auxLabelImgFolder);
            this.groupBox1.Controls.Add(this.bmpBox);
            this.groupBox1.Controls.Add(this.scanFolderButton);
            this.groupBox1.Controls.Add(this.tiffBox);
            this.groupBox1.Controls.Add(this.auxLabelImageFormat);
            this.groupBox1.Controls.Add(this.jpgBox);
            this.groupBox1.Controls.Add(this.pngBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 219);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder Scan";
            // 
            // Slideshow
            // 
            this.Slideshow.Controls.Add(this.label11);
            this.Slideshow.Controls.Add(this.label10);
            this.Slideshow.Controls.Add(this.label9);
            this.Slideshow.Controls.Add(this.label8);
            this.Slideshow.Controls.Add(this.label7);
            this.Slideshow.Controls.Add(this.label6);
            this.Slideshow.Controls.Add(this.label5);
            this.Slideshow.Controls.Add(this.label4);
            this.Slideshow.Controls.Add(this.label3);
            this.Slideshow.Controls.Add(this.label2);
            this.Slideshow.Controls.Add(this.label1);
            this.Slideshow.Controls.Add(this.hideQueueButton);
            this.Slideshow.Controls.Add(this.nextButton);
            this.Slideshow.Controls.Add(this.backButton);
            this.Slideshow.Controls.Add(this.pictureBox1);
            this.Slideshow.Controls.Add(this.startButton);
            this.Slideshow.Controls.Add(this.stopButton);
            this.Slideshow.Controls.Add(this.switchInterval);
            this.Slideshow.Controls.Add(this.auxLabelSwitchInterval);
            this.Slideshow.Location = new System.Drawing.Point(12, 252);
            this.Slideshow.Name = "Slideshow";
            this.Slideshow.Size = new System.Drawing.Size(360, 394);
            this.Slideshow.TabIndex = 19;
            this.Slideshow.TabStop = false;
            this.Slideshow.Text = "Slideshow";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "90";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "60";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "45";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "30";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "1/2";
            // 
            // hideQueueButton
            // 
            this.hideQueueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideQueueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideQueueButton.Location = new System.Drawing.Point(100, 237);
            this.hideQueueButton.Name = "hideQueueButton";
            this.hideQueueButton.Size = new System.Drawing.Size(158, 37);
            this.hideQueueButton.TabIndex = 21;
            this.hideQueueButton.Text = "HIDE QUEUE";
            this.hideQueueButton.UseVisualStyleBackColor = true;
            this.hideQueueButton.Click += new System.EventHandler(this.hideQueueButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(185, 188);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(163, 41);
            this.nextButton.TabIndex = 20;
            this.nextButton.Text = "SKIP FWD >>>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(10, 188);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(158, 41);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "<<< SKIP BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // queueGroupBox
            // 
            this.queueGroupBox.Controls.Add(this.queueListView);
            this.queueGroupBox.Location = new System.Drawing.Point(378, 27);
            this.queueGroupBox.Name = "queueGroupBox";
            this.queueGroupBox.Size = new System.Drawing.Size(538, 619);
            this.queueGroupBox.TabIndex = 21;
            this.queueGroupBox.TabStop = false;
            this.queueGroupBox.Text = "Queue";
            // 
            // queueListView
            // 
            this.queueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.queueHeaderIndex,
            this.queueHeaderFile,
            this.queueHeaderPath});
            this.queueListView.FullRowSelect = true;
            this.queueListView.HideSelection = false;
            this.queueListView.Location = new System.Drawing.Point(6, 16);
            this.queueListView.Name = "queueListView";
            this.queueListView.Size = new System.Drawing.Size(526, 591);
            this.queueListView.TabIndex = 0;
            this.queueListView.UseCompatibleStateImageBehavior = false;
            this.queueListView.View = System.Windows.Forms.View.Details;
            // 
            // queueHeaderIndex
            // 
            this.queueHeaderIndex.Text = "Index";
            this.queueHeaderIndex.Width = 38;
            // 
            // queueHeaderFile
            // 
            this.queueHeaderFile.Text = "File Name";
            this.queueHeaderFile.Width = 149;
            // 
            // queueHeaderPath
            // 
            this.queueHeaderPath.Text = "Path";
            this.queueHeaderPath.Width = 330;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 656);
            this.Controls.Add(this.queueGroupBox);
            this.Controls.Add(this.Slideshow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Slideshow";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.trayIconContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.switchInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Slideshow.ResumeLayout(false);
            this.Slideshow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.queueGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSlideshowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem skipCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ProgressBar scanProgress;
        private System.Windows.Forms.Label auxLabelScanDesc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button folderBrowserInvokeButton;
        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.Label auxLabelImgFolder;
        private System.Windows.Forms.Label auxLabelSwitchInterval;
        private System.Windows.Forms.Button scanFolderButton;
        private System.Windows.Forms.Label auxLabelImageFormat;
        private System.Windows.Forms.CheckBox pngBox;
        private System.Windows.Forms.CheckBox jpgBox;
        private System.Windows.Forms.CheckBox tiffBox;
        private System.Windows.Forms.CheckBox bmpBox;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backwardToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem skipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backwardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.TrackBar switchInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Slideshow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox queueGroupBox;
        private System.Windows.Forms.ListView queueListView;
        private System.Windows.Forms.ColumnHeader queueHeaderIndex;
        private System.Windows.Forms.ColumnHeader queueHeaderFile;
        private System.Windows.Forms.ColumnHeader queueHeaderPath;
        private System.Windows.Forms.Button hideQueueButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

