using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class spawn : Form
	{
		private IContainer components = null;

		private Label label1;

		private TextBox textBox1;

		private Label label2;

		private TextBox textBox2;

		private Label label3;

		private TextBox textBox3;

		private Label label4;

		private TextBox textBox4;

		private Label label5;

		private Label label6;

		private TextBox textBox5;

		private TextBox textBox6;

		private GroupBox groupBox1;

		private Label label13;

		private Label label12;

		private Label label11;

		private Label label10;

		private Label label9;

		private Label label8;

		private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;

		public spawn()
		{
			InitializeComponent();
		}

		private void spawn_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Language.Default.language == "English")
            {
                this.Text = "Add Unigue Spawn";
                label1.Text = "Unique Code To Spawn :";
                label2.Text = "The name of the character whose X Y Z coordinates will be taken :";
                label3.Text = "Min.time before appearing every second :";
                label4.Text = "Max.time before appearing every second :";
                label5.Text = "The perimeter of the spot where the unique appears :";
                label6.Text = "Perimeter of the spot (area) where the unique moves :";
                label7.Text = "                  NOTE : Wherever You Want to Spawn Unigue\r\nTake Your Character There. And Exit The Character After Exit\r\n                      You can add Unigue Spanw with the program..";
                label8.Text = "Example = MOB_RM_ROC";
                label9.Text = "Example = ServerEdit";
                label10.Text = "Example = 60 seconds";
                label11.Text = "Example = 120 seconds";
                label12.Text = "Example = 100";
                label13.Text = "Example = 500";
                button1.Text = "Add";
                groupBox1.Text = "Spawn Addition";
                label1.Location = new Point(197, 29);
                label2.Location = new Point(2, 55);
                label3.Location = new Point(122, 81);
                label4.Location = new Point(119, 107);
                label5.Location = new Point(68, 133);
                label6.Location = new Point(68, 159);
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
					sqlCommand.CommandText = "\r\nDECLARE @UNIQUE VARCHAR (129) \r\nDECLARE @CHARNAME VARCHAR (64) \r\nDECLARE @mindealy INT \r\nDECLARE @maxdelay int \r\nDECLARE @INITRADIUS INT \r\nDECLARE @RADIUS int \r\nDECLARE @MAXNEST int = (SELECT MAX (dwNestID) FROM Tab_RefNest)+1 \r\nDECLARE @MAXHIVE int = (SELECT MAX (dwHiveID) FROM Tab_RefHive)+1 \r\nDECLARE @MAXTACTICS int = (SELECT MAX (dwTacticsID) FROM Tab_RefTactics)+1 \r\n\r\n\r\n\r\n\r\n\r\n\r\nSET @UNIQUE = '" + textBox1.Text + "'\r\nSET @CHARNAME = '" + textBox2.Text + "'\r\nSET @mindealy = '" + textBox3.Text + "'\r\nSET @maxdelay = '" + textBox4.Text + "'\r\nSET @INITRADIUS = '" + textBox5.Text + "'\r\nSET @RADIUS = '" + textBox6.Text + "'\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nDeclare @MOBID int SET @MOBID = (SELECT ID FROM _RefObjCommon WHERE CodeName128 = @UNIQUE) \r\n\r\n\r\n\r\n\r\n\r\n\r\nINSERT INTO Tab_RefTactics (dwTacticsID,dwObjID,btAIQoS,nMaxStamina,btMaxStaminaVariance,nSightRange,btAggressType,AggressData,btChangeTarget,btHelpRequestTo,btHelpResponseTo,btBattleStyle,BattleStyleData,btDiversionBasis,DiversionBasisData1,DiversionBasisData2,DiversionBasisData3,DiversionBasisData4,DiversionBasisData5,DiversionBasisData6,DiversionBasisData7,DiversionBasisData8,btDiversionKeepBasis,DiversionKeepBasisData1,DiversionKeepBasisData2,DiversionKeepBasisData3,DiversionKeepBasisData4,DiversionKeepBasisData5,DiversionKeepBasisData6,DiversionKeepBasisData7,DiversionKeepBasisData8,btKeepDistance,KeepDistanceData,btTraceType,btTraceBoundary,TraceData,btHomingType,HomingData,btAggressTypeOnHoming,btFleeType,dwChampionTacticsID,AdditionOptionFlag,szDescString128) VALUES\r\n(@MAXTACTICS,@MOBID,0,500,50,200,0,0,2,2,2,0,0,5,0,0,0,0,0,30,0,0,4,0,0,0,0,0,0,0,0,0,0,0,1,500,0,0,2,0,0,112,@UNIQUE) \r\n\r\n\r\n\r\n\r\n\r\n\r\nINSERT INTO Tab_RefHive (dwHiveID,btKeepMonsterCountType,dwOverwriteMaxTotalCount,fMonsterCountPerPC,dwSpawnSpeedIncreaseRate,dwMaxIncreaseRate,btFlag,GameWorldID,HatchObjType,szDescString128) VALUES \r\n(@MAXHIVE,0,1,0,0,0,0,1,1,@UNIQUE) \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nDECLARE @REGION INT SET @REGION = (SELECT (LatestRegion) FROM _Char WHERE CharName16 = @CHARNAME) \r\nDECLARE @POSX INT SET @POSX = (SELECT (POSX) FROM _Char WHERE CharName16 = @CHARNAME) \r\nDECLARE @POSY INT SET @POSY = (SELECT (POSY) FROM _Char WHERE CharName16 = @CHARNAME) \r\nDECLARE @POSZ INT SET @POSZ = (SELECT (POSZ) FROM _Char WHERE CharName16 = @CHARNAME) \r\n\r\n\r\n\r\n\r\n\r\nINSERT INTO Tab_RefNest (dwNestID,dwHiveID,dwTacticsID,nRegionDBID,fLocalPosX,fLocalPosY,fLocalPosZ,wInitialDir,nRadius,nGenerateRadius,nChampionGenPercentage,dwDelayTimeMin,dwDelayTimeMax,dwMaxTotalCount,btFlag,btRespawn,btType) VALUES \r\n(@MAXNEST,@MAXHIVE,@MAXTACTICS,@REGION,@POSX,@POSY,@POSZ,0,@RADIUS,@INITRADIUS,0,@mindealy,@maxdelay,1,0,1,0)";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Successfully Added Spawn");
                    }
                    else
                        MessageBox.Show("Başarı İle Spawn Eklendi");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spawn));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spawn Olucak Unique Kodu :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X Y Z Koordinatlarini alacağı karakterin ismi :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saniyede bir belirdikten önce min. süre :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(327, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(130, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saniyede bir belirdikten önce max. süre :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(327, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unique\'nin belirdiği Spotun Çevresi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(79, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Unique\'nin hareket ettiği spotun (bölgenin) Çevresi :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(327, 131);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(178, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(327, 157);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 20);
            this.textBox6.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(6, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 253);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spawn Ekleme";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Coral;
            this.label13.Location = new System.Drawing.Point(510, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Örnek = 500";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Coral;
            this.label12.Location = new System.Drawing.Point(510, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Örnek = 100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(510, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Örnek = 120\'saniye";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(510, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Örnek = 60\'saniye";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(510, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Örnek = ServerEdit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(510, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Örnek = MOB_RM_ROC";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(327, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(132, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(453, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "                NOT : Unigue\'yi nereye Spawn etmek İstiyorsanız\r\nKarakterinizi Or" +
    "aya Götürünüz.Ve Karakterden Çıkınız Çıktıktn Sonra\r\n                      Progr" +
    "am ile Unigue Spanw Ekleye Bilirsiniz..";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 340);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(692, 65);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // spawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(724, 349);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "spawn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unigue Spawn Ekle";
            this.Load += new System.EventHandler(this.spawn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
