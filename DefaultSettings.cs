namespace Torrent
{
    public class DefaultSettings
    {
        public string defaultTorrentPath { get; set; }
        public string defaultSavePath { get; set; }
        public int defaultMaxDownloadSpeed { get; set; }
        public int defaultMaxUploadSpeed { get; set; }
        public bool unlimitedDownloadSpeed { get; set; }
        public bool unlimitedUploadSpeed { get; set; }

    }
}
