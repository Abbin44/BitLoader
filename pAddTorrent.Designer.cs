﻿namespace Torrent
{
    partial class pAddTorrent
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
            this.addFilePathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFilePathTxt = new System.Windows.Forms.TextBox();
            this.saveFolderBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uploadSpeedSelector = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadSpeedSelector = new System.Windows.Forms.NumericUpDown();
            this.addTorBtn = new System.Windows.Forms.Button();
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
            // addFilePathTxt
            // 
            this.addFilePathTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.addFilePathTxt.Location = new System.Drawing.Point(4, 18);
            this.addFilePathTxt.Name = "addFilePathTxt";
            this.addFilePathTxt.Size = new System.Drawing.Size(188, 20);
            this.addFilePathTxt.TabIndex = 1;
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
            this.tableLayoutPanel1.Controls.Add(this.addFilePathTxt, 0, 1);
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
            this.tableLayoutPanel2.Controls.Add(this.uploadSpeedSelector, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.downloadSpeedSelector, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(276, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 147);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // uploadSpeedSelector
            // 
            this.uploadSpeedSelector.Location = new System.Drawing.Point(156, 20);
            this.uploadSpeedSelector.Maximum = new decimal(new int[] {
            1000000,
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
            this.label4.Location = new System.Drawing.Point(156, 1);
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
            this.downloadSpeedSelector.Location = new System.Drawing.Point(4, 20);
            this.downloadSpeedSelector.Maximum = new decimal(new int[] {
            1000000,
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
            // addTorBtn
            // 
            this.addTorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addTorBtn.AutoSize = true;
            this.addTorBtn.Location = new System.Drawing.Point(476, 166);
            this.addTorBtn.Name = "addTorBtn";
            this.addTorBtn.Size = new System.Drawing.Size(128, 33);
            this.addTorBtn.TabIndex = 8;
            this.addTorBtn.Text = "Add Torrent";
            this.addTorBtn.UseVisualStyleBackColor = true;
            this.addTorBtn.Click += new System.EventHandler(this.addTorBtn_Click);
            // 
            // pAddTorrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addTorBtn);
            this.Name = "pAddTorrent";
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
        private System.Windows.Forms.TextBox addFilePathTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox saveFilePathTxt;
        private System.Windows.Forms.Button saveFolderBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addTorBtn;
        private System.Windows.Forms.NumericUpDown downloadSpeedSelector;
        private System.Windows.Forms.NumericUpDown uploadSpeedSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}