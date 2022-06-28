using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class adminpanel : Form
	{
		private IContainer components = null;

		private string resimPath;

		private GroupBox groupBox1;

		private Button button1;

		private OpenFileDialog openFileDialog1;

		private Button button2;

		private PictureBox pictureBox1;

		private Button button3;

		private GroupBox groupBox2;

		private Button button4;

		private PictureBox pictureBox2;

		private Button button5;

		private Button button6;

		private GroupBox groupBox3;

		private Button button7;

		private PictureBox pictureBox3;

		private Button button8;

		private Button button9;

		private GroupBox groupBox4;

		private Button button10;

		private PictureBox pictureBox4;

		private Button button11;

		private Button button12;

		public adminpanel()
		{
			InitializeComponent();
		}

		private void adminpanel_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FileStream fileStream = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = binaryReader.ReadBytes((int)fileStream.Length);
			binaryReader.Close();
			fileStream.Close();
			SqlConnection sqlConnection = new SqlConnection("Data Source=94.101.91.195;Initial Catalog=Program;User ID=sa;Password=1907Fener");
			SqlCommand sqlCommand = new SqlCommand("insert into Sponsor(Reklam) Values (@Reklam) ", sqlConnection);
			sqlCommand.Parameters.Add("@Reklam", SqlDbType.Image, array.Length).Value = array;
			try
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				MessageBox.Show(" Veritabanına kayıt yapıldı.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
			finally
			{
				sqlConnection.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Resim Aç";
			openFileDialog1.Filter = "Gif Dosyası (*.gif)|*.gif";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
			}
			resimPath = openFileDialog1.FileName.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection("Data Source=94.101.91.195;Initial Catalog=Program;User ID=sa;Password=1907Fener");
			SqlCommand sqlCommand = new SqlCommand("DELETE FROM Sponsor", sqlConnection);
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show(" Reklam Silindi.");
			sqlConnection.Close();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			FileStream fileStream = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = binaryReader.ReadBytes((int)fileStream.Length);
			binaryReader.Close();
			fileStream.Close();
			SqlConnection sqlConnection = new SqlConnection("Data Source=94.101.91.195;Initial Catalog=Program;User ID=sa;Password=1907Fener");
			SqlCommand sqlCommand = new SqlCommand("insert into Sponsor2(Reklam) Values (@Reklam) ", sqlConnection);
			sqlCommand.Parameters.Add("@Reklam", SqlDbType.Image, array.Length).Value = array;
			try
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				MessageBox.Show(" Veritabanına kayıt yapıldı.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
			finally
			{
				sqlConnection.Close();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Resim Aç";
			openFileDialog1.Filter = "Gif Dosyası (*.gif)|*.gif";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
			}
			resimPath = openFileDialog1.FileName.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection("Data Source=94.101.91.195;Initial Catalog=Program;User ID=sa;Password=1907Fener");
			SqlCommand sqlCommand = new SqlCommand("DELETE FROM Sponsor2", sqlConnection);
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show(" Reklam Silindi.");
			sqlConnection.Close();
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{
		}

		private void button9_Click(object sender, EventArgs e)
		{
			FileStream fileStream = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = binaryReader.ReadBytes((int)fileStream.Length);
			binaryReader.Close();
			fileStream.Close();
			SqlConnection sqlConnection = new SqlConnection("Data Source=94.101.91.195;Initial Catalog=Program;User ID=sa;Password=1907Fener");
			SqlCommand sqlCommand = new SqlCommand("insert into Sponsor3(Reklam) Values (@Reklam) ", sqlConnection);
			sqlCommand.Parameters.Add("@Reklam", SqlDbType.Image, array.Length).Value = array;
			try
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				MessageBox.Show(" Veritabanına kayıt yapıldı.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
			finally
			{
				sqlConnection.Close();
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Resim Aç";
			openFileDialog1.Filter = "Gif Dosyası (*.gif)|*.gif";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
			}
			resimPath = openFileDialog1.FileName.ToString();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection("Data Source=94.101.91.195;Initial Catalog=Program;User ID=sa;Password=1907Fener");
			SqlCommand sqlCommand = new SqlCommand("DELETE FROM Sponsor3", sqlConnection);
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show(" Reklam Silindi.");
			sqlConnection.Close();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			FileStream fileStream = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = binaryReader.ReadBytes((int)fileStream.Length);
			binaryReader.Close();
			fileStream.Close();
			SqlConnection sqlConnection = new SqlConnection("Data Source=94.101.91.195;Initial Catalog=Program;User ID=sa;Password=1907Fener");
			SqlCommand sqlCommand = new SqlCommand("insert into Sponsor4(Reklam) Values (@Reklam) ", sqlConnection);
			sqlCommand.Parameters.Add("@Reklam", SqlDbType.Image, array.Length).Value = array;
			try
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				MessageBox.Show(" Veritabanına kayıt yapıldı.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
			finally
			{
				sqlConnection.Close();
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Resim Aç";
			openFileDialog1.Filter = "Gif Dosyası (*.gif)|*.gif";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
			}
			resimPath = openFileDialog1.FileName.ToString();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection("Data Source=94.101.91.195;Initial Catalog=Program;User ID=sa;Password=1907Fener");
			SqlCommand sqlCommand = new SqlCommand("DELETE FROM Sponsor4", sqlConnection);
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show(" Reklam Silindi.");
			sqlConnection.Close();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reklam1 Yönetimi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sponsor1 Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sponsor1 Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sponsor1 Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reklam2 Yönetimi";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sponsor2 Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(7, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(468, 60);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(178, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 32);
            this.button5.TabIndex = 1;
            this.button5.Text = "Sponsor2 Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(66, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 32);
            this.button6.TabIndex = 0;
            this.button6.Text = "Sponsor2 Kaydet";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Location = new System.Drawing.Point(536, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 129);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reklam3 Yönetimi";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(290, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 32);
            this.button7.TabIndex = 3;
            this.button7.Text = "Sponsor3 Sil";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(7, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(468, 60);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(178, 85);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 32);
            this.button8.TabIndex = 1;
            this.button8.Text = "Sponsor3 Ekle";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(66, 85);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 32);
            this.button9.TabIndex = 0;
            this.button9.Text = "Sponsor3 Kaydet";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Location = new System.Drawing.Point(536, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(489, 129);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reklam4 Yönetimi";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(290, 85);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 32);
            this.button10.TabIndex = 3;
            this.button10.Text = "Sponsor4 Sil";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(7, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(468, 60);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(178, 85);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(106, 32);
            this.button11.TabIndex = 1;
            this.button11.Text = "Sponsor4 Ekle";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(66, 85);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(106, 32);
            this.button12.TabIndex = 0;
            this.button12.Text = "Sponsor4 Kaydet";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 328);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminpanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerEdit Admin Paneli";
            this.Load += new System.EventHandler(this.adminpanel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
