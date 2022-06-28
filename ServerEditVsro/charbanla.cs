using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class charbanla : Form
	{
		private IContainer components = null;

		private TextBox textBox1;

		private Label label1;

		private Button button1;

		private Label label2;

		private TextBox textBox2;

		public charbanla()
		{
			InitializeComponent();
		}

		private void charbanla_Load(object sender, EventArgs e)
		{
            if (Language.Default.language == "English")
            {
                this.Text="Char ban";
                label1.Location = new Point(8,12);
                label1.Text = "Enter char name:";
                label2.Text = "Ban reason:";
                button1.Text = "Ban";
                label2.Location = new Point(30,38);
            }

        }

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "USE SRO_VT_SHARD          \r\n--------------------------------                           \r\nDECLARE @ChrID INT;            \r\nDECLARE @CharName VARCHAR(64); \r\nDECLARE @AccJID INT;           \r\n---------------------------------\r\nSET @CharName =    '" + textBox1.Text + "'---\r\n---------------------------------\r\nSET @ChrID=(SELECT CharID FROM _Char WHERE CharName16=@CharName)\r\nSET @AccJID=(SELECT UserJID FROM _User WHERE CharID=@ChrID)\r\n-----------------------------------------------------------------\r\nUSE SRO_VT_ACCOUNT\r\nDECLARE @ID VARCHAR (64)\r\nDECLARE @Reason VARCHAR(128)\r\nDECLARE @Begin DATETIME\r\nDECLARE @End DATETIME\r\nSET @ID = (Select STRuserID FROM TB_User Where JID = @AccJID)\r\n\r\n---------------------------------\r\nSET @Reason    =    '" + textBox2.Text + "'\r\nSET @Begin    =    '2012-05-01 00:00:00.000' --    Baslangic    --\r\nSET @End    =    '2050-01-01 00:00:00.000' --    Bitis   --\r\n---------------------------------\r\n---------------------------\r\n\r\nINSERT [dbo].[_Punishment]\r\n(\r\n[UserJID],\r\n[Type],\r\n[Executor],\r\n[Shard],\r\n[CharName],\r\n[CharInfo],\r\n[PosInfo] ,\r\n[Guide],\r\n[Description],\r\n[RaiseTime],\r\n[BlockStartTime],\r\n[BlockEndTime],\r\n[PunishTime],\r\n[Status]\r\n)\r\nVALUES \r\n(\r\n@AccJID,\r\n1,\r\n1,\r\n0,\r\n@CharName,\r\n1,\r\n1,\r\n@Reason,\r\n@Reason,\r\n@Begin,\r\n@Begin,\r\n@End,\r\n@End,\r\n0);\r\n----------------------------------------------------------\r\nDECLARE @ReasonID INT\r\nSET @ReasonID =\r\n(Select SerialNo FROM _Punishment Where UserJID = @AccJID)\r\n----------------------------------------------------------\r\nINSERT [dbo].[_BlockedUser]\r\n(\r\n[UserJID],\r\n[UserID],\r\n[Type],\r\n[SerialNo],\r\n[TimeBegin],\r\n[TimeEnd])\r\nVALUES\r\n(\r\n@AccJID,\r\n@ID,\r\n1,\r\n@ReasonID,\r\n@Begin,\r\n@End);\r\n\r\n-----------------------------------------------------------------\r\nSELECT StrUserID FROM TB_User WHERE JID = @AccJID\r\n-----------------------------------------------------------------";
                    sqlCommand.CommandText = "USE SRO_R_SHARD          \r\n--------------------------------                           \r\nDECLARE @ChrID INT;            \r\nDECLARE @CharName VARCHAR(64); \r\nDECLARE @AccJID INT;           \r\n---------------------------------\r\nSET @CharName =    '" + textBox1.Text + "'---\r\n---------------------------------\r\nSET @ChrID=(SELECT CharID FROM _Char WHERE CharName16=@CharName)\r\nSET @AccJID=(SELECT UserJID FROM _User WHERE CharID=@ChrID)\r\n-----------------------------------------------------------------\r\nUSE SRO_R_ACCOUNT\r\nDECLARE @ID VARCHAR (64)\r\nDECLARE @Reason VARCHAR(128)\r\nDECLARE @Begin DATETIME\r\nDECLARE @End DATETIME\r\nSET @ID = (Select STRuserID FROM TB_User Where JID = @AccJID)\r\n\r\n---------------------------------\r\nSET @Reason    =    '" + textBox2.Text + "'\r\nSET @Begin    =    '2012-05-01 00:00:00.000' --    Baslangic    --\r\nSET @End    =    '2050-01-01 00:00:00.000' --    Bitis   --\r\n---------------------------------\r\n---------------------------\r\n\r\nINSERT [dbo].[_Punishment]\r\n(\r\n[UserJID],\r\n[Type],\r\n[Executor],\r\n[Shard],\r\n[CharName],\r\n[CharInfo],\r\n[PosInfo] ,\r\n[Guide],\r\n[Description],\r\n[RaiseTime],\r\n[BlockStartTime],\r\n[BlockEndTime],\r\n[PunishTime],\r\n[Status]\r\n)\r\nVALUES \r\n(\r\n@AccJID,\r\n1,\r\n1,\r\n0,\r\n@CharName,\r\n1,\r\n1,\r\n@Reason,\r\n@Reason,\r\n@Begin,\r\n@Begin,\r\n@End,\r\n@End,\r\n0);\r\n----------------------------------------------------------\r\nDECLARE @ReasonID INT\r\nSET @ReasonID =\r\n(Select SerialNo FROM _Punishment Where UserJID = @AccJID)\r\n----------------------------------------------------------\r\nINSERT [dbo].[_BlockedUser]\r\n(\r\n[UserJID],\r\n[UserID],\r\n[Type],\r\n[SerialNo],\r\n[TimeBegin],\r\n[TimeEnd])\r\nVALUES\r\n(\r\n@AccJID,\r\n@ID,\r\n1,\r\n@ReasonID,\r\n@Begin,\r\n@End);\r\n\r\n-----------------------------------------------------------------\r\nSELECT StrUserID FROM TB_User WHERE JID = @AccJID\r\n-----------------------------------------------------------------";
                    sqlCommand.ExecuteNonQuery();

                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Banned with success!");
                    }
                    else
                    {
                        MessageBox.Show("Başarı ile banlandı!");
                    }
					sqlConnection.Close();
					Close();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(charbanla));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Karakter ismi girin:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(96, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Banla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ban sebebi:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // charbanla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(240, 92);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "charbanla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Char Banla";
            this.Load += new System.EventHandler(this.charbanla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
