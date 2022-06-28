using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerEditVsro
{
    public partial class CharNickName : Form
    {
        public CharNickName()
        {
            InitializeComponent();
        }
        private void CharSkillReset_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                   comboBox1.Items.Clear();
                   sqlConnection.Open();
                   sqlCommand.Connection = sqlConnection;
                   sqlCommand.CommandText = "Select * From dbo._Char";
                   SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                   while (sqlDataReader.Read())
                   {
                     comboBox1.Items.Add(sqlDataReader[3].ToString());
                   }
                    sqlConnection.Close();
                }
            }
            if (Language.Default.language == "English")
            {
                this.Text = "Char Name Change";
                label1.Text = "Char Name :";
                label2.Text = "New Name :";
                button1.Text = "Update";
                label1.Location = new Point(15,16);
                label2.Location = new Point(20,50);

            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBox2.Text != "")
			{
			    using (SqlConnection sqlConnection = new SqlConnection(Program.SQL_Shard))
			    {
				  using (SqlCommand sqlCommand = new SqlCommand())
				  {
				    sqlConnection.Open();
				    sqlCommand.Connection = sqlConnection;
				    sqlCommand.CommandText = "Update dbo._Char Set CharName16='" + textBox2.Text + "' Where CharName16='" + comboBox1.Text + "' ";
				    sqlCommand.ExecuteNonQuery();
				    sqlCommand.Dispose();
                  if (Language.Default.language == "English")
                  {
                      MessageBox.Show("Updated!");
                  }
                  else
                  {
                      MessageBox.Show("Güncellendi!");
                  }

				    sqlConnection.Close();
				    comboBox1.Items.Clear();
				    textBox2.Clear();
                    this.Close();
			      }
		        }
            }
            else
            {
                if (Language.Default.language == "English")
                {
                    MessageBox.Show("Fill All Fields!");
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz!");
                }
            }
        }
	}
}
