using System;
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
        public cMainForm()
        {
            InitializeComponent();
            string settingsFolder = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Bitloader"; //Use Environment.UserName Here for releases
            if (!Directory.Exists(settingsFolder))
                Directory.CreateDirectory(settingsFolder);

            pSettings settings = new pSettings();
            Thread.Sleep(100);
            settings.Close();
        }
        public Session LibTorrentSession { get; private set; }
        public int maxUploadSpeed;
        public int maxDownloadSpeed;
        public string saveFilePath = "";
        public string torrentFilePath = "";

        public void AddTorrent()
        {
            try
            {
                if (!IsDisposed)
                {
                    byte[] bytes = File.ReadAllBytes(torrentFilePath);
                    TorrentInfo ti = new TorrentInfo(bytes);
                    using (var session = new Session())
                    {
                        // Make the session listen on a port in the range 6881-6889
                        session.ListenOn(6881, 6889);

                        AddTorrentParams addParams = new AddTorrentParams
                        {
                            DownloadLimit = maxDownloadSpeed * 1024,//Transform byte to kB
                            UploadLimit = maxUploadSpeed * 1024,

                            TorrentInfo = ti,
                            SavePath = saveFilePath,
                        };
                        // Add a torrent to the session and get a `TorrentHandle` in return.
                        TorrentHandle handle = session.AddTorrent(addParams);
                        AddToList(ti.Name, ti.TotalSize);

                        while (true)
                        {
                            // Get a `TorrentStatus` instance from the handle.
                            var status = handle.QueryStatus();

                            // If we are seeding, our job here is done.
                            if (status.IsSeeding)
                            {
                                break;
                            }

                            // Print our progress and sleep for a bit.
                            float downloaded = status.Progress * 100;
                            #region Progress Bar 
                            float progress = 0.0f;
                            if (downloaded > progress + 1 && downloaded < progress + 2)//Fix this garbage
                            {
                                progress = downloaded;
                                progressBar.Increment(1);
                            }
                            #endregion
                            Console.WriteLine("{0}% downloaded", downloaded);
                            EditList(downloaded.ToString());
                            Thread.Sleep(1000);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "AddTorrent -- " + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                mainListView.Items[0].SubItems[2].Text = downloaded + "%";
            }
        }

        private string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
        public void SaveTorrentResumeData() //SAVE BYTES TO REMEMBER PROGRESS IF TORRENT IS CLOSED
        {
            //handle.SaveResumeData();

        }

        #region Events
        private void addTorrentFileToolStrip_Click(object sender, EventArgs e)
        {
            pAddTorrent at = new pAddTorrent();
            at.StartPosition = FormStartPosition.CenterScreen;
            at.ShowDialog();

            maxUploadSpeed = at.GetMaxUploadSpeed();
            maxDownloadSpeed = at.GetMaxDownloadSpeed();
            torrentFilePath = at.GetAddTorrentFilePath();
            saveFilePath = at.GetSaveFilePath();

            if (!string.IsNullOrWhiteSpace(torrentFilePath))
            {
                new Thread(AddTorrent).Start();
            }
        }
        private void settingsToolStrip_Click(object sender, EventArgs e)
        {
            pSettings settings = new pSettings();
            settings.StartPosition = FormStartPosition.CenterScreen;
            settings.Show();
        }
        private void cMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        #endregion

    }
}
