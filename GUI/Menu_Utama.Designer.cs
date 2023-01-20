namespace Aplikasi_Penjualan.GUI
{
    partial class Menu_Utama
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_login = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.submenu_keluar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_master = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_barang = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_pelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_laporanbrg = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_paoranplgn = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pengaturan = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_ubahpw = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_tambahpengguna = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tentang = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_info = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_login,
            this.submenu_logout,
            this.toolStripMenuItem1,
            this.submenu_keluar});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(54, 29);
            this.menu_file.Text = "&File";
            // 
            // submenu_login
            // 
            this.submenu_login.Name = "submenu_login";
            this.submenu_login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.submenu_login.Size = new System.Drawing.Size(293, 34);
            this.submenu_login.Text = "&Login";
            this.submenu_login.Click += new System.EventHandler(this.submenu_login_Click);
            // 
            // submenu_logout
            // 
            this.submenu_logout.Name = "submenu_logout";
            this.submenu_logout.Size = new System.Drawing.Size(293, 34);
            this.submenu_logout.Text = "&Logout";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 6);
            // 
            // submenu_keluar
            // 
            this.submenu_keluar.Name = "submenu_keluar";
            this.submenu_keluar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.submenu_keluar.Size = new System.Drawing.Size(293, 34);
            this.submenu_keluar.Text = "Keluar Aplikasi";
            // 
            // menu_master
            // 
            this.menu_master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_barang,
            this.submenu_pelanggan});
            this.menu_master.Name = "menu_master";
            this.menu_master.Size = new System.Drawing.Size(124, 29);
            this.menu_master.Text = "&Master Data";
            // 
            // submenu_barang
            // 
            this.submenu_barang.Name = "submenu_barang";
            this.submenu_barang.Size = new System.Drawing.Size(196, 34);
            this.submenu_barang.Text = "&Barang";
            this.submenu_barang.Click += new System.EventHandler(this.submenu_barang_Click);
            // 
            // submenu_pelanggan
            // 
            this.submenu_pelanggan.Name = "submenu_pelanggan";
            this.submenu_pelanggan.Size = new System.Drawing.Size(196, 34);
            this.submenu_pelanggan.Text = "&Pelanggan";
            this.submenu_pelanggan.Click += new System.EventHandler(this.submenu_pelanggan_Click);
            // 
            // menu_transaksi
            // 
            this.menu_transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_penjualan});
            this.menu_transaksi.Name = "menu_transaksi";
            this.menu_transaksi.Size = new System.Drawing.Size(98, 29);
            this.menu_transaksi.Text = "&Transaksi";
            // 
            // submenu_penjualan
            // 
            this.submenu_penjualan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenu_penjualan.Name = "submenu_penjualan";
            this.submenu_penjualan.Size = new System.Drawing.Size(188, 34);
            this.submenu_penjualan.Text = "&Penjualan";
            this.submenu_penjualan.Click += new System.EventHandler(this.submenu_penjualan_Click);
            // 
            // menu_laporan
            // 
            this.menu_laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_laporanbrg,
            this.submenu_paoranplgn});
            this.menu_laporan.Name = "menu_laporan";
            this.menu_laporan.Size = new System.Drawing.Size(92, 29);
            this.menu_laporan.Text = "&Laporan";
            // 
            // submenu_laporanbrg
            // 
            this.submenu_laporanbrg.Name = "submenu_laporanbrg";
            this.submenu_laporanbrg.Size = new System.Drawing.Size(265, 34);
            this.submenu_laporanbrg.Text = "&Laporan Barang";
            // 
            // submenu_paoranplgn
            // 
            this.submenu_paoranplgn.Name = "submenu_paoranplgn";
            this.submenu_paoranplgn.Size = new System.Drawing.Size(265, 34);
            this.submenu_paoranplgn.Text = "&Laporan Pelanggan";
            // 
            // menu_pengaturan
            // 
            this.menu_pengaturan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_ubahpw,
            this.submenu_tambahpengguna});
            this.menu_pengaturan.Name = "menu_pengaturan";
            this.menu_pengaturan.Size = new System.Drawing.Size(117, 29);
            this.menu_pengaturan.Text = "&Pengaturan";
            // 
            // submenu_ubahpw
            // 
            this.submenu_ubahpw.Name = "submenu_ubahpw";
            this.submenu_ubahpw.Size = new System.Drawing.Size(260, 34);
            this.submenu_ubahpw.Text = "&Ubah Password";
            // 
            // submenu_tambahpengguna
            // 
            this.submenu_tambahpengguna.Name = "submenu_tambahpengguna";
            this.submenu_tambahpengguna.Size = new System.Drawing.Size(260, 34);
            this.submenu_tambahpengguna.Text = "&Tambah Pengguna";
            // 
            // menu_tentang
            // 
            this.menu_tentang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_info});
            this.menu_tentang.Name = "menu_tentang";
            this.menu_tentang.Size = new System.Drawing.Size(90, 29);
            this.menu_tentang.Text = "&Tentang";
            // 
            // submenu_info
            // 
            this.submenu_info.Name = "submenu_info";
            this.submenu_info.Size = new System.Drawing.Size(146, 34);
            this.submenu_info.Text = "&Info";
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_master,
            this.menu_transaksi,
            this.menu_laporan,
            this.menu_pengaturan,
            this.menu_tentang});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(948, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.88608F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.11392F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 661);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.45238F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.54762F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 369F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(192, 655);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "barang";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu_Utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indiemart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem menu_file;
        public System.Windows.Forms.ToolStripMenuItem submenu_login;
        public System.Windows.Forms.ToolStripMenuItem submenu_logout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem submenu_keluar;
        public System.Windows.Forms.ToolStripMenuItem menu_master;
        public System.Windows.Forms.ToolStripMenuItem submenu_barang;
        public System.Windows.Forms.ToolStripMenuItem submenu_pelanggan;
        public System.Windows.Forms.ToolStripMenuItem menu_transaksi;
        public System.Windows.Forms.ToolStripMenuItem submenu_penjualan;
        public System.Windows.Forms.ToolStripMenuItem menu_laporan;
        public System.Windows.Forms.ToolStripMenuItem submenu_laporanbrg;
        public System.Windows.Forms.ToolStripMenuItem submenu_paoranplgn;
        public System.Windows.Forms.ToolStripMenuItem menu_pengaturan;
        public System.Windows.Forms.ToolStripMenuItem submenu_ubahpw;
        public System.Windows.Forms.ToolStripMenuItem submenu_tambahpengguna;
        public System.Windows.Forms.ToolStripMenuItem menu_tentang;
        public System.Windows.Forms.ToolStripMenuItem submenu_info;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
    }
}



