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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviSynthFilePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encodeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFiles = new System.Windows.Forms.BindingSource(this.components);
            this.lblNumberOfFiles = new System.Windows.Forms.Label();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.txtX264LogFileSaveDirectory = new System.Windows.Forms.TextBox();
            this.btnOpenX264LogFileOutputDialog = new System.Windows.Forms.Button();
            this.chkSaveLogFileToDifferentDirectory = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtX264Template = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.gbAviSynthFiles = new System.Windows.Forms.GroupBox();
            this.setDirectoryUserControlX264Output = new BatchGuy.App.UserControls.SetDirectoryUserControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX264BatchFileOutputDirectory = new System.Windows.Forms.TextBox();
            this.btnOpenX264BatchFileOutputDialog = new System.Windows.Forms.Button();
            this.bgwCreateX264BatchFile = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).BeginInit();
            this.gbScreen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAviSynthFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateX264BatchFile
            // 
            this.btnCreateX264BatchFile.Location = new System.Drawing.Point(688, 680);
            this.btnCreateX264BatchFile.Name = "btnCreateX264BatchFile";
            this.btnCreateX264BatchFile.Size = new System.Drawing.Size(168, 33);
            this.btnCreateX264BatchFile.TabIndex = 4;
            this.btnCreateX264BatchFile.Text = "Create x264 Batch File";
            this.btnCreateX264BatchFile.UseVisualStyleBackColor = true;
            this.btnCreateX264BatchFile.Click += new System.EventHandler(this.btnCreateX264BatFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "File Names:";
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
            this.encodeNameDataGridViewTextBoxColumn});
            this.dgvFiles.DataSource = this.bsFiles;
            this.dgvFiles.Location = new System.Drawing.Point(13, 27);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(824, 222);
            this.dgvFiles.TabIndex = 19;
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
            this.gbScreen.Controls.Add(this.txtX264LogFileSaveDirectory);
            this.gbScreen.Controls.Add(this.btnOpenX264LogFileOutputDialog);
            this.gbScreen.Controls.Add(this.chkSaveLogFileToDifferentDirectory);
            this.gbScreen.Controls.Add(this.groupBox2);
            this.gbScreen.Controls.Add(this.gbAviSynthFiles);
            this.gbScreen.Controls.Add(this.setDirectoryUserControlX264Output);
            this.gbScreen.Controls.Add(this.label2);
            this.gbScreen.Controls.Add(this.txtX264BatchFileOutputDirectory);
            this.gbScreen.Controls.Add(this.btnOpenX264BatchFileOutputDialog);
            this.gbScreen.Controls.Add(this.btnCreateX264BatchFile);
            this.gbScreen.Controls.Add(this.label1);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(868, 726);
            this.gbScreen.TabIndex = 31;
            this.gbScreen.TabStop = false;
            // 
            // txtX264LogFileSaveDirectory
            // 
            this.txtX264LogFileSaveDirectory.Enabled = false;
            this.txtX264LogFileSaveDirectory.Location = new System.Drawing.Point(211, 143);
            this.txtX264LogFileSaveDirectory.Name = "txtX264LogFileSaveDirectory";
            this.txtX264LogFileSaveDirectory.ReadOnly = true;
            this.txtX264LogFileSaveDirectory.Size = new System.Drawing.Size(434, 20);
            this.txtX264LogFileSaveDirectory.TabIndex = 34;
            // 
            // btnOpenX264LogFileOutputDialog
            // 
            this.btnOpenX264LogFileOutputDialog.Enabled = false;
            this.btnOpenX264LogFileOutputDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenX264LogFileOutputDialog.Location = new System.Drawing.Point(651, 130);
            this.btnOpenX264LogFileOutputDialog.Name = "btnOpenX264LogFileOutputDialog";
            this.btnOpenX264LogFileOutputDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenX264LogFileOutputDialog.TabIndex = 33;
            this.btnOpenX264LogFileOutputDialog.UseVisualStyleBackColor = true;
            this.btnOpenX264LogFileOutputDialog.Click += new System.EventHandler(this.btnOpenX264LogFileOutputDialog_Click);
            // 
            // chkSaveLogFileToDifferentDirectory
            // 
            this.chkSaveLogFileToDifferentDirectory.AutoSize = true;
            this.chkSaveLogFileToDifferentDirectory.Location = new System.Drawing.Point(21, 146);
            this.chkSaveLogFileToDifferentDirectory.Name = "chkSaveLogFileToDifferentDirectory";
            this.chkSaveLogFileToDifferentDirectory.Size = new System.Drawing.Size(192, 17);
            this.chkSaveLogFileToDifferentDirectory.TabIndex = 32;
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
            this.txtX264Template.TabIndex = 12;
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
            this.cbEncodeType.TabIndex = 3;
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
            // setDirectoryUserControlX264Output
            // 
            this.setDirectoryUserControlX264Output.ComboBoxCaptionText = null;
            this.setDirectoryUserControlX264Output.LabelDirectoryCaptionText = null;
            this.setDirectoryUserControlX264Output.Location = new System.Drawing.Point(21, 64);
            this.setDirectoryUserControlX264Output.Name = "setDirectoryUserControlX264Output";
            this.setDirectoryUserControlX264Output.Size = new System.Drawing.Size(835, 71);
            this.setDirectoryUserControlX264Output.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "x264 Batch File Save Directory:";
            // 
            // txtX264BatchFileOutputDirectory
            // 
            this.txtX264BatchFileOutputDirectory.Location = new System.Drawing.Point(211, 28);
            this.txtX264BatchFileOutputDirectory.Name = "txtX264BatchFileOutputDirectory";
            this.txtX264BatchFileOutputDirectory.ReadOnly = true;
            this.txtX264BatchFileOutputDirectory.Size = new System.Drawing.Size(434, 20);
            this.txtX264BatchFileOutputDirectory.TabIndex = 25;
            // 
            // btnOpenX264BatchFileOutputDialog
            // 
            this.btnOpenX264BatchFileOutputDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenX264BatchFileOutputDialog.Location = new System.Drawing.Point(651, 15);
            this.btnOpenX264BatchFileOutputDialog.Name = "btnOpenX264BatchFileOutputDialog";
            this.btnOpenX264BatchFileOutputDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenX264BatchFileOutputDialog.TabIndex = 1;
            this.btnOpenX264BatchFileOutputDialog.UseVisualStyleBackColor = true;
            this.btnOpenX264BatchFileOutputDialog.Click += new System.EventHandler(this.btnOpenX264BatchFileOutputDialog_Click);
            // 
            // bgwCreateX264BatchFile
            // 
            this.bgwCreateX264BatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateX264BatchFile_DoWork);
            this.bgwCreateX264BatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateX264BatchFile_RunWorkerCompleted);
            // 
            // CreateX264BatchFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 745);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateX264BatchFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create x264 Batch File";
            this.Load += new System.EventHandler(this.CreateX264BatFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).EndInit();
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbAviSynthFiles.ResumeLayout(false);
            this.gbAviSynthFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateX264BatchFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Label lblNumberOfFiles;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.ComponentModel.BackgroundWorker bgwCreateX264BatchFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVSFileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX264BatchFileOutputDirectory;
        private System.Windows.Forms.Button btnOpenX264BatchFileOutputDialog;
        private UserControls.SetDirectoryUserControl setDirectoryUserControlX264Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviSynthFileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviSynthFilePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encodeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsFiles;
        private System.Windows.Forms.GroupBox gbAviSynthFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtX264Template;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.CheckBox chkSaveLogFileToDifferentDirectory;
        private System.Windows.Forms.TextBox txtX264LogFileSaveDirectory;
        private System.Windows.Forms.Button btnOpenX264LogFileOutputDialog;
    }
}