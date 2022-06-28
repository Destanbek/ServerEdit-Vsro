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
    public partial class Uniques : Form
    {
        public Uniques()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MoreUniques().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_CH_TIGERWOMAN 1\r\n/LOADMONSTER MOB_CH_TIGERWOMAN_L2 1\r\n/LOADMONSTER MOB_CH_TIGERWOMAN_L3 1"; }
            if (radioButton2.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_EU_KERBEROS 1\r\n/LOADMONSTER MOB_EU_KERBEROS_L2 1\r\n/LOADMONSTER MOB_EU_KERBEROS_L3 1"; }
            if (radioButton3.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_AM_IVY 1\r\n/LOADMONSTER MOB_AM_IVY_L2 1\r\n/LOADMONSTER MOB_AM_IVY_L3 1"; }
            if (radioButton4.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_OA_URUCHI 1\r\n/LOADMONSTER MOB_OA_URUCHI_L2 1\r\n/LOADMONSTER MOB_OA_URUCHI_L3 1"; }
            if (radioButton5.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_KK_ISYUTARU 1\r\n/LOADMONSTER MOB_KK_ISYUTARU_L2 1\r\n/LOADMONSTER MOB_KK_ISYUTARU_L3 1"; }
            if (radioButton6.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_TK_BONELORD 1\r\n/LOADMONSTER MOB_TK_BONELORD_L2 1\r\n/LOADMONSTER MOB_TK_BONELORD_L3 1"; }
            if (radioButton7.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_RM_TAHOMET 1\r\n/LOADMONSTER MOB_RM_TAHOMET_L2 1\r\n/LOADMONSTER MOB_RM_TAHOMET_L3 1"; }
            if (radioButton8.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_TQ_WHITESNAKE 1"; }
            if (radioButton9.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_RM_ROC 1"; }
            if (radioButton10.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_SD_SPHINX 1"; }
            if (radioButton11.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_SD_HORUS 1"; }
            if (radioButton12.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_SD_NEPHTHYS 1"; }
            if (radioButton13.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_SD_NEITH 1"; }
            if (radioButton14.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_SD_ISIS 1"; }
            if (radioButton15.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_SD_APIS 1"; }
            if (radioButton16.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_SD_OSIRIS 1"; }
            if (radioButton17.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_SD_SETH 1"; }
            if (radioButton18.Checked == true) { textBox1.Text = "/LOADMONSTER MOB_SD_ANUBIS 1"; }
        }

        private void Uniques_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                button1.Text = "Show Code";
                button2.Text = "Back";
                button3.Text = "More Unique";
                groupBox1.Text = "Code";
            }
        }
    }
}
