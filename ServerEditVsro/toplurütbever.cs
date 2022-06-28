using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class toplurütbever : Form
	{
		private IContainer components = null;

		private Button button1;

		private Label label3;

		private TextBox textBox1;

		private Label label2;
        private GroupBox groupBox1;
        private Label label1;

		public toplurütbever()
		{
			InitializeComponent();
		}

		private void toplurütbever_Load(object sender, EventArgs e)
		{
            if (Language.Default.language == "English")
            {
                this.Text = "Give All Players Same Rank...";
                label1.Text = "Makes everyone the same rank.";
                label2.Text = "For example: If you enter 1, everyone's rank\r\n will be 1, Captain-Knight.";
                label3.Text = "Rank Level (1-14) :";
                button1.Text = "Give Rank";
                textBox1.Location = new Point(115,76);
                button1.Location = new Point(115,102);

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
					sqlCommand.CommandText = "UPDATE dbo._Char set HwanLevel='" + textBox1.Text + "'  ";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Everyone was rated!");
                    }
                    else
                    {
                        MessageBox.Show("Rütbeler Verildi!");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toplurütbever));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(130, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Rütbeyi ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rütbe Seviyesi (1-14) :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Örn: 1 girerseniz herkesin rütbesi 1 olur Captain-Knight.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Herkesin rütbesini aynı yapar.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // toplurütbever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(291, 157);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "toplurütbever";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Oyunculara Aynı Rütbeyi Ver...";
            this.Load += new System.EventHandler(this.toplurütbever_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
