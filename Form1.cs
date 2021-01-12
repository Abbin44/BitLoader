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
        ConcurrentQueue<Action> toRunOnUI = new ConcurrentQueue<Action>();
        TorrentDownloader downloader;

        public int maxUploadSpeed;
        public int maxDownloadSpeed;
        public string saveFilePath = "";
        public string torrentFilePath = "";
        bool unlimitedDownloadSpeed;
        bool unlimitedUploadSpeed;

        public void RunOnUIThread(Action a)
        {
            toRunOnUI.Enqueue(a);
        }

        public void AddToList(string name, long size)//Only sets the values once
        {
            if (!IsDisposed)
            {
                string totalSize = FormatBytes(size);
                mainListView.Items[0].SubItems[0].Text = name;
                mainListView.Items[0].SubItems[1].Text = totalSize;
                mainListView.Items[0].SubItems[2].Text = "0%";
            }
        }
        public void EditList(string downloaded) //A method that sets all the values that need to be updated
        {
            if (!IsDisposed)
            {
                downloadedPercentLbl.Text = downloaded + "%"; //Percent after the progress bar in the lower tab page
                mainListView.Items[0].SubItems[2].Text = downloaded + "%";
            }
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

            return String.Format("{0:0.##} {1}", dblSByte, suffix[i]);
        }
        private void DrawGraph()
        {
            //Upload Speed
            //Download Speed
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

        private void addTorrentFileToolStrip_Click(object sender, EventArgs e)
        {
            pAddTorrent at = new pAddTorrent();
            at.StartPosition = FormStartPosition.CenterScreen;
            at.ShowDialog();

            maxUploadSpeed = at.GetMaxUploadSpeed();//Fix bug here where it crashes if you close the addtorrent popup.
            maxDownloadSpeed = at.GetMaxDownloadSpeed();
            saveFilePath = at.GetSaveFilePath();
            torrentFilePath = at.GetAddTorrentFilePath();
            unlimitedDownloadSpeed = at.GetUnlimitedDownloadSpeed();
            unlimitedUploadSpeed = at.GetUnlimitedUploadSpeed();

            if (!string.IsNullOrWhiteSpace(torrentFilePath))
            {
                downloader = new TorrentDownloader(maxUploadSpeed, maxDownloadSpeed, saveFilePath, torrentFilePath, unlimitedDownloadSpeed, unlimitedUploadSpeed);
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
        private void mainToolStripBottom_SelectedIndexChanged(object sender, EventArgs e) //Lägg till graf här
        {
            if (mainToolStripBottom.SelectedTab.Text == "Graphs")
            {
                Console.WriteLine("EEEEK");
            }
        }
        private void cMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        #endregion


    }
}
