using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class shardtemizle : Form
	{
		private IContainer components = null;

		private Label label3;

		private Label label2;

		private Label label1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button button1;

		public shardtemizle()
		{
			InitializeComponent();
		}

		private void shardtemizle_Load(object sender, EventArgs e)
		{
            if (Language.Default.language == "English")
            {
                this.Text = "Clear Shard DB";
                label1.Text = "Shard data is being deleted, do you confirm?\r\n              If you approve, click Clear.\r\n                Press Cross to cancel...";
                label2.Text = "All your data in the Shard will be deleted.\r\n              (Detailed Cleaning)";
                label3.Text = "Read before clicking the button!!";
                label4.Text = "           IMPORTANT WARNING! \r\nBEFORE CLEANING YOUR DATABASE\r\n           MUST HAVE A BACKUP...";
                label5.Text = "DB Name :"; label5.Location = new Point(45, 21);
                label6.Text = "       Please Login \r\n      Select Database Name...";
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
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					try
					{
						sqlConnection.Open();
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText =
                            "TRUNCATE TABLE [dbo].[_Chest]" +
                            "TRUNCATE TABLE [dbo].[_ChestInfo]" +
                            "TRUNCATE TABLE [dbo].[_User]" +
                            "TRUNCATE TABLE [dbo].[_OpenMarket]" +
                            "DELETE FROM [dbo].[_AccountJID] " +
                            "TRUNCATE TABLE [dbo].[_GuildWar]"+
                            "TRUNCATE TABLE [dbo].[_GuildMember]" +
                            "TRUNCATE TABLE [dbo].[_GuildChest]" +
                            "TRUNCATE TABLE [dbo].[_SiegeFortressObject]" +
                            "TRUNCATE TABLE [dbo].[_SiegeFortressItemForge]" +
                            "UPDATE [dbo].[_SiegeFortressStruct] SET OwnerGuildID = '0' where FortressID Between '1' and '6'" +
                            "DELETE FROM [dbo].[_SiegeFortress]" +
                            "INSERT INTO [dbo].[_SiegeFortress](FortressID) VALUES (1)" +
                            "INSERT INTO [dbo].[_SiegeFortress](FortressID) VALUES (3)" +
                            "INSERT INTO [dbo].[_SiegeFortress](FortressID) VALUES (6)" +
                            "INSERT INTO [dbo].[_SiegeFortress](FortressID) VALUES (4)" +
                            "UPDATE [dbo].[_AlliedClans] SET Ally1 = '0', Ally2 = '0', Ally3 = '0', Ally4 = '0', Ally5 = '0', Ally6 = '0', Ally7 = '0', Ally8 = '0'" +
                            "DELETE FROM [dbo].[_Guild] WHERE ID > 0" +
                            "DELETE FROM [dbo].[_AlliedClans] WHERE ID > 0" +
                            "TRUNCATE TABLE [dbo].[_InventoryForAvatar]" +
                            "TRUNCATE TABLE [dbo].[_TrainingCampSubMentorHonorPoint]" +
                            "TRUNCATE TABLE [dbo].[_BlockedWhisperers]" +
                            "TRUNCATE TABLE [dbo].[_TrainingCampMember]" +
                            "TRUNCATE TABLE [dbo].[_CharTrijobSafeTrade]" +
                            "DELETE FROM [dbo].[_CharTrijob] WHERE CharID > 0" +
                            "TRUNCATE TABLE [dbo].[_TimedJob]" +
                            "TRUNCATE TABLE [dbo].[_StaticAvatar]" +
                            "TRUNCATE TABLE [dbo].[_CharAlchemy_MK_Recipe]" +
                            "TRUNCATE TABLE [dbo].[_Inventory]" +
                            "TRUNCATE TABLE [dbo].[_Memo]" +
                            "TRUNCATE TABLE [dbo].[_FleaMarketNetwork]" +
                            "TRUNCATE TABLE [dbo].[_Friend]" +
                            "TRUNCATE TABLE [dbo].[_CharSkillMastery]" +
                            "TRUNCATE TABLE [dbo].[_CharSkill]" +
                            "TRUNCATE TABLE [dbo].[_InvCOS]" +
                            "DELETE FROM [dbo].[_CharCOS] WHERE ID > 0" +
                            "DELETE FROM [dbo].[_Char] WHERE CharID > 0" +
                            "TRUNCATE TABLE [dbo].[_CharCollectionBook]" +
                            "TRUNCATE TABLE [dbo].[_CharInstanceWorldData]" +
                            "TRUNCATE TABLE [dbo].[_CharNameList]" +
                            "TRUNCATE TABLE [dbo].[_CharNickNameList]" +
                            "TRUNCATE TABLE [dbo].[_CharQuest]" +
                            "TRUNCATE TABLE [dbo].[_ClientConfig]" +
                            "TRUNCATE TABLE [dbo].[_DeletedChar]" +
                            "TRUNCATE TABLE [dbo].[_GPHistory]" +
                            "TRUNCATE TABLE [dbo].[_ItemPool]" +
                            "DELETE FROM [dbo].[_Items] WHERE ID64 > 0" +
                            "TRUNCATE TABLE [dbo].[_TimedJobForPet]" +
                            "TRUNCATE TABLE [dbo].[_TrainingCampBuffStatus]" +
                            "TRUNCATE TABLE [dbo].[_TrainingCampHonorRank]" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (1)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (2)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (3)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (4)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (5)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (6)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (7)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (8)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (9)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (10)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (11)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (12)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (13)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (14)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (15)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (16)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (17)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (18)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (19)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (20)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (21)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (22)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (23)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (24)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (25)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (26)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (27)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (28)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (29)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (30)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (31)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (32)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (33)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (34)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (35)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (36)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (37)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (38)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (39)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (40)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (41)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (42)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (43)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (44)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (45)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (46)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (47)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (48)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (49)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (50)" +
                            "DELETE FROM [dbo].[_TrainingCamp]";
                        sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
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
                            MessageBox.Show("An error occurred!");
                        }
                        else
                        {
                            MessageBox.Show("Hata Oluştu!");
                        }

					}
				}
			}
		}
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText =
                            "TRUNCATE TABLE [dbo].[_Chest]" +
                            "TRUNCATE TABLE [dbo].[_ChestInfo]" +
                            "TRUNCATE TABLE [dbo].[_User]" +
                            "TRUNCATE TABLE [dbo].[_OpenMarket]" +
                            "DELETE FROM [dbo].[_AccountJID] " +
                            "TRUNCATE TABLE [dbo].[_GuildWar]" +
                            "DELETE FROM [dbo].[_TradeEquipInventory]" +
                            "TRUNCATE TABLE [dbo].[_CharNewTrade]" +
                            "TRUNCATE TABLE [dbo].[_CharTradeConflictJob]" +
                            "TRUNCATE TABLE [dbo].[_ConsignmentTrade_Invest]" +
                            "TRUNCATE TABLE [dbo].[_EquipInvCos]" +
                            "TRUNCATE TABLE [dbo].[_FriendGroup]" +
                            "TRUNCATE TABLE [dbo].[_GuildMember]" +
                            "TRUNCATE TABLE [dbo].[_GuildChest]" +
                            "TRUNCATE TABLE [dbo].[_SiegeFortressObject]" +
                            "TRUNCATE TABLE [dbo].[_SiegeFortressItemForge]" +
                            "UPDATE [dbo].[_SiegeFortressStruct] SET OwnerGuildID = '0' where FortressID Between '1' and '6'" +
                            "DELETE FROM [dbo].[_SiegeFortress]" +
                            "INSERT INTO [dbo].[_SiegeFortress](FortressID) VALUES (1)" +
                            "INSERT INTO [dbo].[_SiegeFortress](FortressID) VALUES (3)" +
                            "INSERT INTO [dbo].[_SiegeFortress](FortressID) VALUES (6)" +
                            "INSERT INTO [dbo].[_SiegeFortress](FortressID) VALUES (4)" +
                            "UPDATE [dbo].[_AlliedClans] SET Ally1 = '0', Ally2 = '0', Ally3 = '0', Ally4 = '0', Ally5 = '0', Ally6 = '0', Ally7 = '0', Ally8 = '0'" +
                            "DELETE FROM [dbo].[_Guild] WHERE ID > 0" +
                            "DELETE FROM [dbo].[_AlliedClans] WHERE ID > 0" +
                            "TRUNCATE TABLE [dbo].[_InventoryForAvatar]" +
                            "TRUNCATE TABLE [dbo].[_TrainingCampSubMentorHonorPoint]" +
                            "TRUNCATE TABLE [dbo].[_BlockedWhisperers]" +
                            "TRUNCATE TABLE [dbo].[_TrainingCampMember]" +
                            "TRUNCATE TABLE [dbo].[_CharTrijobSafeTrade]" +
                            "DELETE FROM [dbo].[_CharTrijob] WHERE CharID > 0" +
                            "TRUNCATE TABLE [dbo].[_TimedJob]" +
                            "TRUNCATE TABLE [dbo].[_StaticAvatar]" +
                            "TRUNCATE TABLE [dbo].[_CharAlchemy_MK_Recipe]" +
                            "TRUNCATE TABLE [dbo].[_Inventory]" +
                            "TRUNCATE TABLE [dbo].[_Memo]" +
                            "TRUNCATE TABLE [dbo].[_FleaMarketNetwork]" +
                            "TRUNCATE TABLE [dbo].[_TradeBagInventory]" +
                            "TRUNCATE TABLE [dbo].[_MemoBlock]" +
                            "TRUNCATE TABLE [dbo].[_Friend]" +
                            "TRUNCATE TABLE [dbo].[_CharSkillMastery]" +
                            "TRUNCATE TABLE [dbo].[_CharSkill]" +
                            "TRUNCATE TABLE [dbo].[_InvCOS]" +
                            "DELETE FROM [dbo].[_CharCOS] WHERE ID > 0" +
                            "DELETE FROM [dbo].[_Char] WHERE CharID > 0" +
                            "TRUNCATE TABLE [dbo].[_CharCollectionBook]" +
                            "TRUNCATE TABLE [dbo].[_CharInstanceWorldData]" +
                            "TRUNCATE TABLE [dbo].[_CharNameList]" +
                            "TRUNCATE TABLE [dbo].[_CharNickNameList]" +
                            "TRUNCATE TABLE [dbo].[_CharQuest]" +
                            "TRUNCATE TABLE [dbo].[_ClientConfig]" +
                            "TRUNCATE TABLE [dbo].[_DeletedChar]" +
                            "TRUNCATE TABLE [dbo].[_GPHistory]" +
                            "TRUNCATE TABLE [dbo].[_ItemPool]" +
                            "DELETE FROM [dbo].[_Items] WHERE ID64 > 0" +
                            "TRUNCATE TABLE [dbo].[_TimedJobForPet]" +
                            "TRUNCATE TABLE [dbo].[_TrainingCampBuffStatus]" +
                            "TRUNCATE TABLE [dbo].[_TrainingCampHonorRank]" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (1)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (2)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (3)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (4)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (5)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (6)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (7)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (8)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (9)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (10)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (11)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (12)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (13)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (14)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (15)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (16)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (17)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (18)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (19)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (20)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (21)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (22)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (23)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (24)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (25)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (26)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (27)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (28)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (29)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (30)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (31)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (32)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (33)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (34)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (35)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (36)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (37)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (38)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (39)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (40)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (41)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (42)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (43)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (44)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (45)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (46)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (47)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (48)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (49)" +
                            "INSERT INTO [dbo].[_TrainingCampHonorRank](Ranking) VALUES (50)" +
                            "DELETE FROM [dbo].[_TrainingCamp]" +
                            "TRUNCATE TABLE [dbo].[Tab_RefRanking_HunterContribution]" +
                            "TRUNCATE TABLE [dbo].[Tab_RefRanking_RobberContribution]" +
                            "TRUNCATE TABLE [dbo].[Tab_RefRanking_TraderContribution]";
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
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
                            MessageBox.Show("An error occurred!");
                        }
                        else
                        {
                            MessageBox.Show("Hata Oluştu!");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shardtemizle));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Butonu tıklamadan önce okuyunuz!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(71, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Shard\'daki Tüm verileriniz silinecektir.\r\n               (Detaylı Temizlik)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Shard Databasesindeki Tüm Veriler silinecek.\r\n     onaylıyorsanız Temizle\'ye tıkl" +
    "ayınız.\r\n              Iptal için Çarpıya basınız...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(118, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Temizle!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(71, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "              ÖNEMLİ UYARI! \r\nDATABASE\'NİZİ TEMİZLEMEDEN \r\nÖNCE MUTLAKA YEDEĞİNİ " +
    "ALINIZ...";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SRO_VT_SHARD",
            "SRO_R_SHARD"});
            this.comboBox1.Location = new System.Drawing.Point(118, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(89, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lütfen Girişte Girmiş oldugunuz \r\n      Database Adını Seçiniz...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(62, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "DB Adı :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(118, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 46);
            this.button2.TabIndex = 20;
            this.button2.Text = "Temizle!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 212);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(12, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 76);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 54);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // shardtemizle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(392, 358);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "shardtemizle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shard Temizle...";
            this.Load += new System.EventHandler(this.shardtemizle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
    }
}
