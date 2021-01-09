using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torrent
{
    public partial class pSettings : Form
    {
        string filePath = @"C:\Users\" + "abbin" + @"\AppData\Local\Bitloader\settings.cfg"; //USE Environment.UserName for releases
        public DefaultSettings defaultSettings = new DefaultSettings();
        public pSettings()
        {
            InitializeComponent();
            if (!File.Exists(filePath))
                SetDefaultValues();
            else
            {
                ReadSettingsFile();
            }
        }
        public void ReadSettingsFile()
        {
            List<string[]> settings = new List<string[]>();
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                settings.Add(lines[i].Split('>'));
            }

            for (int i = 0; i < settings.Count; i++)
            {
                switch (settings[i][0])//Add new settings here (3 places total)
                {
                    case "TorrentPath":
                        defaultSettings.defaultTorrentPath = settings[i][1];
                        break;
                    case "SaveFolder":
                        defaultSettings.defaultSavePath = settings[i][1];
                        break;
                    case "MaxDownSpeed":
                        defaultSettings.defaultMaxDownloadSpeed = Convert.ToInt32(settings[i][1]);
                        break;
                    case "MaxUpSpeed":
                        defaultSettings.defaultMaxUploadSpeed = Convert.ToInt32(settings[i][1]);
                        break;
                    default:
                        Console.WriteLine("Error loading settings, something is wrong...");
                        break;
                }
            }
        }

        public void SetDefaultValues()
        {
            //Add new settings here (3 places total)
            // > Is used as a splitter.
            string settings;
            if (!File.Exists(filePath))
            {
                settings =  @"TorrentPath>C:\Users" + Environment.UserName + @"\Downloads" + Environment.NewLine +
                            @"SaveFolder>C:\Users" + Environment.UserName + @"\Downloads" + Environment.NewLine +
                            @"MaxDownSpeed>" + downloadSpeedSelector.Value.ToString() + Environment.NewLine +
                            @"MaxUpSpeed>" + uploadSpeedSelector.Value.ToString() + Environment.NewLine;
            }
            else
            {
                settings = $@"TorrentPath>" + defaultSettings.defaultTorrentPath + Environment.NewLine +
                            @"SaveFolder>" + defaultSettings.defaultSavePath + Environment.NewLine +
                            @"MaxDownSpeed>" + defaultSettings.defaultMaxDownloadSpeed.ToString() + Environment.NewLine +
                            @"MaxUpSpeed>" + defaultSettings.defaultMaxUploadSpeed.ToString() + Environment.NewLine;
            }

            ReadSettingsFile();
            File.WriteAllText(filePath, settings);
        }

        private string OpenFolderDialog()
        {
            //Opens file browser
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            string folderPath = string.Empty;
            if (dr == DialogResult.OK)
            {
                folderPath = fbd.SelectedPath;
            }

            return folderPath;
        }

        #region Events
        private void pSettings_Load(object sender, EventArgs e)
        {
            defaultTorrentPathTxt.Text = defaultSettings.defaultTorrentPath;
            defaultSavePathTxt.Text = defaultSettings.defaultSavePath;
            downloadSpeedSelector.Value = defaultSettings.defaultMaxDownloadSpeed;
            uploadSpeedSelector.Value = defaultSettings.defaultMaxUploadSpeed;
            //Fill all boxes with the settings from the read file method
        }
        private void addTorFolderBtn_Click(object sender, EventArgs e)
        {
            string newAddTorrentFolder = OpenFolderDialog();
            defaultSettings.defaultTorrentPath = newAddTorrentFolder;
            defaultTorrentPathTxt.Text = newAddTorrentFolder;
        }
        private void addSaveFolderPathBtn_Click(object sender, EventArgs e)
        {
            string newSaveFolder = OpenFolderDialog();
            defaultSettings.defaultSavePath = newSaveFolder;
            defaultSavePathTxt.Text = newSaveFolder;
        }
        private void downloadSpeedSelector_ValueChanged(object sender, EventArgs e)
        {
            int newDownloadSpeed = Convert.ToInt32(downloadSpeedSelector.Value);
            defaultSettings.defaultMaxDownloadSpeed = newDownloadSpeed;
        }
        private void uploadSpeedSelector_ValueChanged(object sender, EventArgs e)
        {
            int newUploadSpeed = Convert.ToInt32(uploadSpeedSelector.Value);
            defaultSettings.defaultMaxUploadSpeed = newUploadSpeed;
        }
        private void unlimitedDownSpeedChk_CheckedChanged(object sender, EventArgs e)
        {
            if (unlimitedDownSpeedChk.Checked == true)
            {
                defaultSettings.defaultMaxDownloadSpeed = 1888; //1888 is representative of unlimited. However, everything above 1000 will be unlimited
                downloadSpeedSelector.Enabled = false;
            }
            else
                downloadSpeedSelector.Enabled = true;
        }

        private void unlimitedUpSpeedChk_CheckedChanged(object sender, EventArgs e)
        {
            if (unlimitedUpSpeedChk.Checked == true)
            {
                defaultSettings.defaultMaxUploadSpeed = 1888;
                uploadSpeedSelector.Enabled = false;
            }
            else
                uploadSpeedSelector.Enabled = true;
        }
        private void applyBtn_Click(object sender, EventArgs e)
        {
            //Make sure the value 1888 is not stuck after the user has unticked the box but not edited the speed selector
            if (unlimitedDownSpeedChk.Checked == false)
                defaultSettings.defaultMaxDownloadSpeed = Convert.ToInt32(downloadSpeedSelector.Value);

            if (unlimitedUpSpeedChk.Checked == false)
                defaultSettings.defaultMaxUploadSpeed = Convert.ToInt32(uploadSpeedSelector.Value);

            SetDefaultValues();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
