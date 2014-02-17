/// MC Backup v1.0
/// Created by Cookiezzz
///
/// 
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

namespace MCBackup
{
    public partial class SettingsForm : Form
    {
        RegistryKey rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        string settingsFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +  "\\McBackup\\settings.xml";
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (rkApp.GetValue("McBackup") == null)
            {
                // The value doesn't exist, the application is not set to run at startup
                chkStartup.Checked = false;
            }
            else
            {
                // The value exists, the application is set to run at startup
                chkStartup.Checked = true;
            }
            //Load the settings and display them
            if (File.Exists(settingsFile)) {
                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(settingsFile);

                    XmlNodeList reminders = xml.SelectNodes("//setting");

                    foreach (XmlNode reminder in reminders)
                    {
                        txtExeLocation.Text = reminder.SelectSingleNode("ServerDir").InnerText;
                        txtBackupLocation.Text = reminder.SelectSingleNode("BackupDir").InnerText;
                        if (reminder.SelectSingleNode("AutoCreate").InnerText == "1")
                        {
                            chkAutoBU.Checked = true;
                        }
                        else
                        {
                            chkAutoBU.Checked = false;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartup.Checked)
            {
                //Add the value in the registry so that the application runs at startup
                rkApp.SetValue("McBackup", Application.ExecutablePath.ToString());
            }
            else
            {
                //Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("McBackup", false);
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnMcBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtExeLocation.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBackupLocation.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (txtBackupLocation.Text == string.Empty || txtExeLocation.Text == string.Empty)
            {
                MessageBox.Show("You have to select a directory for both settings!", "McBackup v0.1");
            }
            else
            {
                XmlDocument xml = new XmlDocument();

                if (!File.Exists(settingsFile))
                {
                    //Create a new XML document if there is none.
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml("<?xml version=\"1.0\"?><settings></settings>");

                    XmlTextWriter writer = new XmlTextWriter(settingsFile, null);
                    writer.Formatting = Formatting.Indented;
                    doc.Save(writer);
                    writer.Close();
                }

                //Load the XML document and write the settings to it.
                xml.Load(settingsFile);

                //Clear all current settings
                XmlNodeList nodes = xml.SelectNodes("//settings");
                foreach (XmlElement element in nodes)
                {
                    element.RemoveAll();
                }

                //Create a new catalog
                XmlElement newcatalogentry = xml.CreateElement("setting");

                //First settings element
                XmlElement firstelement = xml.CreateElement("ServerDir");
                firstelement.InnerText = txtExeLocation.Text;
                newcatalogentry.AppendChild(firstelement);

                //Second settings element
                XmlElement secondelement = xml.CreateElement("BackupDir");
                secondelement.InnerText = txtBackupLocation.Text;
                newcatalogentry.AppendChild(secondelement);

                //Third settings element
                XmlElement thirdelement = xml.CreateElement("AutoCreate");
                thirdelement.InnerText = chkAutoBU.Checked == true ? Convert.ToString(1) : Convert.ToString(0);
                newcatalogentry.AppendChild(thirdelement);

                //Save the file
                xml.DocumentElement.InsertAfter(newcatalogentry, xml.DocumentElement.LastChild);
                xml.Save(settingsFile);

                //Close the settings page
                this.Close();
            }
        }
    }
}
