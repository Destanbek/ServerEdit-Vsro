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
    public partial class WarpKod : Form
    {
        public WarpKod()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarpKod_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                this.Text = "Warp Code";
                button2.Text = "Back";
            }
        }
    }
}
