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
        string filePath = $@"C:\Users\" + "abbin" + @"\AppData\Local\Bitloader\settings.cfg"; //USE Environment.UserName for releases
        public static DefaultSettings defaultSettings { get; private set; }
        public pSettings()
        {
            if (defaultSettings == null)
                defaultSettings = new DefaultSettings();

            InitializeComponent();
            if (!File.Exists(filePath))//If it's the first time you start the program.
            {
                this.Text = "Please set default file paths";
                this.ShowDialog();
            }
            else
                ReadSettingsFile();
        }
        public void ReadSettingsFile()
        {
            List<string[]> settings = new List<string[]>();
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; ++i)
            {
                settings.Add(lines[i].Split('>'));
            }

            for (int i = 0; i < settings.Count; ++i)
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
                    case "UnlimitedDownSpeed":
                        defaultSettings.unlimitedDownloadSpeed = Convert.ToBoolean(settings[i][1]);
                        break;
                    case "UnlimitedUpSpeed":
                        defaultSettings.unlimitedUploadSpeed = Convert.ToBoolean(settings[i][1]);
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
                //Change this to use string builder.
                settings =  $@"TorrentPath>" + defaultTorrentPathTxt.Text + Environment.NewLine +
                            $@"SaveFolder>" + defaultSavePathTxt.Text + Environment.NewLine +
                            @"MaxDownSpeed>" + downloadSpeedSelector.Value.ToString() + Environment.NewLine +
                            @"MaxUpSpeed>" + uploadSpeedSelector.Value.ToString() + Environment.NewLine +
                            @"UnlimitedDownSpeed>" + unlimitedDownSpeedChk.Checked.ToString() + Environment.NewLine +
                            @"UnlimitedUpSpeed>" + unlimitedUpSpeedChk.Checked.ToString() + Environment.NewLine;
                File.WriteAllText(filePath, settings);
                ReadSettingsFile();
            }
            else
            {
                //Change this to use string builder.
                settings = $@"TorrentPath>" + defaultSettings.defaultTorrentPath + Environment.NewLine +
                            @"SaveFolder>" + defaultSettings.defaultSavePath + Environment.NewLine +
                            @"MaxDownSpeed>" + defaultSettings.defaultMaxDownloadSpeed.ToString() + Environment.NewLine +
                            @"MaxUpSpeed>" + defaultSettings.defaultMaxUploadSpeed.ToString() + Environment.NewLine +
                            @"UnlimitedDownSpeed>" + unlimitedDownSpeedChk.Checked.ToString() + Environment.NewLine +
                            @"UnlimitedUpSpeed>" + unlimitedUpSpeedChk.Checked.ToString() + Environment.NewLine;
                ReadSettingsFile();
                File.WriteAllText(filePath, settings);
            }
        }

        private string OpenFolderDialog()
        {
            //Opens file browser
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            string folderPath = string.Empty;
            if (dr == DialogResult.OK)
                folderPath = fbd.SelectedPath;

            return folderPath;
        }

        private void WriteFile(string filePath, string text)
        {

        }

        #region Events
        private void pSettings_Load(object sender, EventArgs e)
        {
            //Fill all boxes with the settings from the read file method
            if (this.Text == "Please set default file paths")
            {
                downloadSpeedSelector.Value = 500;
                uploadSpeedSelector.Value = 500;
            }
            else
            {
                downloadSpeedSelector.Value = defaultSettings.defaultMaxDownloadSpeed;
                uploadSpeedSelector.Value = defaultSettings.defaultMaxUploadSpeed;
            }

            defaultTorrentPathTxt.Text = defaultSettings.defaultTorrentPath;
            defaultSavePathTxt.Text = defaultSettings.defaultSavePath;
            unlimitedDownSpeedChk.Checked = defaultSettings.unlimitedDownloadSpeed;
            unlimitedUpSpeedChk.Checked = defaultSettings.unlimitedUploadSpeed;
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
                downloadSpeedSelector.Enabled = false;
            else
                downloadSpeedSelector.Enabled = true;
        }

        private void unlimitedUpSpeedChk_CheckedChanged(object sender, EventArgs e)
        {
            if (unlimitedUpSpeedChk.Checked == true)
                uploadSpeedSelector.Enabled = false;
            else
                uploadSpeedSelector.Enabled = true;
        }
        private void applyBtn_Click(object sender, EventArgs e)
        {
            if(this.Text == "Please set default file paths") //Only happens first time you start the program
            {
                if(!string.IsNullOrWhiteSpace(defaultTorrentPathTxt.Text) || !string.IsNullOrWhiteSpace(defaultSavePathTxt.Text))
                {
                    SetDefaultValues();
                    this.Close();
                    return;
                }
                else
                    MessageBox.Show("Please select valid file paths for both the save folder and torrent folder.", "Warning");

            }

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
