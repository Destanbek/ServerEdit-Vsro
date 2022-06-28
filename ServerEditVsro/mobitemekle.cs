using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class mobitemekle : Form
	{
		private IContainer components = null;

		private Button button1;

		private TextBox textBox1;

		private Label label1;

		private Label label2;

		private TextBox textBox2;

		private Label label3;

		private TextBox textBox3;

		private Label label4;

		private TextBox textBox4;

		private Label label5;

		private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mobitemekle));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(123, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mob Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İtem Kodu :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kaç Adet Düşsün :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Düşme Oranı :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(5, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Buraya \"1\" yazarsanız %100 her Mob\'dan düşecektir. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(5, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Buraya \"0.5\" yazarsak %50 oranla düşecektir. ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(5, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Buraya \"0.1\" yazarsak %10 ihtimal ile düşecektir. ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 221);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(5, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 71);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // mobitemekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(307, 227);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mobitemekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mob İtem Ekle";
            this.Load += new System.EventHandler(this.mobitemekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		public mobitemekle()
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
						sqlCommand.CommandText = "\r\n\r\n\r\nDECLARE @Mob VarChar(MAX),@Item VarChar(MAX),@MonsterID iNt,@ItemID iNt,@DropRatio ReaL, @DropAmountMin INT, @DropAmountMax INT\r\n--------------------------------------------------------------------------\r\nSET @Mob            =    '" + textBox1.Text + "'\r\nSET @Item            =    '" + textBox2.Text + "'\r\nSET @DropAmountMin    =    '" + textBox3.Text + "'\r\nSET @DropAmountMax    =    '" + textBox3.Text + "'\r\nSET @DropRatio        =    '" + textBox4.Text + "'\r\n--------------------------------------------------------------------------\r\nSET @MonsterID    =    (SELECT ID FROM [dbo].[_RefObjCommon] WHERE CodeName128 = @Mob)/**/\r\nSET @ItemID        =    (SELECT ID FROM [dbo].[_RefObjCommon] WHERE CodeName128 = @Item)/**/\r\nINSERT [dbo].[_RefMonster_AssignedItemDrop]/**/\r\n(RefMonsterID,RefItemID,DropGroupType,OptLevel,DropAmountMin,DropAmountMax,DropRatio,RefMagicOptionID1,CustomValue1,RefMagicOptionID2,CustomValue2,RefMagicOptionID3,CustomValue3,RefMagicOptionID4,CustomValue4,RefMagicOptionID5,CustomValue5,RefMagicOptionID6,CustomValue6,RefMagicOptionID7,CustomValue7,RefMagicOptionID8,CustomValue8,RefMagicOptionID9,CustomValue9,RentCodeName)/**/\r\nVALUES(@MonsterID,@ItemID,0,0,@DropAmountMin,@DropAmountMax,@DropRatio,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'xxx')/**/";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Item Added to Mob Successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Mob'a İtem Başarı İle Eklendi!");
                        }

					}
					catch (Exception)
					{
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Error occured!, Item code or Mob code may be wrong!");
                        }
                        else
                        {
                            MessageBox.Show("Hata oluştu!, İtem kodu yada Mob kodu yanlış olabilir!");
                        }
					}
				}
			}
		}

        private void mobitemekle_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                this.Text = "Add Mob Item";
                label1.Text = "Mob Code :";
                label2.Text = "Item Code:";
                label3.Text = "How Many Pieces Drop:";
                label4.Text = "Drop Rate :";
                label5.Text = "If you write '1' here, 100% will be dropped from every Mob.";
                label6.Text = "If we write '0.5' here, it will decrease by 50%.";
                label7.Text = "If we write '0.1' here, it will drop with 10% probability.";
                button1.Text = "Add";
                label3.Location = new Point(4,62);
                label2.Location = new Point(67,39);
                label4.Location = new Point(63,85);
            }
        }
    }
}
