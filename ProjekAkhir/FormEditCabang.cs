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
    public partial class FormEditCabang : Form
    {
        public FormEditCabang()
        {
            InitializeComponent();
        }
        public SqlConnection conn { get; set; }

        // private static string connstring = "Data Source=BUKANADRIAN9\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
        // private static SqlConnection conn = new SqlConnection(connstring);

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Cabang(IDCabang, NamaCabang) VALUES (@id, @nama)", conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@nama", textBox2.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inputed");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Cabang set NamaCabang = @nama WHERE IDCabang = @id",conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@nama", textBox2.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE Cabang WHERE IDCabang = @id", conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted");
            conn.Close();
        }
    }
}
