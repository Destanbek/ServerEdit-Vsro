using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class itemsiloyunculardan : Form
	{
		private IContainer components = null;

		private Label label1;

		private TextBox textBox1;

		private Button button1;
        private GroupBox groupBox1;
        private Label label2;

		public itemsiloyunculardan()
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
					sqlCommand.CommandText = "USE SRO_VT_SHARD declare @silinecekiteminid int = \r\n(select id from _refobjcommon where \r\n\r\nCodeName128 = '" + textBox1.Text + "'\t\r\n\r\n)\r\n\r\nupdate _Chest set ItemID=0 where ItemID in\r\n(select id64 from _Items where RefItemID = @silinecekiteminid)\r\nupdate _Inventory set ItemID=0 where ItemID in\r\n(select id64 from _Items where RefItemID = @silinecekiteminid)\r\nupdate _InvCOS set ItemID=0 where ItemID in\r\n(select id64 from _Items where RefItemID = @silinecekiteminid)\r\nupdate _InventoryForAvatar set ItemID=0 where ItemID in\r\n(select id64 from _Items where RefItemID = @silinecekiteminid)\r\nupdate _InventoryForLinkedStorage set ItemID=0 where ItemID in\r\n(select id64 from _Items where RefItemID = @silinecekiteminid)";
                    sqlCommand.CommandText = "USE SRO_R_SHARD declare @silinecekiteminid int = \r\n(select id from _refobjcommon where \r\n\r\nCodeName128 = '" + textBox1.Text + "'\t\r\n\r\n)\r\n\r\nupdate _Chest set ItemID=0 where ItemID in\r\n(select id64 from _Items where RefItemID = @silinecekiteminid)\r\nupdate _Inventory set ItemID=0 where ItemID in\r\n(select id64 from _Items where RefItemID = @silinecekiteminid)\r\nupdate _InvCOS set ItemID=0 where ItemID in\r\n(select id64 from _Items where RefItemID = @silinecekiteminid)\r\nupdate _InventoryForAvatar set ItemID=0 where ItemID in\r\n(select id64 from _Items where RefItemID = @silinecekiteminid)";
                    sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Successfully Deleted Items!");
                    }
                    else
                    {
                        MessageBox.Show("Başarı İle İtemler Silindi!");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemsiloyunculardan));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İtem Kodu :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(89, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sil!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Not: İtem tüm oyunculardan kalkacaktır pet dahil.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // itemsiloyunculardan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(260, 125);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "itemsiloyunculardan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Oyunculardan İtem Sil";
            this.Load += new System.EventHandler(this.itemsiloyunculardan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

        private void itemsiloyunculardan_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                this.Text = "Delete Item from All Players";
                label1.Text = "Item Code:";
                label2.Text = "Note: The item will be removed from all players,\r\n           including pet.";
                button1.Text = "Delete!";
            }
        }
    }
}
