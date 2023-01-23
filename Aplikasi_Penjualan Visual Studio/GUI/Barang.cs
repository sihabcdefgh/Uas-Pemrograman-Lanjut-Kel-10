using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penjualan.GUI
{
    public partial class Barang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;


        Kelas.Koneksi konn = new Kelas.Koneksi();

       

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }



        void bersih()
        {
            textBox_kodebarang.Text = "";
            textBox_namabarang.Text = "";
            textBox_harga.Text = "0";
            textBox_stok.Text = "0";
            textBox1.Text = "";
            comboBox_satuan.Text = "-Pilih Satuan-";
        }
        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;

        }


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
                    cmd = new SqlCommand("select * from tbl_barang where KodeBarang like '%" + textBox1.Text + "%' or NamaBarang like '%" + textBox1.Text + "%'", conn);
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


        void auto_number()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeBarang from tbl_barang where KodeBarang in (select max(KodeBarang) from tbl_barang) order by KodeBarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt32(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;

                string joinstr = "000" + hitung;
                urut = "B" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "B001";
            }
            rd.Close();
            textBox_kodebarang.Enabled = false;
            textBox_kodebarang.Text = urut;
            conn.Close();

        }

        public Barang()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);

            refresh_barang();
            auto_number();
        }



        private void FormBarang_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bersih();
            atur_tombol(false);
            button_simpan.Enabled = true;
            auto_number();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox_kodebarang.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" || textBox_stok.Text.Trim() == "" || textBox_harga.Text.Trim() == "" || comboBox_satuan.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tbl_barang values ('" + textBox_kodebarang.Text + "', '" + textBox_namabarang.Text + "', '" + textBox_harga.Text + "', '" + textBox_stok.Text + "', '" + comboBox_satuan.Text + "')", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_barang();
                    bersih();
                    atur_tombol(false);
                    auto_number();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox_kodebarang.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" || textBox_stok.Text.Trim() == "" || textBox_harga.Text.Trim() == "" || comboBox_satuan.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tbl_barang set NamaBarang = '" + textBox_namabarang.Text + "', Harga = '" + textBox_harga.Text + "', Stok = '" + textBox_stok.Text + "', Satuan = '" + comboBox_satuan.Text + "' where KodeBarang = '" + textBox_kodebarang.Text + "'", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_barang();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                    button_simpan.Enabled = true;


                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data barang : " + textBox_namabarang.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                {
                    cmd = new SqlCommand("delete from tbl_barang where KodeBarang = '" + textBox_kodebarang.Text + "'", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Barang Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_barang();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                    button_simpan.Enabled = true;
                }
            }
        }

        private void dataGridView_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);

                DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox_harga.Text = row.Cells["Harga"].Value.ToString();
                textBox_stok.Text = row.Cells["Stok"].Value.ToString();
                comboBox_satuan.Text = row.Cells["Satuan"].Value.ToString();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            cari_barang();
        }
    }
}
