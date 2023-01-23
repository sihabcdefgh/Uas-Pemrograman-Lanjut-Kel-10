namespace Aplikasi_Penjualan.GUI
{
    partial class FromTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromTransaksi));
            this.groupBox_transaksi = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_caripelanggan = new System.Windows.Forms.Button();
            this.DateTimePicker_kwitansi = new System.Windows.Forms.DateTimePicker();
            this.textBox_nokwitansi = new System.Windows.Forms.TextBox();
            this.textBox_namapelanggan = new System.Windows.Forms.TextBox();
            this.textBox_idpelanggan = new System.Windows.Forms.TextBox();
            this.textBox_jumlah = new System.Windows.Forms.TextBox();
            this.dataGridView_transaksi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_min = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_caribarang = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_hargabarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_namabarang = new System.Windows.Forms.TextBox();
            this.textBox_kodebarang = new System.Windows.Forms.TextBox();
            this.btn_caripelanggan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.label_totalseluruh = new System.Windows.Forms.Label();
            this.lbl_totalseluruh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_transaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_transaksi
            // 
            this.groupBox_transaksi.Controls.Add(this.label7);
            this.groupBox_transaksi.Controls.Add(this.label2);
            this.groupBox_transaksi.Controls.Add(this.label1);
            this.groupBox_transaksi.Controls.Add(this.button_caripelanggan);
            this.groupBox_transaksi.Controls.Add(this.DateTimePicker_kwitansi);
            this.groupBox_transaksi.Controls.Add(this.textBox_nokwitansi);
            this.groupBox_transaksi.Controls.Add(this.textBox_namapelanggan);
            this.groupBox_transaksi.Controls.Add(this.textBox_idpelanggan);
            this.groupBox_transaksi.Controls.Add(this.pictureBox1);
            this.groupBox_transaksi.Location = new System.Drawing.Point(12, 12);
            this.groupBox_transaksi.Name = "groupBox_transaksi";
            this.groupBox_transaksi.Size = new System.Drawing.Size(501, 236);
            this.groupBox_transaksi.TabIndex = 1;
            this.groupBox_transaksi.TabStop = false;
            this.groupBox_transaksi.Text = "Transaksi Penjualan";
            this.groupBox_transaksi.Enter += new System.EventHandler(this.groupBox_transaksi_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "No Kwitansi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Pelanggan";
            // 
            // button_caripelanggan
            // 
            this.button_caripelanggan.Location = new System.Drawing.Point(127, 188);
            this.button_caripelanggan.Name = "button_caripelanggan";
            this.button_caripelanggan.Size = new System.Drawing.Size(75, 29);
            this.button_caripelanggan.TabIndex = 6;
            this.button_caripelanggan.Text = "Cari";
            this.button_caripelanggan.UseVisualStyleBackColor = true;
            this.button_caripelanggan.Click += new System.EventHandler(this.button_caripelanggan_Click);
            // 
            // DateTimePicker_kwitansi
            // 
            this.DateTimePicker_kwitansi.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker_kwitansi.CustomFormat = "MM/dd/yyyy";
            this.DateTimePicker_kwitansi.Location = new System.Drawing.Point(225, 28);
            this.DateTimePicker_kwitansi.Name = "DateTimePicker_kwitansi";
            this.DateTimePicker_kwitansi.Size = new System.Drawing.Size(276, 39);
            this.DateTimePicker_kwitansi.TabIndex = 5;
            this.DateTimePicker_kwitansi.Value = new System.DateTime(2023, 1, 11, 20, 12, 29, 0);
            this.DateTimePicker_kwitansi.ValueChanged += new System.EventHandler(this.DateTimePicker_kwitansi_ValueChanged);
            // 
            // textBox_nokwitansi
            // 
            this.textBox_nokwitansi.Location = new System.Drawing.Point(339, 74);
            this.textBox_nokwitansi.Name = "textBox_nokwitansi";
            this.textBox_nokwitansi.Size = new System.Drawing.Size(162, 39);
            this.textBox_nokwitansi.TabIndex = 4;
            // 
            // textBox_namapelanggan
            // 
            this.textBox_namapelanggan.Location = new System.Drawing.Point(253, 188);
            this.textBox_namapelanggan.Name = "textBox_namapelanggan";
            this.textBox_namapelanggan.Size = new System.Drawing.Size(248, 39);
            this.textBox_namapelanggan.TabIndex = 2;
            // 
            // textBox_idpelanggan
            // 
            this.textBox_idpelanggan.Location = new System.Drawing.Point(6, 188);
            this.textBox_idpelanggan.Name = "textBox_idpelanggan";
            this.textBox_idpelanggan.Size = new System.Drawing.Size(101, 39);
            this.textBox_idpelanggan.TabIndex = 1;
            // 
            // textBox_jumlah
            // 
            this.textBox_jumlah.Location = new System.Drawing.Point(253, 115);
            this.textBox_jumlah.Name = "textBox_jumlah";
            this.textBox_jumlah.Size = new System.Drawing.Size(100, 39);
            this.textBox_jumlah.TabIndex = 3;
            // 
            // dataGridView_transaksi
            // 
            this.dataGridView_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transaksi.Location = new System.Drawing.Point(6, 28);
            this.dataGridView_transaksi.Name = "dataGridView_transaksi";
            this.dataGridView_transaksi.RowHeadersWidth = 62;
            this.dataGridView_transaksi.Size = new System.Drawing.Size(666, 357);
            this.dataGridView_transaksi.TabIndex = 2;
            this.dataGridView_transaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_transaksi_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_transaksi);
            this.groupBox2.Location = new System.Drawing.Point(519, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 391);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Transaksi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_min);
            this.groupBox3.Controls.Add(this.button_plus);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button_caribarang);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_hargabarang);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_namabarang);
            this.groupBox3.Controls.Add(this.textBox_jumlah);
            this.groupBox3.Controls.Add(this.textBox_kodebarang);
            this.groupBox3.Location = new System.Drawing.Point(11, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 172);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ambil Barang";
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(427, 91);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(62, 58);
            this.button_min.TabIndex = 15;
            this.button_min.Text = "-";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(359, 91);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(62, 58);
            this.button_plus.TabIndex = 14;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Jumlah";
            // 
            // button_caribarang
            // 
            this.button_caribarang.Location = new System.Drawing.Point(127, 49);
            this.button_caribarang.Name = "button_caribarang";
            this.button_caribarang.Size = new System.Drawing.Size(75, 29);
            this.button_caribarang.TabIndex = 9;
            this.button_caribarang.Text = "Cari";
            this.button_caribarang.UseVisualStyleBackColor = true;
            this.button_caribarang.Click += new System.EventHandler(this.button_caribarang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Harga Barang";
            // 
            // textBox_hargabarang
            // 
            this.textBox_hargabarang.Location = new System.Drawing.Point(10, 115);
            this.textBox_hargabarang.Name = "textBox_hargabarang";
            this.textBox_hargabarang.Size = new System.Drawing.Size(101, 39);
            this.textBox_hargabarang.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kode Barang";
            // 
            // textBox_namabarang
            // 
            this.textBox_namabarang.Location = new System.Drawing.Point(253, 49);
            this.textBox_namabarang.Name = "textBox_namabarang";
            this.textBox_namabarang.Size = new System.Drawing.Size(242, 39);
            this.textBox_namabarang.TabIndex = 2;
            // 
            // textBox_kodebarang
            // 
            this.textBox_kodebarang.Location = new System.Drawing.Point(6, 49);
            this.textBox_kodebarang.Name = "textBox_kodebarang";
            this.textBox_kodebarang.Size = new System.Drawing.Size(101, 39);
            this.textBox_kodebarang.TabIndex = 0;
            // 
            // btn_caripelanggan
            // 
            this.btn_caripelanggan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_caripelanggan.Location = new System.Drawing.Point(351, 444);
            this.btn_caripelanggan.Name = "btn_caripelanggan";
            this.btn_caripelanggan.Size = new System.Drawing.Size(75, 32);
            this.btn_caripelanggan.TabIndex = 6;
            this.btn_caripelanggan.Text = "&Simpan";
            this.btn_caripelanggan.UseVisualStyleBackColor = true;
            this.btn_caripelanggan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_baru
            // 
            this.button_baru.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_baru.Location = new System.Drawing.Point(48, 444);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(75, 32);
            this.button_baru.TabIndex = 5;
            this.button_baru.Text = "&Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // label_totalseluruh
            // 
            this.label_totalseluruh.AutoSize = true;
            this.label_totalseluruh.Location = new System.Drawing.Point(874, 444);
            this.label_totalseluruh.Name = "label_totalseluruh";
            this.label_totalseluruh.Size = new System.Drawing.Size(27, 32);
            this.label_totalseluruh.TabIndex = 16;
            this.label_totalseluruh.Text = "0";
            // 
            // lbl_totalseluruh
            // 
            this.lbl_totalseluruh.AutoSize = true;
            this.lbl_totalseluruh.Location = new System.Drawing.Point(751, 444);
            this.lbl_totalseluruh.Name = "lbl_totalseluruh";
            this.lbl_totalseluruh.Size = new System.Drawing.Size(166, 32);
            this.lbl_totalseluruh.TabIndex = 17;
            this.lbl_totalseluruh.Text = "Total Seluruh :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FromTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 488);
            this.Controls.Add(this.lbl_totalseluruh);
            this.Controls.Add(this.label_totalseluruh);
            this.Controls.Add(this.btn_caripelanggan);
            this.Controls.Add(this.button_baru);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_transaksi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FromTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.FromTransaksi_Load);
            this.groupBox_transaksi.ResumeLayout(false);
            this.groupBox_transaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_transaksi;
        private System.Windows.Forms.DateTimePicker DateTimePicker_kwitansi;
        private System.Windows.Forms.TextBox textBox_jumlah;
        private System.Windows.Forms.TextBox textBox_namapelanggan;
        private System.Windows.Forms.TextBox textBox_idpelanggan;
        private System.Windows.Forms.DataGridView dataGridView_transaksi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_namabarang;
        private System.Windows.Forms.TextBox textBox_kodebarang;
        private System.Windows.Forms.Button btn_caripelanggan;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.Button button_caripelanggan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_caribarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_hargabarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_totalseluruh;
        private System.Windows.Forms.Label lbl_totalseluruh;
        public System.Windows.Forms.TextBox textBox_nokwitansi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}