/// MC Backup v1.0
/// Created by Cookiezzz
///
/// 
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip;
using System.Collections.Generic;

namespace MCBackup
{
    public partial class RestoreForm : Form
    {
        string settingsFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\McBackup\\settings.xml";
        private string BackupDir = "";
        private string ServerDir = "";
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            //Find all java process' and kill the server one.
            System.Diagnostics.Process[] IEProcesses = System.Diagnostics.Process.GetProcessesByName("javaw");
            foreach (System.Diagnostics.Process CurrentProcess in IEProcesses)
            {
                if (CurrentProcess.MainWindowTitle.ToLower().Contains("server"))
                {
                    CurrentProcess.Kill();
                }
            }

            DirectoryInfo dir = new DirectoryInfo(BackupDir);
            FileInfo[] info = dir.GetFiles("*.*");




            List<FileInfo> list = new List<FileInfo>();
            List<string> Worldlist = new List<string>();
            foreach (FileInfo f in info)
            {
                    string[] parts = f.Name.Split('_');
                    string World = parts[0];
                    list.Add(f);
                    Worldlist.Add(World);
            }

            //Unzip the backup here
            FastZip fastZip = new FastZip();
            string fileFilter = null;
            // Will always overwrite if target filenames already exist
            fastZip.ExtractZip(Path.Combine(BackupDir, list[lstRestore.SelectedIndex].ToString()), Path.Combine(ServerDir, Worldlist[lstRestore.SelectedIndex].ToString()), fileFilter);

            MessageBox.Show("Restore completed! Restart your server", "McBackup v1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void RestoreForm_Load(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(settingsFile);
            XmlNodeList reminders = xml.SelectNodes("//setting");

            foreach (XmlNode reminder in reminders)
            {
                ServerDir = reminder.SelectSingleNode("ServerDir").InnerText;
                BackupDir = reminder.SelectSingleNode("BackupDir").InnerText;
            }

            //Example of a backup archive name: Tropical Vacation-11-06-2013_21-34-10.zip
            DirectoryInfo dir = new DirectoryInfo(BackupDir);
            FileInfo[] info = dir.GetFiles("*.*");
            foreach (FileInfo f in info)
            {
                string[] parts = f.Name.Split('_');
                string World = parts[0];
                string Date = parts[1];
                string Time = parts[2].Substring(0,8).Replace('-',':');
                lstRestore.Items.Add(World + "   :   " + Date + "   :   " + Time + Environment.NewLine);
            }
        }

        //form load
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(settingsFile))
            {
                //Load settings from XML
                XmlDocument xml = new XmlDocument();
                xml.Load(settingsFile);
                XmlNodeList reminders = xml.SelectNodes("//setting");

                foreach (XmlNode reminder in reminders)
                {
                    ServerDir = reminder.SelectSingleNode("ServerDir").InnerText;
                    BackupDir = reminder.SelectSingleNode("BackupDir").InnerText;
                }
            }
            else
            {
                MessageBox.Show("No settings file found, please go to settings and configure them please.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is StartForm)
                {
                    form.Show();
                    break;
                }
            }
        }
    }
}
