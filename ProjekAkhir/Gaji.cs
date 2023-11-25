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
    public partial class Gaji : Form
    {
        public Gaji()
        {
            InitializeComponent();
            textBox2.Text = "0";
        }
        public DataTable Data { get; set; }
        public SqlConnection conn { get; set; }

        private static int POTONGAN = 100000;
        private static int LEMBUR = 150000;


        private void button1_Click(object sender, EventArgs e)
        {
            // string connstring = "Data Source=BUKANADRIAN9\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            // SqlConnection conn = new SqlConnection(connstring);

            string IDPegawai = Data.Rows[0]["IDPegawai"].ToString();

            SqlCommand gaji = new SqlCommand($"SELECT GajiTetap FROM Posisi PO JOIN Pegawai PE ON PO.IDPosisi = PE.IDPosisi WHERE PE.IDPegawai = '{IDPegawai}'", conn);
            SqlCommand terlambat = new SqlCommand($"SELECT COUNT(Status) AS terlambat FROM Absen WHERE Status = 'terlambat' AND IDPegawai = '{IDPegawai}'", conn);
            SqlCommand lembur = new SqlCommand($"SELECT SUM(Lembur) AS lembur FROM Absen WHERE IDPegawai = '{IDPegawai}'", conn);

            conn.Open();

            SqlDataReader reader = gaji.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            int gaji1 = Convert.ToInt32(dt.Rows[0]["GajiTetap"]); 
            textBox1.Text = "Rp. " + String.Format("{0:n}", gaji1);

            reader = terlambat.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            int terlambat1 = Convert.ToInt32(dt.Rows[0]["terlambat"]) * POTONGAN;
            textBox3.Text = "Rp. " + String.Format("{0:n}", terlambat1);

            reader = lembur.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            int lembur1 = Convert.ToInt32(dt.Rows[0]["Lembur"]) * LEMBUR;
            textBox4.Text = "Rp. " + String.Format("{0:n}", lembur1);

            conn.Close();


            textBox5.Text = "Rp. " + String.Format("{0:n}", gaji1 + Convert.ToInt32(textBox2.Text) + lembur1 - terlambat1);
        }
    }
}
