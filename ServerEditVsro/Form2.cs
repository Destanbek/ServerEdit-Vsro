using ServerEditVsro.ProgramDataSet1TableAdapters;
using ServerEditVsro.ProgramDataSet2TableAdapters;
using ServerEditVsro.ProgramDataSet3TableAdapters;
using ServerEditVsro.ProgramDataSetTableAdapters;
using ServerEditVsro.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class Form2 : Form
	{
		private IContainer components = null;

		private SqlCommand Cmd = new SqlCommand();

		private DataTable tablo = new DataTable();

		private ImageList ımageList1;

		public Timer Ping;

		private Timer timer2;

		private Timer timer1;

		private TabPage tabPage4;

		private TabPage tabPage3;

		private Button button44;

		private Button button43;

		private Button button42;

		private Button button40;

		private Button button39;

		private Button button23;

		private Button button20;

		private Button button38;

		private Button button18;

		private Button button37;

		private Button button17;

		private Button button36;

		private Button button22;

		private Button button33;

		private Button button32;

		private TabPage tabPage2;

		private Button button41;

		private Button button19;

		private Button button10;

		private Button button13;

		private Button button11;

		private Button button14;

		private Button button12;

		private TabPage tabPage1;

		private Button button35;

		private Button button2;

		private Button button34;

		private Button button31;

		private Button button3;

		private Button button30;

		private Button button4;

		private Button button29;

		private Button button5;

		private Button button24;

		private Button button6;

		private Button button25;

		private Button button28;

		private Button button21;

		private Button button7;

		private Button button26;

		private Button button8;

		private Button button16;
        private GroupBox groupBox8;
        private Button button70;
        private ImageList ımageList3;
        private GroupBox groupBox10;
        private Button button15;
        private Label label8;
        private GroupBox groupBox4;
        private TextBox textBox3;
        private Button button27;

        internal void Restart()
        {
            throw new NotImplementedException();
        }

        private Button button9;

		private TabControl tabControl1;

		private Button button50;

		private Label label7;

		private Timer timer3;

		private GroupBox groupBox7;

		private Label label22;

		private Label label21;

		private Label label23;

		private Label label24;

		private Button button51;

		private TabPage tabPage5;

		private Button button53;

		private DataGridView dataGridView1;

		private GroupBox groupBox1;

		private Button button54;

		private TextBox textBox1;

		private Label label1;

		private GroupBox groupBox2;

		private Button button52;
        public ListBox listBox1;
        private Label label3;

		private Label label2;

		private Button button55;

		private Button button56;

		private Button button57;

		private Button button58;

		private Button button59;

		private Button button60;

		private Button button61;

		private GroupBox groupBox5;

		private GroupBox groupBox6;

		private TabPage tabPage6;

		private GroupBox groupBox9;

		private Button button64;

		private ProgramDataSet programDataSet;

		private BindingSource sponsorBindingSource;

		private SponsorTableAdapter sponsorTableAdapter;

		private ProgramDataSet1 programDataSet1;

		private BindingSource sponsor2BindingSource;

		private Sponsor2TableAdapter sponsor2TableAdapter;

		private ProgramDataSet2 programDataSet2;

		private BindingSource sponsor3BindingSource;

		private Sponsor3TableAdapter sponsor3TableAdapter;

		private ProgramDataSet3 programDataSet3;

		private BindingSource sponsor4BindingSource;
        private Button button1;
        private GroupBox groupBox3;
        private Button button67;
        private Button button49;
        private Button button66;
        private Button button48;
        private Button button65;
        private Button button47;
        private Button button63;
        private Button button46;
        private Button button62;
        private Button button45;
        private PictureBox pictureBox2;
        private Button button68;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button button69;
        private ImageList ımageList2;
        private Sponsor4TableAdapter sponsor4TableAdapter;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Ping = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button69 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button68 = new System.Windows.Forms.Button();
            this.button67 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button66 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button65 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button63 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button62 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button61 = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.button60 = new System.Windows.Forms.Button();
            this.button59 = new System.Windows.Forms.Button();
            this.button58 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button53 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button64 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button70 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button50 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button54 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sponsor4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programDataSet3 = new ServerEditVsro.ProgramDataSet3();
            this.sponsor3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programDataSet2 = new ServerEditVsro.ProgramDataSet2();
            this.sponsor2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programDataSet1 = new ServerEditVsro.ProgramDataSet1();
            this.sponsorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programDataSet = new ServerEditVsro.ProgramDataSet();
            this.sponsorTableAdapter = new ServerEditVsro.ProgramDataSetTableAdapters.SponsorTableAdapter();
            this.sponsor2TableAdapter = new ServerEditVsro.ProgramDataSet1TableAdapters.Sponsor2TableAdapter();
            this.sponsor3TableAdapter = new ServerEditVsro.ProgramDataSet2TableAdapters.Sponsor3TableAdapter();
            this.sponsor4TableAdapter = new ServerEditVsro.ProgramDataSet3TableAdapters.Sponsor4TableAdapter();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Notice-Info-icon (1).png");
            // 
            // Ping
            // 
            this.Ping.Enabled = true;
            this.Ping.Interval = 5000;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1097, 574);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Item kodları";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Properties.Resources.kapak;
            this.pictureBox2.Location = new System.Drawing.Point(91, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(917, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button69);
            this.groupBox3.Controls.Add(this.button68);
            this.groupBox3.Controls.Add(this.button67);
            this.groupBox3.Controls.Add(this.button49);
            this.groupBox3.Controls.Add(this.button66);
            this.groupBox3.Controls.Add(this.button48);
            this.groupBox3.Controls.Add(this.button65);
            this.groupBox3.Controls.Add(this.button47);
            this.groupBox3.Controls.Add(this.button63);
            this.groupBox3.Controls.Add(this.button46);
            this.groupBox3.Controls.Add(this.button62);
            this.groupBox3.Controls.Add(this.button45);
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(91, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(917, 270);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "YARDIMCI KODLAR";
            // 
            // button69
            // 
            this.button69.BackColor = System.Drawing.Color.RoyalBlue;
            this.button69.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button69.ImageIndex = 33;
            this.button69.ImageList = this.ımageList2;
            this.button69.Location = new System.Drawing.Point(307, 189);
            this.button69.Name = "button69";
            this.button69.Size = new System.Drawing.Size(142, 51);
            this.button69.TabIndex = 1;
            this.button69.Text = "       ROC (SET)";
            this.button69.UseVisualStyleBackColor = false;
            this.button69.Click += new System.EventHandler(this.button69_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "archemy_reinforce_recipe_weapon_b.bmp");
            this.ımageList2.Images.SetKeyName(1, "max_blue03.bmp");
            this.ımageList2.Images.SetKeyName(2, "archemy_element_wind.bmp");
            this.ımageList2.Images.SetKeyName(3, "trader_eu_01_01.bmp");
            this.ımageList2.Images.SetKeyName(4, "mall_change_name.bmp");
            this.ımageList2.Images.SetKeyName(5, "name_changer.png");
            this.ımageList2.Images.SetKeyName(6, "reset 3.png");
            this.ımageList2.Images.SetKeyName(7, "title_3.png");
            this.ımageList2.Images.SetKeyName(8, "title_scroll.jpg");
            this.ımageList2.Images.SetKeyName(9, "str-int.bmp");
            this.ımageList2.Images.SetKeyName(10, "prem remover2.png");
            this.ımageList2.Images.SetKeyName(11, "wanted_5.png");
            this.ımageList2.Images.SetKeyName(12, "sun_weapon_b.bmp");
            this.ımageList2.Images.SetKeyName(13, "test_crown_buff.bmp");
            this.ımageList2.Images.SetKeyName(14, "jobkills.bmp");
            this.ımageList2.Images.SetKeyName(15, "ga03.bmp");
            this.ımageList2.Images.SetKeyName(16, "stats100.bmp");
            this.ımageList2.Images.SetKeyName(17, "supporter.bmp");
            this.ımageList2.Images.SetKeyName(18, "mall_pre_apru_4w_start.bmp");
            this.ımageList2.Images.SetKeyName(19, "lucky_jc01.bmp");
            this.ımageList2.Images.SetKeyName(20, "500.png");
            this.ımageList2.Images.SetKeyName(21, "dragon_hero.bmp");
            this.ımageList2.Images.SetKeyName(22, "pvpkills.bmp");
            this.ımageList2.Images.SetKeyName(23, "rango_1b.bmp");
            this.ımageList2.Images.SetKeyName(24, "max_adv_4_stats.bmp");
            this.ımageList2.Images.SetKeyName(25, "tstaff_01.bmp");
            this.ımageList2.Images.SetKeyName(26, "clothes_01_ba.bmp");
            this.ımageList2.Images.SetKeyName(27, "ring_01.bmp");
            this.ımageList2.Images.SetKeyName(28, "archemy_reinforce_prob_up_a.bmp");
            this.ımageList2.Images.SetKeyName(29, "mall_avatar_m_koreandress.bmp");
            this.ımageList2.Images.SetKeyName(30, "eu_tstaff_11_set_a.bmp");
            this.ımageList2.Images.SetKeyName(31, "clothes_11_ba_set_a.bmp");
            this.ımageList2.Images.SetKeyName(32, "ch_necklace_11_set_a.bmp");
            this.ımageList2.Images.SetKeyName(33, "roc_clothes_ba.bmp");
            this.ımageList2.Images.SetKeyName(34, "manual_battlecamp.bmp");
            this.ımageList2.Images.SetKeyName(35, "mob_ch_tigerwoman.bmp");
            this.ımageList2.Images.SetKeyName(36, "egg_coin.bmp");
            // 
            // button68
            // 
            this.button68.BackColor = System.Drawing.Color.RoyalBlue;
            this.button68.ForeColor = System.Drawing.Color.Gold;
            this.button68.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button68.ImageIndex = 36;
            this.button68.ImageList = this.ımageList2;
            this.button68.Location = new System.Drawing.Point(455, 189);
            this.button68.Name = "button68";
            this.button68.Size = new System.Drawing.Size(129, 51);
            this.button68.TabIndex = 0;
            this.button68.Text = "        DIGER\r\n        ITEMLER";
            this.button68.UseVisualStyleBackColor = false;
            this.button68.Click += new System.EventHandler(this.button68_Click);
            // 
            // button67
            // 
            this.button67.BackColor = System.Drawing.Color.RoyalBlue;
            this.button67.ForeColor = System.Drawing.Color.Gold;
            this.button67.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button67.ImageIndex = 35;
            this.button67.ImageList = this.ımageList2;
            this.button67.Location = new System.Drawing.Point(667, 132);
            this.button67.Name = "button67";
            this.button67.Size = new System.Drawing.Size(129, 51);
            this.button67.TabIndex = 0;
            this.button67.Text = "        UNIQUES";
            this.button67.UseVisualStyleBackColor = false;
            this.button67.Click += new System.EventHandler(this.button67_Click);
            // 
            // button49
            // 
            this.button49.BackColor = System.Drawing.Color.RoyalBlue;
            this.button49.ForeColor = System.Drawing.Color.Gold;
            this.button49.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button49.ImageIndex = 29;
            this.button49.ImageList = this.ımageList2;
            this.button49.Location = new System.Drawing.Point(667, 75);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(129, 51);
            this.button49.TabIndex = 0;
            this.button49.Text = "        KOSTUM";
            this.button49.UseVisualStyleBackColor = false;
            this.button49.Click += new System.EventHandler(this.button49_Click_1);
            // 
            // button66
            // 
            this.button66.BackColor = System.Drawing.Color.RoyalBlue;
            this.button66.ForeColor = System.Drawing.Color.Gold;
            this.button66.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button66.ImageIndex = 34;
            this.button66.ImageList = this.ımageList2;
            this.button66.Location = new System.Drawing.Point(532, 132);
            this.button66.Name = "button66";
            this.button66.Size = new System.Drawing.Size(129, 51);
            this.button66.TabIndex = 0;
            this.button66.Text = "             WARP KODU";
            this.button66.UseVisualStyleBackColor = false;
            this.button66.Click += new System.EventHandler(this.button66_Click);
            // 
            // button48
            // 
            this.button48.BackColor = System.Drawing.Color.RoyalBlue;
            this.button48.ForeColor = System.Drawing.Color.Gold;
            this.button48.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button48.ImageIndex = 28;
            this.button48.ImageList = this.ımageList2;
            this.button48.Location = new System.Drawing.Point(532, 75);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(129, 51);
            this.button48.TabIndex = 0;
            this.button48.Text = "        SIMYA";
            this.button48.UseVisualStyleBackColor = false;
            this.button48.Click += new System.EventHandler(this.button48_Click_1);
            // 
            // button65
            // 
            this.button65.BackColor = System.Drawing.Color.RoyalBlue;
            this.button65.ForeColor = System.Drawing.Color.Gold;
            this.button65.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button65.ImageIndex = 32;
            this.button65.ImageList = this.ımageList2;
            this.button65.Location = new System.Drawing.Point(397, 132);
            this.button65.Name = "button65";
            this.button65.Size = new System.Drawing.Size(129, 51);
            this.button65.TabIndex = 0;
            this.button65.Text = "               MISIR \r\n             AKSESUAR";
            this.button65.UseVisualStyleBackColor = false;
            this.button65.Click += new System.EventHandler(this.button65_Click);
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.RoyalBlue;
            this.button47.ForeColor = System.Drawing.Color.Gold;
            this.button47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button47.ImageIndex = 27;
            this.button47.ImageList = this.ımageList2;
            this.button47.Location = new System.Drawing.Point(397, 75);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(129, 51);
            this.button47.TabIndex = 0;
            this.button47.Text = "            AKSESUAR";
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.button47_Click_1);
            // 
            // button63
            // 
            this.button63.BackColor = System.Drawing.Color.RoyalBlue;
            this.button63.ForeColor = System.Drawing.Color.Gold;
            this.button63.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button63.ImageIndex = 31;
            this.button63.ImageList = this.ımageList2;
            this.button63.Location = new System.Drawing.Point(262, 132);
            this.button63.Name = "button63";
            this.button63.Size = new System.Drawing.Size(129, 51);
            this.button63.TabIndex = 0;
            this.button63.Text = "             MISIR ZIRH \r\n         (SET)";
            this.button63.UseVisualStyleBackColor = false;
            this.button63.Click += new System.EventHandler(this.button63_Click);
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.Color.RoyalBlue;
            this.button46.ForeColor = System.Drawing.Color.Gold;
            this.button46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button46.ImageIndex = 26;
            this.button46.ImageList = this.ımageList2;
            this.button46.Location = new System.Drawing.Point(262, 75);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(129, 51);
            this.button46.TabIndex = 0;
            this.button46.Text = "   ZIRH";
            this.button46.UseVisualStyleBackColor = false;
            this.button46.Click += new System.EventHandler(this.button46_Click_1);
            // 
            // button62
            // 
            this.button62.BackColor = System.Drawing.Color.RoyalBlue;
            this.button62.ForeColor = System.Drawing.Color.Gold;
            this.button62.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button62.ImageIndex = 30;
            this.button62.ImageList = this.ımageList2;
            this.button62.Location = new System.Drawing.Point(127, 132);
            this.button62.Name = "button62";
            this.button62.Size = new System.Drawing.Size(129, 51);
            this.button62.TabIndex = 0;
            this.button62.Text = "          MISIR SILAH";
            this.button62.UseVisualStyleBackColor = false;
            this.button62.Click += new System.EventHandler(this.button62_Click);
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.Color.RoyalBlue;
            this.button45.ForeColor = System.Drawing.Color.Gold;
            this.button45.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button45.ImageIndex = 25;
            this.button45.ImageList = this.ımageList2;
            this.button45.Location = new System.Drawing.Point(127, 75);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(129, 51);
            this.button45.TabIndex = 0;
            this.button45.Text = "     SILAH";
            this.button45.UseVisualStyleBackColor = false;
            this.button45.Click += new System.EventHandler(this.button45_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage3.Controls.Add(this.button61);
            this.tabPage3.Controls.Add(this.button60);
            this.tabPage3.Controls.Add(this.button59);
            this.tabPage3.Controls.Add(this.button58);
            this.tabPage3.Controls.Add(this.button57);
            this.tabPage3.Controls.Add(this.button56);
            this.tabPage3.Controls.Add(this.button44);
            this.tabPage3.Controls.Add(this.button43);
            this.tabPage3.Controls.Add(this.button42);
            this.tabPage3.Controls.Add(this.button40);
            this.tabPage3.Controls.Add(this.button39);
            this.tabPage3.Controls.Add(this.button23);
            this.tabPage3.Controls.Add(this.button20);
            this.tabPage3.Controls.Add(this.button38);
            this.tabPage3.Controls.Add(this.button18);
            this.tabPage3.Controls.Add(this.button37);
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Controls.Add(this.button36);
            this.tabPage3.Controls.Add(this.button22);
            this.tabPage3.Controls.Add(this.button33);
            this.tabPage3.Controls.Add(this.button32);
            this.tabPage3.ForeColor = System.Drawing.Color.Yellow;
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1097, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Datebase İşlemleri";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button61
            // 
            this.button61.BackColor = System.Drawing.Color.RoyalBlue;
            this.button61.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button61.ForeColor = System.Drawing.Color.Yellow;
            this.button61.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button61.ImageIndex = 29;
            this.button61.ImageList = this.ımageList3;
            this.button61.Location = new System.Drawing.Point(10, 448);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(208, 65);
            this.button61.TabIndex = 25;
            this.button61.Text = "      Görev Ekle";
            this.button61.UseVisualStyleBackColor = false;
            this.button61.Click += new System.EventHandler(this.button61_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "starter_pack.bmp");
            this.ımageList3.Images.SetKeyName(1, "blue05.bmp");
            this.ımageList3.Images.SetKeyName(2, "lottery_scroll_box_weapon.bmp");
            this.ımageList3.Images.SetKeyName(3, "lucky_silk.bmp");
            this.ımageList3.Images.SetKeyName(4, "max_blue05.bmp");
            this.ımageList3.Images.SetKeyName(5, "title.bmp");
            this.ımageList3.Images.SetKeyName(6, "max_blue04.bmp");
            this.ımageList3.Images.SetKeyName(7, "max_skill.bmp");
            this.ımageList3.Images.SetKeyName(8, "max_blue02.bmp");
            this.ımageList3.Images.SetKeyName(9, "e120326_kisaeng_buff_07.bmp");
            this.ımageList3.Images.SetKeyName(10, "kisaeng_buff_08.jpg");
            this.ımageList3.Images.SetKeyName(11, "e120326_kisaeng_buff_10.jpg");
            this.ımageList3.Images.SetKeyName(12, "free_silk.bmp");
            this.ımageList3.Images.SetKeyName(13, "mall_damage_abs_35p_scroll.bmp");
            this.ımageList3.Images.SetKeyName(14, "lottery_scroll_box_set.bmp");
            this.ımageList3.Images.SetKeyName(15, "lottery_scroll_box_acc.bmp");
            this.ımageList3.Images.SetKeyName(16, "lucky_jc.bmp");
            this.ımageList3.Images.SetKeyName(17, "mall_damage_inc_abs_35p_scroll.bmp");
            this.ımageList3.Images.SetKeyName(18, "etc_points_pk_remover.bmp");
            this.ımageList3.Images.SetKeyName(19, "blue06f.bmp");
            this.ımageList3.Images.SetKeyName(20, "cure_all_07.bmp");
            this.ımageList3.Images.SetKeyName(21, "mall_damage_inc_35p_scroll.bmp");
            this.ımageList3.Images.SetKeyName(22, "mall_pet_watch_agol_4w.bmp");
            this.ımageList3.Images.SetKeyName(23, "sd_token_copper.bmp");
            this.ımageList3.Images.SetKeyName(24, "wanted.bmp");
            this.ımageList3.Images.SetKeyName(25, "mob1.bmp");
            this.ımageList3.Images.SetKeyName(26, "event_beta.bmp");
            this.ımageList3.Images.SetKeyName(27, "blue_remover.bmp");
            this.ımageList3.Images.SetKeyName(28, "1b.bmp");
            this.ımageList3.Images.SetKeyName(29, "mall_premium_zerk.bmp");
            // 
            // button60
            // 
            this.button60.BackColor = System.Drawing.Color.RoyalBlue;
            this.button60.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button60.ForeColor = System.Drawing.Color.Yellow;
            this.button60.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button60.ImageIndex = 28;
            this.button60.ImageList = this.ımageList3;
            this.button60.Location = new System.Drawing.Point(868, 372);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(220, 65);
            this.button60.TabIndex = 24;
            this.button60.Text = "             Unigue Elite Kaldırma";
            this.button60.UseVisualStyleBackColor = false;
            this.button60.Click += new System.EventHandler(this.button60_Click);
            // 
            // button59
            // 
            this.button59.BackColor = System.Drawing.Color.RoyalBlue;
            this.button59.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button59.ForeColor = System.Drawing.Color.Yellow;
            this.button59.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button59.ImageIndex = 27;
            this.button59.ImageList = this.ımageList3;
            this.button59.Location = new System.Drawing.Point(653, 372);
            this.button59.Name = "button59";
            this.button59.Size = new System.Drawing.Size(210, 65);
            this.button59.TabIndex = 23;
            this.button59.Text = "F1 Fixleme";
            this.button59.UseVisualStyleBackColor = false;
            this.button59.Click += new System.EventHandler(this.button59_Click);
            // 
            // button58
            // 
            this.button58.BackColor = System.Drawing.Color.RoyalBlue;
            this.button58.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button58.ForeColor = System.Drawing.Color.Yellow;
            this.button58.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button58.ImageIndex = 26;
            this.button58.ImageList = this.ımageList3;
            this.button58.Location = new System.Drawing.Point(438, 372);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(210, 65);
            this.button58.TabIndex = 22;
            this.button58.Text = "F10 Dc Fix";
            this.button58.UseVisualStyleBackColor = false;
            this.button58.Click += new System.EventHandler(this.button58_Click);
            // 
            // button57
            // 
            this.button57.BackColor = System.Drawing.Color.RoyalBlue;
            this.button57.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button57.ForeColor = System.Drawing.Color.Yellow;
            this.button57.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button57.ImageIndex = 25;
            this.button57.ImageList = this.ımageList3;
            this.button57.Location = new System.Drawing.Point(223, 372);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(210, 65);
            this.button57.TabIndex = 21;
            this.button57.Text = "Npc Taşı";
            this.button57.UseVisualStyleBackColor = false;
            this.button57.Click += new System.EventHandler(this.button57_Click);
            // 
            // button56
            // 
            this.button56.BackColor = System.Drawing.Color.RoyalBlue;
            this.button56.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button56.ForeColor = System.Drawing.Color.Yellow;
            this.button56.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button56.ImageIndex = 21;
            this.button56.ImageList = this.ımageList3;
            this.button56.Location = new System.Drawing.Point(8, 372);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(210, 65);
            this.button56.TabIndex = 20;
            this.button56.Text = "               Unique Spawn Ekle";
            this.button56.UseVisualStyleBackColor = false;
            this.button56.Click += new System.EventHandler(this.button56_Click);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.RoyalBlue;
            this.button44.ForeColor = System.Drawing.Color.Yellow;
            this.button44.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button44.ImageIndex = 23;
            this.button44.ImageList = this.ımageList3;
            this.button44.Location = new System.Drawing.Point(653, 275);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(210, 65);
            this.button44.TabIndex = 19;
            this.button44.Text = "Mob İtem Ekle";
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button43
            // 
            this.button43.BackColor = System.Drawing.Color.RoyalBlue;
            this.button43.ForeColor = System.Drawing.Color.Yellow;
            this.button43.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button43.ImageIndex = 24;
            this.button43.ImageList = this.ımageList3;
            this.button43.Location = new System.Drawing.Point(868, 275);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(220, 65);
            this.button43.TabIndex = 18;
            this.button43.Text = "               Mob\'dan İtem Kaldırmak";
            this.button43.UseVisualStyleBackColor = false;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.Color.RoyalBlue;
            this.button42.ForeColor = System.Drawing.Color.Yellow;
            this.button42.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button42.ImageIndex = 19;
            this.button42.ImageList = this.ımageList3;
            this.button42.Location = new System.Drawing.Point(438, 275);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(210, 65);
            this.button42.TabIndex = 17;
            this.button42.Text = "Job Rate";
            this.button42.UseVisualStyleBackColor = false;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.RoyalBlue;
            this.button40.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button40.ForeColor = System.Drawing.Color.Yellow;
            this.button40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button40.ImageIndex = 16;
            this.button40.ImageList = this.ımageList3;
            this.button40.Location = new System.Drawing.Point(653, 178);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(210, 65);
            this.button40.TabIndex = 11;
            this.button40.Text = "            Stone Tutma Oranı";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.RoyalBlue;
            this.button39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button39.ForeColor = System.Drawing.Color.Yellow;
            this.button39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button39.ImageKey = "mall_damage_inc_abs_35p_scroll.bmp";
            this.button39.ImageList = this.ımageList3;
            this.button39.Location = new System.Drawing.Point(438, 178);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(210, 65);
            this.button39.TabIndex = 10;
            this.button39.Text = "Npc Sil";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.RoyalBlue;
            this.button23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.ForeColor = System.Drawing.Color.Yellow;
            this.button23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button23.ImageIndex = 22;
            this.button23.ImageList = this.ımageList3;
            this.button23.Location = new System.Drawing.Point(223, 275);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(210, 65);
            this.button23.TabIndex = 9;
            this.button23.Text = "         Unique Süreleri \r\n         Ayarlama";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click_1);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.RoyalBlue;
            this.button20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.ForeColor = System.Drawing.Color.Yellow;
            this.button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.ImageIndex = 9;
            this.button20.ImageList = this.ımageList3;
            this.button20.Location = new System.Drawing.Point(8, 81);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(210, 65);
            this.button20.TabIndex = 0;
            this.button20.Text = "             Accountları Temizleme\r\n               (Hepsini Temizler)";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.RoyalBlue;
            this.button38.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button38.ForeColor = System.Drawing.Color.Yellow;
            this.button38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button38.ImageIndex = 13;
            this.button38.ImageList = this.ımageList3;
            this.button38.Location = new System.Drawing.Point(868, 81);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(220, 65);
            this.button38.TabIndex = 8;
            this.button38.Text = "          Job Ceza Kaldırmak";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.RoyalBlue;
            this.button18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.ForeColor = System.Drawing.Color.Yellow;
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.ImageIndex = 10;
            this.button18.ImageList = this.ımageList3;
            this.button18.Location = new System.Drawing.Point(223, 81);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(210, 65);
            this.button18.TabIndex = 1;
            this.button18.Text = "          Logları Temizle\r\n         (Hepsini Temizler)";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.RoyalBlue;
            this.button37.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button37.ForeColor = System.Drawing.Color.Yellow;
            this.button37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button37.ImageIndex = 20;
            this.button37.ImageList = this.ımageList3;
            this.button37.Location = new System.Drawing.Point(868, 178);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(220, 65);
            this.button37.TabIndex = 7;
            this.button37.Text = "Pill Bugu Fix";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.RoyalBlue;
            this.button17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.ForeColor = System.Drawing.Color.Yellow;
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.ImageIndex = 11;
            this.button17.ImageList = this.ımageList3;
            this.button17.Location = new System.Drawing.Point(438, 81);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(210, 65);
            this.button17.TabIndex = 2;
            this.button17.Text = "         Shardı Temizleme\r\n         (Hepsini Temizler)";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.RoyalBlue;
            this.button36.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button36.ForeColor = System.Drawing.Color.Yellow;
            this.button36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button36.ImageIndex = 6;
            this.button36.ImageList = this.ımageList3;
            this.button36.Location = new System.Drawing.Point(8, 275);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(210, 65);
            this.button36.TabIndex = 6;
            this.button36.Text = "        Mob Çoğalt";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.RoyalBlue;
            this.button22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.ForeColor = System.Drawing.Color.Yellow;
            this.button22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button22.ImageIndex = 12;
            this.button22.ImageList = this.ımageList3;
            this.button22.Location = new System.Drawing.Point(653, 81);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(210, 65);
            this.button22.TabIndex = 3;
            this.button22.Text = "              Datebase Yedekleme";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.RoyalBlue;
            this.button33.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button33.ForeColor = System.Drawing.Color.Yellow;
            this.button33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button33.ImageIndex = 15;
            this.button33.ImageList = this.ımageList3;
            this.button33.Location = new System.Drawing.Point(223, 178);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(210, 65);
            this.button33.TabIndex = 5;
            this.button33.Text = "          Honor Rank Fixle";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.RoyalBlue;
            this.button32.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button32.ForeColor = System.Drawing.Color.Yellow;
            this.button32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button32.ImageIndex = 14;
            this.button32.ImageList = this.ımageList3;
            this.button32.Location = new System.Drawing.Point(8, 178);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(210, 65);
            this.button32.TabIndex = 4;
            this.button32.Text = "Guild Limit";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage2.Controls.Add(this.button53);
            this.tabPage2.Controls.Add(this.button51);
            this.tabPage2.Controls.Add(this.button41);
            this.tabPage2.Controls.Add(this.button19);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1097, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toplu İşlemler";
            // 
            // button53
            // 
            this.button53.BackColor = System.Drawing.Color.RoyalBlue;
            this.button53.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button53.ForeColor = System.Drawing.Color.Yellow;
            this.button53.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button53.ImageIndex = 8;
            this.button53.ImageList = this.ımageList3;
            this.button53.Location = new System.Drawing.Point(754, 356);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(316, 73);
            this.button53.TabIndex = 26;
            this.button53.Text = "Tüm Guild Cezasını Sil";
            this.button53.UseVisualStyleBackColor = false;
            this.button53.Click += new System.EventHandler(this.button53_Click);
            // 
            // button51
            // 
            this.button51.BackColor = System.Drawing.Color.RoyalBlue;
            this.button51.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button51.ForeColor = System.Drawing.Color.Yellow;
            this.button51.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button51.ImageIndex = 7;
            this.button51.ImageList = this.ımageList3;
            this.button51.Location = new System.Drawing.Point(379, 358);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(316, 73);
            this.button51.TabIndex = 25;
            this.button51.Text = "Tüm Job Cezasını Sil";
            this.button51.UseVisualStyleBackColor = false;
            this.button51.Click += new System.EventHandler(this.button51_Click);
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.RoyalBlue;
            this.button41.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button41.ForeColor = System.Drawing.Color.Yellow;
            this.button41.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button41.ImageIndex = 5;
            this.button41.ImageList = this.ımageList3;
            this.button41.Location = new System.Drawing.Point(754, 226);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(316, 72);
            this.button41.TabIndex = 15;
            this.button41.Text = "           Tüm Karakterdeki Skilleri Sıfırla";
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.RoyalBlue;
            this.button19.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button19.ForeColor = System.Drawing.Color.Yellow;
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.ImageIndex = 0;
            this.button19.ImageList = this.ımageList3;
            this.button19.Location = new System.Drawing.Point(4, 96);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(316, 72);
            this.button19.TabIndex = 10;
            this.button19.Text = "Tüm Karakterlere Silk Ver";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.RoyalBlue;
            this.button10.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button10.ForeColor = System.Drawing.Color.Yellow;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.ImageIndex = 4;
            this.button10.ImageList = this.ımageList3;
            this.button10.Location = new System.Drawing.Point(379, 227);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(316, 72);
            this.button10.TabIndex = 14;
            this.button10.Text = "Tüm Karakterlere Sp Ver";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.RoyalBlue;
            this.button13.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button13.ForeColor = System.Drawing.Color.Yellow;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.ImageIndex = 18;
            this.button13.ImageList = this.ımageList3;
            this.button13.Location = new System.Drawing.Point(4, 358);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(316, 73);
            this.button13.TabIndex = 11;
            this.button13.Text = "Tüm Karakterdeki Pk\'lıkları Sil";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.RoyalBlue;
            this.button11.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button11.ForeColor = System.Drawing.Color.Yellow;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.ImageIndex = 3;
            this.button11.ImageList = this.ımageList3;
            this.button11.Location = new System.Drawing.Point(4, 227);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(316, 72);
            this.button11.TabIndex = 13;
            this.button11.Text = "Tüm Karakterlere Gold Ver";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.RoyalBlue;
            this.button14.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button14.ForeColor = System.Drawing.Color.Yellow;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.ImageIndex = 1;
            this.button14.ImageList = this.ımageList3;
            this.button14.Location = new System.Drawing.Point(379, 96);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(316, 72);
            this.button14.TabIndex = 10;
            this.button14.Text = "         Tüm Karakterleri Jangan\'a Işınla";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.RoyalBlue;
            this.button12.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button12.ForeColor = System.Drawing.Color.Yellow;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.ImageIndex = 2;
            this.button12.ImageList = this.ımageList3;
            this.button12.Location = new System.Drawing.Point(754, 96);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(316, 72);
            this.button12.TabIndex = 12;
            this.button12.Text = "            Tüm Karakterlere Aynı Rütbeyi Ver";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button64);
            this.tabPage1.Controls.Add(this.button55);
            this.tabPage1.Controls.Add(this.button52);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button50);
            this.tabPage1.Controls.Add(this.button35);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button34);
            this.tabPage1.Controls.Add(this.button31);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button30);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button29);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button24);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button25);
            this.tabPage1.Controls.Add(this.button28);
            this.tabPage1.Controls.Add(this.button21);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button26);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.button27);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1097, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İşlemler";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(8, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 50);
            this.button1.TabIndex = 28;
            this.button1.Text = "Karakter Adı\r\n Değiştirme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button64
            // 
            this.button64.BackColor = System.Drawing.Color.RoyalBlue;
            this.button64.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button64.ForeColor = System.Drawing.Color.Yellow;
            this.button64.Image = ((System.Drawing.Image)(resources.GetObject("button64.Image")));
            this.button64.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button64.Location = new System.Drawing.Point(6, 513);
            this.button64.Name = "button64";
            this.button64.Size = new System.Drawing.Size(857, 50);
            this.button64.TabIndex = 27;
            this.button64.Text = "SQLServer Bağlantı Ayarlarını Sıfırla";
            this.button64.UseVisualStyleBackColor = false;
            this.button64.Click += new System.EventHandler(this.button64_Click);
            // 
            // button55
            // 
            this.button55.BackColor = System.Drawing.Color.RoyalBlue;
            this.button55.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button55.ForeColor = System.Drawing.Color.Yellow;
            this.button55.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button55.ImageIndex = 5;
            this.button55.ImageList = this.ımageList2;
            this.button55.Location = new System.Drawing.Point(446, 447);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(197, 50);
            this.button55.TabIndex = 26;
            this.button55.Text = "    Karakter Adı ile \r\n   Kullanıcı ID Bulma";
            this.button55.UseVisualStyleBackColor = false;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // button52
            // 
            this.button52.BackColor = System.Drawing.Color.RoyalBlue;
            this.button52.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button52.ForeColor = System.Drawing.Color.Yellow;
            this.button52.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button52.ImageIndex = 24;
            this.button52.ImageList = this.ımageList2;
            this.button52.Location = new System.Drawing.Point(227, 447);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(197, 50);
            this.button52.TabIndex = 25;
            this.button52.Text = "DDJ To DDS";
            this.button52.UseVisualStyleBackColor = false;
            this.button52.Click += new System.EventHandler(this.button52_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(889, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 533);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sisteminizdeki Karakterler";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox8.Controls.Add(this.button70);
            this.groupBox8.Location = new System.Drawing.Point(6, 467);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(188, 60);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            // 
            // button70
            // 
            this.button70.BackColor = System.Drawing.Color.RoyalBlue;
            this.button70.Location = new System.Drawing.Point(38, 11);
            this.button70.Name = "button70";
            this.button70.Size = new System.Drawing.Size(114, 42);
            this.button70.TabIndex = 1;
            this.button70.Text = "Listeyi Yenile";
            this.button70.UseVisualStyleBackColor = false;
            this.button70.Click += new System.EventHandler(this.button70_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 446);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // button50
            // 
            this.button50.BackColor = System.Drawing.Color.RoyalBlue;
            this.button50.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button50.ForeColor = System.Drawing.Color.Yellow;
            this.button50.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button50.ImageIndex = 6;
            this.button50.ImageList = this.ımageList2;
            this.button50.Location = new System.Drawing.Point(7, 444);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(198, 50);
            this.button50.TabIndex = 23;
            this.button50.Text = "Karakter ID Bul";
            this.button50.UseVisualStyleBackColor = false;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.RoyalBlue;
            this.button35.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button35.ForeColor = System.Drawing.Color.Yellow;
            this.button35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button35.ImageIndex = 3;
            this.button35.ImageList = this.ımageList2;
            this.button35.Location = new System.Drawing.Point(227, 284);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(197, 53);
            this.button35.TabIndex = 22;
            this.button35.Text = "        Oyuncuya İtem Gönder";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 20;
            this.button2.ImageList = this.ımageList2;
            this.button2.Location = new System.Drawing.Point(229, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "    Karaktere Gold Ver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.RoyalBlue;
            this.button34.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button34.ForeColor = System.Drawing.Color.Yellow;
            this.button34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button34.ImageIndex = 14;
            this.button34.ImageList = this.ımageList2;
            this.button34.Location = new System.Drawing.Point(665, 199);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(197, 53);
            this.button34.TabIndex = 21;
            this.button34.Text = "         Oyunculardan İtemi Sil";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.RoyalBlue;
            this.button31.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button31.ForeColor = System.Drawing.Color.Yellow;
            this.button31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button31.ImageKey = "test_crown_buff.bmp";
            this.button31.ImageList = this.ımageList2;
            this.button31.Location = new System.Drawing.Point(446, 201);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(197, 53);
            this.button31.TabIndex = 20;
            this.button31.Text = "Onur Puanı";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 21;
            this.button3.ImageList = this.ımageList2;
            this.button3.Location = new System.Drawing.Point(451, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "  Karaktere Sp Ver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.RoyalBlue;
            this.button30.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button30.ForeColor = System.Drawing.Color.Yellow;
            this.button30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button30.ImageIndex = 0;
            this.button30.ImageList = this.ımageList2;
            this.button30.Location = new System.Drawing.Point(446, 367);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(197, 50);
            this.button30.TabIndex = 19;
            this.button30.Text = "+ Basmak";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 22;
            this.button4.ImageList = this.ımageList2;
            this.button4.Location = new System.Drawing.Point(672, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "     Karaktere Rütbe Ver";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.RoyalBlue;
            this.button29.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button29.ForeColor = System.Drawing.Color.Yellow;
            this.button29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button29.ImageIndex = 18;
            this.button29.ImageList = this.ımageList2;
            this.button29.Location = new System.Drawing.Point(665, 281);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(197, 53);
            this.button29.TabIndex = 18;
            this.button29.Text = "Blue Vermek";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Yellow;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 15;
            this.button5.ImageList = this.ımageList2;
            this.button5.Location = new System.Drawing.Point(228, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "      Karaktere Level Ver";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.RoyalBlue;
            this.button24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button24.ForeColor = System.Drawing.Color.Yellow;
            this.button24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button24.ImageIndex = 1;
            this.button24.ImageList = this.ımageList2;
            this.button24.Location = new System.Drawing.Point(665, 363);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(197, 50);
            this.button24.TabIndex = 17;
            this.button24.Text = "Stat Vermek";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.Yellow;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 9;
            this.button6.ImageList = this.ımageList2;
            this.button6.Location = new System.Drawing.Point(446, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 53);
            this.button6.TabIndex = 5;
            this.button6.Text = "Str/Int Vermek";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.RoyalBlue;
            this.button25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button25.ForeColor = System.Drawing.Color.Yellow;
            this.button25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button25.ImageIndex = 11;
            this.button25.ImageList = this.ımageList2;
            this.button25.Location = new System.Drawing.Point(665, 442);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(198, 53);
            this.button25.TabIndex = 3;
            this.button25.Text = "IP Ekle";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.RoyalBlue;
            this.button28.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button28.ForeColor = System.Drawing.Color.Yellow;
            this.button28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button28.ImageIndex = 23;
            this.button28.ImageList = this.ımageList2;
            this.button28.Location = new System.Drawing.Point(8, 118);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(197, 53);
            this.button28.TabIndex = 0;
            this.button28.Text = "  Oyuncuya Silk Ver";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.RoyalBlue;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.ForeColor = System.Drawing.Color.Yellow;
            this.button21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button21.ImageIndex = 7;
            this.button21.ImageList = this.ımageList2;
            this.button21.Location = new System.Drawing.Point(227, 367);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(197, 50);
            this.button21.TabIndex = 16;
            this.button21.Text = " Hesap Ban Kaldır";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.Yellow;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageIndex = 19;
            this.button7.ImageList = this.ımageList2;
            this.button7.Location = new System.Drawing.Point(8, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(197, 53);
            this.button7.TabIndex = 6;
            this.button7.Text = "Bugdan Çıkart";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.RoyalBlue;
            this.button26.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.ForeColor = System.Drawing.Color.Yellow;
            this.button26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button26.ImageIndex = 16;
            this.button26.ImageList = this.ımageList2;
            this.button26.Location = new System.Drawing.Point(669, 117);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(197, 53);
            this.button26.TabIndex = 2;
            this.button26.Text = "Kullanıcı Yap";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RoyalBlue;
            this.button8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.Yellow;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.ImageIndex = 10;
            this.button8.ImageList = this.ımageList2;
            this.button8.Location = new System.Drawing.Point(7, 281);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(198, 53);
            this.button8.TabIndex = 7;
            this.button8.Text = "Premium Silmek";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.RoyalBlue;
            this.button16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.ForeColor = System.Drawing.Color.Yellow;
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.ImageIndex = 8;
            this.button16.ImageList = this.ımageList2;
            this.button16.Location = new System.Drawing.Point(7, 364);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(198, 50);
            this.button16.TabIndex = 15;
            this.button16.Text = "Hesap Banla";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.RoyalBlue;
            this.button27.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button27.ForeColor = System.Drawing.Color.Yellow;
            this.button27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button27.ImageIndex = 17;
            this.button27.ImageList = this.ımageList2;
            this.button27.Location = new System.Drawing.Point(449, 118);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(197, 53);
            this.button27.TabIndex = 1;
            this.button27.Text = "Gm Yap";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RoyalBlue;
            this.button9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.Color.Yellow;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.ImageIndex = 12;
            this.button9.ImageList = this.ımageList2;
            this.button9.Location = new System.Drawing.Point(227, 201);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(197, 53);
            this.button9.TabIndex = 8;
            this.button9.Text = "Guild Level Ver";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 601);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage6.Controls.Add(this.groupBox9);
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1097, 574);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "GM Komutları";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.textBox3);
            this.groupBox9.Controls.Add(this.textBox2);
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(223, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(624, 522);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "GM Konsol Komutları";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox3.ForeColor = System.Drawing.Color.Yellow;
            this.textBox3.Location = new System.Drawing.Point(43, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(564, 483);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(43, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(564, 483);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1097, 574);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Arama Yap";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1080, 392);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ITEM , NPC , MOB ARA";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox1);
            this.groupBox10.Controls.Add(this.button54);
            this.groupBox10.Location = new System.Drawing.Point(398, 56);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(300, 100);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button54
            // 
            this.button54.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button54.ForeColor = System.Drawing.Color.Red;
            this.button54.Image = global::ServerEditVsro.Properties.Resources.search_b1;
            this.button54.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button54.Location = new System.Drawing.Point(75, 42);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(159, 48);
            this.button54.TabIndex = 2;
            this.button54.Text = "Arama Yap";
            this.button54.UseVisualStyleBackColor = false;
            this.button54.Click += new System.EventHandler(this.button54_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(686, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "MOB_RM_ROC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(350, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "%MOB% Gibi aramalar yapılabilir..Örnek Arama : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(408, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "_RefObjCommon Tablosunda Arama Yap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ver 1.004";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Location = new System.Drawing.Point(365, 603);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(388, 54);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Durum";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(308, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(182, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Toplam Açılan Karakter:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(123, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Toplam Açılan Hesap:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(759, 603);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 54);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ServerEditVsro.Properties.Resources.Başlıksız_12;
            this.pictureBox1.Location = new System.Drawing.Point(6, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 105);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(1026, 603);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(75, 54);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.RoyalBlue;
            this.button15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.ForeColor = System.Drawing.Color.Yellow;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(14, 606);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(169, 53);
            this.button15.TabIndex = 17;
            this.button15.Text = "Çıkış Yap";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(49, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Zaman";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(198, 604);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(161, 53);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sunucu zamanı";
            // 
            // sponsor4BindingSource
            // 
            this.sponsor4BindingSource.DataMember = "Sponsor4";
            this.sponsor4BindingSource.DataSource = this.programDataSet3;
            // 
            // programDataSet3
            // 
            this.programDataSet3.DataSetName = "ProgramDataSet3";
            this.programDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsor3BindingSource
            // 
            this.sponsor3BindingSource.DataMember = "Sponsor3";
            this.sponsor3BindingSource.DataSource = this.programDataSet2;
            // 
            // programDataSet2
            // 
            this.programDataSet2.DataSetName = "ProgramDataSet2";
            this.programDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsor2BindingSource
            // 
            this.sponsor2BindingSource.DataMember = "Sponsor2";
            this.sponsor2BindingSource.DataSource = this.programDataSet1;
            // 
            // programDataSet1
            // 
            this.programDataSet1.DataSetName = "ProgramDataSet1";
            this.programDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsorBindingSource
            // 
            this.sponsorBindingSource.DataMember = "Sponsor";
            this.sponsorBindingSource.DataSource = this.programDataSet;
            // 
            // programDataSet
            // 
            this.programDataSet.DataSetName = "ProgramDataSet";
            this.programDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsorTableAdapter
            // 
            this.sponsorTableAdapter.ClearBeforeFill = true;
            // 
            // sponsor2TableAdapter
            // 
            this.sponsor2TableAdapter.ClearBeforeFill = true;
            // 
            // sponsor3TableAdapter
            // 
            this.sponsor3TableAdapter.ClearBeforeFill = true;
            // 
            // sponsor4TableAdapter
            // 
            this.sponsor4TableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1105, 669);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerEdit [GM] Yardım Programı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet)).EndInit();
            this.ResumeLayout(false);

		}

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Acc))
			{
				using (SqlConnection sqlConnection2 = new SqlConnection(Program.SQL_Shard))
				{
					sqlConnection.Open();
					label22.Text = new SqlCommand("SELECT COUNT(*) FROM TB_User", sqlConnection).ExecuteScalar().ToString();
					sqlConnection2.Open();
					label24.Text = new SqlCommand("SELECT COUNT(*) FROM _Char", sqlConnection2).ExecuteScalar().ToString();
					base.FormBorderStyle = FormBorderStyle.FixedSingle;
					timer3.Start();
					using (SqlDataReader sqlDataReader = new SqlCommand("Select CharName16 From _Char", sqlConnection2).ExecuteReader())
					{
						while (sqlDataReader.Read())
						{
							listBox1.Items.Add(sqlDataReader[0].ToString());
						}
					}
				}
			}
            if (Language.Default.language == "English")
            {
                this.Text = "ServerEdit [GM] Management Program..";tabPage1.Text = "Transactions"; tabPage2.Text = "Batch Actions"; tabPage3.Text = "Datebase Transactions"; tabPage4.Text = "Item codes"; tabPage5.Text = "Search"; tabPage6.Text = "GM Commands"; button1.Text = "        Character name changing"; button2.Text = "       Give Gold to the Char"; button3.Text = "       Give Sp to Character"; button4.Text = "     Ranking a Character"; button28.Text = "  Give Silk to Player"; button5.Text = "      Level the Character"; button27.Text = "Make a GM"; button26.Text = "Make User"; button7.Text = "Remove Bug"; button9.Text = "Give Guild Level"; button31.Text = "Honor Point"; button34.Text = "          Delete Item from Players"; button8.Text = "Delete Premium"; button35.Text = "        Send Item to Player"; button6.Text = "Giving Str/Int"; button29.Text = "Giving Blue"; button16.Text = "Account ban"; button21.Text = "      Account Ban Removal"; button30.Text = "+ Pressing"; button24.Text = "Giving Stat"; button50.Text = "Find Char ID"; button55.Text = "          Finding User ID with     Char Name"; button25.Text = "Add IP"; button64.Text = "Reset SQL Server Connection Settings"; button15.Text = "Log out"; button70.Text = "Refresh List"; groupBox2.Text = "Characters on Your System"; groupBox7.Text = "State"; groupBox4.Text = "Server Time"; label8.Text = "Time"; label21.Text = "Total Opened Accounts:"; label23.Text = "Total Unlocked Characters:"; label22.Location = new Point(126, 25); label24.Location = new Point(315, 24);
                button19.Text = "Give Silk to All Characters";
                button14.Text = "         Teleport All Characters to Jangan";
                button12.Text = "            Give All Characters the Same Rank";
                button11.Text = "Give Gold to All Characters";
                button10.Text = "Give Sp To All Characters";
                button41.Text = "           Reset All Character's Skills";
                button13.Text = "Delete All Character Pk's";
                button51.Text = "Delete All Job Penalty";
                button53.Text = "Delete All Guild Penalty";
                button20.Text = "               Cleaning Accounts               (Clears All)";
                button18.Text = " Clear Logs\r\n (Clears All)";
                button17.Text = "               Cleaning the Shard            (Clears All)";
                button22.Text = "              Datebase Backup";
                button38.Text = "          Job Penalty Remove";
                button33.Text = "          Honor Rank Fix";
                button39.Text = "Delete Npc";
                button40.Text = "            Stone Retention Rate";
                button37.Text = "Pill Bug Fix";
                button36.Text = "        Mob Duplication";
                button23.Text = "           Unique Times          setting-up";
                button44.Text = "Add Mob Item";
                button43.Text = "               Remove Item from Mob";
                button56.Text = "               Add Unique Spawn";
                button57.Text = "Npc Move";
                button59.Text = "F1 Fix";
                button60.Text = "             Unique Elite Removal";
                button61.Text = "      Add Task";
                groupBox3.Text = "HELPER CODES";
                button45.Text = "     WEAPON";
                button46.Text = "   ARMOR";
                button47.Text = "            ACCESSORY";
                button48.Text = "        ALCHEMY";
                button49.Text = "        AVATAR";
                button62.Text = "        EGYPT\r\n        WEAPONS";
                button63.Text = "        EGYPT\r\n           ARMOR(SET)";
                button65.Text = "        EGYPT\r\n           ACCESSORIES";
                button66.Text = "           WARP CODE";
                button68.Text = "        OTHER\r\n         ITEMS";
                groupBox9.Text = "GM Console Commands";
                groupBox1.Text = "ITEM , NPC , MOB SEARCH";
                label1.Text = "Search _RefObjCommon Table";
                label2.Text = "Searches such as %MOB% can be done. Example Search : ";
                button54.Text = "Search";
                label2.Location = new Point(290,39);
                textBox3.Show();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new CharNickName().ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
		{
			new goldvermek1().ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			new spvermek().ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			new rütbevermek().ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			new levelvermek().ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			new strintvermek().ShowDialog();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			new bugdancikar().ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			new premiumsilmek().ShowDialog();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			new guildlevelvermek().ShowDialog();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			new toplujanganisinla().ShowDialog();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			new toplupksil().ShowDialog();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			new toplurütbever().ShowDialog();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			new toplugoldver().ShowDialog();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			new topluspver().ShowDialog();
		}

		private void button15_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void button28_Click(object sender, EventArgs e)
		{
			new silkver().ShowDialog();
		}

		private void button27_Click(object sender, EventArgs e)
		{
			new gmyap().ShowDialog();
		}

		private void button26_Click(object sender, EventArgs e)
		{
			new useryap().ShowDialog();
		}

		private void button25_Click(object sender, EventArgs e)
		{
			new ipekle().ShowDialog();
		}

		private void button19_Click(object sender, EventArgs e)
		{
			new toplusilkver().ShowDialog();
		}

		private void button20_Click(object sender, EventArgs e)
		{
			new accounttemizle().ShowDialog();
		}

		private void button16_Click(object sender, EventArgs e)
		{
			new charbanla().ShowDialog();
		}

		private void button21_Click(object sender, EventArgs e)
		{
			new charbankaldir().ShowDialog();
		}

		private void button22_Click(object sender, EventArgs e)
		{
			new datebaseyedekleme().ShowDialog();
		}

		private void button24_Click(object sender, EventArgs e)
		{
			new statvermek().ShowDialog();
		}

		private void button29_Click(object sender, EventArgs e)
		{
			new bluevermek().ShowDialog();
		}

		private void button30_Click(object sender, EventArgs e)
		{
			new artıbasmak().ShowDialog();
		}

		private void button31_Click(object sender, EventArgs e)
		{
			new honorpointver().ShowDialog();
		}

		private void button32_Click(object sender, EventArgs e)
		{
			new guildlimit().ShowDialog();
		}

		private void button33_Click(object sender, EventArgs e)
		{
			new honorrankfixle().ShowDialog();
		}

		private void button34_Click(object sender, EventArgs e)
		{
			new itemsiloyunculardan().ShowDialog();
		}

		private void button35_Click(object sender, EventArgs e)
		{
			new oyuncuyaitemgönder().ShowDialog();
		}

		private void button36_Click(object sender, EventArgs e)
		{
			new mobcoğalt().ShowDialog();
		}

		private void button37_Click(object sender, EventArgs e)
		{
			new pillbugufix().ShowDialog();
		}

		private void button38_Click(object sender, EventArgs e)
		{
			new jobcezakaldirmak().ShowDialog();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.facebook.com/werfection/");
		}

		private void button23_Click_1(object sender, EventArgs e)
		{
			new uniqsureleri().ShowDialog();
		}

		private void button18_Click(object sender, EventArgs e)
		{
			new logtemizle().ShowDialog();
		}

		private void button17_Click(object sender, EventArgs e)
		{
			new shardtemizle().ShowDialog();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.microsoft.com/en-us/download/confirmation.aspx?id=30438");
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://docs.google.com/uc?id=0B031xu6Y6VnXVjBqZmt0bFoxV1k&export=download");
		}

		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://docs.google.com/file/d/0B8phq-8TdxunUzlCVDlMc0tsTGs/edit");
		}

		private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://drive.google.com/file/d/0B8phq-8TdxunQzd5LW9Vd2FDUG8/edit?usp=sharing");
		}

		private void button39_Click(object sender, EventArgs e)
		{
			new npcsil().ShowDialog();
		}

		private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(" https://drive.google.com/file/d/0B8phq-8TdxunSUZ0d3Z3REtTRWs/edit?usp=sharing");
		}

		private void button40_Click(object sender, EventArgs e)
		{
			new stonetutma().ShowDialog();
		}

		private void button42_Click(object sender, EventArgs e)
		{
			new jobrate().ShowDialog();
		}

		private void button43_Click(object sender, EventArgs e)
		{
			new mobitemkaldir().ShowDialog();
		}

		private void button44_Click(object sender, EventArgs e)
		{
			new mobitemekle().ShowDialog();
		}

		private void button41_Click(object sender, EventArgs e)
		{
			new skillsıfırla().ShowDialog();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.microsoft.com/en-US/download/details.aspx?id=42299");
		}

		private void button45_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.mediafire.com/file/xd3s0bfehs2cd7v/Server+Files.rar");
		}

		private void button46_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.mediafire.com/file/w6neagabew37l7d/ZSZC+IP+%26+VERSION+CHANGE+TOOL.rar");
		}

		private void button47_Click(object sender, EventArgs e)
		{
			Process.Start("https://yadi.sk/d/I-sx679Ki5Q8t");
		}

		private void button48_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.mediafire.com/file/y8hhx44a8ge6cy6/Files.rar");
		}

		private void button49_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.vsroforum.com/");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			label8.Text = DateTime.Now.ToLongTimeString();
		}

		private void button50_Click(object sender, EventArgs e)
		{
			new charıdbulmak().ShowDialog();
		}

		private void button52_Click(object sender, EventArgs e)
		{
			new ddj().ShowDialog();
		}

		private void button51_Click(object sender, EventArgs e)
		{
			new jobcezasil().ShowDialog();
		}

		private void button53_Click(object sender, EventArgs e)
		{
			new guildceza().ShowDialog();
		}

		private void button52_Click_1(object sender, EventArgs e)
		{
			new ddj().ShowDialog();
		}

		private void listBox1_MouseDown(object sender, MouseEventArgs e)
		{
			listBox1.SelectedIndex = listBox1.IndexFromPoint(e.X, e.Y);
		}

		private void button54_Click(object sender, EventArgs e)
		{
			using (SqlConnection selectConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (DataTable dataTable = new DataTable())
				{
					using (new SqlCommand())
					{
						dataTable.Clear();
						new SqlDataAdapter("Select * from _RefObjCommon Where CodeName128 like '" + textBox1.Text + "'", selectConnection).Fill(dataTable);
						dataGridView1.DataSource = dataTable;
					}
				}
			}
		}

		private void button55_Click(object sender, EventArgs e)
		{
			new kullanıcııd().ShowDialog();
		}

		private void button56_Click(object sender, EventArgs e)
		{
			new spawn().ShowDialog();
		}

		private void button57_Click(object sender, EventArgs e)
		{
			new npctası().ShowDialog();
		}

		private void button58_Click(object sender, EventArgs e)
		{
			new f10dc().ShowDialog();
		}

		private void button59_Click(object sender, EventArgs e)
		{
			new f1fix().ShowDialog();
		}

		private void button60_Click(object sender, EventArgs e)
		{
			new elite().ShowDialog();
		}

		private void button61_Click(object sender, EventArgs e)
		{
            new gorevekleme().ShowDialog();
        }
		private void button64_Click(object sender, EventArgs e)
		{
			Settings.Default.Reset();
			Process.Start(Application.ExecutablePath);
			Close();
		}

		private void tabPage3_Click(object sender, EventArgs e)
		{
		}

        private void button45_Click_1(object sender, EventArgs e)
        {
            new weapons().ShowDialog();
        }

        private void button46_Click_1(object sender, EventArgs e)
        {
            new Armor().ShowDialog();
        }

        private void button47_Click_1(object sender, EventArgs e)
        {
            new Accessory().ShowDialog();
        }

        private void button48_Click_1(object sender, EventArgs e)
        {
            new alchemy().ShowDialog();
        }

        private void button49_Click_1(object sender, EventArgs e)
        {
            new Avatar().ShowDialog();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            new LegendWeapon().ShowDialog();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            new LegendaryArmor().ShowDialog();
        }
        private void button65_Click(object sender, EventArgs e)
        {
            new LegendaryAccessory().ShowDialog();
        }
        private void button66_Click(object sender, EventArgs e)
        {
            new WarpKod().ShowDialog();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            new Uniques().ShowDialog();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            new OthersItems().ShowDialog();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            new RocSet().ShowDialog();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Acc))
            {
                using (SqlConnection sqlConnection2 = new SqlConnection(Program.SQL_Shard))
                {
                    sqlConnection.Open();
                    label22.Text = new SqlCommand("SELECT COUNT(*) FROM TB_User", sqlConnection).ExecuteScalar().ToString();
                    sqlConnection2.Open();
                    label24.Text = new SqlCommand("SELECT COUNT(*) FROM _Char", sqlConnection2).ExecuteScalar().ToString();
                    base.FormBorderStyle = FormBorderStyle.FixedSingle;
                    timer3.Start();
                    using (SqlDataReader sqlDataReader = new SqlCommand("Select CharName16 From _Char", sqlConnection2).ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            listBox1.Items.Add(sqlDataReader[0].ToString());
                        }
                    }
                }
            }
        }
    }
}
