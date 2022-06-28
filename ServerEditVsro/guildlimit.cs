using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class guildlimit : Form
	{
		private IContainer components = null;

		private Label label1;

		private TextBox textBox1;
        private GroupBox groupBox1;
        private Button button1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guildlimit));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guild Limit Sayısı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(99, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ayarla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Indigo;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // guildlimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(244, 127);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guildlimit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guild Limit";
            this.Load += new System.EventHandler(this.guildlimit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		public guildlimit()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					try
					{
						sqlConnection.Open();
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = "\r\nALTER PROCEDURE [dbo].[_Guild_FnAddMember] \r\n @guildID        int,\r\n @memberID     int,\r\n @memberClass    tinyint,\r\n @joinDate     smalldatetime,\r\n @permission     int    \r\n    \r\nas\r\nDeclare @LiMiT int = '" + textBox1.Text + "' \r\n    if (exists (select CharID from _GuildMember where CharID = @memberID))\r\n    begin\r\n        return -1001\r\n    end\r\n\r\n\r\n\r\n\r\n    declare @memberName    varchar(64)\r\n    declare @curLevel    tinyint\r\n    select @memberName = CharName16, @curLevel = CurLevel from _Char with (nolock) where CharID = @memberID\r\n    if (@@error <> 0 or @@rowcount = 0)\r\n    begin\r\n        return -1\r\n    end\r\n    if (exists (select CharID from _GuildMember with (nolock) where GuildID = @guildID and CharID = @memberID))\r\n    begin \r\n        return -2\r\n    end\r\n    \r\n        declare @refObjID int\r\n    select @refObjID = RefObjID from _Char with (nolock) where CharID = @memberID\r\n    \r\n    if (@@error <> 0 or @@rowcount = 0)\r\n    begin\r\n        return -5\r\n    end";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Successfully set the limit!");
                        }
                        else
                        {
                            MessageBox.Show("Başarı ile  limit koyuldu!");
                        }
						Close();
					}
					catch (Exception)
					{
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {
                            MessageBox.Show("Hata");
                        }

					}
				}
			}
		}

        private void guildlimit_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                label1.Text = "Guild Limit Count :";
                button1.Text = "SET";
            }

        }
    }
}
