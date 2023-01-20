namespace Aplikasi_Penjualan.GUI
{
    partial class Pelanggan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.dataGridView_Pelanggan = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NoTelepon = new System.Windows.Forms.TextBox();
            this.textBox_Alamat = new System.Windows.Forms.TextBox();
            this.textBox_NamaPelanggan = new System.Windows.Forms.TextBox();
            this.textBox_IdPelanggan = new System.Windows.Forms.TextBox();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan)).BeginInit();
            this.groupBox_form.SuspendLayout();
            this.groupBox_proses.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 168);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "PELANGGAN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.groupBox_data);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.groupBox_form);
            this.panel3.Controls.Add(this.groupBox_proses);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(188, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1138, 690);
            this.panel3.TabIndex = 4;
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.groupBox_data.Controls.Add(this.dataGridView_Pelanggan);
            this.groupBox_data.Controls.Add(this.label6);
            this.groupBox_data.Controls.Add(this.textBox_cari);
            this.groupBox_data.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_data.Location = new System.Drawing.Point(399, 174);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(727, 504);
            this.groupBox_data.TabIndex = 8;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Data Pelanggan";
            // 
            // dataGridView_Pelanggan
            // 
            this.dataGridView_Pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pelanggan.Location = new System.Drawing.Point(10, 90);
            this.dataGridView_Pelanggan.Name = "dataGridView_Pelanggan";
            this.dataGridView_Pelanggan.RowHeadersWidth = 62;
            this.dataGridView_Pelanggan.Size = new System.Drawing.Size(711, 408);
            this.dataGridView_Pelanggan.TabIndex = 13;
            this.dataGridView_Pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pelanggan_CellClick_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cari Pelanggan (ID / Nama)";
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_cari.Location = new System.Drawing.Point(315, 37);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(406, 39);
            this.textBox_cari.TabIndex = 11;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged_1);
            // 
            // groupBox_form
            // 
            this.groupBox_form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.label5);
            this.groupBox_form.Controls.Add(this.textBox_NoTelepon);
            this.groupBox_form.Controls.Add(this.textBox_Alamat);
            this.groupBox_form.Controls.Add(this.textBox_NamaPelanggan);
            this.groupBox_form.Controls.Add(this.textBox_IdPelanggan);
            this.groupBox_form.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_form.Location = new System.Drawing.Point(6, 174);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(387, 306);
            this.groupBox_form.TabIndex = 6;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = "Form Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(6, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "No Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alamat";
            // 
            // textBox_NoTelepon
            // 
            this.textBox_NoTelepon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_NoTelepon.Location = new System.Drawing.Point(205, 240);
            this.textBox_NoTelepon.Name = "textBox_NoTelepon";
            this.textBox_NoTelepon.Size = new System.Drawing.Size(176, 39);
            this.textBox_NoTelepon.TabIndex = 6;
            // 
            // textBox_Alamat
            // 
            this.textBox_Alamat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Alamat.Location = new System.Drawing.Point(144, 139);
            this.textBox_Alamat.Multiline = true;
            this.textBox_Alamat.Name = "textBox_Alamat";
            this.textBox_Alamat.Size = new System.Drawing.Size(238, 84);
            this.textBox_Alamat.TabIndex = 4;
            // 
            // textBox_NamaPelanggan
            // 
            this.textBox_NamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_NamaPelanggan.Location = new System.Drawing.Point(207, 90);
            this.textBox_NamaPelanggan.Name = "textBox_NamaPelanggan";
            this.textBox_NamaPelanggan.Size = new System.Drawing.Size(174, 39);
            this.textBox_NamaPelanggan.TabIndex = 2;
            // 
            // textBox_IdPelanggan
            // 
            this.textBox_IdPelanggan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_IdPelanggan.Location = new System.Drawing.Point(281, 47);
            this.textBox_IdPelanggan.Name = "textBox_IdPelanggan";
            this.textBox_IdPelanggan.Size = new System.Drawing.Size(100, 39);
            this.textBox_IdPelanggan.TabIndex = 0;
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_proses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_proses.Location = new System.Drawing.Point(6, 486);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Size = new System.Drawing.Size(387, 186);
            this.groupBox_proses.TabIndex = 7;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = "Proses";
            // 
            // button_hapus
            // 
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_hapus.Location = new System.Drawing.Point(256, 142);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(125, 44);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "&Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click_2);
            // 
            // button_ubah
            // 
            this.button_ubah.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_ubah.Location = new System.Drawing.Point(10, 142);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(134, 44);
            this.button_ubah.TabIndex = 2;
            this.button_ubah.Text = "&Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_simpan.Location = new System.Drawing.Point(256, 55);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(125, 43);
            this.button_simpan.TabIndex = 1;
            this.button_simpan.Text = "&Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_baru
            // 
            this.button_baru.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_baru.Location = new System.Drawing.Point(10, 55);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(134, 43);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "&Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 690);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Aplikasi_Penjualan.Properties.Resources.cashier2_117951;
            this.pictureBox5.Location = new System.Drawing.Point(12, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(158, 165);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Aplikasi_Penjualan.Properties.Resources.kisspng_computer_icons_button_white_circle_5ac110cf271934_4934457915226021911602_removebg_preview_1_;
            this.pictureBox3.Location = new System.Drawing.Point(12, 357);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplikasi_Penjualan.Properties.Resources.kisspng_computer_icons_button_white_circle_5ac110cf271934_4934457915226021911602_removebg_preview_1_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplikasi_Penjualan.Properties.Resources.kisspng_computer_icons_button_white_circle_5ac110cf271934_4934457915226021911602_removebg_preview_1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Barang";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 643);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 47);
            this.button5.TabIndex = 9;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "Transaksi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pelanggan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelanggan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan)).EndInit();
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.groupBox_proses.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox_data;
        public System.Windows.Forms.DataGridView dataGridView_Pelanggan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.GroupBox groupBox_form;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_NoTelepon;
        private System.Windows.Forms.TextBox textBox_Alamat;
        private System.Windows.Forms.TextBox textBox_NamaPelanggan;
        private System.Windows.Forms.TextBox textBox_IdPelanggan;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_baru;
    }
}