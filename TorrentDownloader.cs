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
    class TorrentDownloader : Form
    {
        cMainForm mainForm = new cMainForm();
        public int maxUploadSpeed;
        public int maxDownloadSpeed;
        public string saveFilePath = "";
        public string torrentFilePath = "";
        bool unlimitedDownloadSpeed;
        bool unlimitedUploadSpeed;

        public TorrentDownloader(int uploadSpeed, int downloadSpeed, string savePath, string torrentPath, bool unlimitedDownSpeed, bool unlimitedUpSpeed)
        {
            maxUploadSpeed = uploadSpeed;
            maxDownloadSpeed = downloadSpeed;
            saveFilePath = savePath;
            torrentFilePath = torrentPath;
            unlimitedDownloadSpeed = unlimitedDownSpeed;
            unlimitedUploadSpeed = unlimitedUpSpeed;
        }
        //public Session LibTorrentSession { get; private set; }

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

                        #region Torrent Parameters
                        AddTorrentParams addParams = new AddTorrentParams();

                        if (unlimitedDownloadSpeed == false)
                            addParams.DownloadLimit = maxDownloadSpeed * 1024;//Transform byte to kB

                        if (unlimitedUploadSpeed == false)
                            addParams.UploadLimit = maxUploadSpeed * 1024;

                        addParams.TorrentInfo = ti;
                        addParams.SavePath = saveFilePath;

                        #endregion

                        // Add a torrent to the session and get a `TorrentHandle` in return.
                        TorrentHandle handle = session.AddTorrent(addParams);
                        mainForm.AddToList(ti.Name, ti.TotalSize);

                        while (true)
                        {
                            // Get a `TorrentStatus` instance from the handle.
                            TorrentStatus status = handle.QueryStatus();

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
                                mainForm.downloadedProgressBar.Increment(1);
                            }
                            #endregion
                            Console.WriteLine("{0}% downloaded", downloaded);
                            mainForm.EditList(downloaded.ToString());
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
    }
}
