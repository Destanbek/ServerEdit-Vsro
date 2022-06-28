using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class datebaseyedekleme : Form
	{
		private IContainer components = null;

		private Button button1;

		public datebaseyedekleme()
		{
			InitializeComponent();
		}

		private void datebaseyedekleme_Load(object sender, EventArgs e)
		{
			if (Language.Default.language == "English")
            {
				this.Text = "Database Backup";
				button1.Text = "Back up";
				MessageBox.Show("If you continue the process, the backups in the backupServerEdit file will be deleted and backed up again!");
			}
			else
            {
				MessageBox.Show("İşleme devam ederseniz backupServerEdit dosyasındaki yedekler silinip yeniden yedeklenicektir!");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Acc))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					if (!Directory.Exists("c:\\backupServerEdit"))
					{
						Directory.CreateDirectory("c:\\backupServerEdit");
					}
					else
					{
						Directory.Delete("C:\\backupServerEdit", true);

						if (Language.Default.language == "English")
                        {
							MessageBox.Show("Files deleted!");
						}
						else
                        {
							MessageBox.Show("Dosyalar silindi!");
						}
						Directory.CreateDirectory("c:\\backupServerEdit");
						if (Language.Default.language == "English")
						{
							MessageBox.Show("Backup Begins..");
						}
						else
						{
							MessageBox.Show("Yedekleme Başlıyor..");
						}
					}
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "BACKUP DATABASE SRO_VT_ACCOUNT TO  DISK = N'C:\\backupServerEdit/SRO_VT_ACCOUNT.bak' WITH NOFORMAT, NOINIT,  NAME = N'SRO_VT_ACCOUNT-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
					sqlCommand.CommandText = "BACKUP DATABASE SRO_R_ACCOUNT TO  DISK = N'C:\\backupServerEdit/SRO_R_ACCOUNT.bak' WITH NOFORMAT, NOINIT,  NAME = N'SRO_R_ACCOUNT-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
					sqlCommand.ExecuteNonQuery();
					if (Language.Default.language == "English")
					{
						MessageBox.Show("Account Successfully Backed Up!");
					}
					else
					{
						MessageBox.Show("Account Başarı İle Yedeklendi!");
					}
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "BACKUP DATABASE SRO_VT_LOG TO  DISK = N'C:\\backupServerEdit/SRO_VT_LOG.bak' WITH NOFORMAT, NOINIT,  NAME = N'SRO_VT_LOG-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
					sqlCommand.CommandText = "BACKUP DATABASE SRO_R_LOG TO  DISK = N'C:\\backupServerEdit/SRO_R_LOG.bak' WITH NOFORMAT, NOINIT,  NAME = N'SRO_R_LOG-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
					sqlCommand.ExecuteNonQuery();
					if (Language.Default.language == "English")
					{
						MessageBox.Show("Log Backed Up Successfully!");
					}
					else
					{
						MessageBox.Show("Log Başarı İle Yedeklendi!");
					}
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "BACKUP DATABASE SRO_VT_SHARD TO  DISK = N'C:\\backupServerEdit/SRO_VT_SHARD.bak' WITH NOFORMAT, NOINIT,  NAME = N'SRO_VT_SHARD-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
					sqlCommand.CommandText = "BACKUP DATABASE SRO_R_SHARD TO  DISK = N'C:\\backupServerEdit/SRO_R_SHARD.bak' WITH NOFORMAT, NOINIT,  NAME = N'SRO_R_SHARD-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
					sqlCommand.ExecuteNonQuery();
					if (Language.Default.language == "English")
					{
						MessageBox.Show("Shard Successfully Backed Up! Backup is finished. Backups are in C:/backupServerEdit.");

					}
					else
					{
						MessageBox.Show("Shard Başarı İle Yedeklendi! Yedekleme bitmiştir.Yedekler C:/backupServerEdit dosyasındadır.");
					}
					sqlConnection.Close();
					Close();
				}
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datebaseyedekleme));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(77, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yedekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datebaseyedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(284, 82);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "datebaseyedekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Yedekleme";
            this.Load += new System.EventHandler(this.datebaseyedekleme_Load);
            this.ResumeLayout(false);

		}
	}
}
