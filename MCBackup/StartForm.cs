/// MC Backup v1.0
/// Created by Cookiezzz
///
/// 
using System;
using System.IO;
using System.Windows.Forms;

namespace MCBackup
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            pctLogo.Image = MCBackup.Properties.Resources.McBackup2;

            //Check if this is the programs first run.
            String appDataMcB = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\McBackup";
            if (!Directory.Exists(appDataMcB))
            {
                MessageBox.Show("It looks like this is the first time you run McBackup. " + "\n" + "Please configure the settings first", "McBackup v0.1");
                Directory.CreateDirectory(appDataMcB);
                showSettings();
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            Form fB = new BackupForm();
            this.Hide();
            fB.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSettings();
        }
        private void showSettings()
        {
            Form fS = new SettingsForm();
            this.Hide();
            fS.ShowDialog();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Form fR = new RestoreForm();
            this.Hide();
            fR.ShowDialog();
        }
    }
}
