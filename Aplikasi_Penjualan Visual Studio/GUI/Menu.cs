using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penjualan.GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

       

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Barang menu = new Barang();
            menu.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Pelanggan menu = new Pelanggan();
            menu.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Transaksi menu = new Transaksi();
            menu.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
