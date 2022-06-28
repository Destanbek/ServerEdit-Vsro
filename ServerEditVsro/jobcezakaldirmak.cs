using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class jobcezakaldirmak : Form
	{
		private IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;

		public jobcezakaldirmak()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "\r\nALTER procedure [dbo].[_AddTimedJob]\r\n@CharID int,\r\n@Category tinyint,\r\n@JobID int,\r\n@TimeToKeep int,\r\n@Data1 int,\r\n@Data2 int,\r\n--##begin due to develop composite item\r\n@Data3 int,\r\n@Data4 int,\r\n@Data5 int,\r\n@Data6 int,\r\n@Data7 int,\r\n@Data8 int,\r\n@Serial64 bigint,\r\n@JID int\r\n--##end due to develop composite item\r\nas\r\nif (not exists (select CharID from _Char with (nolock) where CharID = @CharID))\r\nreturn -1\r\nif (@TimeToKeep <= 0)\r\nreturn -2\r\ndeclare @NewJobID int\r\nset @NewJobID = 0\r\n\r\n\r\n--##JobID 1 = Guild // JobID 2 = Thief/Hunter/Trader\r\n--##If you want to only have one not both, then just modify the line below!\r\nif (@JobID = 1 or @JobID = 2)\r\nBEGIN\r\nreturn -1\r\nEND\r\nELSE\r\nBEGIN\r\n--##begin due to develop composite item\r\ninsert into _TimedJob(CharID,Category,JobID,TimeToKeep,Data1,Data2,Data3,Data4,Data5,Data6,Data7,Data8,Serial64, JID)\r\nvalues(@CharID, @Category, @JobID, @TimeToKeep, @Data1, @Data2, @Data3, @Data4, @Data5, @Data6, @Data7, @Data8, @Serial64, @JID)\r\nEND\r\n--##end due to develop composite item\r\nset @NewJobID = @@identity\r\nif (@@error <> 0 or @@rowcount = 0)\r\n\r\n\r\nreturn -3\r\nreturn @NewJobID";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Guild&Job Penalties Fixed Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Guild&Job Cezaları Başarı İle Fixlendi!");
                    }
				}
			}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jobcezakaldirmak));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(61, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kaldir!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaldırmadan önce Database Yedek alınız.";
            // 
            // jobcezakaldirmak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(241, 104);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "jobcezakaldirmak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Ceza Kaldır..";
            this.Load += new System.EventHandler(this.jobcezakaldirmak_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

        private void jobcezakaldirmak_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                this.Text = "Remove Job Penalty..";
                label1.Text = "Take a Database Backup before uninstalling.";
                button1.Text = "Remove!";
            }
        }
    }
}
