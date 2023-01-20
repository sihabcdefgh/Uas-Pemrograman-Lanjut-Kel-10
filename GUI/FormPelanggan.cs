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


    public partial class FormPelanggan : Form
    {


        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void bersih()
        {
            textBox_IdPelanggan.Text = "";
            textBox_NamaPelanggan.Text = "";
            textBox_NoTelepon.Text = "";
            textBox_Alamat.Text = "";
            textBox_cari.Text = "";
            textBox_IdPelanggan.Focus();
            
        }

        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;

        }


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
                    dataGridView_Pelanggan.DataSource = ds;
                    dataGridView_Pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_Pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Pelanggan.AllowUserToAddRows = false;
                    dataGridView_Pelanggan.Refresh();
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
                    dataGridView_Pelanggan.DataSource = ds;
                    dataGridView_Pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_Pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Pelanggan.AllowUserToAddRows = false;
                    dataGridView_Pelanggan.Refresh();
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
            cmd = new SqlCommand("select IdPelanggan from tbl_pelanggan where IdPelanggan in (select max(IdPelanggan) from tbl_pelanggan) order by IdPelanggan desc", conn);

            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IdPelanggan"].ToString().Length - 3, 3)) + 1;

                string joinstr = "000" + hitung;
                urut = "P" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "P001";
            }
            rd.Close();
            textBox_IdPelanggan.Enabled = false;
            textBox_IdPelanggan.Text = urut;
            conn.Close();

        }

        public FormPelanggan()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            
            refresh_pelanggan();
            auto_number();
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_pelanggan();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (textBox_IdPelanggan.Text.Trim() == "" || textBox_NamaPelanggan.Text.Trim() == "" || textBox_Alamat.Text.Trim() == "" || textBox_NoTelepon.Text.Trim() == "" )
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tbl_pelanggan values ('" +textBox_IdPelanggan.Text + "', '" + textBox_NamaPelanggan.Text + "', '" + textBox_Alamat.Text + "', '" + textBox_NoTelepon.Text + "')", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_pelanggan();
                    bersih();
                    
                    auto_number();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void dataGridView_Pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);

                DataGridViewRow row = this.dataGridView_Pelanggan.Rows[e.RowIndex];
                textBox_IdPelanggan.Text = row.Cells["IdPelanggan"].Value.ToString();
                textBox_NamaPelanggan.Text = row.Cells["NamaPelanggan"].Value.ToString();
                textBox_Alamat.Text = row.Cells["Alamat"].Value.ToString();
                textBox_NoTelepon.Text = row.Cells["NoTelepon"].Value.ToString();
                

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (textBox_IdPelanggan.Text.Trim() == "" || textBox_NamaPelanggan.Text.Trim() == "" || textBox_Alamat.Text.Trim() == "" || textBox_NoTelepon.Text.Trim() == "" )
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tbl_pelanggan set NamaPelanggan = '" + textBox_NamaPelanggan.Text + "', Alamat = '" + textBox_Alamat.Text + "', NoTelepon = '" + textBox_NoTelepon.Text + "' where IdPelanggan = '" + textBox_IdPelanggan.Text + "'", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_pelanggan();
                    bersih();
                    auto_number();
                    atur_tombol(false);
                    
                    button_simpan.Enabled = true;


                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data Pelanggan : " + textBox_NamaPelanggan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                {
                    cmd = new SqlCommand("delete from tbl_pelanggan where IdPelanggan = '" + textBox_IdPelanggan.Text + "'", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Pelanggan " + textBox_IdPelanggan.Text + "Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_pelanggan();
                    bersih();
                    auto_number();
                    atur_tombol(false);
                    
                    button_simpan.Enabled = true;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            bersih();
            atur_tombol(false);
            auto_number();
            button_simpan.Enabled = true;

        }

        private void dataGridView_Pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {

        }
    }
}
