using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class uniqsureleri : Form
	{
		private IContainer components = null;

		private Label label1;

		private ComboBox comboBox1;

		private Label label2;

		private Label label3;

		private TextBox textBox1;

		private TextBox textBox2;
        private GroupBox groupBox1;
        private Button button1;

		public uniqsureleri()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			{
				using (SqlCommand sqlCommand = new SqlCommand())
				{
					int num = int.Parse(textBox1.Text);
					int num2 = int.Parse(textBox2.Text);
					int num3 = num * 60;
					int num4 = num2 * 60;
					sqlConnection.Open();
					if (comboBox1.SelectedItem.ToString() == "Tiger")
					{
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = "Update Tab_RefNest Set dwDelayTimeMin='" + num3 + "' , dwDelayTimeMax='" + num4 + "' WHERE dwTacticsID = (SELECT dwTacticsID FROM Tab_RefTactics WHERE dwObjID = (SELECT ID FROM _RefObjCommon WHERE Codename128 like 'MOB_CH_TIGERWOMAN'))";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
						MessageBox.Show("Tiger Girl Süresi Başarı İle Ayarlandı.");
					}
					else if (comboBox1.SelectedItem.ToString() == "Cerberus")
					{
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = "Update Tab_RefNest Set dwDelayTimeMin='" + num3 + "' , dwDelayTimeMax='" + num4 + "' WHERE dwTacticsID = (SELECT dwTacticsID FROM Tab_RefTactics WHERE dwObjID = (SELECT ID FROM _RefObjCommon WHERE Codename128 like 'MOB_EU_KERBEROS'))";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
						MessageBox.Show("Cerberus Süresi Başarı İle Ayarlandı.");
					}
					else if (comboBox1.SelectedItem.ToString() == "İwy")
					{
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = "Update Tab_RefNest Set dwDelayTimeMin='" + num3 + "' , dwDelayTimeMax='" + num4 + "' WHERE dwTacticsID = (SELECT dwTacticsID FROM Tab_RefTactics WHERE dwObjID = (SELECT ID FROM _RefObjCommon WHERE Codename128 like 'MOB_AM_IVY'))";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Ivy Time Set Successfully.");
                        }
                        else
                        {
                            MessageBox.Show("İvy Süresi Başarı İle Ayarlandı.");
                        }
                    }
					else if (comboBox1.SelectedItem.ToString() == "Urichi")
					{
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = "Update Tab_RefNest Set dwDelayTimeMin='" + num3 + "' , dwDelayTimeMax='" + num4 + "' WHERE dwTacticsID = (SELECT dwTacticsID FROM Tab_RefTactics WHERE dwObjID = (SELECT ID FROM _RefObjCommon WHERE Codename128='MOB_OA_URUCHI'))";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Urichi Time Set Successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Urichi Süresi Başarı İle Ayarlandı.");
                        }
                    }
					else if (comboBox1.SelectedItem.ToString() == "İsy")
					{
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = "Update Tab_RefNest Set dwDelayTimeMin='" + num3 + "' , dwDelayTimeMax='" + num4 + "' WHERE dwTacticsID = (SELECT dwTacticsID FROM Tab_RefTactics WHERE dwObjID = (SELECT ID FROM _RefObjCommon WHERE Codename128='MOB_KK_ISYUTARU'))";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("İsy Time Set Successfully.");
                        }
                        else
                        {
                            MessageBox.Show("İsy Süresi Başarı İle Ayarlandı.");
                        }
                    }
					else if (comboBox1.SelectedItem.ToString() == "Lord")
					{
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = "Update Tab_RefNest Set dwDelayTimeMin='" + num3 + "' , dwDelayTimeMax='" + num4 + "' WHERE dwTacticsID = (SELECT dwTacticsID FROM Tab_RefTactics WHERE dwObjID = (SELECT ID FROM _RefObjCommon WHERE Codename128 like 'MOB_TK_BONELORD'))";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Lord Yarkan Time Set Successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Lord Yarkan Süresi Başarı İle Ayarlandı.");
                        }
                    }
					else if (comboBox1.SelectedItem.ToString() == "Demon")
					{
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = "Update Tab_RefNest Set dwDelayTimeMin='" + num3 + "' , dwDelayTimeMax='" + num4 + "' WHERE dwTacticsID = (SELECT dwTacticsID FROM Tab_RefTactics WHERE dwObjID = (SELECT ID FROM _RefObjCommon WHERE Codename128 like 'MOB_RM_TAHOMET'))";
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
                        if (Language.Default.language == "English")
                        {
                            MessageBox.Show("Demon Shaitan Time Set Successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Demon Shaitan Süresi Başarı İle Ayarlandı.");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uniqsureleri));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unique Seçin :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tiger",
            "Cerberus",
            "İwy",
            "Uruchi",
            "İsy",
            "Lord",
            "Demon"});
            this.comboBox1.Location = new System.Drawing.Point(89, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min Dakika :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max Dakika :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(89, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ayarla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 123);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // uniqsureleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(228, 126);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uniqsureleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uniq Süresi Ayarla";
            this.Load += new System.EventHandler(this.uniqsureleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

        private void uniqsureleri_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                this.Text = "Set Uniq Duration";
                label1.Text = "Select Unique :";
                label2.Text = "Min Minutes :";
                label3.Text = "Max Minutes :";
                button1.Text = "SET";
            }
        }
    }
}
