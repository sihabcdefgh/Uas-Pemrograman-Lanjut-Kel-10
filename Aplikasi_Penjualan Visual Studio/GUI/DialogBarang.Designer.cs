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
            this.dataGridView_barang = new System.Windows.Forms.DataGridView();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_Barang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Barang
            // 
            this.groupBox_Barang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.groupBox_Barang.Controls.Add(this.dataGridView_barang);
            this.groupBox_Barang.Controls.Add(this.textBox_cari);
            this.groupBox_Barang.Controls.Add(this.label1);
            this.groupBox_Barang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Barang.Location = new System.Drawing.Point(18, 18);
            this.groupBox_Barang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Barang.Name = "groupBox_Barang";
            this.groupBox_Barang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Barang.Size = new System.Drawing.Size(807, 514);
            this.groupBox_Barang.TabIndex = 0;
            this.groupBox_Barang.TabStop = false;
            this.groupBox_Barang.Text = "Data Barang";
            // 
            // dataGridView_barang
            // 
            this.dataGridView_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barang.Location = new System.Drawing.Point(15, 74);
            this.dataGridView_barang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_barang.Name = "dataGridView_barang";
            this.dataGridView_barang.RowHeadersWidth = 62;
            this.dataGridView_barang.Size = new System.Drawing.Size(783, 431);
            this.dataGridView_barang.TabIndex = 3;
            this.dataGridView_barang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellDoubleClick);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Location = new System.Drawing.Point(348, 20);
            this.textBox_cari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(448, 39);
            this.textBox_cari.TabIndex = 2;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Barang (Kode/Nama)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(810, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DialogBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(843, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_Barang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button1;
    }
}