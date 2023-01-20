namespace Aplikasi_Penjualan.GUI
{
    partial class FormPelanggan
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
            this.textBox_NoTelepon = new System.Windows.Forms.TextBox();
            this.textBox_Alamat = new System.Windows.Forms.TextBox();
            this.textBox_NamaPelanggan = new System.Windows.Forms.TextBox();
            this.textBox_IdPelanggan = new System.Windows.Forms.TextBox();
            this.dataGridView_Pelanggan = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan)).BeginInit();
            this.groupBox_data.SuspendLayout();
            this.groupBox_proses.SuspendLayout();
            this.groupBox_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_NoTelepon
            // 
            this.textBox_NoTelepon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_NoTelepon.Location = new System.Drawing.Point(143, 240);
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
            this.textBox_NamaPelanggan.Location = new System.Drawing.Point(143, 90);
            this.textBox_NamaPelanggan.Name = "textBox_NamaPelanggan";
            this.textBox_NamaPelanggan.Size = new System.Drawing.Size(238, 39);
            this.textBox_NamaPelanggan.TabIndex = 2;
            // 
            // textBox_IdPelanggan
            // 
            this.textBox_IdPelanggan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_IdPelanggan.Location = new System.Drawing.Point(143, 42);
            this.textBox_IdPelanggan.Name = "textBox_IdPelanggan";
            this.textBox_IdPelanggan.Size = new System.Drawing.Size(100, 39);
            this.textBox_IdPelanggan.TabIndex = 0;
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
            this.dataGridView_Pelanggan.Size = new System.Drawing.Size(776, 368);
            this.dataGridView_Pelanggan.TabIndex = 13;
            this.dataGridView_Pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pelanggan_CellClick);
            this.dataGridView_Pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pelanggan_CellContentClick);
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
            this.textBox_cari.Location = new System.Drawing.Point(215, 37);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(571, 39);
            this.textBox_cari.TabIndex = 11;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.Controls.Add(this.dataGridView_Pelanggan);
            this.groupBox_data.Controls.Add(this.label6);
            this.groupBox_data.Controls.Add(this.textBox_cari);
            this.groupBox_data.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_data.Location = new System.Drawing.Point(405, 12);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(792, 464);
            this.groupBox_data.TabIndex = 5;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Data Pelanggan";
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_proses.Location = new System.Drawing.Point(12, 288);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Size = new System.Drawing.Size(387, 188);
            this.groupBox_proses.TabIndex = 4;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = "Proses";
            // 
            // button_hapus
            // 
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_hapus.Location = new System.Drawing.Point(306, 93);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(75, 32);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "&Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_ubah.Location = new System.Drawing.Point(10, 93);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(75, 32);
            this.button_ubah.TabIndex = 2;
            this.button_ubah.Text = "&Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_simpan.Location = new System.Drawing.Point(306, 55);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(75, 32);
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
            this.button_baru.Size = new System.Drawing.Size(75, 32);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "&Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.textBox_NoTelepon);
            this.groupBox_form.Controls.Add(this.textBox_Alamat);
            this.groupBox_form.Controls.Add(this.textBox_NamaPelanggan);
            this.groupBox_form.Controls.Add(this.textBox_IdPelanggan);
            this.groupBox_form.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_form.Location = new System.Drawing.Point(12, 12);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(387, 270);
            this.groupBox_form.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Pelanggan";
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alamat";
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 488);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pelanggan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan)).EndInit();
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            this.groupBox_proses.ResumeLayout(false);
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NoTelepon;
        private System.Windows.Forms.TextBox textBox_Alamat;
        private System.Windows.Forms.TextBox textBox_NamaPelanggan;
        private System.Windows.Forms.TextBox textBox_IdPelanggan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.GroupBox groupBox_form;
        public System.Windows.Forms.DataGridView dataGridView_Pelanggan;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}