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
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DonasiApplicationDesktop
{
    public partial class Form5 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=;database=donasi_app ");
        MySqlCommand cmd;
        MySqlDataReader dr;
        DataTable dt = new DataTable();
        int i = 0;

        public Form5()
        {
            InitializeComponent();
        }

        public DataTable getAll()
        {
            dt.Reset();
            dt = new DataTable();
            con.Open();
            cmd = new MySqlCommand("select * from payment", con);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            return dt;
        }

        public void resetdata_Table()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = getAll();
            dataGridView1.RowTemplate.Height = 80;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Sudah Bayar";
            buttonColumn.Name = "SudahBayarButton";
            buttonColumn.Text = "OK";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

            ID.DataPropertyName = "id";
            Nama_Donatur.DataPropertyName = "nama_donatur";
            Jumlah_Donasi.DataPropertyName = "jumlah_donasi";
            Status_Bayar.DataPropertyName = "paid_of";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            resetdata_Table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["SudahBayarButton"].Index && e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                cmd = new MySqlCommand("UPDATE payment SET paid_of='ok' WHERE id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Paid status updated successfully");

                resetdata_Table();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }
    }
}
