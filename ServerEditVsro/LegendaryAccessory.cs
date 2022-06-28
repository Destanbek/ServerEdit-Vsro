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
    public partial class LegendaryAccessory : Form
    {
        public LegendaryAccessory()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Hide();
            listBox5.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox5.Hide();
            listBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { CH_RING_11_SET_A.Show(); } else { CH_RING_11_SET_A.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { CH_EARRING_11_SET_A.Show(); } else { CH_EARRING_11_SET_A.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { CH_NECKLACE_11_SET_A.Show(); } else { CH_NECKLACE_11_SET_A.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { CH_RING_11_SET_B.Show(); } else { CH_RING_11_SET_B.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { CH_EARRING_11_SET_B.Show(); } else { CH_EARRING_11_SET_B.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { CH_NECKLACE_11_SET_B.Show(); } else { CH_NECKLACE_11_SET_B.Visible = false; }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { EU_RING_11_SET_A.Show(); } else { EU_RING_11_SET_A.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { EU_EARRING_11_SET_A.Show(); } else { EU_EARRING_11_SET_A.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { EU_NECKLACE_11_SET_A.Show(); } else { EU_NECKLACE_11_SET_A.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { EU_RING_11_SET_B.Show(); } else { EU_RING_11_SET_B.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { EU_EARRING_11_SET_B.Show(); } else { EU_EARRING_11_SET_B.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { EU_NECKLACE_11_SET_B.Show(); } else { EU_NECKLACE_11_SET_B.Visible = false; }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { CH_RING_11_SET_A.Show(); } else { CH_RING_11_SET_A.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { CH_EARRING_11_SET_A.Show(); } else { CH_EARRING_11_SET_A.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { CH_NECKLACE_11_SET_A.Show(); } else { CH_NECKLACE_11_SET_A.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { CH_RING_11_SET_B.Show(); } else { CH_RING_11_SET_B.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { CH_EARRING_11_SET_B.Show(); } else { CH_EARRING_11_SET_B.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { CH_NECKLACE_11_SET_B.Show(); } else { CH_NECKLACE_11_SET_B.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { EU_RING_11_SET_A.Show(); } else { EU_RING_11_SET_A.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { EU_EARRING_11_SET_A.Show(); } else { EU_EARRING_11_SET_A.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { EU_NECKLACE_11_SET_A.Show(); } else { EU_NECKLACE_11_SET_A.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { EU_RING_11_SET_B.Show(); } else { EU_RING_11_SET_B.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { EU_EARRING_11_SET_B.Show(); } else { EU_EARRING_11_SET_B.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { EU_NECKLACE_11_SET_B.Show(); } else { EU_NECKLACE_11_SET_B.Visible = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_A 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_A 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_A 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_A_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_A_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_A_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_B 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_B 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_B 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_B_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_B_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_RING_11_SET_B_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_A 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_A 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_A 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_A_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_A_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_A_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_B 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_B 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_B 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_B_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_B_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_EARRING_11_SET_B_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_A 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_A 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_A 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_A_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_A_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_A_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_B 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_B 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_B 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_B_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_B_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_NECKLACE_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_RING_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_EARRING_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_NECKLACE_11_SET_B_RARE 250"; }
        }

        private void LegendaryAccessory_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                button1.Text = "Show Code";
                button2.Text = "Back";
            }
        }
    }
}
