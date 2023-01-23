namespace Aplikasi_Penjualan.GUI
{
    partial class FormBarang
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
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.comboBox_satuan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_stok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_namabarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kodebarang = new System.Windows.Forms.TextBox();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.dataGridView_barang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.groupBox_form.SuspendLayout();
            this.groupBox_proses.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.comboBox_satuan);
            this.groupBox_form.Controls.Add(this.label5);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.textBox_stok);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.textBox_harga);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.textBox_namabarang);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Controls.Add(this.textBox_kodebarang);
            this.groupBox_form.Location = new System.Drawing.Point(12, 12);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(387, 280);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = "Form Barang";
            this.groupBox_form.Enter += new System.EventHandler(this.groupBox_form_Enter);
            // 
            // comboBox_satuan
            // 
            this.comboBox_satuan.FormattingEnabled = true;
            this.comboBox_satuan.Items.AddRange(new object[] {
            "Unit",
            "Kodi",
            "Lusin",
            "Box"});
            this.comboBox_satuan.Location = new System.Drawing.Point(110, 237);
            this.comboBox_satuan.Name = "comboBox_satuan";
            this.comboBox_satuan.Size = new System.Drawing.Size(271, 40);
            this.comboBox_satuan.TabIndex = 10;
            this.comboBox_satuan.SelectedIndexChanged += new System.EventHandler(this.comboBox_satuan_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Satuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok";
            // 
            // textBox_stok
            // 
            this.textBox_stok.Location = new System.Drawing.Point(110, 186);
            this.textBox_stok.Name = "textBox_stok";
            this.textBox_stok.Size = new System.Drawing.Size(100, 39);
            this.textBox_stok.TabIndex = 6;
            this.textBox_stok.TextChanged += new System.EventHandler(this.textBox_stok_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga Barang";
            // 
            // textBox_harga
            // 
            this.textBox_harga.Location = new System.Drawing.Point(110, 136);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(162, 39);
            this.textBox_harga.TabIndex = 4;
            this.textBox_harga.TextChanged += new System.EventHandler(this.textBox_harga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Barang";
            // 
            // textBox_namabarang
            // 
            this.textBox_namabarang.Location = new System.Drawing.Point(110, 90);
            this.textBox_namabarang.Name = "textBox_namabarang";
            this.textBox_namabarang.Size = new System.Drawing.Size(271, 39);
            this.textBox_namabarang.TabIndex = 2;
            this.textBox_namabarang.TextChanged += new System.EventHandler(this.textBox_namabarang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Barang";
            // 
            // textBox_kodebarang
            // 
            this.textBox_kodebarang.Location = new System.Drawing.Point(110, 42);
            this.textBox_kodebarang.Name = "textBox_kodebarang";
            this.textBox_kodebarang.Size = new System.Drawing.Size(100, 39);
            this.textBox_kodebarang.TabIndex = 0;
            this.textBox_kodebarang.TextChanged += new System.EventHandler(this.textBox_kodebarang_TextChanged);
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Location = new System.Drawing.Point(12, 290);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Size = new System.Drawing.Size(388, 186);
            this.groupBox_proses.TabIndex = 1;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = "Proses";
            // 
            // button_hapus
            // 
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_ubah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_baru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baru.Location = new System.Drawing.Point(10, 55);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(75, 32);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "&Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.Controls.Add(this.dataGridView_barang);
            this.groupBox_data.Controls.Add(this.label6);
            this.groupBox_data.Controls.Add(this.textBox_cari);
            this.groupBox_data.Location = new System.Drawing.Point(405, 12);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(792, 464);
            this.groupBox_data.TabIndex = 2;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Data Barang";
            // 
            // dataGridView_barang
            // 
            this.dataGridView_barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barang.Location = new System.Drawing.Point(10, 90);
            this.dataGridView_barang.Name = "dataGridView_barang";
            this.dataGridView_barang.RowHeadersWidth = 62;
            this.dataGridView_barang.Size = new System.Drawing.Size(776, 368);
            this.dataGridView_barang.TabIndex = 13;
            this.dataGridView_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellClick);
            this.dataGridView_barang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellContentClick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cari Barang (Kode / Nama)";
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Location = new System.Drawing.Point(198, 37);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(588, 39);
            this.textBox_cari.TabIndex = 11;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 488);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.groupBox_proses.ResumeLayout(false);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_stok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_namabarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kodebarang;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.DataGridView dataGridView_barang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.ComboBox comboBox_satuan;
        private System.Windows.Forms.Label label5;
    }
}