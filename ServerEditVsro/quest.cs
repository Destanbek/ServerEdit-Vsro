using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ServerEditVsro
{
	public class quest : Form
	{
		private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quest));
            this.SuspendLayout();
            // 
            // quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 452);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "quest";
            this.Text = "Görev Ekle";
            this.Load += new System.EventHandler(this.quest_Load);
            this.ResumeLayout(false);

		}

		public quest()
		{
			InitializeComponent();
		}

		private void quest_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
		}
	}
}
