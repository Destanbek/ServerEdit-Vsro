using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class accounttemizle : Form
	{
		private IContainer components = null;

		private Label label3;

		private Label label2;

		private Label label1;
        private Label label4;
        private Button button2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;

		public accounttemizle()
		{
			InitializeComponent();
		}

		private void accounttemizle_Load(object sender, EventArgs e)
		{
            if (Language.Default.language == "English")
            {
                this.Text = "Clear Account";
                label1.Text = "Account data is being deleted, do you confirm?\r\n                If you approve, click Clear.\r\n                Press Cross to cancel...";
                label2.Text = "All your data in the Account will be deleted.\r\n                (Detailed Cleaning)";
                label3.Text = "Read before clicking the button!!";
                label4.Text = "           IMPORTANT WARNING! \r\nBEFORE CLEANING YOUR DATABASE\r\n           MUST HAVE A BACKUP...";
                label5.Text = "DB Name :"; label5.Location = new Point(45,21);
                label6.Text = "        Please Login \r\n      Select Database Name...";
                button1.Text = "Clean";
                button2.Text = "Clean";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button1.Show();
                button2.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                button2.Show();
                button1.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Acc))
				{
					using (SqlCommand sqlCommand = new SqlCommand())
					{
						sqlConnection.Open();
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText =
                        "TRUNCATE TABLE [dbo].[TB_User]" +
                        "TRUNCATE TABLE [dbo].[TB_User_Bak]" +
                        "TRUNCATE TABLE [dbo].[SK_CharRenameLog]" +
                        "TRUNCATE TABLE [dbo].[_Punishment]" +
                        "TRUNCATE TABLE [dbo].[_ServiceManagerLog]" +
                        "TRUNCATE TABLE [dbo].[Test_HN]" +
                        "TRUNCATE TABLE [dbo].[_BlockedUser]" +
                        "TRUNCATE TABLE [dbo].[_CasGMChatLog]" +
                        "TRUNCATE TABLE [dbo].[_Notice]" +
                        "TRUNCATE TABLE [dbo].[_SMCLog]" +
                        "TRUNCATE TABLE [dbo].[QuaySoEpoint]" +
                        "TRUNCATE TABLE [dbo].[SK_ITEM_GuardLog]" +
                        "TRUNCATE TABLE [dbo].[SK_ItemSaleLog]" +
                        "TRUNCATE TABLE [dbo].[SK_PackageItemSaleLog]" +
                        "TRUNCATE TABLE [dbo].[SK_PK_UpdateLog]" +
                        "TRUNCATE TABLE [dbo].[SK_ResetSkillLog]" +
                        "TRUNCATE TABLE [dbo].[SK_Silk]" +
                        "TRUNCATE TABLE [dbo].[SK_SilkBuyList]" +
                        "TRUNCATE TABLE [dbo].[SK_SilkGoods]" +
                        "TRUNCATE TABLE [dbo].[SK_SubtractSilk_VAS]" +
                        "TRUNCATE TABLE [dbo].[SR_ShardCharNames]" +
                        "TRUNCATE TABLE [dbo].[TB_Net2e]" +
                        "TRUNCATE TABLE [dbo].[TB_Net2e_Bak]" +
                        "TRUNCATE TABLE [dbo].[tb_paygate_trans]";
                        sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
				}
                if (Language.Default.language == "English")
                {
                    MessageBox.Show("Tables Cleared Successfully!");
                }
                else
                {
                    MessageBox.Show("Tablolar Başarı İle Temizlendi!");
                }

			}
			catch (Exception)
			{
                if (Language.Default.language == "English")
                {
                    MessageBox.Show("table missing!");
                }
                else
                {
                    MessageBox.Show("tablo eksik!");
                }
			}
		}
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Acc))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlConnection.Open();
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText =
                        "TRUNCATE TABLE [dbo].[TB_User]" +
                        "TRUNCATE TABLE [dbo].[_Punishment]" +
                        "TRUNCATE TABLE [dbo].[_ServiceManagerLog]" +
                        "TRUNCATE TABLE [dbo].[__SiegeFortressStatus__]" +
                        "TRUNCATE TABLE [dbo].[_ShardCurrentUser]" +
                        "TRUNCATE TABLE [dbo].[_BlockedUser]" +
                        "TRUNCATE TABLE [dbo].[_CasData]" +
                        "TRUNCATE TABLE [dbo].[_PrivilegedIP]" +
                        "TRUNCATE TABLE [dbo].[_CasGMChatLog]" +
                        "TRUNCATE TABLE [dbo].[_Notice]" +
                        "TRUNCATE TABLE [dbo].[_SMCLog]" +
                        "TRUNCATE TABLE [dbo].[SK_Silk]" +
                        "TRUNCATE TABLE [dbo].[SK_SilkBuyList]" +
                        "TRUNCATE TABLE [dbo].[SK_SilkChange_BY_Web]" +
                        "TRUNCATE TABLE [dbo].[WEB_ITEM_CERTIFYKEY]" +
                        "TRUNCATE TABLE [dbo].[WEB_ITEM_GIVE_LIST]" +
                        "TRUNCATE TABLE [dbo].[WEB_ITEM_GIVE_LIST_DETAIL]" +
                        "TRUNCATE TABLE [dbo].[WEB_ITEM_RENT_INFO]";
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                if (Language.Default.language == "English")
                {
                    MessageBox.Show("Tables Cleared Successfully!");
                }
                else
                {
                    MessageBox.Show("Tablolar Başarı İle Temizlendi!");
                }

            }
            catch (Exception)
            {
                if (Language.Default.language == "English")
                {
                    MessageBox.Show("table missing!");
                }
                else
                {
                    MessageBox.Show("tablo eksik!");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accounttemizle));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Butonu tıklamadan önce okuyunuz!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(52, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account\'daki Tüm verileriniz silinecektir.\r\n                (Detaylı Temizlik)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account verileri siliniyor onaylıyormusunuz?\r\n      onaylıyorsanız Temizle\'ye tık" +
    "layınız. \r\n                Iptal için Çarpıya basınız...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(122, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Temizle!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(59, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "             ÖNEMLİ UYARI! \r\nDATABASE\'NİZİ TEMİZLEMEDEN \r\nÖNCE MUTLAKA YEDEĞİNİ A" +
    "LINIZ...";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(122, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Temizle!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SRO_VT_ACCOUNT",
            "SRO_R_ACCOUNT"});
            this.comboBox1.Location = new System.Drawing.Point(116, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(61, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "DB Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(77, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lütfen Girişte Girmiş oldugunuz \r\n      Database Adını Seçiniz...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 203);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 55);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 72);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // accounttemizle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(371, 341);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "accounttemizle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Temizle";
            this.Load += new System.EventHandler(this.accounttemizle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
    }
}
