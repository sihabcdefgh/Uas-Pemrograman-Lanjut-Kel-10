namespace Aplikasi_Penjualan.GUI
{
    partial class DialogBarang
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
            this.groupBox_Barang = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.dataGridView_barang = new System.Windows.Forms.DataGridView();
            this.groupBox_Barang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Barang
            // 
            this.groupBox_Barang.Controls.Add(this.dataGridView_barang);
            this.groupBox_Barang.Controls.Add(this.textBox_cari);
            this.groupBox_Barang.Controls.Add(this.label1);
            this.groupBox_Barang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Barang.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Barang.Name = "groupBox_Barang";
            this.groupBox_Barang.Size = new System.Drawing.Size(538, 334);
            this.groupBox_Barang.TabIndex = 0;
            this.groupBox_Barang.TabStop = false;
            this.groupBox_Barang.Text = "Data Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Barang (Kode/Nama)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Location = new System.Drawing.Point(232, 13);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(300, 29);
            this.textBox_cari.TabIndex = 2;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // dataGridView_barang
            // 
            this.dataGridView_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barang.Location = new System.Drawing.Point(10, 48);
            this.dataGridView_barang.Name = "dataGridView_barang";
            this.dataGridView_barang.Size = new System.Drawing.Size(522, 280);
            this.dataGridView_barang.TabIndex = 3;
            this.dataGridView_barang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellDoubleClick);
            // 
            // DialogBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.groupBox_Barang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Barang";
            this.groupBox_Barang.ResumeLayout(false);
            this.groupBox_Barang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Barang;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView_barang;
        private System.Windows.Forms.TextBox textBox_cari;
    }
}