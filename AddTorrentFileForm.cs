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
    public partial class AddTorrentFileForm : Form
    {
        public AddTorrentFileForm()
        {
            InitializeComponent();
        }
        public string GetAddTorrentFilePath()
        {
            return addTorrentFilePathTxt.Text;
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

        public bool GetUnlimitedDownloadSpeed()
        {
            return unlimitedDownloadSpeed;
        }
        public bool GetUnlimitedUploadSpeed()
        {
            return unlimitedUploadSpeed;
        }

        int maxUploadSpeed;
        int maxDownloadSpeed;
        bool unlimitedDownloadSpeed;
        bool unlimitedUploadSpeed;

        #region Events
        private void pAddTorrent_Load(object sender, EventArgs e)
        {
            addTorrentFilePathTxt.Text = SettingsForm.defaultSettings.defaultTorrentPath;
            saveFilePathTxt.Text = SettingsForm.defaultSettings.defaultSavePath;
            unlimitedDownloadSpeed = SettingsForm.defaultSettings.unlimitedDownloadSpeed;
            unlimitedUploadSpeed = SettingsForm.defaultSettings.unlimitedUploadSpeed;


            if (SettingsForm.defaultSettings.unlimitedDownloadSpeed == true)
            {
                downloadSpeedSelector.Enabled = false;
                unlimitedDownSpeedBox.Checked = true;
                unlimitedDownSpeedBox.Visible = true;
            }
            else
                downloadSpeedSelector.Value = SettingsForm.defaultSettings.defaultMaxDownloadSpeed;

            if (SettingsForm.defaultSettings.unlimitedUploadSpeed == true)
            {
                uploadSpeedSelector.Enabled = false;
                unlimitedUpSpeedBox.Checked = true;
                unlimitedUpSpeedBox.Visible = true;
            }
            else
                uploadSpeedSelector.Value = SettingsForm.defaultSettings.defaultMaxUploadSpeed;
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
            addTorrentFilePathTxt.Text = torrentFile;
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

        private void unlimitedDownSpeedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (unlimitedDownSpeedBox.Checked == true)
                downloadSpeedSelector.Enabled = false;
            else
                downloadSpeedSelector.Enabled = true;
        }

        private void unlimitedUpSpeedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (unlimitedUpSpeedBox.Checked == true)
                uploadSpeedSelector.Enabled = false;
            else
                uploadSpeedSelector.Enabled = true;
        }

        private void addTorrentBtn_Click(object sender, EventArgs e)
        {
            maxUploadSpeed = Convert.ToInt32(uploadSpeedSelector.Value);
            maxDownloadSpeed = Convert.ToInt32(downloadSpeedSelector.Value);
            unlimitedDownloadSpeed = unlimitedDownSpeedBox.Checked;
            unlimitedUploadSpeed = unlimitedUpSpeedBox.Checked;
            this.Close();
        }
        #endregion

    }
}
