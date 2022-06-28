using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class npctası : Form
	{
		private IContainer components = null;

		private GroupBox groupBox1;

		private Button button1;

		private TextBox textBox2;

		private TextBox textBox1;

		private Label label2;

		private Label label1;
        private GroupBox groupBox2;
        private Label label3;

		public npctası()
		{
			InitializeComponent();
		}

		private void npctası_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Language.Default.language == "English")
            {
                this.Text = "Npc Migration Process";
                label3.Text = "          Wherever you want to move Npc.. Take your character there.\r\n           And leave the character and write that character name here..\r\nNOTE: The Npc Migration Process will not be active before the Res is\r\n           taken to GameServer.";
                groupBox1.Text = "Npc Move";
                label1.Text = "Char name where Npc will be placed :";
                label2.Text = "Npc's Code :";
                button1.Text = "Move";
                label1.Location = new Point(23, 49);
                label2.Location = new Point(139, 89);
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
					sqlCommand.CommandText = "\r\nDECLARE @charname1 VARCHAR (30)\r\nDECLARE @NPCPOS VARCHAR (MAX)\r\nDECLARE @ID INT\r\nDECLARE @TACTICSID INT\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nSET @charname1 = '" + textBox1.Text + "' -- NPC NİN KOCAĞI YERDEKİ CHAR İSMİ\r\nSET @NPCPOS = '" + textBox2.Text + "' -- NPC NİN KODU\r\n\r\n\r\n\r\n\r\n\r\n\r\nDECLARE @regiON1 INT SET @regiON1 = (SELECT (LatestRegion) FROM _Char WHERE CharName16 = @charname1)\r\nDECLARE @posX1 INT SET @posX1 = (SELECT (POSX) FROM _Char WHERE CharName16 = @charname1)\r\nDECLARE @posY1 INT SET @posY1 = (SELECT (POSY) FROM _Char WHERE CharName16 = @charname1)\r\nDECLARE @posZ1 INT SET @posZ1 = (SELECT (POSZ) FROM _Char WHERE CharName16 = @charname1)\r\nSET @ID = (SELECT ID FROM _RefObjCommon WHERE CodeName128=@NPCPOS)\r\nSET @TACTICSID =(SELECT dwTacticsID FROM Tab_RefTactics WHERE dwObjID=@ID)\r\n\r\n\r\n\r\n\r\nUPDATE Tab_RefNest SET fLocalPosX= @posX1,fLocalPosY= @posY1,fLocalPosZ= @posZ1,nRegionDBID= @regiON1 WHERE dwTacticsID=@TACTICSID";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();

                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Npc Migration Successful.");
                    }
                    else
                    {
                        MessageBox.Show("Npc Taşıma İşlemi Başarılı.");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(npctası));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Npc Taşıma";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(210, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Taşı";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Npc\'nin Kodu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Npc\'nin Konacağı Yerdeki Char ismi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(5, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // npctası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(463, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "npctası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Npc Taşıma İşlemi";
            this.Load += new System.EventHandler(this.npctası_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
