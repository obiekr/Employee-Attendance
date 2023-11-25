using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ProjekAkhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // change connstring to your own connection string
        private static string connstring = "Data Source=BUKANADRIAN9\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connstring);

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string user = textBox1.Text;
            string password = textBox2.Text;

            string query = $"select * from Pegawai where IDPegawai = '{user}' and Password = '{password}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            conn.Close();

            if(dt.Rows.Count > 0)
            {
                Menu mn = new Menu();
                mn.Data = dt;
                mn.conn = conn;
                mn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid");
            }



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register rs = new Register();
            rs.conn = conn;
            rs.ShowDialog();
        }
    }
}
//test