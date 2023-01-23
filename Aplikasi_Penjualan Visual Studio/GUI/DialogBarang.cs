using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Penjualan.GUI
{
    public partial class DialogBarang : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        public string kodebarang, namabarang, harga = "";

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void refresh_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang where KodeBarang like '%" + textBox_cari.Text + "%' or NamaBarang like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_barang();

        }

        private void dataGridView_barang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                kodebarang = row.Cells["KodeBarang"].Value.ToString();
                namabarang = row.Cells["NamaBarang"].Value.ToString();
                harga = row.Cells["Harga"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());  
            }
        }

        public DialogBarang()
        {
            InitializeComponent();

            refresh_barang();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string ambil_kode_barang
        {
            get
            {
                return kodebarang;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string ambil_nama_barang
        {
            get
            {
                return namabarang;
            }
        }

        public string ambil_harga
        {
            get
            {
                return harga;
            }
        }
    }
}
