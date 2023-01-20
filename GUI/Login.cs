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
using Aplikasi_Penjualan.Kelas;

namespace Aplikasi_Penjualan.GUI
{
    public partial class Login : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        Koneksi konn = new Koneksi();

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from tbl_login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah");
            }
        }
    }
}
