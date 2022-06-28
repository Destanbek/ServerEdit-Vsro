using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class bluevermek : Form
	{
		private IContainer components = null;

		private Label label17;

		private TextBox textBox1;

		private Button button2;

		private Label label3;

		private TextBox textBox2;

		private DataGridView dataGridView1;

		private Button button1;

		private Label label1;

		private Label label2;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox15;
        private Label label14;
        private GroupBox groupBox14;
        private Label label16;
        private GroupBox groupBox13;
        private Label label13;
        private GroupBox groupBox12;
        private Label label12;
        private GroupBox groupBox11;
        private Label label15;
        private GroupBox groupBox10;
        private Label label7;
        private GroupBox groupBox9;
        private Label label8;
        private GroupBox groupBox8;
        private Label label9;
        private GroupBox groupBox7;
        private Label label4;
        private GroupBox groupBox6;
        private Label label5;
        private GroupBox groupBox5;
        private Label label6;
        private GroupBox groupBox4;
        private Label label10;
        private ComboBox comboBox1;

		public bluevermek()
		{
			InitializeComponent();
		}

		private void bluevermek_Load(object sender, EventArgs e)
		{
            if (Language.Default.language == "English")
            {
                this.Text = "Give Blue";
                label1.Text = "Char Nick :";
                label17.Text = "Important note!!: Items must be mounted on the char.";
                groupBox2.Text = "Meaning of Slot Part";
                label10.Text = "0=Head";
                label6.Text = "1=Chest";
                label5.Text = "2=Shoulder";
                label4.Text = "3=Hands";
                label9.Text = "4=Legs";
                label8.Text = "5=Foot";
                label7.Text = "6=Weapon";
                label15.Text = "7=Sheld";
                label12.Text = "9=Earring";
                label13.Text = "10=Necklace";
                label16.Text = "11=Ring";
                label14.Text = "12=Ring2";
                label2.Text = "ItemType :";
                label3.Text = "ItemID :";
                button1.Text = "Find";
                button2.Text = "Give Blue";
                comboBox1.Items.Remove("Silah"); comboBox1.Items.Remove("Kıyafet"); comboBox1.Items.Remove("Takı");
                comboBox1.Items.Add("Weapon"); comboBox1.Items.Add("Clothes"); comboBox1.Items.Add("Accessory");
                label1.Location = new Point(21,16);
                label3.Location = new Point(18,54);
            }

        }

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection selectConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (DataTable dataTable = new DataTable())
				{
					using (new SqlCommand())
					{
						dataTable.Clear();
						new SqlDataAdapter("select ID64,CodeName128,Slot from _RefObjCommon\r\ninner join _Items\r\non _Items.RefItemID=_RefObjCommon.ID\r\ninner join _Inventory\r\non Slot between 0 and 12 and _Inventory.ItemID <> 0 and _Inventory.ItemID=_Items.ID64\r\ninner join _Char\r\non _Char.CharName16='" + textBox1.Text + "' and _Inventory.CharID=_Char.CharID ", selectConnection).Fill(dataTable);
						dataGridView1.DataSource = dataTable;
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
            if (Language.Default.language == "English")
            {
            using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					try
					{
						if ((textBox1.Text != "") & (textBox2.Text != "") & (comboBox1.Text != ""))
						{
							sqlConnection.Open();
							sqlCommand.Connection = sqlConnection;
							if (comboBox1.SelectedItem.ToString() == "Weapon")
							{
								sqlCommand.CommandText = "UPDATE dbo._Items set MagParamNum='4',MagParam1='30064771144',MagParam2= '30064771150',MagParam3='858993459290',MagParam4= '257698037862' WHERE ID64='" + textBox2.Text + "' ";
								sqlCommand.ExecuteNonQuery();
								MessageBox.Show("Successfully awarded the gun blue.");
								Close();
							}
							else if (comboBox1.SelectedItem.ToString() == "Clothes")
							{
								sqlCommand.CommandText = "UPDATE dbo._Items set MagParamNum='5',MagParam1='30064771144',MagParam2= '30064771150',MagParam3='5583457484962',MagParam4= '5583457484950',MagParam5= '858993459290' WHERE ID64='" + textBox2.Text + "' ";
								sqlCommand.ExecuteNonQuery();
								MessageBox.Show("The outfit was given blue with success.");
								Close();
							}
							else if (comboBox1.SelectedItem.ToString() == "Accessory")
							{
								sqlCommand.CommandText = "UPDATE dbo._Items set MagParamNum='7',MagParam1='30064771144',MagParam2= '30064771150',MagParam3='85899346100',MagParam4= '85899346094',MagParam5= '85899346088',MagParam6= '85899346106',MagParam7= '85899346112' WHERE ID64='" + textBox2.Text + "' ";
								sqlCommand.ExecuteNonQuery();
								MessageBox.Show("The Accessory was awarded blue with success.");
								Close();
							}
						}
						else
						{
							MessageBox.Show("Make sure you fill in all fields!");
						}
					}
					catch
					{
						MessageBox.Show("You have incorrectly selected the Char Name or Weapon-Set-Accessory part!");
					}
				}
			}
        }
            else
            {
            using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					try
					{
						if ((textBox1.Text != "") & (textBox2.Text != "") & (comboBox1.Text != ""))
						{
							sqlConnection.Open();
							sqlCommand.Connection = sqlConnection;
							if (comboBox1.SelectedItem.ToString() == "Silah")
							{
								sqlCommand.CommandText = "UPDATE dbo._Items set MagParamNum='4',MagParam1='30064771144',MagParam2= '30064771150',MagParam3='858993459290',MagParam4= '257698037862' WHERE ID64='" + textBox2.Text + "' ";
								sqlCommand.ExecuteNonQuery();
								MessageBox.Show("Silah'a başarı ile blue verildi.");
								Close();
							}
							else if (comboBox1.SelectedItem.ToString() == "Kıyafet")
							{
								sqlCommand.CommandText = "UPDATE dbo._Items set MagParamNum='5',MagParam1='30064771144',MagParam2= '30064771150',MagParam3='5583457484962',MagParam4= '5583457484950',MagParam5= '858993459290' WHERE ID64='" + textBox2.Text + "' ";
								sqlCommand.ExecuteNonQuery();
								MessageBox.Show("Kıyafet'e başarı ile blue verildi.");
								Close();
							}
							else if (comboBox1.SelectedItem.ToString() == "Takı")
							{
								sqlCommand.CommandText = "UPDATE dbo._Items set MagParamNum='7',MagParam1='30064771144',MagParam2= '30064771150',MagParam3='85899346100',MagParam4= '85899346094',MagParam5= '85899346088',MagParam6= '85899346106',MagParam7= '85899346112' WHERE ID64='" + textBox2.Text + "' ";
								sqlCommand.ExecuteNonQuery();
								MessageBox.Show("Takıya başarı ile blue verildi.");
								Close();
							}
						}
						else
						{
							MessageBox.Show("Tüm Alanları Doldurduğunuzdan Emin Olun!");
						}
					}
					catch
					{
						MessageBox.Show("Char İsmi Yanlış yada Silah-Set-Takı kısmını yanlış seçtiniz!");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bluevermek));
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(77, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(231, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Önemli not!!:İtemler charın üstüne takılı olmalıdır.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(63, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 31);
            this.button2.TabIndex = 33;
            this.button2.Text = "Blue Ver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "İtem ID\'si :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 160);
            this.dataGridView1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(184, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Karakter Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "İtem Türü :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Silah",
            "Kıyafet",
            "Takı"});
            this.comboBox1.Location = new System.Drawing.Point(63, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 120);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Properties.Resources.invertor;
            this.pictureBox1.Location = new System.Drawing.Point(561, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 61);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox15);
            this.groupBox2.Controls.Add(this.groupBox14);
            this.groupBox2.Controls.Add(this.groupBox13);
            this.groupBox2.Controls.Add(this.groupBox12);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.ForeColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Location = new System.Drawing.Point(418, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 351);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slot Kısmının Anlamı";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label14);
            this.groupBox15.Location = new System.Drawing.Point(6, 314);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(125, 28);
            this.groupBox15.TabIndex = 48;
            this.groupBox15.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(5, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "12=Yüzük2";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label16);
            this.groupBox14.Location = new System.Drawing.Point(6, 287);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(125, 28);
            this.groupBox14.TabIndex = 48;
            this.groupBox14.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(5, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "11=Yüzük";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label13);
            this.groupBox13.Location = new System.Drawing.Point(6, 258);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(125, 28);
            this.groupBox13.TabIndex = 48;
            this.groupBox13.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(5, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "10=Kolye";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Location = new System.Drawing.Point(6, 230);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(125, 28);
            this.groupBox12.TabIndex = 48;
            this.groupBox12.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(5, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "9=Küpe";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Location = new System.Drawing.Point(6, 202);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(125, 28);
            this.groupBox11.TabIndex = 48;
            this.groupBox11.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Yellow;
            this.label15.Location = new System.Drawing.Point(5, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "7=Kalkan";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Location = new System.Drawing.Point(6, 174);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(125, 28);
            this.groupBox10.TabIndex = 48;
            this.groupBox10.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(6, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "6=Silah";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Location = new System.Drawing.Point(6, 147);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(125, 28);
            this.groupBox9.TabIndex = 48;
            this.groupBox9.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "5=Ayaklık";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Location = new System.Drawing.Point(6, 120);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(125, 28);
            this.groupBox8.TabIndex = 48;
            this.groupBox8.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(5, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "4=Bacaklık";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(6, 93);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(125, 28);
            this.groupBox7.TabIndex = 48;
            this.groupBox7.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "3=Kolluk";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(6, 66);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(125, 28);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "2=Omuzluk";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(6, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 28);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "1=Gövdelik";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(6, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 28);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "0=Kafalık";
            // 
            // bluevermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(767, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bluevermek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Ver";
            this.Load += new System.EventHandler(this.bluevermek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
