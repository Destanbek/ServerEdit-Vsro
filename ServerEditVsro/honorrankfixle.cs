using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class honorrankfixle : Form
	{
		private IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;

		public honorrankfixle()
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
					sqlCommand.CommandText = "\r\nTRUNCATE TABLE _TrainingCampHonorRank\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (1)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (2)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (3)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (4)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (5)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (6)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (7)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (8)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (9)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (10)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (11)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (12)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (13)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (14)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (15)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (16)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (17)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (18)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (19)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (20)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (21)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (22)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (23)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (24)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (25)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (26)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (27)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (28)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (29)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (30)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (31)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (32)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (33)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (34)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (35)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (36)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (37)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (38)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (39)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (40)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (41)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (42)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (43)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (44)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (45)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (46)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (47)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (48)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (49)\r\nINSERT INTO _TrainingCampHonorRank(Ranking) VALUES (50)\r\nexec _TRAINING_CAMP_UPDATEHONORRANK";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Honor rank fixed!");
                    }
                    else
                    {
                        MessageBox.Show("Honor rank fixlendi!");
                    }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(honorrankfixle));
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
            this.button1.Location = new System.Drawing.Point(52, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fixle!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fixlemeden önce Databaseyi yedekleyiniz..";
            // 
            // honorrankfixle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(235, 130);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "honorrankfixle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Honor Rank Fixle";
            this.Load += new System.EventHandler(this.honorrankfixle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

        private void honorrankfixle_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                this.Text = "Honor Rank Fix";
                label1.Text = "Backup the database before fixing.";
                button1.Text = "Fix!";
                label1.Location = new Point(15,28);
            }
        }
    }
}
