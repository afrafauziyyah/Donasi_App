namespace DonasiApplicationDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            slidebox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            anu1 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slidebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 66);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 15);
            label2.Name = "label2";
            label2.Size = new Size(120, 29);
            label2.TabIndex = 1;
            label2.Text = "DonasiKita";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(412, 379);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 0;
            label1.Text = "PILIH KATEGORI ";
            label1.Click += label1_Click;
            // 
            // slidebox
            // 
            slidebox.Image = (Image)resources.GetObject("slidebox.Image");
            slidebox.Location = new Point(187, 78);
            slidebox.Name = "slidebox";
            slidebox.Size = new Size(572, 274);
            slidebox.SizeMode = PictureBoxSizeMode.StretchImage;
            slidebox.TabIndex = 2;
            slidebox.TabStop = false;
            slidebox.Click += slidebox_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(233, 444);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 537);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 6;
            label3.Text = "Korban Bencana Alam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 537);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 7;
            label4.Text = "Santunan Anak Yatim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 537);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 8;
            label5.Text = "Pembangunan Masjid";
            // 
            // anu1
            // 
            anu1.Location = new Point(198, 586);
            anu1.Name = "anu1";
            anu1.Size = new Size(169, 48);
            anu1.TabIndex = 9;
            anu1.Text = "Lihat Selengkapnya";
            anu1.UseVisualStyleBackColor = true;
            anu1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(428, 444);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 84);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(626, 444);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(396, 586);
            button1.Name = "button1";
            button1.Size = new Size(169, 48);
            button1.TabIndex = 12;
            button1.Text = "Lihat Selengkapnya";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(591, 586);
            button2.Name = "button2";
            button2.Size = new Size(169, 48);
            button2.TabIndex = 13;
            button2.Text = "Lihat Selengkapnya";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(838, 15);
            button3.Name = "button3";
            button3.Size = new Size(83, 36);
            button3.TabIndex = 14;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(931, 664);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(anu1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(slidebox);
            Controls.Add(panel1);
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slidebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox slidebox;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button anu1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}