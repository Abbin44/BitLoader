namespace Torrent
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            ""}, -1);
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addTorrentFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStrip = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainListView = new System.Windows.Forms.ListView();
            this.column0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.settingsToolStrip});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1137, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
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
            this.splitContainer1.Panel1.Controls.Add(this.progressBar);
            this.splitContainer1.Panel1.Controls.Add(this.mainListView);
            this.splitContainer1.Size = new System.Drawing.Size(1137, 638);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 2;
            // 
            // mainListView
            // 
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column0,
            this.column1,
            this.column2,
            this.column3});
            this.mainListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainListView.FullRowSelect = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.mainListView.Location = new System.Drawing.Point(0, 0);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(1137, 322);
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
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Blue;
            this.progressBar.Location = new System.Drawing.Point(688, 180);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 1;
            // 
            // column3
            // 
            this.column3.Text = "Progress";
            this.column3.Width = 112;
            // 
            // cMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 663);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "cMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitload";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cMainForm_FormClosing);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addTorrentFileToolStrip;
        private System.Windows.Forms.ToolStripButton settingsToolStrip;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader column0;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ColumnHeader column3;
    }
}

