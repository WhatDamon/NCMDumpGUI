﻿namespace NCMDumpGUI
{
    partial class WndMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            filepathTextBox = new TextBox();
            browseButton = new Button();
            convertButton = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            fixMetaDataCheckBox = new CheckBox();
            toolTip = new ToolTip(components);
            linkLabel1 = new LinkLabel();
            fileFolderComboBox = new ComboBox();
            scanMoreFoldersCheckBox = new CheckBox();
            filesizeLabel = new Label();
            playGroupBox = new GroupBox();
            playMoreButton = new Button();
            audioProgressLabel = new Label();
            playResumeButton = new Button();
            audioProgressTrackBar = new TrackBar();
            playMoreBtnContextMenuStrip = new ContextMenuStrip(components);
            openWithDefaultPlayerToolStripMenuItem = new ToolStripMenuItem();
            openFileLocationToolStripMenuItem = new ToolStripMenuItem();
            timerTrackBar = new System.Windows.Forms.Timer(components);
            folderConvertContextMenuStrip = new ContextMenuStrip(components);
            autoDumpToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            playGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)audioProgressTrackBar).BeginInit();
            playMoreBtnContextMenuStrip.SuspendLayout();
            folderConvertContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 24);
            label1.TabIndex = 0;
            label1.Text = "文件&&目录路径（可以直接拖入）：";
            // 
            // filepathTextBox
            // 
            filepathTextBox.Location = new Point(93, 37);
            filepathTextBox.Name = "filepathTextBox";
            filepathTextBox.Size = new Size(379, 30);
            filepathTextBox.TabIndex = 1;
            filepathTextBox.TextChanged += filepathTextBox_TextChanged;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(474, 36);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(45, 34);
            browseButton.TabIndex = 2;
            browseButton.Text = "...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(16, 72);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(112, 34);
            convertButton.TabIndex = 3;
            convertButton.Text = "转换";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripProgressBar1 });
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            statusStrip1.Location = new Point(0, 234);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(531, 36);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabel1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(70, 29);
            toolStripStatusLabel1.Text = "状态：";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(100, 29);
            toolStripStatusLabel2.Text = "请提供文件";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Alignment = ToolStripItemAlignment.Right;
            toolStripProgressBar1.MarqueeAnimationSpeed = 1;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 28);
            toolStripProgressBar1.Step = 5;
            // 
            // fixMetaDataCheckBox
            // 
            fixMetaDataCheckBox.AutoSize = true;
            fixMetaDataCheckBox.Checked = true;
            fixMetaDataCheckBox.CheckState = CheckState.Checked;
            fixMetaDataCheckBox.Location = new Point(392, 78);
            fixMetaDataCheckBox.Name = "fixMetaDataCheckBox";
            fixMetaDataCheckBox.Size = new Size(126, 28);
            fixMetaDataCheckBox.TabIndex = 5;
            fixMetaDataCheckBox.Text = "修复元数据";
            fixMetaDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(437, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(82, 24);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "免责声明";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // fileFolderComboBox
            // 
            fileFolderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fileFolderComboBox.FlatStyle = FlatStyle.System;
            fileFolderComboBox.FormattingEnabled = true;
            fileFolderComboBox.Items.AddRange(new object[] { "文件", "目录" });
            fileFolderComboBox.Location = new Point(16, 36);
            fileFolderComboBox.Name = "fileFolderComboBox";
            fileFolderComboBox.Size = new Size(77, 32);
            fileFolderComboBox.TabIndex = 7;
            fileFolderComboBox.SelectedIndexChanged += fileFolderComboBox_SelectedIndexChanged;
            // 
            // scanMoreFoldersCheckBox
            // 
            scanMoreFoldersCheckBox.AutoSize = true;
            scanMoreFoldersCheckBox.Location = new Point(260, 78);
            scanMoreFoldersCheckBox.Name = "scanMoreFoldersCheckBox";
            scanMoreFoldersCheckBox.Size = new Size(126, 28);
            scanMoreFoldersCheckBox.TabIndex = 8;
            scanMoreFoldersCheckBox.Text = "扫描子目录";
            scanMoreFoldersCheckBox.UseVisualStyleBackColor = true;
            scanMoreFoldersCheckBox.Visible = false;
            // 
            // filesizeLabel
            // 
            filesizeLabel.AutoSize = true;
            filesizeLabel.Location = new Point(134, 77);
            filesizeLabel.Name = "filesizeLabel";
            filesizeLabel.Size = new Size(0, 24);
            filesizeLabel.TabIndex = 9;
            // 
            // playGroupBox
            // 
            playGroupBox.Controls.Add(playMoreButton);
            playGroupBox.Controls.Add(audioProgressLabel);
            playGroupBox.Controls.Add(playResumeButton);
            playGroupBox.Controls.Add(audioProgressTrackBar);
            playGroupBox.Enabled = false;
            playGroupBox.Location = new Point(16, 112);
            playGroupBox.Name = "playGroupBox";
            playGroupBox.Size = new Size(502, 112);
            playGroupBox.TabIndex = 10;
            playGroupBox.TabStop = false;
            playGroupBox.Text = "播放";
            // 
            // playMoreButton
            // 
            playMoreButton.Cursor = Cursors.Hand;
            playMoreButton.Font = new Font("Microsoft YaHei UI", 6F);
            playMoreButton.Location = new Point(6, 72);
            playMoreButton.Name = "playMoreButton";
            playMoreButton.Size = new Size(40, 26);
            playMoreButton.TabIndex = 3;
            playMoreButton.Text = "…";
            playMoreButton.TextAlign = ContentAlignment.TopCenter;
            playMoreButton.UseVisualStyleBackColor = true;
            playMoreButton.Click += playMoreButton_Click;
            // 
            // audioProgressLabel
            // 
            audioProgressLabel.AutoSize = true;
            audioProgressLabel.Font = new Font("Microsoft YaHei UI", 7F);
            audioProgressLabel.ForeColor = SystemColors.ControlDarkDark;
            audioProgressLabel.Location = new Point(403, 78);
            audioProgressLabel.Name = "audioProgressLabel";
            audioProgressLabel.Size = new Size(93, 20);
            audioProgressLabel.TabIndex = 2;
            audioProgressLabel.Text = "00:00 / 00:00";
            audioProgressLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // playResumeButton
            // 
            playResumeButton.Location = new Point(6, 29);
            playResumeButton.Name = "playResumeButton";
            playResumeButton.Size = new Size(40, 44);
            playResumeButton.TabIndex = 1;
            playResumeButton.Text = "▶️";
            playResumeButton.UseVisualStyleBackColor = true;
            playResumeButton.Click += playResumeButton_Click;
            // 
            // audioProgressTrackBar
            // 
            audioProgressTrackBar.Location = new Point(52, 29);
            audioProgressTrackBar.Name = "audioProgressTrackBar";
            audioProgressTrackBar.Size = new Size(444, 69);
            audioProgressTrackBar.TabIndex = 0;
            audioProgressTrackBar.TickStyle = TickStyle.Both;
            audioProgressTrackBar.Scroll += audioProgressTrackBar_Scroll;
            // 
            // playMoreBtnContextMenuStrip
            // 
            playMoreBtnContextMenuStrip.BackgroundImageLayout = ImageLayout.None;
            playMoreBtnContextMenuStrip.ImageScalingSize = new Size(24, 24);
            playMoreBtnContextMenuStrip.Items.AddRange(new ToolStripItem[] { openWithDefaultPlayerToolStripMenuItem, openFileLocationToolStripMenuItem });
            playMoreBtnContextMenuStrip.Name = "playBtnContextMenuStrip";
            playMoreBtnContextMenuStrip.RenderMode = ToolStripRenderMode.System;
            playMoreBtnContextMenuStrip.Size = new Size(281, 68);
            // 
            // openWithDefaultPlayerToolStripMenuItem
            // 
            openWithDefaultPlayerToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            openWithDefaultPlayerToolStripMenuItem.Name = "openWithDefaultPlayerToolStripMenuItem";
            openWithDefaultPlayerToolStripMenuItem.Size = new Size(280, 32);
            openWithDefaultPlayerToolStripMenuItem.Text = "使用系统默认播放器打开";
            openWithDefaultPlayerToolStripMenuItem.Click += openWithDefaultPlayerToolStripMenuItem_Click;
            // 
            // openFileLocationToolStripMenuItem
            // 
            openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            openFileLocationToolStripMenuItem.Size = new Size(280, 32);
            openFileLocationToolStripMenuItem.Text = "打开文件所在位置";
            openFileLocationToolStripMenuItem.Click += openFileLocationToolStripMenuItem_Click;
            // 
            // timerTrackBar
            // 
            timerTrackBar.Tick += timerTrackBar_Tick;
            // 
            // folderConvertContextMenuStrip
            // 
            folderConvertContextMenuStrip.ImageScalingSize = new Size(24, 24);
            folderConvertContextMenuStrip.Items.AddRange(new ToolStripItem[] { autoDumpToolStripMenuItem });
            folderConvertContextMenuStrip.Name = "folderConvertContextMenuStrip";
            folderConvertContextMenuStrip.RenderMode = ToolStripRenderMode.System;
            folderConvertContextMenuStrip.Size = new Size(286, 69);
            // 
            // autoDumpToolStripMenuItem
            // 
            autoDumpToolStripMenuItem.Enabled = false;
            autoDumpToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            autoDumpToolStripMenuItem.Name = "autoDumpToolStripMenuItem";
            autoDumpToolStripMenuItem.Size = new Size(285, 32);
            autoDumpToolStripMenuItem.Text = "启用 文件夹实时自动转换";
            autoDumpToolStripMenuItem.Click += autoDumpToolStripMenuItem_Click;
            // 
            // WndMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 270);
            Controls.Add(playGroupBox);
            Controls.Add(filesizeLabel);
            Controls.Add(scanMoreFoldersCheckBox);
            Controls.Add(fileFolderComboBox);
            Controls.Add(linkLabel1);
            Controls.Add(fixMetaDataCheckBox);
            Controls.Add(statusStrip1);
            Controls.Add(convertButton);
            Controls.Add(browseButton);
            Controls.Add(filepathTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WndMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NCMDumpGUI";
            FormClosed += WndMain_FormClosed;
            DragDrop += WndMain_DragDrop;
            DragEnter += WndMain_DragEnter;
            KeyDown += WndMain_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            playGroupBox.ResumeLayout(false);
            playGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)audioProgressTrackBar).EndInit();
            playMoreBtnContextMenuStrip.ResumeLayout(false);
            folderConvertContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox filepathTextBox;
        private Button browseButton;
        private Button convertButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private CheckBox fixMetaDataCheckBox;
        private ToolTip toolTip;
        private ToolStripProgressBar toolStripProgressBar1;
        private LinkLabel linkLabel1;
        private ComboBox fileFolderComboBox;
        private CheckBox scanMoreFoldersCheckBox;
        private Label filesizeLabel;
        private GroupBox playGroupBox;
        private Button playResumeButton;
        private TrackBar audioProgressTrackBar;
        private Label audioProgressLabel;
        private System.Windows.Forms.Timer timerTrackBar;
        private ContextMenuStrip playMoreBtnContextMenuStrip;
        private ToolStripMenuItem openWithDefaultPlayerToolStripMenuItem;
        private ToolStripMenuItem openFileLocationToolStripMenuItem;
        private Button playMoreButton;
        private ContextMenuStrip folderConvertContextMenuStrip;
        private ToolStripMenuItem autoDumpToolStripMenuItem;
    }
}
