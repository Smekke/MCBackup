namespace MCBackup
{
    partial class BackupForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MCBackup = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.trcBInterval = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.cboWorld = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trcBInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // MCBackup
            // 
            this.MCBackup.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MCBackup.Icon = ((System.Drawing.Icon)(resources.GetObject("MCBackup.Icon")));
            this.MCBackup.Text = "MCBackup";
            this.MCBackup.Visible = true;
            this.MCBackup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(17, 125);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // trcBInterval
            // 
            this.trcBInterval.Location = new System.Drawing.Point(173, 71);
            this.trcBInterval.Maximum = 120;
            this.trcBInterval.Minimum = 5;
            this.trcBInterval.Name = "trcBInterval";
            this.trcBInterval.Size = new System.Drawing.Size(344, 45);
            this.trcBInterval.SmallChange = 5;
            this.trcBInterval.TabIndex = 24;
            this.trcBInterval.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcBInterval.Value = 5;
            this.trcBInterval.Scroll += new System.EventHandler(this.trcBInterval_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(12, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Backup inteveral:";
            // 
            // cboWorld
            // 
            this.cboWorld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWorld.FormattingEnabled = true;
            this.cboWorld.Location = new System.Drawing.Point(181, 32);
            this.cboWorld.Name = "cboWorld";
            this.cboWorld.Size = new System.Drawing.Size(164, 21);
            this.cboWorld.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(12, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Select a world:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(314, 103);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 33;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(17, 154);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 34;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 187);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.trcBInterval);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboWorld);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupForm";
            this.Text = "MC Backup - Backup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BackupForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trcBInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.NotifyIcon MCBackup;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar trcBInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboWorld;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStop;
    }
}

