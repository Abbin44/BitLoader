using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Build.Framework.XamlTypes;
using Ragnar;

namespace Torrent
{
    public partial class cMainForm : Form
    {
        public static cMainForm mainForm { get; private set; }
        public static Session session { get; private set; }

        public List<string> activeTorrents = new List<string>();
        List<string> connectedPeers = new List<string>();
        public List<TorrentDownloader> downloadList = new List<TorrentDownloader>();
        ConcurrentQueue<Action> toRunOnUI = new ConcurrentQueue<Action>();
        TorrentDownloader downloader;

        public int maxUploadSpeed;
        public int maxDownloadSpeed;
        public string saveFilePath = string.Empty;
        public string torrentFilePath = string.Empty;
        public string magnetLink = string.Empty;
        bool unlimitedDownloadSpeed;
        bool unlimitedUploadSpeed;
        public int torrentIndex = 0;
        int selectedItemIndex;

        readonly string activeTorrentsPath = $@"C:\Users\" + "abbin" + @"\AppData\Local\Bitloader\active_torrents.tor"; // Environment.UserName
        public cMainForm()
        {
            if (mainForm != null) 
                throw new Exception("Only one instance of cMainForm may ever exist!");

            mainForm = this;

            if(session != null)
                throw new Exception("Only one instance of session may ever exist!");

            session = new Session();

            InitializeComponent();
            string settingsFolder = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Bitloader"; //Use Environment.UserName Here for releases
            if (!Directory.Exists(settingsFolder))
                Directory.CreateDirectory(settingsFolder);

            this.Show();
            SettingsForm settings = new SettingsForm();
            Thread.Sleep(100);
            settings.Close();

            TorrentHandler handler = new TorrentHandler();
            if(File.Exists(activeTorrentsPath))
                handler.ReadActiveTorrents();
        }

        public void RunOnUIThread(Action a)
        {
            toRunOnUI.Enqueue(a);
        }

        #region Lists
        public void AddToMainList(string name, long size, int index)//Only sets the values once
        {
            if (!IsDisposed)
            {
                string totalSize = FormatBytes(size);
                ListViewItem item = new ListViewItem(name);
                item.Tag = torrentIndex.ToString();
                item.SubItems.Add(totalSize);
                item.SubItems.Add("");//Downloaded %
                item.SubItems.Add("");//Download Speed
                item.SubItems.Add("");//Upload Speed
                mainListView.Items.Add(item);
                torrentIndex++;
            }
        }

        public void EditMainList(string downloaded, int upSpeed, int downSpeed, string status, int index) //A method that sets all the values that need to be updated
        {
            if (!IsDisposed)
            {
                string downloadSpeed = FormatBytes(downSpeed); ;
                string uploadSpeed = FormatBytes(upSpeed); ;
                downloadedPercentLbl.Text = downloaded + "%"; //Percent after the progress bar in the lower tab page

                if(status == "CheckingFiles")//Used to not display percentage when connecting to peers
                {
                    downloaded = TrimString(downloaded);
                    mainListView.Items[index].SubItems[2].Text = "Connecting to peers: " + downloaded + "%";
                }
                else
                    mainListView.Items[index].SubItems[2].Text = downloaded + "%";

                mainListView.Items[index].SubItems[3].Text = downloadSpeed + "/s";
                mainListView.Items[index].SubItems[4].Text = uploadSpeed + "/s";
            }
        }

        public void RemoveFromList(int index)
        {
            if (!IsDisposed)
            {
                mainListView.Items[index].Remove();
            }
        }

        public void RemoveData(string folder, string torrentName)
        {
            if (Directory.Exists(folder + torrentName))
                Directory.Delete(folder + torrentName, true);
        }

        #region LowerTabs
        public void AddToClientList(int index)
        {
            string uploadSpeed;
            string downloadSpeed;

            IEnumerable<PeerInfo> peers = downloadList[selectedItemIndex].connectedPeers;
            ListViewItem item;
            foreach (PeerInfo peer in peers)
            {
                downloadSpeed = FormatBytes(peer.DownSpeed);
                uploadSpeed = FormatBytes(peer.UpSpeed);

                if (!connectedPeers.Contains(peer.EndPoint.ToString()))
                {
                    item = new ListViewItem(peer.EndPoint.ToString());
                    item.Tag = torrentIndex.ToString();
                    item.SubItems.Add(peer.Client);//Client
                    item.SubItems.Add(peer.TotalDownload.ToString());//Downloaded %
                    item.SubItems.Add(downloadSpeed);//Download speed TO peer
                    item.SubItems.Add(uploadSpeed);//Upload speed TO peer
                    clientListView.Items.Add(item);
                    connectedPeers.Add(peer.EndPoint.ToString());
                }
            }
        }

        public void UpdateInfoTabData()
        {
            string down = string.Concat(downloadList[selectedItemIndex].downloaded, " %");
            string downSpeed = FormatBytes(downloadList[selectedItemIndex].downloadSpeed);
            string limit;
            if (downloadList[selectedItemIndex].formattedDownLimit != "∞")
                limit = string.Concat(downloadList[selectedItemIndex].formattedDownLimit, " KB/s");
            else
                limit = downloadList[selectedItemIndex].formattedDownLimit;

            infoElapsedTimeValueLbl.Text = downloadList[selectedItemIndex].elapsedTime.ToString();//Elapsed time
            infoDownloadedValueLbl.Text = down; //Downloaded
            infoDownloadSpeedValueLbl.Text = downSpeed;//Download Speed
            infoDownloadLimitValueLbl.Text = limit;//Download Speed Limit
            infoStatusValueLbl.Text = downloadList[selectedItemIndex].currentStatus;//Current Status
        }
        #endregion
        #endregion
        public string TrimString(string text)
        {
            if (string.IsNullOrEmpty(text)) 
                return text;

            int maxLength = 0;
            char[] value = text.ToCharArray();

            if (value[1] == ',')// 0-9
                maxLength = 3;
            else if (value[2] == ',')//10-99
                maxLength = 4;
            else if (value[3] == ',')//100 ->
                maxLength = 3;

            text = value.ToString();

            return text.Length <= maxLength ? text : text.Substring(0, maxLength);
        }

        private string FormatBytes(long bytes)
        {
            string[] suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return string.Format("{0:0.##} {1}", dblSByte, suffix[i]);
        }

        private int GetTorrentIndexByName(string torrentName)
        {
            for (int i = 0; i < downloadList.Count; ++i)
            {
                if (downloadList[i].ti.Name == torrentName)
                    return i;
            }
            return 0;
        }

        #region Events
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            Action temp;
            while (toRunOnUI.TryDequeue(out temp))
            {
                try
                {
                    temp();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error during callback: {temp}:\n{ex}");
                }
            }
        }

        private void mainListView_MouseClick(object sender, MouseEventArgs e)
        {
            selectedItemIndex = mainListView.FocusedItem.Index;
            clientListView.Clear();
            trackerListView.Clear();
            connectedPeers.Clear();
        }

        private void addTorrentFileToolStrip_Click(object sender, EventArgs e) //Add torrent from file
        {
            AddTorrentFileForm at = new AddTorrentFileForm();
            at.StartPosition = FormStartPosition.CenterScreen;
            at.ShowDialog();

            if (!string.IsNullOrWhiteSpace(at.GetSaveFilePath()) && at.GetAddTorrentFilePath().EndsWith(".torrent"))
            {
                saveFilePath = at.GetSaveFilePath();
                torrentFilePath = at.GetAddTorrentFilePath();
            }
            else
                return;

            maxUploadSpeed = at.GetMaxUploadSpeed();
            maxDownloadSpeed = at.GetMaxDownloadSpeed();
            unlimitedDownloadSpeed = at.GetUnlimitedDownloadSpeed();
            unlimitedUploadSpeed = at.GetUnlimitedUploadSpeed();

            downloader = new TorrentDownloader(maxUploadSpeed, maxDownloadSpeed, saveFilePath, torrentFilePath, "", unlimitedDownloadSpeed, unlimitedUploadSpeed);
            downloadList.Add(downloader);
            downloader.torrentIndex = torrentIndex;
            activeTorrents.Add(downloader.torrentFilePath);
            new Thread(downloader.AddTorrentFromFile).Start();
            mainTimer.Start();
        }

        private void addTorrentFromMagnetToolStripMenuItem_Click(object sender, EventArgs e) //Add torrent From magnet
        {
            AddMagnetForm addMagnet = new AddMagnetForm();
            addMagnet.StartPosition = FormStartPosition.CenterScreen;
            addMagnet.ShowDialog();

            if (!string.IsNullOrWhiteSpace(addMagnet.GetSaveFilePath()) && !string.IsNullOrWhiteSpace(addMagnet.GetMagnetLink()))
            {
                saveFilePath = addMagnet.GetSaveFilePath();
                magnetLink = addMagnet.GetMagnetLink();
            }
            else
                return;

            maxUploadSpeed = addMagnet.GetMaxUploadSpeed();
            maxDownloadSpeed = addMagnet.GetMaxDownloadSpeed();
            unlimitedDownloadSpeed = addMagnet.GetUnlimitedDownloadSpeed();
            unlimitedUploadSpeed = addMagnet.GetUnlimitedUploadSpeed();

            downloader = new TorrentDownloader(maxUploadSpeed, maxDownloadSpeed, saveFilePath, "", magnetLink, unlimitedDownloadSpeed, unlimitedUploadSpeed);
            downloadList.Add(downloader);
            downloader.torrentIndex = torrentIndex;
            activeTorrents.Add(downloader.magnetLink); //This needs to be extended to accept magnet links... Currently only supports file paths.
            new Thread(downloader.AddTorrentFromMagnet).Start();
            mainTimer.Start();
        }

        private void settingsToolStrip_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.StartPosition = FormStartPosition.CenterScreen;
            settings.Show();
        }
        #region Context menu

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = GetTorrentIndexByName(mainListView.FocusedItem.Text);

            if(downloadList[index].pause == false && !downloadList[index].handle.IsPaused)
               downloadList[index].pause = true;
            else if(downloadList[index].pause == true && downloadList[index].handle.IsPaused)
                downloadList[index].pause = false;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = GetTorrentIndexByName(mainListView.FocusedItem.Text);

            if (downloadList[index].pause == true)
                downloadList[index].pause = false;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = GetTorrentIndexByName(mainListView.FocusedItem.Text);
            downloadList[index].Close();
        }

        private void removeFromListToolStripMenuItem_Click(object sender, EventArgs e) //Remove only from list
        {
            int index = GetTorrentIndexByName(mainListView.FocusedItem.Text);
            downloadList[index].Close();
            RemoveFromList(selectedItemIndex);

            //Stop torrent here as well
        }
        private void removeDataToolStripMenuItem_Click(object sender, EventArgs e)//Remove from list + data
        {
            int index = GetTorrentIndexByName(mainListView.FocusedItem.Text);

            session.RemoveTorrent(downloadList[index].handle, true);
            downloadList[index].Close();
            RemoveFromList(selectedItemIndex);
        }
        private void removeDataTorrentFileToolStripMenuItem_Click(object sender, EventArgs e)//Remove from list + data + .torrent file
        {
            int index = GetTorrentIndexByName(mainListView.FocusedItem.Text);
            session.RemoveTorrent(downloadList[index].handle, true);//Remove data

            string filePath = downloadList[index].torrentFilePath;
            if (File.Exists(filePath))//Remove torrent file
                File.Delete(filePath);

            downloadList[index].Close();
            RemoveFromList(selectedItemIndex);//Remove from list
        }
        #endregion

        private void cMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TorrentHandler handler = new TorrentHandler();
            handler.WriteActiveTorrents(activeTorrents);

            for (int i = 0; i < downloadList.Count; i++) //Save resume data for all torrents that aren't finished.
            {
                if (!downloadList[i].handle.IsFinished)
                    downloadList[i].SaveResumeData();
            }

            Environment.Exit(Environment.ExitCode);
        }
        #endregion

    }
}
