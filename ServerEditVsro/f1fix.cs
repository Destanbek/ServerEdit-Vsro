using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class f1fix : Form
	{
		private IContainer components = null;
        private Label label1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f1fix));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(74, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fixle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SkillBar F1 Fixler";
            // 
            // f1fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(265, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f1fix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F1 Fixleme";
            this.Load += new System.EventHandler(this.f1fix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		public f1fix()
		{
			InitializeComponent();
		}

		private void f1fix_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Language.Default.language == "English")
            {
                this.Text = "F1 Fix";
                label1.Text = "SkillBar F1 Fixed";
                button1.Text = "Fix";
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
					sqlCommand.CommandText = "\r\nUPDATE _RefCharDefault_Quest SET Service = 1\r\ndelete from _CHARQUEST where QuestID = 1\r\nINSERT INTO _CharQuest (CharID, QuestID, Status,AchievementCount,StartTime,EndTime,QuestData1,QuestData2) SELECT CharID, 1,5,0, '2012-04-13 20:44:00','2012-04-13 20:44:00',31458135,0 FROM _CHAR where CharID > 0";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("F1 Fixed");
                    }
                    else
                    {
                        MessageBox.Show("F1 Fixlendi");
                    }
				}
			}
		}
	}
}
