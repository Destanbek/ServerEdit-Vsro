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
    public partial class RocSet : Form
    {
        public RocSet()
        {
            InitializeComponent();
        }
        private void RocSet_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
                button1.Text = "Back";
                textBox1.Text = "Please Click On The Picture!\r\nSelect China for China items.\r\nSelect Europe for Europe items.";
            }
        }

        private void CH_M_ROCSET_ARMOR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_CH_M_HEAVY_HA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_HEAVY_SA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_HEAVY_BA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_HEAVY_LA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_HEAVY_FA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_HEAVY_AA_SET 15";
        }
        private void CH_M_ROCSET_LARMOR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_CH_M_LIGHT_HA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_LIGHT_SA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_LIGHT_BA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_LIGHT_LA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_LIGHT_FA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_LIGHT_AA_SET 15";
        }
        private void CH_M_ROCSET_CLOTHES_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_CH_M_CLOTHES_HA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_CLOTHES_SA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_CLOTHES_BA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_CLOTHES_LA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_CLOTHES_FA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_M_CLOTHES_AA_SET 15";
        }
        private void CH_W_ROCSET_ARMOR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_CH_W_HEAVY_HA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_HEAVY_SA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_HEAVY_BA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_HEAVY_LA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_HEAVY_FA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_HEAVY_AA_SET 15";
        }
        private void CH_W_ROCSET_LARMOR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_CH_W_LIGHT_HA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_LIGHT_SA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_LIGHT_BA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_LIGHT_LA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_LIGHT_FA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_LIGHT_AA_SET 15";
        }
        private void CH_W_ROCSET_CLOTHES_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_CH_W_CLOTHES_HA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_CLOTHES_SA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_CLOTHES_BA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_CLOTHES_LA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_CLOTHES_FA_SET 15\r\n/MAKEITEM ITEM_ROC_CH_W_CLOTHES_AA_SET 15";
        }
        private void EU_M_ROCSET_ARMOR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_EU_M_HEAVY_HA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_HEAVY_SA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_HEAVY_BA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_HEAVY_LA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_HEAVY_FA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_HEAVY_AA_SET 15";
        }
        private void EU_M_ROCSET_LARMOR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_EU_M_LIGHT_HA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_LIGHT_SA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_LIGHT_BA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_LIGHT_LA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_LIGHT_FA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_LIGHT_AA_SET 15";
        }
        private void EU_M_ROCSET_CLOTHES_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_EU_M_CLOTHES_HA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_CLOTHES_SA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_CLOTHES_BA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_CLOTHES_LA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_CLOTHES_FA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_M_CLOTHES_AA_SET 15";
        }
        private void EU_W_ROCSET_ARMOR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_EU_W_HEAVY_HA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_HEAVY_SA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_HEAVY_BA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_HEAVY_LA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_HEAVY_FA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_HEAVY_AA_SET 15";
        }
        private void EU_W_ROCSET_LARMOR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_EU_W_LIGHT_HA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_LIGHT_SA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_LIGHT_BA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_LIGHT_LA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_LIGHT_FA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_LIGHT_AA_SET 15";
        }
        private void EU_W_ROCSET_CLOTHES_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/MAKEITEM ITEM_ROC_EU_W_CLOTHES_HA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_CLOTHES_SA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_CLOTHES_BA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_CLOTHES_LA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_CLOTHES_FA_SET 15\r\n/MAKEITEM ITEM_ROC_EU_W_CLOTHES_AA_SET 15";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CH_M_ROCSET_ARMOR.Show();
            CH_M_ROCSET_LARMOR.Show();
            CH_M_ROCSET_CLOTHES.Show();
            CH_W_ROCSET_ARMOR.Hide();
            CH_W_ROCSET_LARMOR.Hide();
            CH_W_ROCSET_CLOTHES.Hide();
            EU_M_ROCSET_ARMOR.Hide();
            EU_M_ROCSET_LARMOR.Hide();
            EU_M_ROCSET_CLOTHES.Hide();
            EU_W_ROCSET_ARMOR.Hide();
            EU_W_ROCSET_LARMOR.Hide();
            EU_W_ROCSET_CLOTHES.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CH_W_ROCSET_ARMOR.Show();
            CH_W_ROCSET_LARMOR.Show();
            CH_W_ROCSET_CLOTHES.Show();
            CH_M_ROCSET_ARMOR.Hide();
            CH_M_ROCSET_LARMOR.Hide();
            CH_M_ROCSET_CLOTHES.Hide();
            EU_M_ROCSET_ARMOR.Hide();
            EU_M_ROCSET_LARMOR.Hide();
            EU_M_ROCSET_CLOTHES.Hide();
            EU_W_ROCSET_ARMOR.Hide();
            EU_W_ROCSET_LARMOR.Hide();
            EU_W_ROCSET_CLOTHES.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EU_M_ROCSET_ARMOR.Show();
            EU_M_ROCSET_LARMOR.Show();
            EU_M_ROCSET_CLOTHES.Show();
            CH_M_ROCSET_ARMOR.Hide();
            CH_M_ROCSET_LARMOR.Hide();
            CH_M_ROCSET_CLOTHES.Hide();
            CH_W_ROCSET_ARMOR.Hide();
            CH_W_ROCSET_LARMOR.Hide();
            CH_W_ROCSET_CLOTHES.Hide();
            EU_W_ROCSET_ARMOR.Hide();
            EU_W_ROCSET_LARMOR.Hide();
            EU_W_ROCSET_CLOTHES.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            EU_W_ROCSET_ARMOR.Show();
            EU_W_ROCSET_LARMOR.Show();
            EU_W_ROCSET_CLOTHES.Show();
            CH_M_ROCSET_ARMOR.Hide();
            CH_M_ROCSET_LARMOR.Hide();
            CH_M_ROCSET_CLOTHES.Hide();
            CH_W_ROCSET_ARMOR.Hide();
            CH_W_ROCSET_LARMOR.Hide();
            CH_W_ROCSET_CLOTHES.Hide();
            EU_M_ROCSET_ARMOR.Hide();
            EU_M_ROCSET_LARMOR.Hide();
            EU_M_ROCSET_CLOTHES.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
