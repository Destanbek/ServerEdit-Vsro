using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class kullanıcııd : Form
	{
		private IContainer components = null;

		private Label label1;

		private TextBox textBox1;

		private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button1;

		public kullanıcııd()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection selectConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (new SqlConnection(Program.SQL_Acc))
				{
					using (DataTable dataTable = new DataTable())
					{
						using (new SqlCommand())
						{
							dataTable.Clear();
							new SqlDataAdapter("Select SRO_VT_SHARD.dbo._Char.CharName16 As CharName, U.StrUserID As UserName, UserJID As JID From SRO_VT_SHARD.dbo._User \r\nRight Join SRO_VT_SHARD.dbo._Char\r\nOn SRO_VT_SHARD.dbo._User.CharID = SRO_VT_SHARD.dbo._Char.CharID\r\nRight Join SRO_VT_ACCOUNT.dbo.TB_User As U\r\nOn U.JID = SRO_VT_SHARD.dbo._User.UserJID\r\nWhere _Char.CharName16 = '" + textBox1.Text + "'", selectConnection).Fill(dataTable);
                            new SqlDataAdapter("Select SRO_R_SHARD.dbo._Char.CharName16 As CharName, U.StrUserID As UserName, UserJID As JID From SRO_R_SHARD.dbo._User \r\nRight Join SRO_R_SHARD.dbo._Char\r\nOn SRO_R_SHARD.dbo._User.CharID = SRO_R_SHARD.dbo._Char.CharID\r\nRight Join SRO_R_ACCOUNT.dbo.TB_User As U\r\nOn U.JID = SRO_R_SHARD.dbo._User.UserJID\r\nWhere _Char.CharName16 = '" + textBox1.Text + "'", selectConnection).Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
						}
					}
				}
			}
		}

		private void kullanıcııd_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Language.Default.language == "English")
            {
                this.Text = "Finding User ID with Character Name";
                label1.Text = "Char Name :";
                button1.Text = "Find";
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanıcııd));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karakter Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 96);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(111, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // kullanıcııd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(375, 207);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kullanıcııd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karakter İsmi ile Kullanıcı ID Bulma";
            this.Load += new System.EventHandler(this.kullanıcııd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
