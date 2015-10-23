namespace TimelyDrill
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grpOptions = new System.Windows.Forms.GroupBox();
			this.panFolders = new System.Windows.Forms.Panel();
			this.lblBackupTimer = new System.Windows.Forms.Label();
			this.trkBackupTimer = new System.Windows.Forms.TrackBar();
			this.lblBackupFrom = new System.Windows.Forms.Label();
			this.txtBackupFrom = new System.Windows.Forms.TextBox();
			this.btnBackupFrom = new System.Windows.Forms.Button();
			this.btnBackupTo = new System.Windows.Forms.Button();
			this.lblBackupTo = new System.Windows.Forms.Label();
			this.txtBackupTo = new System.Windows.Forms.TextBox();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.grpBackup = new System.Windows.Forms.GroupBox();
			this.lblBackupEmptyList = new System.Windows.Forms.Label();
			this.lsbBackups = new System.Windows.Forms.ListBox();
			this.fbdBackupDestination = new System.Windows.Forms.FolderBrowserDialog();
			this.fbdBackupOrigin = new System.Windows.Forms.FolderBrowserDialog();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.grpOptions.SuspendLayout();
			this.panFolders.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkBackupTimer)).BeginInit();
			this.grpBackup.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 271);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(462, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(52, 17);
			this.lblStatus.Text = "_-_-_-_-_";
			this.lblStatus.Visible = false;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.grpOptions);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(7, 7, 1, 7);
			this.splitContainer1.Panel1MinSize = 180;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.grpBackup);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(1, 7, 7, 7);
			this.splitContainer1.Panel2MinSize = 140;
			this.splitContainer1.Size = new System.Drawing.Size(462, 271);
			this.splitContainer1.SplitterDistance = 244;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			// 
			// grpOptions
			// 
			this.grpOptions.Controls.Add(this.panFolders);
			this.grpOptions.Controls.Add(this.btnStop);
			this.grpOptions.Controls.Add(this.btnStart);
			this.grpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpOptions.Location = new System.Drawing.Point(7, 7);
			this.grpOptions.Name = "grpOptions";
			this.grpOptions.Padding = new System.Windows.Forms.Padding(5);
			this.grpOptions.Size = new System.Drawing.Size(236, 257);
			this.grpOptions.TabIndex = 0;
			this.grpOptions.TabStop = false;
			this.grpOptions.Text = "Options";
			// 
			// panFolders
			// 
			this.panFolders.Controls.Add(this.lblBackupTimer);
			this.panFolders.Controls.Add(this.trkBackupTimer);
			this.panFolders.Controls.Add(this.lblBackupFrom);
			this.panFolders.Controls.Add(this.txtBackupFrom);
			this.panFolders.Controls.Add(this.btnBackupFrom);
			this.panFolders.Controls.Add(this.btnBackupTo);
			this.panFolders.Controls.Add(this.lblBackupTo);
			this.panFolders.Controls.Add(this.txtBackupTo);
			this.panFolders.Dock = System.Windows.Forms.DockStyle.Top;
			this.panFolders.Location = new System.Drawing.Point(5, 18);
			this.panFolders.Name = "panFolders";
			this.panFolders.Size = new System.Drawing.Size(226, 163);
			this.panFolders.TabIndex = 2;
			// 
			// lblBackupTimer
			// 
			this.lblBackupTimer.AutoSize = true;
			this.lblBackupTimer.Location = new System.Drawing.Point(3, 99);
			this.lblBackupTimer.Name = "lblBackupTimer";
			this.lblBackupTimer.Size = new System.Drawing.Size(118, 13);
			this.lblBackupTimer.TabIndex = 7;
			this.lblBackupTimer.Text = "Backup each x minutes";
			// 
			// trkBackupTimer
			// 
			this.trkBackupTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trkBackupTimer.Location = new System.Drawing.Point(6, 115);
			this.trkBackupTimer.Maximum = 30;
			this.trkBackupTimer.Minimum = 1;
			this.trkBackupTimer.Name = "trkBackupTimer";
			this.trkBackupTimer.Size = new System.Drawing.Size(211, 45);
			this.trkBackupTimer.TabIndex = 6;
			this.trkBackupTimer.TickFrequency = 5;
			this.trkBackupTimer.Value = 5;
			this.trkBackupTimer.Scroll += new System.EventHandler(this.trkBackupTimer_Scroll);
			// 
			// lblBackupFrom
			// 
			this.lblBackupFrom.AutoSize = true;
			this.lblBackupFrom.Location = new System.Drawing.Point(3, 3);
			this.lblBackupFrom.Name = "lblBackupFrom";
			this.lblBackupFrom.Size = new System.Drawing.Size(67, 13);
			this.lblBackupFrom.TabIndex = 0;
			this.lblBackupFrom.Text = "Backup from";
			// 
			// txtBackupFrom
			// 
			this.txtBackupFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBackupFrom.Location = new System.Drawing.Point(6, 19);
			this.txtBackupFrom.Name = "txtBackupFrom";
			this.txtBackupFrom.Size = new System.Drawing.Size(179, 20);
			this.txtBackupFrom.TabIndex = 1;
			// 
			// btnBackupFrom
			// 
			this.btnBackupFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBackupFrom.Location = new System.Drawing.Point(191, 18);
			this.btnBackupFrom.Name = "btnBackupFrom";
			this.btnBackupFrom.Size = new System.Drawing.Size(32, 22);
			this.btnBackupFrom.TabIndex = 2;
			this.btnBackupFrom.Text = "...";
			this.btnBackupFrom.UseVisualStyleBackColor = true;
			this.btnBackupFrom.Click += new System.EventHandler(this.btnBackupFrom_Click);
			// 
			// btnBackupTo
			// 
			this.btnBackupTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBackupTo.Location = new System.Drawing.Point(191, 66);
			this.btnBackupTo.Name = "btnBackupTo";
			this.btnBackupTo.Size = new System.Drawing.Size(32, 22);
			this.btnBackupTo.TabIndex = 5;
			this.btnBackupTo.Text = "...";
			this.btnBackupTo.UseVisualStyleBackColor = true;
			this.btnBackupTo.Click += new System.EventHandler(this.btnBackupTo_Click);
			// 
			// lblBackupTo
			// 
			this.lblBackupTo.AutoSize = true;
			this.lblBackupTo.Location = new System.Drawing.Point(3, 51);
			this.lblBackupTo.Name = "lblBackupTo";
			this.lblBackupTo.Size = new System.Drawing.Size(56, 13);
			this.lblBackupTo.TabIndex = 3;
			this.lblBackupTo.Text = "Backup to";
			// 
			// txtBackupTo
			// 
			this.txtBackupTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBackupTo.Location = new System.Drawing.Point(6, 67);
			this.txtBackupTo.Name = "txtBackupTo";
			this.txtBackupTo.Size = new System.Drawing.Size(179, 20);
			this.txtBackupTo.TabIndex = 4;
			// 
			// btnStop
			// 
			this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStop.Location = new System.Drawing.Point(11, 226);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 7;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStart.Location = new System.Drawing.Point(152, 226);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(76, 23);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// grpBackup
			// 
			this.grpBackup.Controls.Add(this.lblBackupEmptyList);
			this.grpBackup.Controls.Add(this.lsbBackups);
			this.grpBackup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpBackup.Location = new System.Drawing.Point(1, 7);
			this.grpBackup.Name = "grpBackup";
			this.grpBackup.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.grpBackup.Size = new System.Drawing.Size(205, 257);
			this.grpBackup.TabIndex = 0;
			this.grpBackup.TabStop = false;
			this.grpBackup.Text = "Backups";
			// 
			// lblBackupEmptyList
			// 
			this.lblBackupEmptyList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblBackupEmptyList.ForeColor = System.Drawing.SystemColors.GrayText;
			this.lblBackupEmptyList.Location = new System.Drawing.Point(10, 18);
			this.lblBackupEmptyList.Name = "lblBackupEmptyList";
			this.lblBackupEmptyList.Size = new System.Drawing.Size(185, 234);
			this.lblBackupEmptyList.TabIndex = 1;
			this.lblBackupEmptyList.Text = "There is currently no backup";
			this.lblBackupEmptyList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lsbBackups
			// 
			this.lsbBackups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbBackups.FormattingEnabled = true;
			this.lsbBackups.IntegralHeight = false;
			this.lsbBackups.Location = new System.Drawing.Point(10, 18);
			this.lsbBackups.Margin = new System.Windows.Forms.Padding(5);
			this.lsbBackups.Name = "lsbBackups";
			this.lsbBackups.Size = new System.Drawing.Size(185, 234);
			this.lsbBackups.Sorted = true;
			this.lsbBackups.TabIndex = 0;
			this.lsbBackups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbBackups_MouseDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 293);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(355, 270);
			this.Name = "MainForm";
			this.Text = "TimelyDrill";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.grpOptions.ResumeLayout(false);
			this.panFolders.ResumeLayout(false);
			this.panFolders.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkBackupTimer)).EndInit();
			this.grpBackup.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox grpOptions;
		private System.Windows.Forms.GroupBox grpBackup;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnBackupTo;
		private System.Windows.Forms.TextBox txtBackupTo;
		private System.Windows.Forms.Label lblBackupTo;
		private System.Windows.Forms.Button btnBackupFrom;
		private System.Windows.Forms.TextBox txtBackupFrom;
		private System.Windows.Forms.Label lblBackupFrom;
		private System.Windows.Forms.ListBox lsbBackups;
		private System.Windows.Forms.Label lblBackupEmptyList;
		private System.Windows.Forms.Panel panFolders;
		private System.Windows.Forms.TrackBar trkBackupTimer;
		private System.Windows.Forms.Label lblBackupTimer;
		private System.Windows.Forms.FolderBrowserDialog fbdBackupDestination;
		private System.Windows.Forms.FolderBrowserDialog fbdBackupOrigin;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
	}
}

