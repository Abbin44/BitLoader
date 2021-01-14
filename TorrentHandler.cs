using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Torrent
{
    class TorrentHandler
    {
        public TorrentHandler()
        {

        }

        string filePath = $@"C:\Users\" + "abbin" + @"\AppData\Local\Bitloader\active_torrents.tor"; //USE Environment.UserName for releases

        public void WriteActiveTorrents(List<string> torrents)
        {
            string[] activeTorrents = new string[torrents.Count];
            for (int i = 0; i < activeTorrents.Length; i++)
            {
                activeTorrents[i] = torrents[i];
            }
            File.WriteAllLines(filePath, activeTorrents);
        }

        public void ReadActiveTorrents()
        {
            DefaultSettings settings = new DefaultSettings();
            string[] torrentsToAdd = File.ReadAllLines(filePath);
            int uploadSpeed = settings.defaultMaxUploadSpeed;
            int downloadSpeed = settings.defaultMaxDownloadSpeed;
            string savePath = settings.defaultSavePath;
            string torrentPath;
            bool unlimitedDownloadSpeed = settings.unlimitedDownloadSpeed;
            bool unlimitedUpSpeed = settings.unlimitedUploadSpeed;

            for (int i = 0; i < torrentsToAdd.Length; i++)
            {
                torrentPath = torrentsToAdd[i];
                //Add to downloaderList as well
                TorrentDownloader downloader = new TorrentDownloader(uploadSpeed, downloadSpeed, savePath, torrentPath, unlimitedDownloadSpeed, unlimitedUpSpeed);
                cMainForm.mainForm.downloadList.Add(downloader);  //Add to the main list of downloading objects for indexing
                cMainForm.mainForm.activeTorrents.Add(downloader.torrentFilePath);

                downloader.torrentIndex = cMainForm.mainForm.torrentIndex;
                new Thread(downloader.AddTorrent).Start();
                cMainForm.mainForm.mainTimer.Start();
            }
        }
    }
}
