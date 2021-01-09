using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torrent
{
    public class DefaultSettings
    {
        public string defaultTorrentPath { get; set; }
        public string defaultSavePath { get; set; }
        public int defaultMaxDownloadSpeed { get; set; }
        public int defaultMaxUploadSpeed { get; set; }
    }
}
