/// MC Backup v1.0
/// Created by Cookiezzz
///
/// 
using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip;


namespace MCBackup
{
    public partial class BackupForm : Form
    {
        private string BackupDir = "";
        private string ServerDir = "";
        private string selectedWorld = "";
        string settingsFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\McBackup\\settings.xml";
        System.Timers.Timer backupTimer = new System.Timers.Timer();


        public BackupForm()
        {
            InitializeComponent();
        }

        //Display the interval time
        private void trcBInterval_Scroll(object sender, EventArgs e)
        {
            lblTime.Text = trcBInterval.Value + " Minutes";
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

                //Default value for tracker
                trcBInterval.Value = 5;
                lblTime.Text = trcBInterval.Value + " Minutes";
                //Read all folders(worlds) in the ServerDir and add them to the dropdownlist
                foreach (string f in Directory.GetDirectories(ServerDir))
                {
                    cboWorld.Items.Add(f.Replace(ServerDir + "\\", ""));
                }
                cboWorld.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No settings file found, please go to settings and configure them please.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (BackupDir != string.Empty && ServerDir != string.Empty)
            {
                btnStart.Enabled = false;
                selectedWorld = cboWorld.SelectedItem.ToString();
                //Minimize the program to tray
                this.WindowState = FormWindowState.Minimized;
                this.MCBackup.BalloonTipTitle = "McBackup v0.1";
                this.MCBackup.BalloonTipText = "Backup schedule started...";
                this.MCBackup.ShowBalloonTip(500);

                //Set and start the timer
                backupTimer.Interval = 1000 *60 * trcBInterval.Value;
                backupTimer.Elapsed += new ElapsedEventHandler(TimerEnd);
                backupTimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("You did forget to set a backup or Server directory, go to settings and select one please.", "McBackup v0.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerEnd(object source, ElapsedEventArgs e)
        {
            //Create the actual backup
                String now = DateTime.Now.ToString("G");
                this.MCBackup.BalloonTipTitle = "McBackup v0.1";
                this.MCBackup.BalloonTipText = "Creating live backup: " + selectedWorld + "-" + now;
                this.MCBackup.ShowBalloonTip(3000);


                if (Directory.Exists(System.Environment.GetEnvironmentVariable("TEMP") + "\\" + selectedWorld))
                {
                    Directory.Delete(System.Environment.GetEnvironmentVariable("TEMP") + "\\" + selectedWorld, true);
                }

                Copy(ServerDir + "\\" + selectedWorld, System.Environment.GetEnvironmentVariable("TEMP") + "\\" + selectedWorld);

                Thread.Sleep(5000);
                FastZip fZip = new FastZip();
                fZip.CreateZip(BackupDir + "\\" + selectedWorld + "_" + now.Replace('/', '-').Replace(" ", "_").Replace(':', '-') + ".zip", System.Environment.GetEnvironmentVariable("TEMP") + "\\" + selectedWorld, true, "");
                this.MCBackup.BalloonTipTitle = "McBackup v0.1";
                this.MCBackup.BalloonTipText = "Finished backup: " + selectedWorld + "-" + now;
                this.MCBackup.ShowBalloonTip(3000);
                Thread.Sleep(10000);
                Directory.Delete(System.Environment.GetEnvironmentVariable("TEMP") + "\\" + selectedWorld, true);
        }

        private void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourceDir, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(sourceDir, targetDir));
            //Copy all the files
            foreach (string newPath in Directory.GetFiles(sourceDir, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(sourceDir, targetDir),false);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Maximize our form
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        //When getting resized, minimize the form and hide it in the tray.
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
               this.MCBackup.Visible = true;
               this.MCBackup.BalloonTipText = "Minimized to tray.";
               this.MCBackup.ShowBalloonTip(500);
               this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                MCBackup.Visible = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            backupTimer.Enabled = false;
        }

        private void BackupForm_FormClosed(object sender, FormClosedEventArgs e)
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
