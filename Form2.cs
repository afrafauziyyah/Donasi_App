using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonasiApplicationDesktop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form6
            Form6 form6 = new();

            // Menampilkan Form6
            form6.ShowDialog();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form6
            Form6 form6 = new();

            // Menampilkan Form6
            form6.ShowDialog();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form6
            Form6 form6 = new();

            // Menampilkan Form6
            form6.ShowDialog();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
