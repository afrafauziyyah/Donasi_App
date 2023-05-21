using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DonasiApplicationDesktop
{
    public partial class Register : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=;database=donasi_app");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("insert into login (Username,Password,Email) values (@Username,@Password,@Email)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("succesfully registered");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
