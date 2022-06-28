using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class skillsıfırla : Form
	{
		private IContainer components = null;
        private GroupBox groupBox1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skillsıfırla));
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
            this.button1.Location = new System.Drawing.Point(42, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sıfırla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(5, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skill\'leri Sıfırlamadan önce mutlaka \r\n         Database yedek alınız...";
            // 
            // skillsıfırla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(196, 110);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "skillsıfırla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skill Sıfırla";
            this.Load += new System.EventHandler(this.skillsıfırla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		public skillsıfırla()
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
                    sqlCommand.CommandText = "\r\n\r\nupdate _ClientConfig\r\nset Data = '0'\r\n\r\n\r\nDELETE FROM [dbo].[_CharSkill]\r\n      WHERE  SKillID NOT LIKE '1' and  SKillID NOT LIKE '2' and  SKillID NOT LIKE '40'\r\n\t  and  SKillID NOT LIKE '70' and  SKillID NOT LIKE '8421' and  SKillID NOT LIKE '8419'\r\n\t  and  SKillID NOT LIKE '8420' and  SKillID NOT LIKE '9354' and  SKillID NOT LIKE '9355'\r\n\t  and  SKillID NOT LIKE '9944' and  SKillID NOT LIKE '10625' and  SKillID NOT LIKE '11162'\r\n\t  and  SKillID NOT LIKE '11526'\r\n\r\nUPDATE [dbo].[_CharSkillMastery]\r\n   SET \r\n      [Level] = '0'";
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Skills Reset!");
                    }
                    else
                    {
                        MessageBox.Show("Skiller Sıfırlandı!");
                    }
                }
            }

        }

        private void skillsıfırla_Load(object sender, EventArgs e)
		{
            if (Language.Default.language == "English")
            {
                this.Text = "Reset Skill";
                label1.Text = "Before Resetting Skills\r\n          Take a database backup...";
                button1.Text = "Reset";
            }

        }
	}
}
