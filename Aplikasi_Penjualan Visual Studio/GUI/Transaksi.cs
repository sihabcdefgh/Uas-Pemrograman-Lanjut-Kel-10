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
    public partial class Transaksi : Form
    {
        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi konn = new Kelas.Koneksi();
        private object row;

        private void bersih()
        {
            textBox_nokwitansi.Text = "";
            DateTimePicker_kwitansi.Value = DateTime.Now;
            textBox_idpelanggan.Text = "";
            textBox_namapelanggan.Text = "";
            textBox_kodebarang.Text = "";
            textBox_namabarang.Text = "";
            noKwitansi.Text = "";
            textBox_hargabarang.Text = "0";
            textBox_jumlah.Text = "0";
            textBox_idpelanggan.Enabled = false;
            textBox_namapelanggan.Enabled = false;
            textBox_kodebarang.Enabled = false;
            textBox_namabarang.Enabled = false;
            textBox_hargabarang.Enabled = false;
            button_min.Enabled = false;
            btn_caripelanggan.Enabled = false;
        }

        private void awal()
        {
            bersih();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();

                    cmd = new SqlCommand("SELECT * FROM vw_penjualan order by NoKwitansi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_penjualan");
                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_penjualan";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.AllowUserToAddRows = false;
                    dataGridView_transaksi.Refresh();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
                groupBox_transaksi.Enabled = true;
            }
        }

        void auto_number()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NoKwitansi from tbl_penjualan where NoKwitansi in (select max(NoKwitansi) from tbl_penjualan) order by NoKwitansi desc", conn);

            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoKwitansi"].ToString().Length - 12, 4)) + 1;

                string joinstr = "0000" + hitung;
                urut = "Trx-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
            }
            else
            {
                urut = "Trx-0001/" + DateTime.Now.ToString("MM/yyyy");
            }
            rd.Close();
            textBox_nokwitansi.Text = urut;
            textBox_nokwitansi.Enabled = false;
            conn.Close();
        }

        public Transaksi()
        {
            InitializeComponent();
            awal();
            auto_number();
        }

        private void totalseluruh()
        {
            SqlConnection conn = konn.GetConn();
            {

                conn.Open();
                cmd = new SqlCommand("select sum(harga*jumlah) as TotalBayar from vw_detail where NoKwitansi= '" + textBox_nokwitansi.Text + "' ", conn);
                cmd.Connection = conn;
                int result = ((int)cmd.ExecuteScalar());
                String TotalSeluruh = result.ToString();
                lbl_total.Text = result.ToString();
                conn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barang menu = new Barang();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pelanggan menu = new Pelanggan();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transaksi menu = new Transaksi();
            menu.Show();
            this.Hide();
        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Transaksi menu = new Transaksi();
            menu.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Pelanggan menu = new Pelanggan();
            menu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Barang menu = new Barang();
            menu.Show();
            this.Hide();
        }

        private void button_caripelanggan_Click(object sender, EventArgs e)
        {
            DialogPelanggan plgn = new DialogPelanggan();
            plgn.ShowDialog();
            textBox_idpelanggan.Text = plgn.ambil_id_pelanggan;
            textBox_namapelanggan.Text = plgn.ambil_nama_pelanggan;
        }

        private void button_caribarang_Click(object sender, EventArgs e)
        {
            DialogBarang brg = new DialogBarang();
            brg.ShowDialog();
            textBox_kodebarang.Text = brg.ambil_kode_barang;
            textBox_namabarang.Text = brg.ambil_nama_barang;
            textBox_hargabarang.Text = brg.ambil_harga;
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            awal();
            auto_number();
            DateTimePicker_kwitansi.Focus();
            button_caripelanggan.Enabled = true;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if (textBox_nokwitansi.Text.Trim() == "" || textBox_idpelanggan.Text.Trim() == "" || textBox_kodebarang.Text.Trim() == "" || textBox_jumlah.Text.Trim() == "")
                {
                    MessageBox.Show("Data belum lengkap, lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_penjualan where NoKwitansi = '" + textBox_nokwitansi.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Simpan_DetailPenjualan();
                        totalseluruh();
                    }
                    else
                    {
                        Simpan_MasterPenjualan();
                        Simpan_DetailPenjualan();
                        totalseluruh();
                    }
                    RefreshTransaksi();
                    button_caripelanggan.Enabled = false;
                    btn_caripelanggan.Enabled = true;
                    groupBox_transaksi.Enabled = true;
                    
                }
            }
        }

        private void btn_caripelanggan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaksi Selesai");
            //Laporan.LaporanTransaksi a = new Laporan.LaporanTransaksi(textBox_nokwitansi.Text);
            //a.show();
            awal();

            lbl_total.Text = "0";
            btn_caripelanggan.Enabled = true;
        }

        private void Simpan_DetailPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tbl_detailpenjualan values('" + textBox_nokwitansi.Text + "','" + textBox_kodebarang.Text + "','" + textBox_jumlah.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void Simpan_MasterPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tbl_penjualan values('" + textBox_nokwitansi.Text + "','" + DateTimePicker_kwitansi.Text + "', '" + textBox_idpelanggan.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }


        }

        private void refresh_penjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from vw_detail where NoKwitansi = '" + textBox_nokwitansi.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_detail");
                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_detail";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.AllowUserToAddRows = false;
                    dataGridView_transaksi.Refresh();
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

        private void RefreshTransaksi()
        {
            refresh_penjualan();
            textBox_kodebarang.Clear();
            textBox_namabarang.Clear();
            textBox_hargabarang.Text = "0";
            textBox_jumlah.Text = "0";
            textBox_jumlah.Focus();

        }

        private void dataGridView_transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button_plus.Enabled = false;
            button_min.Enabled = true;
            DataGridViewRow row = this.dataGridView_transaksi.Rows[e.RowIndex];
            noKwitansi.Text = row.Cells["NoKwitansi"].Value.ToString();
            textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
            textBox_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
            textBox_hargabarang.Text = row.Cells["Harga"].Value.ToString();
            textBox_jumlah.Text = row.Cells["Jumlah"].Value.ToString();
            
        }

        private void button_min_Click(object sender, EventArgs e)
        {   
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("delete from tbl_detailpenjualan where NoKwitansi = '" + noKwitansi.Text + "' AND KodeBarang = '" + textBox_kodebarang.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                totalseluruh();
                RefreshTransaksi();
                button_plus.Enabled = true;
                button_min.Enabled = false;
            }
        }

        private void button_caribarang_Click_1(object sender, EventArgs e)
        {
            DialogBarang brg = new DialogBarang();
            brg.ShowDialog();
            textBox_kodebarang.Text = brg.ambil_kode_barang;
            textBox_namabarang.Text = brg.ambil_nama_barang;
            textBox_hargabarang.Text = brg.ambil_harga;
        }

        private void penomoran_datagrid(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView_transaksi.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
