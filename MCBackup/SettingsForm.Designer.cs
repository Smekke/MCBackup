namespace MCBackup
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkAutoBU = new System.Windows.Forms.CheckBox();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExeLocation = new System.Windows.Forms.TextBox();
            this.btnMcBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBackupBrowse = new System.Windows.Forms.Button();
            this.txtBackupLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAutoBU
            // 
            this.chkAutoBU.AutoSize = true;
            this.chkAutoBU.Location = new System.Drawing.Point(415, 210);
            this.chkAutoBU.Name = "chkAutoBU";
            this.chkAutoBU.Size = new System.Drawing.Size(15, 14);
            this.chkAutoBU.TabIndex = 35;
            this.chkAutoBU.UseVisualStyleBackColor = true;
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(415, 168);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(15, 14);
            this.chkStartup.TabIndex = 33;
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Minecraft server directory:";
            // 
            // txtExeLocation
            // 
            this.txtExeLocation.Enabled = false;
            this.txtExeLocation.Location = new System.Drawing.Point(18, 50);
            this.txtExeLocation.Name = "txtExeLocation";
            this.txtExeLocation.Size = new System.Drawing.Size(425, 20);
            this.txtExeLocation.TabIndex = 38;
            // 
            // btnMcBrowse
            // 
            this.btnMcBrowse.Location = new System.Drawing.Point(449, 47);
            this.btnMcBrowse.Name = "btnMcBrowse";
            this.btnMcBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnMcBrowse.TabIndex = 39;
            this.btnMcBrowse.Text = "Browse";
            this.btnMcBrowse.UseVisualStyleBackColor = true;
            this.btnMcBrowse.Click += new System.EventHandler(this.btnMcBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Save backups to:";
            // 
            // btnBackupBrowse
            // 
            this.btnBackupBrowse.Location = new System.Drawing.Point(449, 120);
            this.btnBackupBrowse.Name = "btnBackupBrowse";
            this.btnBackupBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBackupBrowse.TabIndex = 42;
            this.btnBackupBrowse.Text = "Browse";
            this.btnBackupBrowse.UseVisualStyleBackColor = true;
            this.btnBackupBrowse.Click += new System.EventHandler(this.btnBackupBrowse_Click);
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Enabled = false;
            this.txtBackupLocation.Location = new System.Drawing.Point(18, 123);
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.Size = new System.Drawing.Size(425, 20);
            this.txtBackupLocation.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Start McBackup when your pc starts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Start creating backups when program starts:";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(449, 258);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 45;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 293);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBackupBrowse);
            this.Controls.Add(this.txtBackupLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMcBrowse);
            this.Controls.Add(this.txtExeLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAutoBU);
            this.Controls.Add(this.chkStartup);
            this.Name = "SettingsForm";
            this.Text = "McBackup - Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAutoBU;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExeLocation;
        private System.Windows.Forms.Button btnMcBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackupBrowse;
        private System.Windows.Forms.TextBox txtBackupLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}