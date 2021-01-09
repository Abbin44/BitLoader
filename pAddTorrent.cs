using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Ragnar;

namespace Torrent
{
    public partial class pAddTorrent : Form
    {
        public pAddTorrent()
        {
            InitializeComponent();
        }
        public string GetAddTorrentFilePath()
        {
            return addFilePathTxt.Text;
        }

        public string GetSaveFilePath()
        {
            return saveFilePathTxt.Text;
        }        
        
        public int GetMaxUploadSpeed()
        {
            return maxUploadSpeed;
        }
        public int GetMaxDownloadSpeed()
        {
            return maxDownloadSpeed;
        }

        #region Events
        private void pAddTorrent_Load(object sender, EventArgs e)
        {
            pSettings settings = new pSettings();
            addFilePathTxt.Text = settings.defaultSettings.defaultTorrentPath;
            saveFilePathTxt.Text = settings.defaultSettings.defaultSavePath;
            downloadSpeedSelector.Value = settings.defaultSettings.defaultMaxDownloadSpeed;
            uploadSpeedSelector.Value = settings.defaultSettings.defaultMaxUploadSpeed;
        }


        private void addFileBtn_Click(object sender, EventArgs e)
        {
            //Opens file browser
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Torrents (*.torrent)|*.torrent|All Files (*.*)|*.*"; //<--- Don't touch this piece of shit filter
            ofd.RestoreDirectory = true;

            DialogResult dr = ofd.ShowDialog();
            string torrentFile = string.Empty;
            if (dr == DialogResult.OK)
            {
                torrentFile = ofd.FileName;
            }
            addFilePathTxt.Text = torrentFile;
        }
        private void saveFolderBtn_Click(object sender, EventArgs e)
        {
            //Opens file browser
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            string saveFilePath = string.Empty;
            if (dr == DialogResult.OK)
            {
                saveFilePath = fbd.SelectedPath;
            }

            saveFilePathTxt.Text = saveFilePath;
        }

        int maxUploadSpeed;
        int maxDownloadSpeed;
        private void addTorBtn_Click(object sender, EventArgs e)
        {
            maxUploadSpeed = Convert.ToInt32(uploadSpeedSelector.Value * 1024);
            maxDownloadSpeed = Convert.ToInt32(downloadSpeedSelector.Value * 1024);
            this.Close();
        }
        #endregion
    }
}
