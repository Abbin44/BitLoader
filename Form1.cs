﻿using System;
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

        public cMainForm()
        {
            if (mainForm != null) 
                throw new Exception("Only one instance of cMainForm may ever exist!");

            mainForm = this;
               
            InitializeComponent();
            string settingsFolder = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Bitloader"; //Use Environment.UserName Here for releases
            if (!Directory.Exists(settingsFolder))
                Directory.CreateDirectory(settingsFolder);

            pSettings settings = new pSettings();
            Thread.Sleep(100);
            settings.Close();
        }
        List<TorrentDownloader> downloadList = new List<TorrentDownloader>();
        ConcurrentQueue<Action> toRunOnUI = new ConcurrentQueue<Action>();
        TorrentDownloader downloader;

        public int maxUploadSpeed;
        public int maxDownloadSpeed;
        public string saveFilePath = "";
        public string torrentFilePath = "";
        bool unlimitedDownloadSpeed;
        bool unlimitedUploadSpeed;
        int torrentIndex = 0;
        int selectedItemIndex;
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
                item.SubItems.Add("0%");//Downloaded %
                item.SubItems.Add("0%");//Download Speed
                item.SubItems.Add("0%");//Upload Speed
                mainListView.Items.Add(item);
                torrentIndex++;
            }
        }
        public void EditMainList(string downloaded, int upSpeed, int downSpeed, int index) //A method that sets all the values that need to be updated
        {
            if (!IsDisposed)
            {
                string downloadSpeed = FormatBytes(downSpeed); ;
                string uploadSpeed = FormatBytes(upSpeed); ;
                downloadedPercentLbl.Text = downloaded + "%"; //Percent after the progress bar in the lower tab page
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

        public void AddToClientList()
        {

        }
        #endregion
        private string FormatBytes(long bytes)
        {
            string[] suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, suffix[i]);
        }

        private int GetTorrentIndexByName(string torrentName)
        {
            for (int i = 0; i < downloadList.Count; i++)
            {
                if (downloadList[i].ti.Name == torrentName)
                    return i;
            }
            return 0; //<---- preferably don't want this here. Should theortically never be an issue though
        }

        #region Events
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("REEE CLOCK IS TICKING");
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
        }

        private void addTorrentFileToolStrip_Click(object sender, EventArgs e)
        {
            pAddTorrent at = new pAddTorrent();
            at.StartPosition = FormStartPosition.CenterScreen;
            at.ShowDialog();

            if (!string.IsNullOrWhiteSpace(at.GetSaveFilePath()) && at.GetAddTorrentFilePath().EndsWith(".torrent"))
            {
                saveFilePath = at.GetSaveFilePath();
                torrentFilePath = at.GetAddTorrentFilePath();
            }
            else
                return;

            maxUploadSpeed = at.GetMaxUploadSpeed();//Fix bug here where it crashes if you close the addtorrent popup.
            maxDownloadSpeed = at.GetMaxDownloadSpeed();
            unlimitedDownloadSpeed = at.GetUnlimitedDownloadSpeed();
            unlimitedUploadSpeed = at.GetUnlimitedUploadSpeed();

            if (!string.IsNullOrWhiteSpace(torrentFilePath))
            {
                downloader = new TorrentDownloader(maxUploadSpeed, maxDownloadSpeed, saveFilePath, torrentFilePath, unlimitedDownloadSpeed, unlimitedUploadSpeed);
                downloadList.Add(downloader);
                downloader.torrentIndex = torrentIndex;
                new Thread(downloader.AddTorrent).Start();
                mainTimer.Start();
            }
        }
        private void settingsToolStrip_Click(object sender, EventArgs e)
        {
            pSettings settings = new pSettings();
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
            RemoveFromList(selectedItemIndex);
            //Stop torrent here as well
        }
        private void removeDataToolStripMenuItem_Click(object sender, EventArgs e)//Remove from list + data
        {
            int index = GetTorrentIndexByName(mainListView.FocusedItem.Text);
            string savePath;
            string torrentName;

            savePath = downloadList[index].saveFilePath;
            torrentName = downloadList[index].ti.Name;
            downloadList[index].session.RemoveTorrent(downloadList[index].handle, true);
            RemoveFromList(selectedItemIndex);
        }
        private void removeDataTorrentFileToolStripMenuItem_Click(object sender, EventArgs e)//Remove from list + data + .torrent file
        {
            RemoveFromList(selectedItemIndex);

        }
        #endregion

        private void mainToolStripBottom_SelectedIndexChanged(object sender, EventArgs e) //Lägg till graf här
        {
            if (mainToolStripBottom.SelectedTab.Text == "Graphs")
            {
                //Console.WriteLine("EEEEK");
            }
        }

        private void cMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        #endregion
    }
}
