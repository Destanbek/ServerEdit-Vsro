using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class rütbevermek : Form
	{
		private IContainer components = null;

		private ComboBox comboBox1;

		private Button button1;

		private TextBox textBox2;

		private Label label2;
        private GroupBox groupBox1;
        private Label label1;

		public rütbevermek()
		{
			InitializeComponent();
		}

		private void rütbevermek_Load(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					comboBox1.Items.Clear();
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "Select * From dbo._Char";
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					while (sqlDataReader.Read())
					{
						comboBox1.Items.Add(sqlDataReader[3].ToString());
					}
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        this.Text = "Rank Character...";
                        label1.Text = "Char Nick :";
                        label2.Text = "Rank(1-14) :";
                        button1.Text = "Update";
                        label1.Location = new Point(15,19);
                    }

                }
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					if (comboBox1.Text != "" && textBox2.Text != "")
					{
						sqlConnection.Open();
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = "Update dbo._Char Set HwanLevel='" + textBox2.Text + "' Where CharName16='" + comboBox1.Text + "' ";
						sqlCommand.ExecuteNonQuery();
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Updated!");
                        }
                        else
                        {
                            MessageBox.Show("Güncellendi!");
                        }
						sqlConnection.Close();
						comboBox1.Items.Clear();
						textBox2.Clear();
					}
					else
                    {
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Fill All Fields!");
                        }
                        else
                        {
                            MessageBox.Show("Tüm Alanları Doldurunuz!");
                        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rütbevermek));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(79, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rütbe(1-14) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Karakter Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 128);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // rütbevermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(203, 129);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rütbevermek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karaktere Rütbe Ver...";
            this.Load += new System.EventHandler(this.rütbevermek_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
