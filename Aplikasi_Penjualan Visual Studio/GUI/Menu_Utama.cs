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
    public partial class Menu_Utama : Form
    {
        FormBarang brg;
        FormPelanggan plgn;
        FromTransaksi trx;

        void brg_FormClosed(object sender, FormClosedEventArgs e)
        {
            brg = null;
        }

        void plgn_FormClosed(object sender, FormClosedEventArgs e)
        {
            plgn = null;
        }

        void trx_FormClosed(object sender, FormClosedEventArgs e)
        {
            trx = null;
        }



        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void submenu_barang_Click(object sender, EventArgs e)
        {
            if(brg == null)
            {
                brg = new FormBarang();
                brg.MdiParent= this;
                brg.FormClosed+= new FormClosedEventHandler
                    (brg_FormClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void submenu_pelanggan_Click(object sender, EventArgs e)
        {
            if (plgn == null)
            {
                plgn = new FormPelanggan();
                plgn.MdiParent = this;
                plgn.FormClosed += new FormClosedEventHandler
                    (plgn_FormClosed);
                plgn.Show();
            }
            else
            {
                plgn.Activate();
            }
        }

        private void submenu_penjualan_Click(object sender, EventArgs e)
        {
            if (trx == null)
            {
                trx = new FromTransaksi();
                trx.MdiParent = this;
                trx.FormClosed += new FormClosedEventHandler
                    (trx_FormClosed);
                trx.Show();
            }
            else
            {
                trx.Activate();
            }
        }

        private void submenu_login_Click(object sender, EventArgs e)
        {

        }
    }
}
