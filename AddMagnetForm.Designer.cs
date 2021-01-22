
namespace Torrent
{
    partial class AddMagnetForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.unlimitedUpSpeedBox = new System.Windows.Forms.CheckBox();
            this.uploadSpeedSelector = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadSpeedSelector = new System.Windows.Forms.NumericUpDown();
            this.unlimitedDownSpeedBox = new System.Windows.Forms.CheckBox();
            this.magnetLinkTxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveFilePathTxt = new System.Windows.Forms.TextBox();
            this.magnetLinkLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pasteClipboardLbl = new System.Windows.Forms.Label();
            this.saveFolderBtn = new System.Windows.Forms.Button();
            this.pasteClipboardBtn = new System.Windows.Forms.Button();
            this.addTorrentBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadSpeedSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadSpeedSelector)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(291, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 92);
            this.tableLayoutPanel2.TabIndex = 8;
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
            // magnetLinkTxt
            // 
            this.magnetLinkTxt.Location = new System.Drawing.Point(4, 18);
            this.magnetLinkTxt.Name = "magnetLinkTxt";
            this.magnetLinkTxt.Size = new System.Drawing.Size(160, 20);
            this.magnetLinkTxt.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.61539F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.38462F));
            this.tableLayoutPanel1.Controls.Add(this.saveFilePathTxt, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.magnetLinkLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.magnetLinkTxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pasteClipboardLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveFolderBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pasteClipboardBtn, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 91);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // saveFilePathTxt
            // 
            this.saveFilePathTxt.Location = new System.Drawing.Point(4, 62);
            this.saveFilePathTxt.Name = "saveFilePathTxt";
            this.saveFilePathTxt.Size = new System.Drawing.Size(160, 20);
            this.saveFilePathTxt.TabIndex = 13;
            // 
            // magnetLinkLbl
            // 
            this.magnetLinkLbl.AutoSize = true;
            this.magnetLinkLbl.ForeColor = System.Drawing.Color.Blue;
            this.magnetLinkLbl.Location = new System.Drawing.Point(4, 1);
            this.magnetLinkLbl.Name = "magnetLinkLbl";
            this.magnetLinkLbl.Size = new System.Drawing.Size(66, 13);
            this.magnetLinkLbl.TabIndex = 0;
            this.magnetLinkLbl.Text = "Magnet Link";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Save to folder";
            // 
            // pasteClipboardLbl
            // 
            this.pasteClipboardLbl.AutoSize = true;
            this.pasteClipboardLbl.ForeColor = System.Drawing.Color.Blue;
            this.pasteClipboardLbl.Location = new System.Drawing.Point(171, 1);
            this.pasteClipboardLbl.Name = "pasteClipboardLbl";
            this.pasteClipboardLbl.Size = new System.Drawing.Size(81, 13);
            this.pasteClipboardLbl.TabIndex = 14;
            this.pasteClipboardLbl.Text = "Paste Clipboard";
            // 
            // saveFolderBtn
            // 
            this.saveFolderBtn.Location = new System.Drawing.Point(171, 62);
            this.saveFolderBtn.Name = "saveFolderBtn";
            this.saveFolderBtn.Size = new System.Drawing.Size(27, 20);
            this.saveFolderBtn.TabIndex = 12;
            this.saveFolderBtn.Text = "...";
            this.saveFolderBtn.UseVisualStyleBackColor = true;
            this.saveFolderBtn.Click += new System.EventHandler(this.saveFolderBtn_Click);
            // 
            // pasteClipboardBtn
            // 
            this.pasteClipboardBtn.ForeColor = System.Drawing.Color.Blue;
            this.pasteClipboardBtn.Location = new System.Drawing.Point(171, 18);
            this.pasteClipboardBtn.Name = "pasteClipboardBtn";
            this.pasteClipboardBtn.Size = new System.Drawing.Size(81, 23);
            this.pasteClipboardBtn.TabIndex = 15;
            this.pasteClipboardBtn.Text = "Paste";
            this.pasteClipboardBtn.UseVisualStyleBackColor = true;
            this.pasteClipboardBtn.Click += new System.EventHandler(this.pasteClipboardBtn_Click);
            // 
            // addTorrentBtn
            // 
            this.addTorrentBtn.Location = new System.Drawing.Point(530, 110);
            this.addTorrentBtn.Name = "addTorrentBtn";
            this.addTorrentBtn.Size = new System.Drawing.Size(89, 23);
            this.addTorrentBtn.TabIndex = 21;
            this.addTorrentBtn.Text = "Add";
            this.addTorrentBtn.UseVisualStyleBackColor = true;
            this.addTorrentBtn.Click += new System.EventHandler(this.addTorrentBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(182, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hint: You can change your default settings in the settings menu";
            // 
            // AddMagnetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 143);
            this.Controls.Add(this.addTorrentBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "AddMagnetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Torrent From Magnet";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadSpeedSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadSpeedSelector)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox unlimitedUpSpeedBox;
        private System.Windows.Forms.NumericUpDown uploadSpeedSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown downloadSpeedSelector;
        private System.Windows.Forms.CheckBox unlimitedDownSpeedBox;
        private System.Windows.Forms.TextBox magnetLinkTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label magnetLinkLbl;
        private System.Windows.Forms.TextBox saveFilePathTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pasteClipboardLbl;
        private System.Windows.Forms.Button saveFolderBtn;
        private System.Windows.Forms.Button pasteClipboardBtn;
        private System.Windows.Forms.Button addTorrentBtn;
        private System.Windows.Forms.Label label5;
    }
}