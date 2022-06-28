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
    public partial class LegendWeapon : Form
    {
        public LegendWeapon()
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
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_A 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_A 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_A 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_A 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_A 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_A 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_A 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_A 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_A 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_A 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_A 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_A 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_A 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_A 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_A 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_A 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_A 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_A 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_A_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_A_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_A_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_A_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_A_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_A_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_A_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_A_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_A_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_A_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_A_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_A_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_A_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_A_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_A_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_A_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_A_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_A_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_B 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_B 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_B 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_B 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_B 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_B 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_B 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_B 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_B 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_B 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_B 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_B 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_B 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_B 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_B 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_B 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_B 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_B 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_B_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_B_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SPEAR_11_SET_B_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_B_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_B_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_BOW_11_SET_B_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_B_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_B_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_TBLADE_11_SET_B_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_B_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_B_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SWORD_11_SET_B_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_B_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_B_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_BLADE_11_SET_B_RARE 250"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_B_RARE 5"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_B_RARE 15"; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_CH_SHIELD_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_A 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_A 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_A 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_B 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_B 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_B 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_A_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_A_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_A_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_SWORD_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_TSWORD_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_CROSSBOW_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_DAGGER_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_TSTAFF_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_HARP_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_STAFF_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_DARKSTAFF_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_AXE_11_SET_B_RARE 250"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_B_RARE 5"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_B_RARE 15"; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1 && listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 2) { textBox1.Text = "/MAKEITEM ITEM_EU_SHIELD_11_SET_B_RARE 250"; }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Show(); } else { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Show(); } else { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Show(); } else { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Show(); } else { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Show(); } else { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Show(); } else { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Show(); } else { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Show(); } else { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Show(); } else { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Show(); } else { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Show(); } else { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Show(); } else { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Show(); } else { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Show(); } else { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Show(); } else { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Show(); } else { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Show(); } else { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Show(); } else { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Show(); } else { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Show(); } else { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Show(); } else { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Show(); } else { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Show(); } else { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Show(); } else { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Show(); } else { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Show(); } else { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Show(); } else { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Show(); } else { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Show(); } else { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Show(); } else { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Show(); } else { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Show(); } else { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Show(); } else { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Show(); } else { DEGREE_11_SET_A_BOW.Visible = false; }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Show(); } else { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Show(); } else { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Show(); } else { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Show(); } else { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Show(); } else { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Show(); } else { DEGREE_11_SET_B_BOW.Visible = false; }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Show(); } else { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Show(); } else { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Show(); } else { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Show(); } else { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Show(); } else { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Show(); } else { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Show(); } else { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Show(); } else { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Show(); } else { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Show(); } else { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Show(); } else { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Show(); } else { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Show(); } else { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Show(); } else { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Show(); } else { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Show(); } else { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Show(); } else { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Show(); } else { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Show(); } else { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Show(); } else { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Show(); } else { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Show(); } else { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Show(); } else { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Show(); } else { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 0) { DEGREE_11_SET_A_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SPEAR.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BOW.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_GLAVIE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SWORD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_BLADE.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 6 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 7 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 8 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton1.Checked == true && listBox5.SelectedIndex == 9 && listBox2.SelectedIndex == 1) { DEGREE_11_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0) { DEGREE_11_EU_SET_A_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSWORD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_CROSSBOW.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DAGGER.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_TSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_HARP.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_STAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_DARKSTAFF.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_AXE.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
            if (radioButton2.Checked == true && listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1) { DEGREE_11_EU_SET_B_SHIELD.Visible = false; }
        }

        private void LegendWeapon_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                button3.Text = "Show Code";
                button4.Text = "Back";
            }
        }
    }
}
