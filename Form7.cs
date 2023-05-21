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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DonasiApplicationDesktop
{
    public partial class Form7 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=;database=donasi_app");
        MySqlCommand cmd;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if ((textBox1.Text == string.Empty | textBox2.Text == string.Empty))
            //{
            //    MessageBox.Show("Please fill all fields");
            //    return;
            //}

            //try
            //{
            //    cmd = new MySqlCommand("insert into payment (nama_donatur,jumlah_donasi) values (@nama_donatur,@jumlah_donasi)", con);
            //    con.Open();
            //    cmd.Parameters.AddWithValue("@nama_donatur", textBox1.Text);
            //    cmd.Parameters.AddWithValue("@jumlah_donasi", textBox2.Text);
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("succesfully");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}

            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
