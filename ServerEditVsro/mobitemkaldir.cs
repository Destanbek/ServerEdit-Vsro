using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class mobitemkaldir : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mobitemkaldir));
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
            this.button1.Location = new System.Drawing.Point(91, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İtem Kodu Girin :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // mobitemkaldir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(248, 82);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mobitemkaldir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mob İtem Kaldır..";
            this.Load += new System.EventHandler(this.mobitemkaldir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		public mobitemkaldir()
		{
			InitializeComponent();
		}

		private void mobitemkaldir_Load(object sender, EventArgs e)
		{
            if (Language.Default.language == "English")
            {
                this.Text = "Remove Mob Item..";
                label1.Text = "Enter Item Code:";
                button1.Text = "Delete";
            }

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
						sqlCommand.CommandText = "DELETE _RefDropItemAssign\r\nFROM _RefDropItemAssign Drops\r\nLEFT JOIN _RefObjCommon Objects\r\nON (Drops.RefItemID = Objects.ID) \r\nWHERE CodeName128 like '" + textBox1.Text + "'\r\ndelete from _RefMonster_AssignedItemDrop where RefItemID like (select ID from _RefObjCommon where CodeName128 = '" + textBox1.Text + "' )";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Item has been successfully removed from the mob!");
                        }
                        else
                        {
                            MessageBox.Show("Mobdan item başarı ile kaldırıldı!");
                        }
					}
					catch (Exception)
					{
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Error occured!, Item code may be wrong!");
                        }
                        else
                        {
                            MessageBox.Show("Hata oluştu!, İtem kodu yanlış olabilir!");
                        }
					}
				}
			}
		}
	}
}
