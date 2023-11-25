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

namespace ProjekAkhir
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public SqlConnection conn { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            // string connstring = "Data Source=BUKANADRIAN9\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            // SqlConnection conn = new SqlConnection(connstring);
            SqlCommand insert = new SqlCommand(
                                $"INSERT INTO Pegawai(IDPegawai, NamaPegawai, AlamatPegawai, EmailPegawai, TglLahirPegawai, Password, Telepon, IDPosisi, IDCabang) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}',  '{textBox7.Text}', '{textBox8.Text}', '{textBox10.Text}' )", conn
                                );
            
                conn.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Anda berhasil melakukan registrasi");
                this.Close();
           
                conn.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
