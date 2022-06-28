using ServerEditVsro.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class ddj : Form
	{
		private static string application_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";

		private IContainer components = null;

		private Button button1;

		private Label label1;

		private Label label2;

		private Button button2;

		private GroupBox groupBox1;

		private GroupBox groupBox2;

		private PictureBox pictureBox1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ddj));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(186, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = ".......";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DDJ\'yi DDS\'ye Çevir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DDS\'yi DDJ\'ye Çevir";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(186, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = ".......";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(168, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(168, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 66);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ServerEditVsro.Properties.Resources.Audio_Converter1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 171);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ddj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(455, 175);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ddj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDJ =DDS= DDJ Converter";
            this.Load += new System.EventHandler(this.ddj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		public ddj()
		{
			InitializeComponent();
		}

		private void ddj_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			if (Language.Default.language == "English")
            {
				label1.Text = "DDJ to DDS Convert";
				label2.Text = "DDS to DDJ Convert";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowDialog();
			if (folderBrowserDialog.SelectedPath.Length <= 0)
			{
				return;
			}
			string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.ddj", SearchOption.TopDirectoryOnly);
			if (files.Length != 0)
			{
				if (Language.Default.language == "English")
                {
					MessageBox.Show("The conversion process may take several minutes, depending on how many files there are. Then the converted directory opens.", "DDJ to DDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
                {
					MessageBox.Show("Dönüştürme işlemi, kaç dosya olduğuna bağlı olarak birkaç dakika sürebilir. Ardından, dönüştürülen dizin açılır.", "DDJ to DDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				string text = application_path + "\\DDJ_TO_DDS\\";
				Directory.CreateDirectory(text);
				for (int i = 0; i < files.Length; i++)
				{
					string path = text + Path.GetFileNameWithoutExtension(files[i]) + ".dds";
					byte[] array = File.ReadAllBytes(files[i]);
					using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
					{
						fileStream.Write(array, 20, array.Length - 20);
						fileStream.Close();
					}
				}
				Process.Start(text);
			}
			else
			{
				if (Language.Default.language == "English")
                {
					MessageBox.Show("No DDJ's could be found in the specified directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
                {
					MessageBox.Show("Belirtilen dizinde DDJ bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
		
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			byte[] buffer = new byte[20]
			{
				74,
				77,
				88,
				86,
				68,
				68,
				74,
				32,
				49,
				48,
				48,
				48,
				136,
				128,
				0,
				0,
				3,
				0,
				0,
				0
			};
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowDialog();
			if (folderBrowserDialog.SelectedPath.Length <= 0)
			{
				return;
			}
			string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.dds", SearchOption.TopDirectoryOnly);
			if (files.Length != 0)
			{
				if (Language.Default.language == "English")
				{
					MessageBox.Show("The conversion process may take several minutes, depending on how many files there are. Then the converted directory opens.", "DDS to DDJ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					MessageBox.Show("Dönüştürme işlemi, kaç dosya olduğuna bağlı olarak birkaç dakika sürebilir. Ardından, dönüştürülen dizin açılır. Ardından, dönüştürülen dizin açılır.", "DDS to DDJ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				string text = application_path + "\\DDS_TO_DDJ\\";
				Directory.CreateDirectory(text);
				for (int i = 0; i < files.Length; i++)
				{
					string path = text + Path.GetFileNameWithoutExtension(files[i]) + ".ddj";
					byte[] array = File.ReadAllBytes(files[i]);
					using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
					{
						fileStream.Write(buffer, 0, 20);
						fileStream.Write(array, 0, array.Length);
						fileStream.Close();
					}
				}
				Process.Start(text);
			}
			else
			{
				if (Language.Default.language == "English")
				{
					MessageBox.Show("No DDS's could be found in the specified directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					MessageBox.Show("Belirtilen dizinde DDS bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}
	}
}
