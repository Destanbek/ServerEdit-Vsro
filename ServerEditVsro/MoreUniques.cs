using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerEditVsro
{
    public partial class MoreUniques : Form
    {
        public MoreUniques()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Uniques().ShowDialog();
        }

        private void MoreUniques_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                textBox1.Show();
                textBox2.Hide();
                this.Text = "More Uniques";
                button2.Text = "Back";
            }
            else
            {
                textBox2.Show();
                textBox1.Hide();
            }
        }
    }
}
