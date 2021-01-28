using System.Collections.Generic;
using System.IO;
using System.Threading;

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
            string[] torrentsToAdd = File.ReadAllLines(filePath);
            int uploadSpeed = SettingsForm.defaultSettings.defaultMaxUploadSpeed;
            int downloadSpeed = SettingsForm.defaultSettings.defaultMaxDownloadSpeed;
            string savePath = SettingsForm.defaultSettings.defaultSavePath;
            string torrentPath = string.Empty;
            string magnetLink = string.Empty;
            bool unlimitedDownloadSpeed = SettingsForm.defaultSettings.unlimitedDownloadSpeed;
            bool unlimitedUpSpeed = SettingsForm.defaultSettings.unlimitedUploadSpeed;

            for (int i = 0; i < torrentsToAdd.Length; i++)
            {
                if (torrentsToAdd[i].StartsWith("magnet:"))
                    magnetLink = torrentsToAdd[i];
                else
                    torrentPath = torrentsToAdd[i];

                TorrentDownloader downloader = new TorrentDownloader(uploadSpeed, downloadSpeed, savePath, torrentPath, magnetLink, unlimitedDownloadSpeed, unlimitedUpSpeed);
                cMainForm.mainForm.downloadList.Add(downloader);  //Add to the main list of downloading objects for indexing
                downloader.torrentIndex = cMainForm.mainForm.torrentIndex;

                if (!string.IsNullOrEmpty(torrentPath))
                {
                    cMainForm.mainForm.activeTorrents.Add(downloader.torrentFilePath);
                    new Thread(downloader.AddTorrentFromFile).Start();
                }
                else if (!string.IsNullOrEmpty(magnetLink))
                {
                    cMainForm.mainForm.activeTorrents.Add(downloader.magnetLink);
                    new Thread(downloader.AddTorrentFromMagnet).Start();
                }
                else
                    return;

                if (File.Exists(filePath))
                    File.Delete(filePath);

                cMainForm.mainForm.mainTimer.Start();
            }
        }
    }
}
