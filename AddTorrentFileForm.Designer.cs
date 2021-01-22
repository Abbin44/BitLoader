namespace Torrent
{
    partial class AddTorrentFileForm
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
            this.addFileBtn = new System.Windows.Forms.Button();
            this.addTorrentFilePathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFilePathTxt = new System.Windows.Forms.TextBox();
            this.saveFolderBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.unlimitedUpSpeedBox = new System.Windows.Forms.CheckBox();
            this.uploadSpeedSelector = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadSpeedSelector = new System.Windows.Forms.NumericUpDown();
            this.unlimitedDownSpeedBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addTorrentBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadSpeedSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadSpeedSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // addFileBtn
            // 
            this.addFileBtn.Location = new System.Drawing.Point(199, 18);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(27, 20);
            this.addFileBtn.TabIndex = 0;
            this.addFileBtn.Text = "...";
            this.addFileBtn.UseVisualStyleBackColor = true;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
            // 
            // addTorrentFilePathTxt
            // 
            this.addTorrentFilePathTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.addTorrentFilePathTxt.Location = new System.Drawing.Point(4, 18);
            this.addTorrentFilePathTxt.Name = "addTorrentFilePathTxt";
            this.addTorrentFilePathTxt.Size = new System.Drawing.Size(188, 20);
            this.addTorrentFilePathTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filepath to torrent";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFilePathTxt
            // 
            this.saveFilePathTxt.Location = new System.Drawing.Point(4, 59);
            this.saveFilePathTxt.Name = "saveFilePathTxt";
            this.saveFilePathTxt.Size = new System.Drawing.Size(188, 20);
            this.saveFilePathTxt.TabIndex = 4;
            // 
            // saveFolderBtn
            // 
            this.saveFolderBtn.Location = new System.Drawing.Point(199, 59);
            this.saveFolderBtn.Name = "saveFolderBtn";
            this.saveFolderBtn.Size = new System.Drawing.Size(27, 20);
            this.saveFolderBtn.TabIndex = 3;
            this.saveFolderBtn.Text = "...";
            this.saveFolderBtn.UseVisualStyleBackColor = true;
            this.saveFolderBtn.Click += new System.EventHandler(this.saveFolderBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.saveFilePathTxt, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveFolderBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.addTorrentFilePathTxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addFileBtn, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 148);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save to folder";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.unlimitedUpSpeedBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.uploadSpeedSelector, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.downloadSpeedSelector, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.unlimitedDownSpeedBox, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(276, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 147);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // unlimitedUpSpeedBox
            // 
            this.unlimitedUpSpeedBox.AutoSize = true;
            this.unlimitedUpSpeedBox.ForeColor = System.Drawing.Color.Blue;
            this.unlimitedUpSpeedBox.Location = new System.Drawing.Point(165, 45);
            this.unlimitedUpSpeedBox.Name = "unlimitedUpSpeedBox";
            this.unlimitedUpSpeedBox.Size = new System.Drawing.Size(140, 17);
            this.unlimitedUpSpeedBox.TabIndex = 13;
            this.unlimitedUpSpeedBox.Text = "Unlimited Upload Speed";
            this.unlimitedUpSpeedBox.UseVisualStyleBackColor = true;
            this.unlimitedUpSpeedBox.Visible = false;
            this.unlimitedUpSpeedBox.CheckedChanged += new System.EventHandler(this.unlimitedUpSpeedBox_CheckedChanged);
            // 
            // uploadSpeedSelector
            // 
            this.uploadSpeedSelector.ForeColor = System.Drawing.Color.Blue;
            this.uploadSpeedSelector.Location = new System.Drawing.Point(165, 18);
            this.uploadSpeedSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uploadSpeedSelector.Name = "uploadSpeedSelector";
            this.uploadSpeedSelector.Size = new System.Drawing.Size(73, 20);
            this.uploadSpeedSelector.TabIndex = 9;
            this.uploadSpeedSelector.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(165, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max Upload Speed (KB/s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Download Speed (KB/s)";
            // 
            // downloadSpeedSelector
            // 
            this.downloadSpeedSelector.ForeColor = System.Drawing.Color.Blue;
            this.downloadSpeedSelector.Location = new System.Drawing.Point(4, 18);
            this.downloadSpeedSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.downloadSpeedSelector.Name = "downloadSpeedSelector";
            this.downloadSpeedSelector.Size = new System.Drawing.Size(72, 20);
            this.downloadSpeedSelector.TabIndex = 5;
            this.downloadSpeedSelector.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // unlimitedDownSpeedBox
            // 
            this.unlimitedDownSpeedBox.AutoSize = true;
            this.unlimitedDownSpeedBox.ForeColor = System.Drawing.Color.Blue;
            this.unlimitedDownSpeedBox.Location = new System.Drawing.Point(4, 45);
            this.unlimitedDownSpeedBox.Name = "unlimitedDownSpeedBox";
            this.unlimitedDownSpeedBox.Size = new System.Drawing.Size(154, 17);
            this.unlimitedDownSpeedBox.TabIndex = 12;
            this.unlimitedDownSpeedBox.Text = "Unlimited Download Speed";
            this.unlimitedDownSpeedBox.UseVisualStyleBackColor = true;
            this.unlimitedDownSpeedBox.Visible = false;
            this.unlimitedDownSpeedBox.CheckedChanged += new System.EventHandler(this.unlimitedDownSpeedBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(162, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hint: You can change your default settings in the settings menu";
            // 
            // addTorrentBtn
            // 
            this.addTorrentBtn.Location = new System.Drawing.Point(515, 171);
            this.addTorrentBtn.Name = "addTorrentBtn";
            this.addTorrentBtn.Size = new System.Drawing.Size(89, 23);
            this.addTorrentBtn.TabIndex = 19;
            this.addTorrentBtn.Text = "Add";
            this.addTorrentBtn.UseVisualStyleBackColor = true;
            this.addTorrentBtn.Click += new System.EventHandler(this.addTorrentBtn_Click);
            // 
            // AddTorrentFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 200);
            this.Controls.Add(this.addTorrentBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddTorrentFileForm";
            this.Text = "Add a Torrent";
            this.Load += new System.EventHandler(this.pAddTorrent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadSpeedSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadSpeedSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.TextBox addTorrentFilePathTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox saveFilePathTxt;
        private System.Windows.Forms.Button saveFolderBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown downloadSpeedSelector;
        private System.Windows.Forms.NumericUpDown uploadSpeedSelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addTorrentBtn;
        private System.Windows.Forms.CheckBox unlimitedDownSpeedBox;
        private System.Windows.Forms.CheckBox unlimitedUpSpeedBox;
    }
}