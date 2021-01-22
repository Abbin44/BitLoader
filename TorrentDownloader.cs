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
        public string magnetLink = "";
        public bool unlimitedDownloadSpeed;
        public bool unlimitedUploadSpeed;
        public int uploadSpeed;
        public int downloadSpeed;
        public string currentStatus;
        public string formattedDownLimit;
        public TimeSpan elapsedTime = TimeSpan.Zero;
        public IEnumerable<PeerInfo> connectedPeers;
        public bool pause { get; set; }
        public float downloaded { get; set; }
        public int torrentIndex;
        public TorrentDownloader(int uploadSpeed, int downloadSpeed, string savePath, string torrentPath, string magnet, bool unlimitedDownSpeed, bool unlimitedUpSpeed)
        {
            maxUploadSpeed = uploadSpeed;
            maxDownloadSpeed = downloadSpeed;
            saveFilePath = savePath;
            torrentFilePath = torrentPath;
            magnetLink = magnet;
            unlimitedDownloadSpeed = unlimitedDownSpeed;
            unlimitedUploadSpeed = unlimitedUpSpeed;
            pause = false;
        }

        public void AddTorrentFromFile()
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
                        addParams.SavePath = saveFilePath + @"\" + ti.Name; //This is weird, check it out later

                        string resumeFile = Path.ChangeExtension(torrentFilePath, "resume");
                        if (File.Exists(resumeFile))
                            addParams.ResumeData = File.ReadAllBytes(resumeFile);// Loading the resume data will load all torrents settings
                        #endregion

                        // Add a torrent to the session and get a `TorrentHandle` in return. There is only one session that contains many handles.
                        handle = cMainForm.session.AddTorrent(addParams);
                        if(handle.NeedSaveResumeData() == true)
                           SaveResumeData();

                        if (unlimitedDownloadSpeed == true)
                            formattedDownLimit = "∞";
                        else
                            formattedDownLimit = maxDownloadSpeed.ToString();

                        cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.AddToMainList(ti.Name, ti.TotalSize, torrentIndex));
                       
                        while (true)
                        {
                            if (pause == true)
                                PauseHandle();
                            else if (handle.IsPaused == true && pause == false)
                                ResumeHandle();

                            // Get a `TorrentStatus` instance from the handle.
                            TorrentStatus status = handle.QueryStatus();
                            connectedPeers = handle.GetPeerInfo();

                            if (status.IsSeeding)
                                break;

                            elapsedTime = status.ActiveTime;
                            downloaded = status.Progress * 100;
                            uploadSpeed = status.UploadRate;
                            downloadSpeed = status.DownloadRate;
                            currentStatus = status.State.ToString();

                            if(connectedPeers.Count() > 0 && cMainForm.mainForm.mainToolStripBottom.SelectedIndex == 2)//2 is client tab
                                cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.AddToClientList(torrentIndex));

                            if(cMainForm.mainForm.mainToolStripBottom.SelectedIndex == 0)//0 is info tab
                                cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.UpdateInfoTabData());

                            cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.EditMainList(downloaded.ToString(), uploadSpeed, downloadSpeed, currentStatus, torrentIndex));
                            Thread.Sleep(100);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "AddTorrentFromFile -- " + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddTorrentFromMagnet()
        {
            try
            {
                if (!IsDisposed)
                {
                    using (cMainForm.session)
                    {
                        cMainForm.session.ListenOn(6881, 6889);

                        #region Torrent Parameters
                        AddTorrentParams addParams = new AddTorrentParams();

                        if (unlimitedDownloadSpeed == false)
                            addParams.DownloadLimit = maxDownloadSpeed * 1024;//Transform byte to kB

                        if (unlimitedUploadSpeed == false)
                            addParams.UploadLimit = maxUploadSpeed * 1024;

                        addParams.Url = magnetLink;
                        addParams.SavePath = saveFilePath; //This is weird, check it out later
                        #endregion

                        // Add a torrent to the session and get a `TorrentHandle` in return. There is only one session that contains many handles.
                        handle = cMainForm.session.AddTorrent(addParams);

                        if (unlimitedDownloadSpeed == true)
                            formattedDownLimit = "∞";
                        else
                            formattedDownLimit = maxDownloadSpeed.ToString();

                        cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.AddToMainList(ti.Name, ti.TotalSize, torrentIndex));

                        while (true)
                        {
                            if (pause == true)
                                PauseHandle();
                            else if (handle.IsPaused == true && pause == false)
                                ResumeHandle();

                            // Get a `TorrentStatus` instance from the handle.
                            TorrentStatus status = handle.QueryStatus();
                            IEnumerable<PeerInfo> connectedPeers = handle.GetPeerInfo();

                            if (status.IsSeeding) //If download is finished
                                break;

                            elapsedTime = status.ActiveTime;
                            downloaded = status.Progress * 100;
                            uploadSpeed = status.UploadRate;
                            downloadSpeed = status.DownloadRate;
                            currentStatus = status.State.ToString();                           

                            if (connectedPeers.Count() > 0 && cMainForm.mainForm.mainToolStripBottom.SelectedIndex == 2)//2 is client tab
                                cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.AddToClientList(torrentIndex));

                            if (cMainForm.mainForm.mainToolStripBottom.SelectedIndex == 0)//0 is info tab
                                cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.UpdateInfoTabData());

                            cMainForm.mainForm.RunOnUIThread(() => cMainForm.mainForm.EditMainList(downloaded.ToString(), uploadSpeed, downloadSpeed, currentStatus, torrentIndex));
                            Thread.Sleep(1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "AddTorrentFromMagnet -- " + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar()
        {
            float progress = 0.0f;
            if (downloaded > progress + 1 && downloaded < progress + 2)//Fix this garbage
            {
                progress = downloaded;
                cMainForm.mainForm.downloadedProgressBar.Increment(1);
            }
        }

        public void PauseHandle()
        {
            handle.Pause();
        }

        public void ResumeHandle()
        {
            handle.Resume();
        }

        public void SaveResumeData()
        {
            //WARNING 
            //If you pause every torrent individually instead of pausing the session,
            // every torrent will have its paused state saved in the resume data
            //Pause and unpause when saving resume data to not fuck up the saved data.

            cMainForm.session.Pause();
            handle.SaveResumeData();
            cMainForm.session.Resume();
        }
    }
}
