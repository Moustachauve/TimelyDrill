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
using TimelyDrill.Model;

namespace TimelyDrill
{
	public partial class MainForm : Form
	{
		public BindingList<Backup> lstBackup = new BindingList<Backup>();
		public Timer tmrBackup = new Timer();

		public string backupOrigin;
		public string backupDestination;

		public MainForm()
		{
			InitializeComponent();

			lsbBackups.DataSource = lstBackup;
			tmrBackup.Tick += TmrBackup_Tick;

			UpdateOptions();
			UpdateBackup();
		}

		private void UpdateBackup()
		{
			lblBackupEmptyList.Visible = lstBackup.Count == 0;
		}

		private void UpdateOptions()
		{
			panFolders.Enabled = !tmrBackup.Enabled;
			btnStart.Enabled = !tmrBackup.Enabled;
			btnStop.Enabled = tmrBackup.Enabled;

			lblBackupTimer.Text = "Update each " + trkBackupTimer.Value;
			if (trkBackupTimer.Value > 1)
				lblBackupTimer.Text += " minutes";
			else
				lblBackupTimer.Text += " minute";
		}

		private void lsbBackups_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lsbBackups.SelectedItem != null)
			{
				MessageBox.Show(lsbBackups.SelectedItem.ToString());
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			tmrBackup.Interval = trkBackupTimer.Value * 60000;
			tmrBackup.Start();

			if (string.IsNullOrWhiteSpace(txtBackupFrom.Text))
			{
				MessageBox.Show("The \"Backup from\" path cannot be empty", "Path is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Directory.Exists(txtBackupFrom.Text))
			{
				MessageBox.Show("The \"Backup from\" path must already exist", "Directory does not exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtBackupTo.Text))
			{
				MessageBox.Show("The \"Backup to\" path cannot be empty", "Path is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Directory.Exists(txtBackupTo.Text))
			{
				DialogResult result = MessageBox.Show("The \"Backup to\" path does not exist. Do you want to create it?", "Directory does not exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.No)
					return;

				try
				{
					Directory.CreateDirectory(txtBackupTo.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occured while trying to create the directory \"" + txtBackupTo.Text + "\": " + Environment.NewLine
						+ ex.ToString() + Environment.NewLine
						+ ex.Message, "An error occured",
						MessageBoxButtons.OK, MessageBoxIcon.Error);

					return;
				}
			}

			backupOrigin = txtBackupFrom.Text;
			backupDestination = txtBackupTo.Text;

			CreateBackup();
			UpdateOptions();
			UpdateBackup();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			tmrBackup.Stop();

			backupOrigin = string.Empty;
			backupDestination = string.Empty;

			UpdateOptions();
		}

		private void trkBackupTimer_Scroll(object sender, EventArgs e)
		{
			UpdateOptions();
		}

		private void TmrBackup_Tick(object sender, EventArgs e)
		{
			CreateBackup();
			UpdateBackup();
		}

		private void CreateBackup()
		{
			try
			{
				Backup backup = new Backup();
				backup.DestinationPath = backupDestination;
				backup.Time = DateTime.Now;

				string saveFolder = Path.Combine(backup.DestinationPath, backup.ToString());

				lblStatus.Text = "Backup in progress...";
				lblStatus.Visible = true;

				new Microsoft.VisualBasic.Devices.Computer().FileSystem.CopyDirectory(backupOrigin, saveFolder);

				lstBackup.Add(backup);
			}
			catch (Exception ex)
			{
				tmrBackup.Stop();

				MessageBox.Show("An error occured while trying to save a backup:" + Environment.NewLine
					+ ex.GetType().Name + Environment.NewLine
					+ ex.Message, "An error occured",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				UpdateOptions();
				UpdateBackup();
			}
			finally
			{
				lblStatus.Visible = false;
			}
		}


		private void btnBackupFrom_Click(object sender, EventArgs e)
		{
			fbdBackupOrigin.ShowDialog();
			txtBackupFrom.Text = fbdBackupOrigin.SelectedPath;
		}

		private void btnBackupTo_Click(object sender, EventArgs e)
		{
			fbdBackupDestination.ShowDialog();
			txtBackupTo.Text = fbdBackupDestination.SelectedPath;
		}
	}
}
