using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class elite : Form
	{
		private IContainer components = null;

		private Label label1;

		private Button button1;

		private GroupBox groupBox1;

		private Label label7;

		private GroupBox groupBox2;

		private Label label8;

		private Label label2;

		private Button button2;

		private GroupBox groupBox3;

		private Label label9;

		private Label label3;

		private Button button3;

		private GroupBox groupBox4;

		private Label label10;

		private Label label4;

		private Button button4;

		private GroupBox groupBox5;

		private Label label11;

		private Label label5;

		private Button button5;

		private GroupBox groupBox6;

		private Label label12;

		private Label label6;

		private Button button6;

		private GroupBox groupBox7;

		private Label label13;

		private Label label14;

		private Button button7;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elite));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(114, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elitelerini Kaldır..";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(249, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kaldır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(40, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tiger Gril :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 42);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(46, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cerberus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(114, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Elitelerini Kaldır..";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(249, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kaldır";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(12, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 42);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(30, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "Captain Ivy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(114, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Elitelerini Kaldır..";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(250, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Kaldır";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(12, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 42);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(63, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 5;
            this.label10.Text = "Uruchi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(114, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Elitelerini Kaldır..";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(249, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "Kaldır";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Location = new System.Drawing.Point(12, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 42);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(50, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 14);
            this.label11.TabIndex = 6;
            this.label11.Text = "Isyutaru:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(114, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Elitelerini Kaldır..";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.ForeColor = System.Drawing.Color.Yellow;
            this.button5.Location = new System.Drawing.Point(249, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 28);
            this.button5.TabIndex = 1;
            this.button5.Text = "Kaldır";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Location = new System.Drawing.Point(12, 253);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(351, 42);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(24, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 14);
            this.label12.TabIndex = 7;
            this.label12.Text = "Lord Yarkan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(114, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Elitelerini Kaldır..";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.ForeColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(249, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "Kaldır";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Location = new System.Drawing.Point(12, 303);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(351, 42);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 14);
            this.label13.TabIndex = 7;
            this.label13.Text = "Demon Shaitan:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Salmon;
            this.label14.Location = new System.Drawing.Point(118, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "Elitelerini Kaldır...";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.ForeColor = System.Drawing.Color.Yellow;
            this.button7.Location = new System.Drawing.Point(249, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 28);
            this.button7.TabIndex = 1;
            this.button7.Text = "Kaldır";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // elite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(385, 357);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "elite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vsro Unig Elite Kaldırma";
            this.Load += new System.EventHandler(this.elite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

		}

		public elite()
		{
			InitializeComponent();
		}

		private void elite_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Language.Default.language == "English")
            {
                this.Text = "Unique Elite Removal";
                label1.Text = "Remove Elite..";
                label2.Text = "Remove Elite..";
                label3.Text = "Remove Elite..";
                label4.Text = "Remove Elite..";
                label5.Text = "Remove Elite..";
                label6.Text = "Remove Elite..";
                label14.Text = "Remove Elite..";
                button1.Text = "Remove";
                button2.Text = "Remove";
                button3.Text = "Remove";
                button4.Text = "Remove";
                button5.Text = "Remove";
                button6.Text = "Remove";
                button7.Text = "Remove";
                groupBox1.Size = groupBox2.Size = groupBox3.Size = groupBox4.Size = groupBox5.Size = groupBox6.Size = groupBox7.Size = new Size(340,42);
                button1.Location = button2.Location = button3.Location = button4.Location = button5.Location = button6.Location = button7.Location = new Point(224, 9);
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
					sqlCommand.CommandText = "\r\ndeclare @uniq1 varchar (64) = 'MOB_CH_TIGERWOMAN_L3'\r\ndeclare @UniQ2 varchar (64) = 'MOB_CH_TIGERWOMAN'\r\ndeclare @id1 int = (select link from _RefObjCommon where CodeName128 = @uniq1)\r\ndeclare @id2 int = (select link from _RefObjCommon where CodeName128 = @UniQ2)\r\ndeclare @skill1 int = (select DefaultSkill_1 from _RefObjChar where ID = @id1)\r\ndeclare @skill2 int = (select DefaultSkill_2 from _RefObjChar where ID = @id1)\r\ndeclare @skill3 int = (select DefaultSkill_3 from _RefObjChar where ID = @id1)\r\ndeclare @skill4 int = (select DefaultSkill_4 from _RefObjChar where ID = @id1)\r\ndeclare @skill5 int = (select DefaultSkill_5 from _RefObjChar where ID = @id1)\r\ndeclare @skill6 int = (select DefaultSkill_6 from _RefObjChar where ID = @id1)\r\ndeclare @skill7 int = (select DefaultSkill_7 from _RefObjChar where ID = @id1)\r\ndeclare @skill8 int = (select DefaultSkill_8 from _RefObjChar where ID = @id1)\r\ndeclare @skill9 int = (select DefaultSkill_9 from _RefObjChar where ID = @id1)\r\ndeclare @skill10 int = (select DefaultSkill_10 from _RefObjChar where ID = @id1)\r\n\r\n\r\n\r\n\r\nupdate _RefObjChar set\r\nDefaultSkill_1 = @skill1,\r\nDefaultSkill_2 = @skill2,\r\nDefaultSkill_3 = @skill3,\r\nDefaultSkill_4 = @skill4,\r\nDefaultSkill_5 = @skill5,\r\nDefaultSkill_6 = @skill6,\r\nDefaultSkill_7 = @skill7,\r\nDefaultSkill_8 = @skill8,\r\nDefaultSkill_9 = @skill9,\r\nDefaultSkill_10 = @skill10 where ID=@id2 ";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Elite Removed.");
                    }
                    else
                    {
                        MessageBox.Show("Eliteler Kaldırıldı.");
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
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "\r\ndeclare @uniq1 varchar (64) = 'MOB_EU_KERBEROS_L3'\r\ndeclare @UniQ2 varchar (64) = 'MOB_EU_KERBEROS'\r\ndeclare @id1 int = (select link from _RefObjCommon where CodeName128 = @uniq1)\r\ndeclare @id2 int = (select link from _RefObjCommon where CodeName128 = @UniQ2)\r\ndeclare @skill1 int = (select DefaultSkill_1 from _RefObjChar where ID = @id1)\r\ndeclare @skill2 int = (select DefaultSkill_2 from _RefObjChar where ID = @id1)\r\ndeclare @skill3 int = (select DefaultSkill_3 from _RefObjChar where ID = @id1)\r\ndeclare @skill4 int = (select DefaultSkill_4 from _RefObjChar where ID = @id1)\r\ndeclare @skill5 int = (select DefaultSkill_5 from _RefObjChar where ID = @id1)\r\ndeclare @skill6 int = (select DefaultSkill_6 from _RefObjChar where ID = @id1)\r\ndeclare @skill7 int = (select DefaultSkill_7 from _RefObjChar where ID = @id1)\r\ndeclare @skill8 int = (select DefaultSkill_8 from _RefObjChar where ID = @id1)\r\ndeclare @skill9 int = (select DefaultSkill_9 from _RefObjChar where ID = @id1)\r\ndeclare @skill10 int = (select DefaultSkill_10 from _RefObjChar where ID = @id1)\r\n\r\n\r\n\r\n\r\nupdate _RefObjChar set\r\nDefaultSkill_1 = @skill1,\r\nDefaultSkill_2 = @skill2,\r\nDefaultSkill_3 = @skill3,\r\nDefaultSkill_4 = @skill4,\r\nDefaultSkill_5 = @skill5,\r\nDefaultSkill_6 = @skill6,\r\nDefaultSkill_7 = @skill7,\r\nDefaultSkill_8 = @skill8,\r\nDefaultSkill_9 = @skill9,\r\nDefaultSkill_10 = @skill10 where ID=@id2 ";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Elite Removed.");
                    }
                    else
                    {
                        MessageBox.Show("Eliteler Kaldırıldı.");
                    }
                }
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "\r\ndeclare @uniq1 varchar (64) = 'MOB_AM_IVY_L3'\r\ndeclare @UniQ2 varchar (64) = 'MOB_AM_IVY'\r\ndeclare @id1 int = (select link from _RefObjCommon where CodeName128 = @uniq1)\r\ndeclare @id2 int = (select link from _RefObjCommon where CodeName128 = @UniQ2)\r\ndeclare @skill1 int = (select DefaultSkill_1 from _RefObjChar where ID = @id1)\r\ndeclare @skill2 int = (select DefaultSkill_2 from _RefObjChar where ID = @id1)\r\ndeclare @skill3 int = (select DefaultSkill_3 from _RefObjChar where ID = @id1)\r\ndeclare @skill4 int = (select DefaultSkill_4 from _RefObjChar where ID = @id1)\r\ndeclare @skill5 int = (select DefaultSkill_5 from _RefObjChar where ID = @id1)\r\ndeclare @skill6 int = (select DefaultSkill_6 from _RefObjChar where ID = @id1)\r\ndeclare @skill7 int = (select DefaultSkill_7 from _RefObjChar where ID = @id1)\r\ndeclare @skill8 int = (select DefaultSkill_8 from _RefObjChar where ID = @id1)\r\ndeclare @skill9 int = (select DefaultSkill_9 from _RefObjChar where ID = @id1)\r\ndeclare @skill10 int = (select DefaultSkill_10 from _RefObjChar where ID = @id1)\r\n\r\n\r\n\r\n\r\nupdate _RefObjChar set\r\nDefaultSkill_1 = @skill1,\r\nDefaultSkill_2 = @skill2,\r\nDefaultSkill_3 = @skill3,\r\nDefaultSkill_4 = @skill4,\r\nDefaultSkill_5 = @skill5,\r\nDefaultSkill_6 = @skill6,\r\nDefaultSkill_7 = @skill7,\r\nDefaultSkill_8 = @skill8,\r\nDefaultSkill_9 = @skill9,\r\nDefaultSkill_10 = @skill10 where ID=@id2 ";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Elite Removed.");
                    }
                    else
                    {
                        MessageBox.Show("Eliteler Kaldırıldı.");
                    }
                }
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "\r\ndeclare @uniq1 varchar (64) = 'MOB_OA_URUCHI_L3'\r\ndeclare @UniQ2 varchar (64) = 'MOB_OA_URUCHI'\r\ndeclare @id1 int = (select link from _RefObjCommon where CodeName128 = @uniq1)\r\ndeclare @id2 int = (select link from _RefObjCommon where CodeName128 = @UniQ2)\r\ndeclare @skill1 int = (select DefaultSkill_1 from _RefObjChar where ID = @id1)\r\ndeclare @skill2 int = (select DefaultSkill_2 from _RefObjChar where ID = @id1)\r\ndeclare @skill3 int = (select DefaultSkill_3 from _RefObjChar where ID = @id1)\r\ndeclare @skill4 int = (select DefaultSkill_4 from _RefObjChar where ID = @id1)\r\ndeclare @skill5 int = (select DefaultSkill_5 from _RefObjChar where ID = @id1)\r\ndeclare @skill6 int = (select DefaultSkill_6 from _RefObjChar where ID = @id1)\r\ndeclare @skill7 int = (select DefaultSkill_7 from _RefObjChar where ID = @id1)\r\ndeclare @skill8 int = (select DefaultSkill_8 from _RefObjChar where ID = @id1)\r\ndeclare @skill9 int = (select DefaultSkill_9 from _RefObjChar where ID = @id1)\r\ndeclare @skill10 int = (select DefaultSkill_10 from _RefObjChar where ID = @id1)\r\n\r\n\r\n\r\n\r\nupdate _RefObjChar set\r\nDefaultSkill_1 = @skill1,\r\nDefaultSkill_2 = @skill2,\r\nDefaultSkill_3 = @skill3,\r\nDefaultSkill_4 = @skill4,\r\nDefaultSkill_5 = @skill5,\r\nDefaultSkill_6 = @skill6,\r\nDefaultSkill_7 = @skill7,\r\nDefaultSkill_8 = @skill8,\r\nDefaultSkill_9 = @skill9,\r\nDefaultSkill_10 = @skill10 where ID=@id2 ";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Elite Removed.");
                    }
                    else
                    {
                        MessageBox.Show("Eliteler Kaldırıldı.");
                    }
                }
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "\r\ndeclare @uniq1 varchar (64) = 'MOB_KK_ISYUTARU_L3'\r\ndeclare @UniQ2 varchar (64) = 'MOB_KK_ISYUTARU'\r\ndeclare @id1 int = (select link from _RefObjCommon where CodeName128 = @uniq1)\r\ndeclare @id2 int = (select link from _RefObjCommon where CodeName128 = @UniQ2)\r\ndeclare @skill1 int = (select DefaultSkill_1 from _RefObjChar where ID = @id1)\r\ndeclare @skill2 int = (select DefaultSkill_2 from _RefObjChar where ID = @id1)\r\ndeclare @skill3 int = (select DefaultSkill_3 from _RefObjChar where ID = @id1)\r\ndeclare @skill4 int = (select DefaultSkill_4 from _RefObjChar where ID = @id1)\r\ndeclare @skill5 int = (select DefaultSkill_5 from _RefObjChar where ID = @id1)\r\ndeclare @skill6 int = (select DefaultSkill_6 from _RefObjChar where ID = @id1)\r\ndeclare @skill7 int = (select DefaultSkill_7 from _RefObjChar where ID = @id1)\r\ndeclare @skill8 int = (select DefaultSkill_8 from _RefObjChar where ID = @id1)\r\ndeclare @skill9 int = (select DefaultSkill_9 from _RefObjChar where ID = @id1)\r\ndeclare @skill10 int = (select DefaultSkill_10 from _RefObjChar where ID = @id1)\r\n\r\n\r\n\r\n\r\nupdate _RefObjChar set\r\nDefaultSkill_1 = @skill1,\r\nDefaultSkill_2 = @skill2,\r\nDefaultSkill_3 = @skill3,\r\nDefaultSkill_4 = @skill4,\r\nDefaultSkill_5 = @skill5,\r\nDefaultSkill_6 = @skill6,\r\nDefaultSkill_7 = @skill7,\r\nDefaultSkill_8 = @skill8,\r\nDefaultSkill_9 = @skill9,\r\nDefaultSkill_10 = @skill10 where ID=@id2 ";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Elite Removed.");
                    }
                    else
                    {
                        MessageBox.Show("Eliteler Kaldırıldı.");
                    }
                }
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "\r\ndeclare @uniq1 varchar (64) = 'MOB_TK_BONELORD_L3'\r\ndeclare @UniQ2 varchar (64) = 'MOB_TK_BONELORD'\r\ndeclare @id1 int = (select link from _RefObjCommon where CodeName128 = @uniq1)\r\ndeclare @id2 int = (select link from _RefObjCommon where CodeName128 = @UniQ2)\r\ndeclare @skill1 int = (select DefaultSkill_1 from _RefObjChar where ID = @id1)\r\ndeclare @skill2 int = (select DefaultSkill_2 from _RefObjChar where ID = @id1)\r\ndeclare @skill3 int = (select DefaultSkill_3 from _RefObjChar where ID = @id1)\r\ndeclare @skill4 int = (select DefaultSkill_4 from _RefObjChar where ID = @id1)\r\ndeclare @skill5 int = (select DefaultSkill_5 from _RefObjChar where ID = @id1)\r\ndeclare @skill6 int = (select DefaultSkill_6 from _RefObjChar where ID = @id1)\r\ndeclare @skill7 int = (select DefaultSkill_7 from _RefObjChar where ID = @id1)\r\ndeclare @skill8 int = (select DefaultSkill_8 from _RefObjChar where ID = @id1)\r\ndeclare @skill9 int = (select DefaultSkill_9 from _RefObjChar where ID = @id1)\r\ndeclare @skill10 int = (select DefaultSkill_10 from _RefObjChar where ID = @id1)\r\n\r\n\r\n\r\n\r\nupdate _RefObjChar set\r\nDefaultSkill_1 = @skill1,\r\nDefaultSkill_2 = @skill2,\r\nDefaultSkill_3 = @skill3,\r\nDefaultSkill_4 = @skill4,\r\nDefaultSkill_5 = @skill5,\r\nDefaultSkill_6 = @skill6,\r\nDefaultSkill_7 = @skill7,\r\nDefaultSkill_8 = @skill8,\r\nDefaultSkill_9 = @skill9,\r\nDefaultSkill_10 = @skill10 where ID=@id2 ";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Elite Removed.");
                    }
                    else
                    {
                        MessageBox.Show("Eliteler Kaldırıldı.");
                    }
                }
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					sqlConnection.Open();
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandText = "\r\ndeclare @uniq1 varchar (64) = 'MOB_RM_TAHOMET_L3'\r\ndeclare @UniQ2 varchar (64) = 'MOB_RM_TAHOMET'\r\ndeclare @id1 int = (select link from _RefObjCommon where CodeName128 = @uniq1)\r\ndeclare @id2 int = (select link from _RefObjCommon where CodeName128 = @UniQ2)\r\ndeclare @skill1 int = (select DefaultSkill_1 from _RefObjChar where ID = @id1)\r\ndeclare @skill2 int = (select DefaultSkill_2 from _RefObjChar where ID = @id1)\r\ndeclare @skill3 int = (select DefaultSkill_3 from _RefObjChar where ID = @id1)\r\ndeclare @skill4 int = (select DefaultSkill_4 from _RefObjChar where ID = @id1)\r\ndeclare @skill5 int = (select DefaultSkill_5 from _RefObjChar where ID = @id1)\r\ndeclare @skill6 int = (select DefaultSkill_6 from _RefObjChar where ID = @id1)\r\ndeclare @skill7 int = (select DefaultSkill_7 from _RefObjChar where ID = @id1)\r\ndeclare @skill8 int = (select DefaultSkill_8 from _RefObjChar where ID = @id1)\r\ndeclare @skill9 int = (select DefaultSkill_9 from _RefObjChar where ID = @id1)\r\ndeclare @skill10 int = (select DefaultSkill_10 from _RefObjChar where ID = @id1)\r\n\r\n\r\n\r\n\r\nupdate _RefObjChar set\r\nDefaultSkill_1 = @skill1,\r\nDefaultSkill_2 = @skill2,\r\nDefaultSkill_3 = @skill3,\r\nDefaultSkill_4 = @skill4,\r\nDefaultSkill_5 = @skill5,\r\nDefaultSkill_6 = @skill6,\r\nDefaultSkill_7 = @skill7,\r\nDefaultSkill_8 = @skill8,\r\nDefaultSkill_9 = @skill9,\r\nDefaultSkill_10 = @skill10 where ID=@id2 ";
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
                    if (Language.Default.language == "English")
                    {
                        MessageBox.Show("Elite Removed.");
                    }
                    else
                    {
                        MessageBox.Show("Eliteler Kaldırıldı.");
                    }
                }
			}
		}
	}
}
