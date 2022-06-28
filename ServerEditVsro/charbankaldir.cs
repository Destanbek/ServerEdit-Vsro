using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class charbankaldir : Form
	{
		private IContainer components = null;

		private Button button1;

		private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(charbankaldir));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(124, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ban Kaldir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Karakter ismi girin:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // charbankaldir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "charbankaldir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Char Ban Kaldır...";
            this.Load += new System.EventHandler(this.charbankaldir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		public charbankaldir()
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
					sqlCommand.CommandText = "USE SRO_VT_SHARD          \r\n                         \r\nDECLARE @ChrID INT;            \r\nDECLARE @CharName VARCHAR(64); \r\nDECLARE @AccJID INT;           \r\n---------------------------------\r\nSET @CharName =    '" + textBox1.Text + "'---\r\n---------------------------------\r\nSET @ChrID=(SELECT CharID FROM _Char WHERE CharName16=@CharName)\r\nSET @AccJID=(SELECT UserJID FROM _User WHERE CharID=@ChrID)\r\n--------------------------------\r\nUSE [SRO_VT_ACCOUNT]\r\n--------------------------------\r\nDELETE FROM [dbo].[_BlockedUser]\r\nWHERE UserJID = @AccJID\r\nDELETE FROM [dbo].[_Punishment]\r\nWHERE UserJID = @AccJID\r\n\r\n--Maxigame ( KaRa ) --  \r\n\r\n-----------------------------------------------------------------\r\nSELECT StrUserID FROM TB_User WHERE JID = @AccJID\r\n-----------------------------------------------------------------  ";
                    sqlCommand.CommandText = "USE SRO_R_SHARD          \r\n                         \r\nDECLARE @ChrID INT;            \r\nDECLARE @CharName VARCHAR(64); \r\nDECLARE @AccJID INT;           \r\n---------------------------------\r\nSET @CharName =    '" + textBox1.Text + "'---\r\n---------------------------------\r\nSET @ChrID=(SELECT CharID FROM _Char WHERE CharName16=@CharName)\r\nSET @AccJID=(SELECT UserJID FROM _User WHERE CharID=@ChrID)\r\n--------------------------------\r\nUSE [SRO_R_ACCOUNT]\r\n--------------------------------\r\nDELETE FROM [dbo].[_BlockedUser]\r\nWHERE UserJID = @AccJID\r\nDELETE FROM [dbo].[_Punishment]\r\nWHERE UserJID = @AccJID\r\n\r\n--Maxigame ( KaRa ) --  \r\n\r\n-----------------------------------------------------------------\r\nSELECT StrUserID FROM TB_User WHERE JID = @AccJID\r\n-----------------------------------------------------------------  ";
                    sqlCommand.ExecuteNonQuery();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Banned successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Başarı ile ban açıldı!");
                    }

					sqlConnection.Close();
				}
			}
		}

        private void charbankaldir_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                this.Text = "Remove Char Ban...";
                label1.Text = "Enter char name:";
                label1.Location = new Point(12,19);

                button1.Text = "Remove Ban";
            }
        }
    }
}
