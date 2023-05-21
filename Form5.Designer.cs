namespace DonasiApplicationDesktop
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ID = new DataGridViewTextBoxColumn();
            Nama_Donatur = new DataGridViewTextBoxColumn();
            Jumlah_Donasi = new DataGridViewTextBoxColumn();
            Status_Bayar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nama_Donatur, Jumlah_Donasi, Status_Bayar });
            dataGridView1.Location = new Point(66, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(545, 321);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 35);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 1;
            label1.Text = "Payment Confirmation";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(536, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nama_Donatur
            // 
            Nama_Donatur.HeaderText = "Donatur";
            Nama_Donatur.Name = "Nama_Donatur";
            // 
            // Jumlah_Donasi
            // 
            Jumlah_Donasi.HeaderText = "Jumlah_Donasi";
            Jumlah_Donasi.Name = "Jumlah_Donasi";
            // 
            // Status_Bayar
            // 
            Status_Bayar.HeaderText = "Status_Bayar";
            Status_Bayar.Name = "Status_Bayar";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nama_Donatur;
        private DataGridViewTextBoxColumn Jumlah_Donasi;
        private DataGridViewTextBoxColumn Status_Bayar;
    }
}