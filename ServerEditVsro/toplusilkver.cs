using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class toplusilkver : Form
	{
		private IContainer components = null;

		private Button button1;

		private Label label3;

		private TextBox textBox1;

		private Label label2;
        private GroupBox groupBox1;
        private Label label1;

		public toplusilkver()
		{
			InitializeComponent();
		}

		private void toplusilkver_Load(object sender, EventArgs e)
		{
            if (Language.Default.language == "English")
            {
                this.Text = "Give Bulk Silk To All Players...";
                label1.Text = "It makes everyone's SILK the same.";
                label2.Text = "The old Silk is deleted. No matter how much you have\r\n written, it will be replaced.";
                label3.Text = "Silk Quantity :";
                button1.Text = "Give Silk";
                label3.Location = new Point(24,74);

            }

        }

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Acc))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "UPDATE [dbo].[SK_Silk] SET  silk_own='" + textBox1.Text + "' ";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Everyone was given a silk!");
                    }
                    else
                    {
                        MessageBox.Show("Silkler Verildi!");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toplusilkver));
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
            this.button1.Location = new System.Drawing.Point(95, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 28;
            this.button1.Text = "Silk\'i ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Silk Miktarı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Eski Silk\'i silinir.Ne kadar yazdıysanız yerine o gelir.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Herkesin SİLK\'ini aynı yapar.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 147);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // toplusilkver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(292, 153);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "toplusilkver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Oyunculara Toplu Silk Ver...";
            this.Load += new System.EventHandler(this.toplusilkver_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
