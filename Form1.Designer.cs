﻿namespace Torrent
{
    partial class cMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cMainForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            ""}, -1);
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addTorrentFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStrip = new System.Windows.Forms.ToolStripButton();
            this.mainToolStripTop = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainListView = new System.Windows.Forms.ListView();
            this.column0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainToolStripBottom = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.downloadedLbl = new System.Windows.Forms.Label();
            this.downloadedProgressBar = new System.Windows.Forms.ProgressBar();
            this.downloadedPercentLbl = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.tab4 = new System.Windows.Forms.TabPage();
            this.mainToolStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainToolStripBottom.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTorrentFileToolStrip});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // addTorrentFileToolStrip
            // 
            this.addTorrentFileToolStrip.Name = "addTorrentFileToolStrip";
            this.addTorrentFileToolStrip.Size = new System.Drawing.Size(186, 22);
            this.addTorrentFileToolStrip.Text = "Add .torrent from file";
            this.addTorrentFileToolStrip.Click += new System.EventHandler(this.addTorrentFileToolStrip_Click);
            // 
            // settingsToolStrip
            // 
            this.settingsToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStrip.Image")));
            this.settingsToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsToolStrip.Name = "settingsToolStrip";
            this.settingsToolStrip.Size = new System.Drawing.Size(69, 22);
            this.settingsToolStrip.Text = "Settings";
            this.settingsToolStrip.Click += new System.EventHandler(this.settingsToolStrip_Click);
            // 
            // mainToolStripTop
            // 
            this.mainToolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.settingsToolStrip});
            this.mainToolStripTop.Location = new System.Drawing.Point(0, 0);
            this.mainToolStripTop.Name = "mainToolStripTop";
            this.mainToolStripTop.Size = new System.Drawing.Size(1904, 25);
            this.mainToolStripTop.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainToolStripBottom);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 1016);
            this.splitContainer1.SplitterDistance = 512;
            this.splitContainer1.TabIndex = 2;
            // 
            // mainListView
            // 
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column0,
            this.column1,
            this.column2});
            this.mainListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainListView.FullRowSelect = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.mainListView.Location = new System.Drawing.Point(0, 0);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(1904, 512);
            this.mainListView.TabIndex = 0;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            // 
            // column0
            // 
            this.column0.Text = "Name";
            this.column0.Width = 191;
            // 
            // column1
            // 
            this.column1.Text = "Total Size";
            this.column1.Width = 96;
            // 
            // column2
            // 
            this.column2.Text = "Downloaded";
            this.column2.Width = 111;
            // 
            // mainToolStripBottom
            // 
            this.mainToolStripBottom.Controls.Add(this.tab1);
            this.mainToolStripBottom.Controls.Add(this.tab2);
            this.mainToolStripBottom.Controls.Add(this.tab3);
            this.mainToolStripBottom.Controls.Add(this.tab4);
            this.mainToolStripBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainToolStripBottom.Location = new System.Drawing.Point(0, 0);
            this.mainToolStripBottom.Name = "mainToolStripBottom";
            this.mainToolStripBottom.SelectedIndex = 0;
            this.mainToolStripBottom.Size = new System.Drawing.Size(1904, 500);
            this.mainToolStripBottom.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tableLayoutPanelTop);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1896, 474);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Torrent Info";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTop.Controls.Add(this.downloadedLbl, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.downloadedProgressBar, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.downloadedPercentLbl, 2, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 2;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1890, 77);
            this.tableLayoutPanelTop.TabIndex = 1;
            // 
            // downloadedLbl
            // 
            this.downloadedLbl.AutoSize = true;
            this.downloadedLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.downloadedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadedLbl.ForeColor = System.Drawing.Color.Blue;
            this.downloadedLbl.Location = new System.Drawing.Point(3, 0);
            this.downloadedLbl.Name = "downloadedLbl";
            this.downloadedLbl.Size = new System.Drawing.Size(80, 29);
            this.downloadedLbl.TabIndex = 0;
            this.downloadedLbl.Text = "Downloaded:";
            this.downloadedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // downloadedProgressBar
            // 
            this.downloadedProgressBar.ForeColor = System.Drawing.Color.Blue;
            this.downloadedProgressBar.Location = new System.Drawing.Point(89, 3);
            this.downloadedProgressBar.Name = "downloadedProgressBar";
            this.downloadedProgressBar.Size = new System.Drawing.Size(1750, 23);
            this.downloadedProgressBar.TabIndex = 1;
            // 
            // downloadedPercentLbl
            // 
            this.downloadedPercentLbl.AutoSize = true;
            this.downloadedPercentLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.downloadedPercentLbl.ForeColor = System.Drawing.Color.Blue;
            this.downloadedPercentLbl.Location = new System.Drawing.Point(1845, 0);
            this.downloadedPercentLbl.Name = "downloadedPercentLbl";
            this.downloadedPercentLbl.Size = new System.Drawing.Size(30, 29);
            this.downloadedPercentLbl.TabIndex = 2;
            this.downloadedPercentLbl.Text = "0.0%";
            this.downloadedPercentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(1896, 474);
            this.tab2.TabIndex = 2;
            this.tab2.Text = "Clients";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tab3
            // 
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(1896, 474);
            this.tab3.TabIndex = 3;
            this.tab3.Text = "Trackers";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // tab4
            // 
            this.tab4.Location = new System.Drawing.Point(4, 22);
            this.tab4.Name = "tab4";
            this.tab4.Padding = new System.Windows.Forms.Padding(3);
            this.tab4.Size = new System.Drawing.Size(1896, 474);
            this.tab4.TabIndex = 1;
            this.tab4.Text = "Graphs";
            this.tab4.UseVisualStyleBackColor = true;
            // 
            // cMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainToolStripTop);
            this.Name = "cMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitload";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cMainForm_FormClosing);
            this.mainToolStripTop.ResumeLayout(false);
            this.mainToolStripTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mainToolStripBottom.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addTorrentFileToolStrip;
        private System.Windows.Forms.ToolStripButton settingsToolStrip;
        private System.Windows.Forms.ToolStrip mainToolStripTop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader column0;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.TabControl mainToolStripBottom;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Label downloadedLbl;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        public System.Windows.Forms.ProgressBar downloadedProgressBar;
        public System.Windows.Forms.Label downloadedPercentLbl;
        private System.Windows.Forms.ListView mainListView;
    }
}

