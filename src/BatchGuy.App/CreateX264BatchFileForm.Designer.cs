﻿namespace BatchGuy.App
{
    partial class CreateX264BatchFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateX264BatchFileForm));
            this.btnCreateX264BatchFile = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviSynthFilePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encodeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsEpisodeNumbersDropDownListItem = new System.Windows.Forms.BindingSource(this.components);
            this.bsFiles = new System.Windows.Forms.BindingSource(this.components);
            this.lblNumberOfFiles = new System.Windows.Forms.Label();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.btnWriteToMKVMergeBatFile = new System.Windows.Forms.Button();
            this.lblOutputAndLogFileCaption = new System.Windows.Forms.Label();
            this.txtX264EncodeOutputAndLogDirectory = new System.Windows.Forms.TextBox();
            this.lblDirectoryType = new System.Windows.Forms.Label();
            this.lblDirectoryTypeCaption = new System.Windows.Forms.Label();
            this.txtX264LogFileSaveDirectory = new System.Windows.Forms.TextBox();
            this.btnOpenX264LogFileOutputDialog = new System.Windows.Forms.Button();
            this.chkSaveLogFileToDifferentDirectory = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtX264Template = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.gbAviSynthFiles = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX264BatchFileOutputDirectory = new System.Windows.Forms.TextBox();
            this.btnOpenX264BatchFileOutputDialog = new System.Windows.Forms.Button();
            this.bgwCreateX264BatchFile = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveSettingsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMkvMergeWriteBatchFile = new System.ComponentModel.BackgroundWorker();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEpisodeNumbersDropDownListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).BeginInit();
            this.gbScreen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAviSynthFiles.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateX264BatchFile
            // 
            this.btnCreateX264BatchFile.Location = new System.Drawing.Point(491, 675);
            this.btnCreateX264BatchFile.Name = "btnCreateX264BatchFile";
            this.btnCreateX264BatchFile.Size = new System.Drawing.Size(168, 33);
            this.btnCreateX264BatchFile.TabIndex = 6;
            this.btnCreateX264BatchFile.Text = "Create x264 Batch File";
            this.btnCreateX264BatchFile.UseVisualStyleBackColor = true;
            this.btnCreateX264BatchFile.Click += new System.EventHandler(this.btnCreateX264BatFile_Click);
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowDrop = true;
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToOrderColumns = true;
            this.dgvFiles.AutoGenerateColumns = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn,
            this.aviSynthFilePathDataGridViewTextBoxColumn,
            this.encodeNameDataGridViewTextBoxColumn,
            this.episodeNumberDataGridViewTextBoxColumn});
            this.dgvFiles.DataSource = this.bsFiles;
            this.dgvFiles.Location = new System.Drawing.Point(13, 27);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(824, 222);
            this.dgvFiles.TabIndex = 3;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            this.dgvFiles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvFiles_RowsRemoved);
            this.dgvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragDrop);
            this.dgvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // aviSynthFileNameOnlyDataGridViewTextBoxColumn
            // 
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.DataPropertyName = "AviSynthFileNameOnly";
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.HeaderText = "File Name";
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.Name = "aviSynthFileNameOnlyDataGridViewTextBoxColumn";
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.ReadOnly = true;
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.Width = 150;
            // 
            // aviSynthFilePathDataGridViewTextBoxColumn
            // 
            this.aviSynthFilePathDataGridViewTextBoxColumn.DataPropertyName = "AviSynthFilePath";
            this.aviSynthFilePathDataGridViewTextBoxColumn.HeaderText = "AviSynthFilePath";
            this.aviSynthFilePathDataGridViewTextBoxColumn.Name = "aviSynthFilePathDataGridViewTextBoxColumn";
            this.aviSynthFilePathDataGridViewTextBoxColumn.Visible = false;
            // 
            // encodeNameDataGridViewTextBoxColumn
            // 
            this.encodeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.encodeNameDataGridViewTextBoxColumn.DataPropertyName = "EncodeName";
            this.encodeNameDataGridViewTextBoxColumn.HeaderText = "Encode Name (EX: E01.mkv)";
            this.encodeNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.encodeNameDataGridViewTextBoxColumn.Name = "encodeNameDataGridViewTextBoxColumn";
            // 
            // episodeNumberDataGridViewTextBoxColumn
            // 
            this.episodeNumberDataGridViewTextBoxColumn.DataPropertyName = "EpisodeNumber";
            this.episodeNumberDataGridViewTextBoxColumn.DataSource = this.bsEpisodeNumbersDropDownListItem;
            this.episodeNumberDataGridViewTextBoxColumn.DisplayMember = "DisplayMember";
            this.episodeNumberDataGridViewTextBoxColumn.HeaderText = "Blu-ray Episode Number";
            this.episodeNumberDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.episodeNumberDataGridViewTextBoxColumn.Name = "episodeNumberDataGridViewTextBoxColumn";
            this.episodeNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.episodeNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.episodeNumberDataGridViewTextBoxColumn.ValueMember = "ValueMember";
            this.episodeNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsEpisodeNumbersDropDownListItem
            // 
            this.bsEpisodeNumbersDropDownListItem.AllowNew = false;
            this.bsEpisodeNumbersDropDownListItem.DataSource = typeof(BatchGuy.App.Shared.Models.DropDownListItem);
            // 
            // bsFiles
            // 
            this.bsFiles.DataSource = typeof(BatchGuy.App.X264.Models.X264File);
            // 
            // lblNumberOfFiles
            // 
            this.lblNumberOfFiles.AutoSize = true;
            this.lblNumberOfFiles.Location = new System.Drawing.Point(10, 251);
            this.lblNumberOfFiles.Name = "lblNumberOfFiles";
            this.lblNumberOfFiles.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfFiles.TabIndex = 23;
            this.lblNumberOfFiles.Text = "Number of Files:";
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.btnWriteToMKVMergeBatFile);
            this.gbScreen.Controls.Add(this.lblOutputAndLogFileCaption);
            this.gbScreen.Controls.Add(this.txtX264EncodeOutputAndLogDirectory);
            this.gbScreen.Controls.Add(this.lblDirectoryType);
            this.gbScreen.Controls.Add(this.lblDirectoryTypeCaption);
            this.gbScreen.Controls.Add(this.txtX264LogFileSaveDirectory);
            this.gbScreen.Controls.Add(this.btnOpenX264LogFileOutputDialog);
            this.gbScreen.Controls.Add(this.chkSaveLogFileToDifferentDirectory);
            this.gbScreen.Controls.Add(this.groupBox2);
            this.gbScreen.Controls.Add(this.gbAviSynthFiles);
            this.gbScreen.Controls.Add(this.label2);
            this.gbScreen.Controls.Add(this.txtX264BatchFileOutputDirectory);
            this.gbScreen.Controls.Add(this.btnOpenX264BatchFileOutputDialog);
            this.gbScreen.Controls.Add(this.btnCreateX264BatchFile);
            this.gbScreen.Location = new System.Drawing.Point(12, 28);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(868, 720);
            this.gbScreen.TabIndex = 31;
            this.gbScreen.TabStop = false;
            // 
            // btnWriteToMKVMergeBatFile
            // 
            this.btnWriteToMKVMergeBatFile.Location = new System.Drawing.Point(690, 675);
            this.btnWriteToMKVMergeBatFile.Name = "btnWriteToMKVMergeBatFile";
            this.btnWriteToMKVMergeBatFile.Size = new System.Drawing.Size(166, 33);
            this.btnWriteToMKVMergeBatFile.TabIndex = 7;
            this.btnWriteToMKVMergeBatFile.Text = "Create mkvmerge Batch File";
            this.btnWriteToMKVMergeBatFile.UseVisualStyleBackColor = true;
            this.btnWriteToMKVMergeBatFile.Click += new System.EventHandler(this.btnWriteToMKVMergeBatFile_Click);
            // 
            // lblOutputAndLogFileCaption
            // 
            this.lblOutputAndLogFileCaption.AutoSize = true;
            this.lblOutputAndLogFileCaption.Location = new System.Drawing.Point(24, 58);
            this.lblOutputAndLogFileCaption.Name = "lblOutputAndLogFileCaption";
            this.lblOutputAndLogFileCaption.Size = new System.Drawing.Size(135, 13);
            this.lblOutputAndLogFileCaption.TabIndex = 40;
            this.lblOutputAndLogFileCaption.Text = "-output and (.log) Directory:";
            // 
            // txtX264EncodeOutputAndLogDirectory
            // 
            this.txtX264EncodeOutputAndLogDirectory.Location = new System.Drawing.Point(211, 55);
            this.txtX264EncodeOutputAndLogDirectory.Name = "txtX264EncodeOutputAndLogDirectory";
            this.txtX264EncodeOutputAndLogDirectory.ReadOnly = true;
            this.txtX264EncodeOutputAndLogDirectory.Size = new System.Drawing.Size(576, 20);
            this.txtX264EncodeOutputAndLogDirectory.TabIndex = 39;
            // 
            // lblDirectoryType
            // 
            this.lblDirectoryType.AutoSize = true;
            this.lblDirectoryType.Location = new System.Drawing.Point(208, 24);
            this.lblDirectoryType.Name = "lblDirectoryType";
            this.lblDirectoryType.Size = new System.Drawing.Size(79, 13);
            this.lblDirectoryType.TabIndex = 38;
            this.lblDirectoryType.Text = "Directory Type:";
            // 
            // lblDirectoryTypeCaption
            // 
            this.lblDirectoryTypeCaption.AutoSize = true;
            this.lblDirectoryTypeCaption.Location = new System.Drawing.Point(24, 25);
            this.lblDirectoryTypeCaption.Name = "lblDirectoryTypeCaption";
            this.lblDirectoryTypeCaption.Size = new System.Drawing.Size(118, 13);
            this.lblDirectoryTypeCaption.TabIndex = 37;
            this.lblDirectoryTypeCaption.Text = "Directory Type Chosen:";
            // 
            // txtX264LogFileSaveDirectory
            // 
            this.txtX264LogFileSaveDirectory.Enabled = false;
            this.txtX264LogFileSaveDirectory.Location = new System.Drawing.Point(211, 137);
            this.txtX264LogFileSaveDirectory.Name = "txtX264LogFileSaveDirectory";
            this.txtX264LogFileSaveDirectory.ReadOnly = true;
            this.txtX264LogFileSaveDirectory.Size = new System.Drawing.Size(576, 20);
            this.txtX264LogFileSaveDirectory.TabIndex = 34;
            // 
            // btnOpenX264LogFileOutputDialog
            // 
            this.btnOpenX264LogFileOutputDialog.Enabled = false;
            this.btnOpenX264LogFileOutputDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenX264LogFileOutputDialog.Location = new System.Drawing.Point(793, 124);
            this.btnOpenX264LogFileOutputDialog.Name = "btnOpenX264LogFileOutputDialog";
            this.btnOpenX264LogFileOutputDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenX264LogFileOutputDialog.TabIndex = 2;
            this.btnOpenX264LogFileOutputDialog.UseVisualStyleBackColor = true;
            this.btnOpenX264LogFileOutputDialog.Click += new System.EventHandler(this.btnOpenX264LogFileOutputDialog_Click);
            // 
            // chkSaveLogFileToDifferentDirectory
            // 
            this.chkSaveLogFileToDifferentDirectory.AutoSize = true;
            this.chkSaveLogFileToDifferentDirectory.Location = new System.Drawing.Point(21, 140);
            this.chkSaveLogFileToDifferentDirectory.Name = "chkSaveLogFileToDifferentDirectory";
            this.chkSaveLogFileToDifferentDirectory.Size = new System.Drawing.Size(192, 17);
            this.chkSaveLogFileToDifferentDirectory.TabIndex = 1;
            this.chkSaveLogFileToDifferentDirectory.Text = "Save (.log) file to differen directory?";
            this.chkSaveLogFileToDifferentDirectory.UseVisualStyleBackColor = true;
            this.chkSaveLogFileToDifferentDirectory.CheckedChanged += new System.EventHandler(this.chkSaveLogFileToDifferentDirectory_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtX264Template);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbEncodeType);
            this.groupBox2.Location = new System.Drawing.Point(8, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 188);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "x264 Template";
            // 
            // txtX264Template
            // 
            this.txtX264Template.Location = new System.Drawing.Point(13, 46);
            this.txtX264Template.Multiline = true;
            this.txtX264Template.Name = "txtX264Template";
            this.txtX264Template.Size = new System.Drawing.Size(818, 126);
            this.txtX264Template.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Encode Type:";
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.Items.AddRange(new object[] {
            "CRF",
            "2Pass"});
            this.cbEncodeType.Location = new System.Drawing.Point(681, 19);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(148, 21);
            this.cbEncodeType.TabIndex = 4;
            this.cbEncodeType.SelectedIndexChanged += new System.EventHandler(this.cbEncodeType_SelectedIndexChanged);
            // 
            // gbAviSynthFiles
            // 
            this.gbAviSynthFiles.Controls.Add(this.dgvFiles);
            this.gbAviSynthFiles.Controls.Add(this.lblNumberOfFiles);
            this.gbAviSynthFiles.Location = new System.Drawing.Point(8, 181);
            this.gbAviSynthFiles.Name = "gbAviSynthFiles";
            this.gbAviSynthFiles.Size = new System.Drawing.Size(848, 273);
            this.gbAviSynthFiles.TabIndex = 28;
            this.gbAviSynthFiles.TabStop = false;
            this.gbAviSynthFiles.Text = "Drag N Drop (.avs) files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "x264 Batch File Save Directory*:";
            // 
            // txtX264BatchFileOutputDirectory
            // 
            this.txtX264BatchFileOutputDirectory.Location = new System.Drawing.Point(211, 93);
            this.txtX264BatchFileOutputDirectory.Name = "txtX264BatchFileOutputDirectory";
            this.txtX264BatchFileOutputDirectory.ReadOnly = true;
            this.txtX264BatchFileOutputDirectory.Size = new System.Drawing.Size(576, 20);
            this.txtX264BatchFileOutputDirectory.TabIndex = 25;
            // 
            // btnOpenX264BatchFileOutputDialog
            // 
            this.btnOpenX264BatchFileOutputDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenX264BatchFileOutputDialog.Location = new System.Drawing.Point(793, 80);
            this.btnOpenX264BatchFileOutputDialog.Name = "btnOpenX264BatchFileOutputDialog";
            this.btnOpenX264BatchFileOutputDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenX264BatchFileOutputDialog.TabIndex = 0;
            this.btnOpenX264BatchFileOutputDialog.UseVisualStyleBackColor = true;
            this.btnOpenX264BatchFileOutputDialog.Click += new System.EventHandler(this.btnOpenX264BatchFileOutputDialog_Click);
            // 
            // bgwCreateX264BatchFile
            // 
            this.bgwCreateX264BatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateX264BatchFile_DoWork);
            this.bgwCreateX264BatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateX264BatchFile_RunWorkerCompleted);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsFileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(892, 24);
            this.menuStrip.TabIndex = 32;
            this.menuStrip.Text = "menuStrip1";
            // 
            // saveSettingsFileToolStripMenuItem
            // 
            this.saveSettingsFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem});
            this.saveSettingsFileToolStripMenuItem.Name = "saveSettingsFileToolStripMenuItem";
            this.saveSettingsFileToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.saveSettingsFileToolStripMenuItem.Text = "Save / Restore";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Flatastic_10_Open_file;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.loadToolStripMenuItem.Text = "Restore";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Flatastic_10_New_file;
            this.saveToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // bgwMkvMergeWriteBatchFile
            // 
            this.bgwMkvMergeWriteBatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMkvMergeWriteBatchFile_DoWork);
            this.bgwMkvMergeWriteBatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMkvMergeWriteBatchFile_RunWorkerCompleted);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 751);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 41;
            this.lblVersion.Text = "Version";
            // 
            // CreateX264BatchFileForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 773);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateX264BatchFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create x264 Batch File";
            this.Load += new System.EventHandler(this.CreateX264BatFileForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CreateX264BatchFileForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CreateX264BatchFileForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEpisodeNumbersDropDownListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).EndInit();
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbAviSynthFiles.ResumeLayout(false);
            this.gbAviSynthFiles.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateX264BatchFile;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Label lblNumberOfFiles;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.ComponentModel.BackgroundWorker bgwCreateX264BatchFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVSFileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX264BatchFileOutputDirectory;
        private System.Windows.Forms.Button btnOpenX264BatchFileOutputDialog;
        private System.Windows.Forms.BindingSource bsFiles;
        private System.Windows.Forms.GroupBox gbAviSynthFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtX264Template;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.CheckBox chkSaveLogFileToDifferentDirectory;
        private System.Windows.Forms.TextBox txtX264LogFileSaveDirectory;
        private System.Windows.Forms.Button btnOpenX264LogFileOutputDialog;
        private System.Windows.Forms.BindingSource bsEpisodeNumbersDropDownListItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lblOutputAndLogFileCaption;
        private System.Windows.Forms.TextBox txtX264EncodeOutputAndLogDirectory;
        private System.Windows.Forms.Label lblDirectoryType;
        private System.Windows.Forms.Label lblDirectoryTypeCaption;
        private System.Windows.Forms.Button btnWriteToMKVMergeBatFile;
        private System.ComponentModel.BackgroundWorker bgwMkvMergeWriteBatchFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviSynthFileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviSynthFilePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encodeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn episodeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblVersion;
    }
}