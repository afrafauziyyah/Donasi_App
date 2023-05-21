namespace DonasiApplicationDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }

            slidebox.ImageLocation = string.Format(@"Image\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void slidebox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Membuat instance dari Form3
            Form3 form3 = new();

            // Menampilkan Form3
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Membuat instance dari Form4
            Form4 form4 = new();

            // Menampilkan Form4
            form4.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Show();

            this.Hide();
        }
    }
}