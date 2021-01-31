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
            this.components = new System.ComponentModel.Container();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addTorrentFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addTorrentFromMagnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStrip = new System.Windows.Forms.ToolStripButton();
            this.mainToolStripTop = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainListView = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDataTorrentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripBottom = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.infoUploadedValueLbl = new System.Windows.Forms.Label();
            this.infoUploadLimitLbl = new System.Windows.Forms.Label();
            this.infoUploadSpeedValueLbl = new System.Windows.Forms.Label();
            this.infoUploadedLbl = new System.Windows.Forms.Label();
            this.infoUploadSpeedLbl = new System.Windows.Forms.Label();
            this.infoUploadLimitValueLbl = new System.Windows.Forms.Label();
            this.generalInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.infoElapsedTimeValueLbl = new System.Windows.Forms.Label();
            this.infoElapsedTimeLbl = new System.Windows.Forms.Label();
            this.infoDownloadedValueLbl = new System.Windows.Forms.Label();
            this.infoDownloadedLbl = new System.Windows.Forms.Label();
            this.infoDownloadSpeedValueLbl = new System.Windows.Forms.Label();
            this.infoDownloadSpeedLbl = new System.Windows.Forms.Label();
            this.infoDownloadLimitValueLbl = new System.Windows.Forms.Label();
            this.infoDownloadLimitLbl = new System.Windows.Forms.Label();
            this.infoStatusValueLbl = new System.Windows.Forms.Label();
            this.infoStatusLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.downloadedLbl = new System.Windows.Forms.Label();
            this.downloadedProgressBar = new System.Windows.Forms.ProgressBar();
            this.downloadedPercentLbl = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.clientListView = new System.Windows.Forms.ListView();
            this.ipHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downSpeedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.upSpeedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab4 = new System.Windows.Forms.TabPage();
            this.trackerListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sourcesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.peerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadedHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab5 = new System.Windows.Forms.TabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.filesListView = new System.Windows.Forms.ListView();
            this.fileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePercentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePriorityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highPriorityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalPriorityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowPriorityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainListContextMenu.SuspendLayout();
            this.mainToolStripBottom.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.generalInfoTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tab4.SuspendLayout();
            this.tab5.SuspendLayout();
            this.filesContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTorrentFileToolStrip,
            this.addTorrentFromMagnetToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Torrent.Properties.Resources.Add;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // addTorrentFileToolStrip
            // 
            this.addTorrentFileToolStrip.Name = "addTorrentFileToolStrip";
            this.addTorrentFileToolStrip.Size = new System.Drawing.Size(208, 22);
            this.addTorrentFileToolStrip.Text = "Add torrent from file";
            this.addTorrentFileToolStrip.Click += new System.EventHandler(this.addTorrentFileToolStrip_Click);
            // 
            // addTorrentFromMagnetToolStripMenuItem
            // 
            this.addTorrentFromMagnetToolStripMenuItem.Name = "addTorrentFromMagnetToolStripMenuItem";
            this.addTorrentFromMagnetToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addTorrentFromMagnetToolStripMenuItem.Text = "Add torrent from magnet";
            this.addTorrentFromMagnetToolStripMenuItem.Click += new System.EventHandler(this.addTorrentFromMagnetToolStripMenuItem_Click);
            // 
            // settingsToolStrip
            // 
            this.settingsToolStrip.Image = global::Torrent.Properties.Resources.Settings;
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
            this.mainListView.BackColor = System.Drawing.SystemColors.Window;
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5});
            this.mainListView.ContextMenuStrip = this.mainListContextMenu;
            this.mainListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainListView.FullRowSelect = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Location = new System.Drawing.Point(0, 0);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(1904, 512);
            this.mainListView.TabIndex = 0;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            this.mainListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainListView_MouseClick);
            // 
            // column1
            // 
            this.column1.Text = "Name";
            this.column1.Width = 182;
            // 
            // column2
            // 
            this.column2.Text = "Total Size";
            this.column2.Width = 162;
            // 
            // column3
            // 
            this.column3.Text = "Downloaded";
            this.column3.Width = 140;
            // 
            // column4
            // 
            this.column4.Text = "Download Speed";
            this.column4.Width = 118;
            // 
            // column5
            // 
            this.column5.Text = "Upload Speed";
            this.column5.Width = 101;
            // 
            // mainListContextMenu
            // 
            this.mainListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.mainListContextMenu.Name = "contextMenuStrip1";
            this.mainListContextMenu.Size = new System.Drawing.Size(118, 92);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromListToolStripMenuItem,
            this.removeDataToolStripMenuItem,
            this.removeDataTorrentFileToolStripMenuItem});
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // removeFromListToolStripMenuItem
            // 
            this.removeFromListToolStripMenuItem.Name = "removeFromListToolStripMenuItem";
            this.removeFromListToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.removeFromListToolStripMenuItem.Text = "Remove from list";
            this.removeFromListToolStripMenuItem.Click += new System.EventHandler(this.removeFromListToolStripMenuItem_Click);
            // 
            // removeDataToolStripMenuItem
            // 
            this.removeDataToolStripMenuItem.Name = "removeDataToolStripMenuItem";
            this.removeDataToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.removeDataToolStripMenuItem.Text = "Remove from list + data ";
            this.removeDataToolStripMenuItem.Click += new System.EventHandler(this.removeDataToolStripMenuItem_Click);
            // 
            // removeDataTorrentFileToolStripMenuItem
            // 
            this.removeDataTorrentFileToolStripMenuItem.Name = "removeDataTorrentFileToolStripMenuItem";
            this.removeDataTorrentFileToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.removeDataTorrentFileToolStripMenuItem.Text = "Remove from list +  data + torrent file";
            this.removeDataTorrentFileToolStripMenuItem.Click += new System.EventHandler(this.removeDataTorrentFileToolStripMenuItem_Click);
            // 
            // mainToolStripBottom
            // 
            this.mainToolStripBottom.Controls.Add(this.tab1);
            this.mainToolStripBottom.Controls.Add(this.tab2);
            this.mainToolStripBottom.Controls.Add(this.tab3);
            this.mainToolStripBottom.Controls.Add(this.tab4);
            this.mainToolStripBottom.Controls.Add(this.tab5);
            this.mainToolStripBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainToolStripBottom.Location = new System.Drawing.Point(0, 0);
            this.mainToolStripBottom.Name = "mainToolStripBottom";
            this.mainToolStripBottom.SelectedIndex = 0;
            this.mainToolStripBottom.Size = new System.Drawing.Size(1904, 500);
            this.mainToolStripBottom.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tableLayoutPanel1);
            this.tab1.Controls.Add(this.generalInfoTableLayoutPanel);
            this.tab1.Controls.Add(this.tableLayoutPanelTop);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1896, 474);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Torrent Info";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.16418F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.83582F));
            this.tableLayoutPanel1.Controls.Add(this.infoUploadedValueLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.infoUploadLimitLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.infoUploadSpeedValueLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.infoUploadedLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.infoUploadSpeedLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.infoUploadLimitValueLbl, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(250, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 77);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // infoUploadedValueLbl
            // 
            this.infoUploadedValueLbl.AutoSize = true;
            this.infoUploadedValueLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoUploadedValueLbl.Location = new System.Drawing.Point(116, 0);
            this.infoUploadedValueLbl.Name = "infoUploadedValueLbl";
            this.infoUploadedValueLbl.Size = new System.Drawing.Size(0, 13);
            this.infoUploadedValueLbl.TabIndex = 15;
            // 
            // infoUploadLimitLbl
            // 
            this.infoUploadLimitLbl.AutoSize = true;
            this.infoUploadLimitLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoUploadLimitLbl.Location = new System.Drawing.Point(3, 50);
            this.infoUploadLimitLbl.Name = "infoUploadLimitLbl";
            this.infoUploadLimitLbl.Size = new System.Drawing.Size(68, 13);
            this.infoUploadLimitLbl.TabIndex = 13;
            this.infoUploadLimitLbl.Text = "Upload Limit:";
            // 
            // infoUploadSpeedValueLbl
            // 
            this.infoUploadSpeedValueLbl.AutoSize = true;
            this.infoUploadSpeedValueLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoUploadSpeedValueLbl.Location = new System.Drawing.Point(116, 25);
            this.infoUploadSpeedValueLbl.Name = "infoUploadSpeedValueLbl";
            this.infoUploadSpeedValueLbl.Size = new System.Drawing.Size(0, 13);
            this.infoUploadSpeedValueLbl.TabIndex = 15;
            // 
            // infoUploadedLbl
            // 
            this.infoUploadedLbl.AutoSize = true;
            this.infoUploadedLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoUploadedLbl.Location = new System.Drawing.Point(3, 0);
            this.infoUploadedLbl.Name = "infoUploadedLbl";
            this.infoUploadedLbl.Size = new System.Drawing.Size(56, 13);
            this.infoUploadedLbl.TabIndex = 13;
            this.infoUploadedLbl.Text = "Uploaded:";
            // 
            // infoUploadSpeedLbl
            // 
            this.infoUploadSpeedLbl.AutoSize = true;
            this.infoUploadSpeedLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoUploadSpeedLbl.Location = new System.Drawing.Point(3, 25);
            this.infoUploadSpeedLbl.Name = "infoUploadSpeedLbl";
            this.infoUploadSpeedLbl.Size = new System.Drawing.Size(78, 13);
            this.infoUploadSpeedLbl.TabIndex = 13;
            this.infoUploadSpeedLbl.Text = "Upload Speed:";
            // 
            // infoUploadLimitValueLbl
            // 
            this.infoUploadLimitValueLbl.AutoSize = true;
            this.infoUploadLimitValueLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoUploadLimitValueLbl.Location = new System.Drawing.Point(116, 50);
            this.infoUploadLimitValueLbl.Name = "infoUploadLimitValueLbl";
            this.infoUploadLimitValueLbl.Size = new System.Drawing.Size(0, 13);
            this.infoUploadLimitValueLbl.TabIndex = 14;
            // 
            // generalInfoTableLayoutPanel
            // 
            this.generalInfoTableLayoutPanel.ColumnCount = 2;
            this.generalInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoElapsedTimeValueLbl, 1, 0);
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoElapsedTimeLbl, 0, 0);
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoDownloadedValueLbl, 1, 1);
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoDownloadedLbl, 0, 1);
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoDownloadSpeedValueLbl, 1, 2);
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoDownloadSpeedLbl, 0, 2);
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoDownloadLimitValueLbl, 1, 3);
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoDownloadLimitLbl, 0, 3);
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoStatusValueLbl, 1, 4);
            this.generalInfoTableLayoutPanel.Controls.Add(this.infoStatusLbl, 0, 4);
            this.generalInfoTableLayoutPanel.Location = new System.Drawing.Point(9, 83);
            this.generalInfoTableLayoutPanel.Name = "generalInfoTableLayoutPanel";
            this.generalInfoTableLayoutPanel.RowCount = 6;
            this.generalInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.generalInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.generalInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.generalInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.generalInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.generalInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalInfoTableLayoutPanel.Size = new System.Drawing.Size(235, 124);
            this.generalInfoTableLayoutPanel.TabIndex = 2;
            // 
            // infoElapsedTimeValueLbl
            // 
            this.infoElapsedTimeValueLbl.AutoSize = true;
            this.infoElapsedTimeValueLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoElapsedTimeValueLbl.Location = new System.Drawing.Point(120, 0);
            this.infoElapsedTimeValueLbl.Name = "infoElapsedTimeValueLbl";
            this.infoElapsedTimeValueLbl.Size = new System.Drawing.Size(0, 13);
            this.infoElapsedTimeValueLbl.TabIndex = 12;
            // 
            // infoElapsedTimeLbl
            // 
            this.infoElapsedTimeLbl.AutoSize = true;
            this.infoElapsedTimeLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoElapsedTimeLbl.Location = new System.Drawing.Point(3, 0);
            this.infoElapsedTimeLbl.Name = "infoElapsedTimeLbl";
            this.infoElapsedTimeLbl.Size = new System.Drawing.Size(74, 13);
            this.infoElapsedTimeLbl.TabIndex = 3;
            this.infoElapsedTimeLbl.Text = "Elapsed Time:";
            // 
            // infoDownloadedValueLbl
            // 
            this.infoDownloadedValueLbl.AutoSize = true;
            this.infoDownloadedValueLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoDownloadedValueLbl.Location = new System.Drawing.Point(120, 25);
            this.infoDownloadedValueLbl.Name = "infoDownloadedValueLbl";
            this.infoDownloadedValueLbl.Size = new System.Drawing.Size(0, 13);
            this.infoDownloadedValueLbl.TabIndex = 11;
            // 
            // infoDownloadedLbl
            // 
            this.infoDownloadedLbl.AutoSize = true;
            this.infoDownloadedLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoDownloadedLbl.Location = new System.Drawing.Point(3, 25);
            this.infoDownloadedLbl.Name = "infoDownloadedLbl";
            this.infoDownloadedLbl.Size = new System.Drawing.Size(70, 13);
            this.infoDownloadedLbl.TabIndex = 4;
            this.infoDownloadedLbl.Text = "Downloaded:";
            // 
            // infoDownloadSpeedValueLbl
            // 
            this.infoDownloadSpeedValueLbl.AutoSize = true;
            this.infoDownloadSpeedValueLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoDownloadSpeedValueLbl.Location = new System.Drawing.Point(120, 50);
            this.infoDownloadSpeedValueLbl.Name = "infoDownloadSpeedValueLbl";
            this.infoDownloadSpeedValueLbl.Size = new System.Drawing.Size(0, 13);
            this.infoDownloadSpeedValueLbl.TabIndex = 10;
            // 
            // infoDownloadSpeedLbl
            // 
            this.infoDownloadSpeedLbl.AutoSize = true;
            this.infoDownloadSpeedLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoDownloadSpeedLbl.Location = new System.Drawing.Point(3, 50);
            this.infoDownloadSpeedLbl.Name = "infoDownloadSpeedLbl";
            this.infoDownloadSpeedLbl.Size = new System.Drawing.Size(92, 13);
            this.infoDownloadSpeedLbl.TabIndex = 5;
            this.infoDownloadSpeedLbl.Text = "Download Speed:";
            // 
            // infoDownloadLimitValueLbl
            // 
            this.infoDownloadLimitValueLbl.AutoSize = true;
            this.infoDownloadLimitValueLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoDownloadLimitValueLbl.Location = new System.Drawing.Point(120, 75);
            this.infoDownloadLimitValueLbl.Name = "infoDownloadLimitValueLbl";
            this.infoDownloadLimitValueLbl.Size = new System.Drawing.Size(0, 13);
            this.infoDownloadLimitValueLbl.TabIndex = 9;
            // 
            // infoDownloadLimitLbl
            // 
            this.infoDownloadLimitLbl.AutoSize = true;
            this.infoDownloadLimitLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoDownloadLimitLbl.Location = new System.Drawing.Point(3, 75);
            this.infoDownloadLimitLbl.Name = "infoDownloadLimitLbl";
            this.infoDownloadLimitLbl.Size = new System.Drawing.Size(82, 13);
            this.infoDownloadLimitLbl.TabIndex = 6;
            this.infoDownloadLimitLbl.Text = "Download Limit:";
            // 
            // infoStatusValueLbl
            // 
            this.infoStatusValueLbl.AutoSize = true;
            this.infoStatusValueLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoStatusValueLbl.Location = new System.Drawing.Point(120, 100);
            this.infoStatusValueLbl.Name = "infoStatusValueLbl";
            this.infoStatusValueLbl.Size = new System.Drawing.Size(0, 13);
            this.infoStatusValueLbl.TabIndex = 8;
            // 
            // infoStatusLbl
            // 
            this.infoStatusLbl.AutoSize = true;
            this.infoStatusLbl.ForeColor = System.Drawing.Color.Blue;
            this.infoStatusLbl.Location = new System.Drawing.Point(3, 100);
            this.infoStatusLbl.Name = "infoStatusLbl";
            this.infoStatusLbl.Size = new System.Drawing.Size(40, 13);
            this.infoStatusLbl.TabIndex = 7;
            this.infoStatusLbl.Text = "Status:";
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
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1890, 42);
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
            this.downloadedLbl.Size = new System.Drawing.Size(80, 34);
            this.downloadedLbl.TabIndex = 0;
            this.downloadedLbl.Text = "Downloaded:";
            this.downloadedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // downloadedProgressBar
            // 
            this.downloadedProgressBar.ForeColor = System.Drawing.Color.Blue;
            this.downloadedProgressBar.Location = new System.Drawing.Point(89, 3);
            this.downloadedProgressBar.Name = "downloadedProgressBar";
            this.downloadedProgressBar.Size = new System.Drawing.Size(1750, 28);
            this.downloadedProgressBar.TabIndex = 1;
            // 
            // downloadedPercentLbl
            // 
            this.downloadedPercentLbl.AutoSize = true;
            this.downloadedPercentLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.downloadedPercentLbl.ForeColor = System.Drawing.Color.Blue;
            this.downloadedPercentLbl.Location = new System.Drawing.Point(1845, 0);
            this.downloadedPercentLbl.Name = "downloadedPercentLbl";
            this.downloadedPercentLbl.Size = new System.Drawing.Size(0, 34);
            this.downloadedPercentLbl.TabIndex = 2;
            this.downloadedPercentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.filesListView);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(1896, 474);
            this.tab2.TabIndex = 4;
            this.tab2.Text = "Files";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.clientListView);
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(1896, 474);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Clients";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // clientListView
            // 
            this.clientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ipHeader,
            this.clientHeader,
            this.downloadedHeader,
            this.downSpeedHeader,
            this.upSpeedHeader});
            this.clientListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientListView.HideSelection = false;
            this.clientListView.Location = new System.Drawing.Point(0, 0);
            this.clientListView.Name = "clientListView";
            this.clientListView.Size = new System.Drawing.Size(1896, 474);
            this.clientListView.TabIndex = 0;
            this.clientListView.UseCompatibleStateImageBehavior = false;
            this.clientListView.View = System.Windows.Forms.View.Details;
            // 
            // ipHeader
            // 
            this.ipHeader.Text = "IP";
            this.ipHeader.Width = 125;
            // 
            // clientHeader
            // 
            this.clientHeader.Text = "Client";
            this.clientHeader.Width = 136;
            // 
            // downloadedHeader
            // 
            this.downloadedHeader.Text = "Downloaded %";
            this.downloadedHeader.Width = 115;
            // 
            // downSpeedHeader
            // 
            this.downSpeedHeader.Text = "Download Speed to Peer";
            this.downSpeedHeader.Width = 134;
            // 
            // upSpeedHeader
            // 
            this.upSpeedHeader.Text = "Upload Speed to Peer";
            this.upSpeedHeader.Width = 117;
            // 
            // tab4
            // 
            this.tab4.Controls.Add(this.trackerListView);
            this.tab4.Location = new System.Drawing.Point(4, 22);
            this.tab4.Name = "tab4";
            this.tab4.Size = new System.Drawing.Size(1896, 474);
            this.tab4.TabIndex = 3;
            this.tab4.Text = "Trackers";
            this.tab4.UseVisualStyleBackColor = true;
            // 
            // trackerListView
            // 
            this.trackerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.statusHeader,
            this.sourcesHeader,
            this.peerHeader,
            this.downloadedHeader2});
            this.trackerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackerListView.HideSelection = false;
            this.trackerListView.Location = new System.Drawing.Point(0, 0);
            this.trackerListView.Name = "trackerListView";
            this.trackerListView.Size = new System.Drawing.Size(1896, 474);
            this.trackerListView.TabIndex = 0;
            this.trackerListView.UseCompatibleStateImageBehavior = false;
            this.trackerListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 108;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 99;
            // 
            // sourcesHeader
            // 
            this.sourcesHeader.Text = "Sources";
            this.sourcesHeader.Width = 92;
            // 
            // peerHeader
            // 
            this.peerHeader.Text = "Peers";
            this.peerHeader.Width = 96;
            // 
            // downloadedHeader2
            // 
            this.downloadedHeader2.Text = "Downloaded";
            this.downloadedHeader2.Width = 112;
            // 
            // tab5
            // 
            this.tab5.Controls.Add(this.cartesianChart1);
            this.tab5.Location = new System.Drawing.Point(4, 22);
            this.tab5.Name = "tab5";
            this.tab5.Padding = new System.Windows.Forms.Padding(3);
            this.tab5.Size = new System.Drawing.Size(1896, 474);
            this.tab5.TabIndex = 1;
            this.tab5.Text = "Graphs";
            this.tab5.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(459, 90);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(635, 276);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // filesListView
            // 
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameHeader,
            this.fileSizeHeader,
            this.filePercentHeader,
            this.filePriorityHeader});
            this.filesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(0, 0);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(1896, 474);
            this.filesListView.TabIndex = 0;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            this.filesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filesListView_MouseClick);
            // 
            // fileNameHeader
            // 
            this.fileNameHeader.Text = "Name";
            this.fileNameHeader.Width = 205;
            // 
            // fileSizeHeader
            // 
            this.fileSizeHeader.Text = "Size";
            this.fileSizeHeader.Width = 98;
            // 
            // filePercentHeader
            // 
            this.filePercentHeader.Text = "%";
            this.filePercentHeader.Width = 63;
            // 
            // filePriorityHeader
            // 
            this.filePriorityHeader.Text = "Priority";
            this.filePriorityHeader.Width = 110;
            // 
            // filesContextMenu
            // 
            this.filesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPriorityToolStripMenuItem});
            this.filesContextMenu.Name = "filesContextMenu";
            this.filesContextMenu.Size = new System.Drawing.Size(132, 26);
            // 
            // setPriorityToolStripMenuItem
            // 
            this.setPriorityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highPriorityMenuItem,
            this.normalPriorityMenuItem,
            this.lowPriorityMenuItem});
            this.setPriorityToolStripMenuItem.Name = "setPriorityToolStripMenuItem";
            this.setPriorityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setPriorityToolStripMenuItem.Text = "Set Priority";
            // 
            // highPriorityMenuItem
            // 
            this.highPriorityMenuItem.Name = "highPriorityMenuItem";
            this.highPriorityMenuItem.Size = new System.Drawing.Size(180, 22);
            this.highPriorityMenuItem.Text = "High";
            this.highPriorityMenuItem.Click += new System.EventHandler(this.highPriorityMenuItem_Click);
            // 
            // normalPriorityMenuItem
            // 
            this.normalPriorityMenuItem.Name = "normalPriorityMenuItem";
            this.normalPriorityMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalPriorityMenuItem.Text = "Normal";
            this.normalPriorityMenuItem.Click += new System.EventHandler(this.normalPriorityMenuItem_Click);
            // 
            // lowPriorityMenuItem
            // 
            this.lowPriorityMenuItem.Name = "lowPriorityMenuItem";
            this.lowPriorityMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lowPriorityMenuItem.Text = "Low";
            this.lowPriorityMenuItem.Click += new System.EventHandler(this.lowPriorityMenuItem_Click);
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
            this.Text = "Bitloader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cMainForm_FormClosing);
            this.mainToolStripTop.ResumeLayout(false);
            this.mainToolStripTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mainListContextMenu.ResumeLayout(false);
            this.mainToolStripBottom.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.generalInfoTableLayoutPanel.ResumeLayout(false);
            this.generalInfoTableLayoutPanel.PerformLayout();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tab4.ResumeLayout(false);
            this.tab5.ResumeLayout(false);
            this.filesContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addTorrentFileToolStrip;
        private System.Windows.Forms.ToolStripButton settingsToolStrip;
        private System.Windows.Forms.ToolStrip mainToolStripTop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Label downloadedLbl;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.TabPage tab4;
        public System.Windows.Forms.ProgressBar downloadedProgressBar;
        public System.Windows.Forms.Label downloadedPercentLbl;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.ColumnHeader column3;
        private System.Windows.Forms.ContextMenuStrip mainListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ColumnHeader column4;
        private System.Windows.Forms.ColumnHeader column5;
        private System.Windows.Forms.ListView clientListView;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDataTorrentFileToolStripMenuItem;
        public System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ColumnHeader ipHeader;
        private System.Windows.Forms.ColumnHeader clientHeader;
        private System.Windows.Forms.ColumnHeader downloadedHeader;
        private System.Windows.Forms.ColumnHeader downSpeedHeader;
        private System.Windows.Forms.ColumnHeader upSpeedHeader;
        private System.Windows.Forms.ListView trackerListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.ColumnHeader sourcesHeader;
        private System.Windows.Forms.ColumnHeader peerHeader;
        private System.Windows.Forms.ColumnHeader downloadedHeader2;
        private System.Windows.Forms.TableLayoutPanel generalInfoTableLayoutPanel;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label infoDownloadedValueLbl;
        private System.Windows.Forms.Label infoDownloadSpeedValueLbl;
        private System.Windows.Forms.Label infoDownloadLimitValueLbl;
        private System.Windows.Forms.Label infoStatusValueLbl;
        private System.Windows.Forms.Label infoStatusLbl;
        private System.Windows.Forms.Label infoDownloadLimitLbl;
        private System.Windows.Forms.Label infoDownloadSpeedLbl;
        private System.Windows.Forms.Label infoDownloadedLbl;
        private System.Windows.Forms.Label infoElapsedTimeLbl;
        private System.Windows.Forms.Label infoElapsedTimeValueLbl;
        public System.Windows.Forms.TabControl mainToolStripBottom;
        private System.Windows.Forms.ToolStripMenuItem addTorrentFromMagnetToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label infoUploadLimitLbl;
        private System.Windows.Forms.Label infoUploadedLbl;
        private System.Windows.Forms.Label infoUploadSpeedLbl;
        private System.Windows.Forms.Label infoUploadLimitValueLbl;
        private System.Windows.Forms.Label infoUploadedValueLbl;
        private System.Windows.Forms.Label infoUploadSpeedValueLbl;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.ColumnHeader fileNameHeader;
        private System.Windows.Forms.ColumnHeader fileSizeHeader;
        private System.Windows.Forms.ColumnHeader filePercentHeader;
        private System.Windows.Forms.ColumnHeader filePriorityHeader;
        private System.Windows.Forms.ContextMenuStrip filesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem setPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highPriorityMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalPriorityMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowPriorityMenuItem;
    }
}

