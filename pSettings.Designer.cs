namespace Torrent
{
    partial class pSettings
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.torrentLbl = new System.Windows.Forms.Label();
            this.saveFolderLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addSaveFolderPathBtn = new System.Windows.Forms.Button();
            this.addTorFolderBtn = new System.Windows.Forms.Button();
            this.defaultTorrentPathTxt = new System.Windows.Forms.TextBox();
            this.defaultSavePathTxt = new System.Windows.Forms.TextBox();
            this.uploadSpeedSelector = new System.Windows.Forms.NumericUpDown();
            this.uploadSpeedLbl = new System.Windows.Forms.Label();
            this.downloadSpeedLbl = new System.Windows.Forms.Label();
            this.downloadSpeedSelector = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.unlimitedDownSpeedLbl = new System.Windows.Forms.Label();
            this.unlimitedUpSpeedLbl = new System.Windows.Forms.Label();
            this.unlimitedUpSpeedChk = new System.Windows.Forms.CheckBox();
            this.unlimitedDownSpeedChk = new System.Windows.Forms.CheckBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadSpeedSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadSpeedSelector)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // torrentLbl
            // 
            this.torrentLbl.AutoSize = true;
            this.torrentLbl.BackColor = System.Drawing.Color.Transparent;
            this.torrentLbl.ForeColor = System.Drawing.Color.Blue;
            this.torrentLbl.Location = new System.Drawing.Point(3, 0);
            this.torrentLbl.Name = "torrentLbl";
            this.torrentLbl.Size = new System.Drawing.Size(110, 13);
            this.torrentLbl.TabIndex = 0;
            this.torrentLbl.Text = "Default Torrent Folder";
            // 
            // saveFolderLbl
            // 
            this.saveFolderLbl.AutoSize = true;
            this.saveFolderLbl.BackColor = System.Drawing.Color.Transparent;
            this.saveFolderLbl.ForeColor = System.Drawing.Color.Blue;
            this.saveFolderLbl.Location = new System.Drawing.Point(3, 39);
            this.saveFolderLbl.Name = "saveFolderLbl";
            this.saveFolderLbl.Size = new System.Drawing.Size(101, 13);
            this.saveFolderLbl.TabIndex = 1;
            this.saveFolderLbl.Text = "Default Save Folder";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.saveFolderLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addSaveFolderPathBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.addTorFolderBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.defaultTorrentPathTxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.torrentLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.defaultSavePathTxt, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(231, 153);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // addSaveFolderPathBtn
            // 
            this.addSaveFolderPathBtn.Location = new System.Drawing.Point(197, 55);
            this.addSaveFolderPathBtn.Name = "addSaveFolderPathBtn";
            this.addSaveFolderPathBtn.Size = new System.Drawing.Size(27, 20);
            this.addSaveFolderPathBtn.TabIndex = 5;
            this.addSaveFolderPathBtn.Text = "...";
            this.addSaveFolderPathBtn.UseVisualStyleBackColor = true;
            this.addSaveFolderPathBtn.Click += new System.EventHandler(this.addSaveFolderPathBtn_Click);
            // 
            // addTorFolderBtn
            // 
            this.addTorFolderBtn.Location = new System.Drawing.Point(197, 16);
            this.addTorFolderBtn.Name = "addTorFolderBtn";
            this.addTorFolderBtn.Size = new System.Drawing.Size(27, 20);
            this.addTorFolderBtn.TabIndex = 3;
            this.addTorFolderBtn.Text = "...";
            this.addTorFolderBtn.UseVisualStyleBackColor = true;
            this.addTorFolderBtn.Click += new System.EventHandler(this.addTorFolderBtn_Click);
            // 
            // defaultTorrentPathTxt
            // 
            this.defaultTorrentPathTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.defaultTorrentPathTxt.Location = new System.Drawing.Point(3, 16);
            this.defaultTorrentPathTxt.Name = "defaultTorrentPathTxt";
            this.defaultTorrentPathTxt.Size = new System.Drawing.Size(188, 20);
            this.defaultTorrentPathTxt.TabIndex = 4;
            // 
            // defaultSavePathTxt
            // 
            this.defaultSavePathTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.defaultSavePathTxt.Location = new System.Drawing.Point(3, 55);
            this.defaultSavePathTxt.Name = "defaultSavePathTxt";
            this.defaultSavePathTxt.Size = new System.Drawing.Size(188, 20);
            this.defaultSavePathTxt.TabIndex = 5;
            // 
            // uploadSpeedSelector
            // 
            this.uploadSpeedSelector.Location = new System.Drawing.Point(3, 68);
            this.uploadSpeedSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uploadSpeedSelector.Name = "uploadSpeedSelector";
            this.uploadSpeedSelector.Size = new System.Drawing.Size(73, 20);
            this.uploadSpeedSelector.TabIndex = 13;
            this.uploadSpeedSelector.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.uploadSpeedSelector.ValueChanged += new System.EventHandler(this.uploadSpeedSelector_ValueChanged);
            // 
            // uploadSpeedLbl
            // 
            this.uploadSpeedLbl.AutoSize = true;
            this.uploadSpeedLbl.BackColor = System.Drawing.Color.Transparent;
            this.uploadSpeedLbl.ForeColor = System.Drawing.Color.Blue;
            this.uploadSpeedLbl.Location = new System.Drawing.Point(3, 52);
            this.uploadSpeedLbl.Name = "uploadSpeedLbl";
            this.uploadSpeedLbl.Size = new System.Drawing.Size(131, 13);
            this.uploadSpeedLbl.TabIndex = 12;
            this.uploadSpeedLbl.Text = "Max Upload Speed (KB/s)";
            // 
            // downloadSpeedLbl
            // 
            this.downloadSpeedLbl.AutoSize = true;
            this.downloadSpeedLbl.BackColor = System.Drawing.Color.Transparent;
            this.downloadSpeedLbl.ForeColor = System.Drawing.Color.Blue;
            this.downloadSpeedLbl.Location = new System.Drawing.Point(3, 0);
            this.downloadSpeedLbl.Name = "downloadSpeedLbl";
            this.downloadSpeedLbl.Size = new System.Drawing.Size(115, 26);
            this.downloadSpeedLbl.TabIndex = 10;
            this.downloadSpeedLbl.Text = "Max Download Speed (KB/s)";
            // 
            // downloadSpeedSelector
            // 
            this.downloadSpeedSelector.Location = new System.Drawing.Point(3, 29);
            this.downloadSpeedSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.downloadSpeedSelector.Name = "downloadSpeedSelector";
            this.downloadSpeedSelector.Size = new System.Drawing.Size(72, 20);
            this.downloadSpeedSelector.TabIndex = 11;
            this.downloadSpeedSelector.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.downloadSpeedSelector.ValueChanged += new System.EventHandler(this.downloadSpeedSelector_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83819F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16181F));
            this.tableLayoutPanel2.Controls.Add(this.uploadSpeedSelector, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.uploadSpeedLbl, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.downloadSpeedLbl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.unlimitedDownSpeedLbl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.unlimitedUpSpeedLbl, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.unlimitedUpSpeedChk, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.unlimitedDownSpeedChk, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.downloadSpeedSelector, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(255, 9);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 153);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // unlimitedDownSpeedLbl
            // 
            this.unlimitedDownSpeedLbl.AutoSize = true;
            this.unlimitedDownSpeedLbl.ForeColor = System.Drawing.Color.Blue;
            this.unlimitedDownSpeedLbl.Location = new System.Drawing.Point(144, 0);
            this.unlimitedDownSpeedLbl.Name = "unlimitedDownSpeedLbl";
            this.unlimitedDownSpeedLbl.Size = new System.Drawing.Size(135, 13);
            this.unlimitedDownSpeedLbl.TabIndex = 15;
            this.unlimitedDownSpeedLbl.Text = "Unlimited Download Speed";
            // 
            // unlimitedUpSpeedLbl
            // 
            this.unlimitedUpSpeedLbl.AutoSize = true;
            this.unlimitedUpSpeedLbl.ForeColor = System.Drawing.Color.Blue;
            this.unlimitedUpSpeedLbl.Location = new System.Drawing.Point(144, 52);
            this.unlimitedUpSpeedLbl.Name = "unlimitedUpSpeedLbl";
            this.unlimitedUpSpeedLbl.Size = new System.Drawing.Size(121, 13);
            this.unlimitedUpSpeedLbl.TabIndex = 16;
            this.unlimitedUpSpeedLbl.Text = "Unlimited Upload Speed";
            // 
            // unlimitedUpSpeedChk
            // 
            this.unlimitedUpSpeedChk.AutoSize = true;
            this.unlimitedUpSpeedChk.Location = new System.Drawing.Point(144, 68);
            this.unlimitedUpSpeedChk.Name = "unlimitedUpSpeedChk";
            this.unlimitedUpSpeedChk.Size = new System.Drawing.Size(15, 14);
            this.unlimitedUpSpeedChk.TabIndex = 17;
            this.unlimitedUpSpeedChk.UseVisualStyleBackColor = true;
            this.unlimitedUpSpeedChk.CheckedChanged += new System.EventHandler(this.unlimitedUpSpeedChk_CheckedChanged);
            // 
            // unlimitedDownSpeedChk
            // 
            this.unlimitedDownSpeedChk.AutoSize = true;
            this.unlimitedDownSpeedChk.Location = new System.Drawing.Point(144, 29);
            this.unlimitedDownSpeedChk.Name = "unlimitedDownSpeedChk";
            this.unlimitedDownSpeedChk.Size = new System.Drawing.Size(15, 14);
            this.unlimitedDownSpeedChk.TabIndex = 14;
            this.unlimitedDownSpeedChk.UseVisualStyleBackColor = true;
            this.unlimitedDownSpeedChk.CheckedChanged += new System.EventHandler(this.unlimitedDownSpeedChk_CheckedChanged);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(464, 168);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 15;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(383, 168);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // pSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 196);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "pSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Default Settings";
            this.Load += new System.EventHandler(this.pSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadSpeedSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadSpeedSelector)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label torrentLbl;
        private System.Windows.Forms.Label saveFolderLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addTorFolderBtn;
        private System.Windows.Forms.TextBox defaultTorrentPathTxt;
        private System.Windows.Forms.TextBox defaultSavePathTxt;
        private System.Windows.Forms.Button addSaveFolderPathBtn;
        private System.Windows.Forms.Label downloadSpeedLbl;
        private System.Windows.Forms.NumericUpDown uploadSpeedSelector;
        private System.Windows.Forms.NumericUpDown downloadSpeedSelector;
        private System.Windows.Forms.Label uploadSpeedLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label unlimitedDownSpeedLbl;
        private System.Windows.Forms.Label unlimitedUpSpeedLbl;
        private System.Windows.Forms.CheckBox unlimitedUpSpeedChk;
        private System.Windows.Forms.CheckBox unlimitedDownSpeedChk;
    }
}