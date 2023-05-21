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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DonasiApplicationDesktop
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=;database=donasi_app");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("select * from login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else if ((textBox1.Text == "admin") && (textBox2.Text == "admin123"))
            {
                MessageBox.Show("Welcome back, Admin", "adminer");
                this.Hide();
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Register
            Form R = new Register();

            // Menampilkan Register
            R.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
