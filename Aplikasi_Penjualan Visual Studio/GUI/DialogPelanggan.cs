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
    public partial class DialogPelanggan : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        public string idpelanggan, namapelanggan = "";

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void refresh_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pelanggan", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_pelanggan.DataSource = ds;
                    dataGridView_pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_pelanggan.AllowUserToAddRows = false;
                    dataGridView_pelanggan.Refresh();
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

        void cari_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pelanggan where IdPelanggan like '%" + textBox_cari.Text + "%' or NamaPelanggan like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_pelanggan.DataSource = ds;
                    dataGridView_pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_pelanggan.AllowUserToAddRows = false;
                    dataGridView_pelanggan.Refresh();
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
            cari_pelanggan();
        }

        private void dataGridView_pelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {        
                DataGridViewRow row = this.dataGridView_pelanggan.Rows[e.RowIndex];
                idpelanggan = row.Cells["IdPelanggan"].Value.ToString();
                namapelanggan = row.Cells["NamaPelanggan"].Value.ToString();
                this.Close();


            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public DialogPelanggan()
        {
            InitializeComponent();

            refresh_pelanggan();
        }

        public string ambil_id_pelanggan
        {
            get
            {
                return idpelanggan;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string ambil_nama_pelanggan
        {
            get 
            { 
                return namapelanggan;
            }
        }
    }
}
