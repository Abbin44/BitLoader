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

    public class TorrentDownloader : Form
    {
        public TorrentInfo ti;
        public TorrentHandle handle;
        public int maxUploadSpeed;
        public int maxDownloadSpeed;
        public string saveFilePath = "";
        public string torrentFilePath = "";
        public bool unlimitedDownloadSpeed;
        public bool unlimitedUploadSpeed;
        public int uploadSpeed;
        public int downloadSpeed;
        public bool pause { get; set; }
        public float downloaded { get; set; }
        public int torrentIndex { get; set; }
        public TorrentDownloader(int uploadSpeed, int downloadSpeed, string savePath, string torrentPath, bool unlimitedDownSpeed, bool unlimitedUpSpeed)
        {
            maxUploadSpeed = uploadSpeed;
            maxDownloadSpeed = downloadSpeed;
            saveFilePath = savePath;
            torrentFilePath = torrentPath;
            unlimitedDownloadSpeed = unlimitedDownSpeed;
            unlimitedUploadSpeed = unlimitedUpSpeed;
        }

        public void AddTorrent()
        {
            try
            {
                if (!IsDisposed)
                {
                    byte[] bytes = File.ReadAllBytes(torrentFilePath);
                    ti = new TorrentInfo(bytes);
                    using (cMainForm.session)
                    {
                        cMainForm.session.ListenOn(6881, 6889);

                        #region Torrent Parameters
                        AddTorrentParams addParams = new AddTorrentParams();

                        if (unlimitedDownloadSpeed == false)
                            addParams.DownloadLimit = maxDownloadSpeed * 1024;//Transform byte to kB

                        if (unlimitedUploadSpeed == false)
                            addParams.UploadLimit = maxUploadSpeed * 1024;

                        addParams.TorrentInfo = ti;
                        addParams.SavePath = saveFilePath + @"\" + ti.Name;

                        string resumeFile = Path.ChangeExtension(torrentFilePath, "resume");
                        if (File.Exists(resumeFile))
                            addParams.ResumeData = File.ReadAllBytes(resumeFile);// Loading the resume data will load all torrents settings
                        #endregion

                        // Add a torrent to the session and get a `TorrentHandle` in return. There is only one session that contains many handles.
                        handle = cMainForm.session.AddTorrent(addParams);
                        if(handle.NeedSaveResumeData() == true)
                           SaveResumeData();

                        cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.AddToMainList(ti.Name, ti.TotalSize, torrentIndex));

                        if (pause == true)
                            handle.Pause();
                        else if (handle.IsPaused == true && pause == false)
                            handle.Resume();

                        while (true)
                        {
                            // Get a `TorrentStatus` instance from the handle.
                            TorrentStatus status = handle.QueryStatus();

                            // If we are seeding, our job here is done.
                            if (status.IsSeeding)
                                break;

                            // Print our progress and sleep for a bit.
                            downloaded = status.Progress * 100;
                            uploadSpeed = status.UploadRate;
                            downloadSpeed = status.DownloadRate;

                            #region Progress Bar 
                            float progress = 0.0f;
                            if (downloaded > progress + 1 && downloaded < progress + 2)//Fix this garbage
                            {
                                progress = downloaded;
                                cMainForm.mainForm.downloadedProgressBar.Increment(1);
                            }
                            #endregion

                            //Console.WriteLine("{0}% downloaded", downloaded);
                            cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.EditMainList(downloaded.ToString(), uploadSpeed, downloadSpeed, torrentIndex));
                            Thread.Sleep(100);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "AddTorrent -- " + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveResumeData()
        {
            //WARNING 
            //If you pause every torrent individually instead of pausing the session,
            // every torrent will have its paused state saved in the resume data
            //Pause and unpause when saving resume data to not fuck up the saved data.

            cMainForm.session.Pause();
            handle.SaveResumeData();
            cMainForm.session.Pause();
        }
    }
}
