using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class f10dc : Form
	{
		private IContainer components = null;

		private Label label1;
        private GroupBox groupBox1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f10dc));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "_RefObjCommon\r\n_RefPackageItem\r\n_RefscrapofPackageItem\r\n_RefPricePolicyOfItem\r\n_R" +
    "efShopGoods\r\n  Kontrol Eder ITEM Service\'leri \'0\' ise \'1\' yapar.\r\n  Sadece MALL-" +
    "COS-ETC yazanlarý açar.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(102, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fixle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // f10dc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(375, 187);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f10dc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F10 Dc Fix";
            this.Load += new System.EventHandler(this.f10dc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		public f10dc()
		{
			InitializeComponent();
		}

		private void f10dc_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Language.Default.language == "English")
            {
                label1.Text = "_RefObjCommon\r\n_RefPackageItem\r\n_RefscrapofPackageItem\r\n_RefPricePolicyOfItem\r\n_RefShopGoods\r\n  Controls ITEM Services makes \'0\' if \'1\'.\r\n  It only opens MALL-COS-ETC.";
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
                    sqlCommand.CommandText = "\r\nupdate _RefObjCommon set Service = 1 where CodeName128 like '%MALL%'\r\nupdate _RefPackageItem set Service = 1 where CodeName128 like  '%MALL%'\r\nupdate _RefscrapofPackageItem set Service = 1 where RefPackageItemCodeName like  '%MALL%'\r\nupdate _RefPricePolicyOfItem set Service =1 where RefPackageItemCodeName like  '%MALL%'\r\nupdate _RefShopGoods set Service =1 where RefPackageItemCodeName like  '%MALL%'";
                    sqlCommand.CommandText = "\r\nupdate _RefObjCommon set Service = 1 where CodeName128 like '%COS%'\r\nupdate _RefPackageItem set Service = 1 where CodeName128 like  '%COS%'\r\nupdate _RefscrapofPackageItem set Service = 1 where RefPackageItemCodeName like  '%COS%'\r\nupdate _RefPricePolicyOfItem set Service =1 where RefPackageItemCodeName like  '%COS%'\r\nupdate _RefShopGoods set Service =1 where RefPackageItemCodeName like  '%COS%'";
                    sqlCommand.CommandText = "\r\nupdate _RefObjCommon set Service = 1 where CodeName128 like '%ETC%'\r\nupdate _RefPackageItem set Service = 1 where CodeName128 like  '%ETC%'\r\nupdate _RefscrapofPackageItem set Service = 1 where RefPackageItemCodeName like  '%ETC%'\r\nupdate _RefPricePolicyOfItem set Service =1 where RefPackageItemCodeName like  '%ETC%'\r\nupdate _RefShopGoods set Service =1 where RefPackageItemCodeName like  '%ETC%'";
                    sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("F10 Fixed");
                    }
                    else
                    {
                        MessageBox.Show("F10 Fixlendi");
                    }
				}
			}
		}
	}
}
