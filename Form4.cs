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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form6
            Form6 form6 = new();

            // Menampilkan Form6
            form6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form6
            Form6 form6 = new();

            // Menampilkan Form6
            form6.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
