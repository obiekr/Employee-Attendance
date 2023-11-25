using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace ProjekAkhir
{
    public partial class FormKhususManajer : Form
    {
        public FormKhususManajer()
        {
            InitializeComponent();
        }

        public SqlConnection conn { get; set; }

        private void FormKhususManajer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalprojectDataSet5.Absen' table. You can move, or remove it, as needed.
            this.absenTableAdapter.Fill(this.finalprojectDataSet5.Absen);
            // TODO: This line of code loads data into the 'finalprojectDataSet4.Pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.finalprojectDataSet4.Pegawai);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            FormCrystalManajer fcm = new FormCrystalManajer();
            fcm.ShowDialog();
        }

        private void printDataBerdasarCabangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrystalManajer2Cabang fcm2c = new FormCrystalManajer2Cabang();
            fcm2c.Show();
        }

        private void printDataKeTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SqlConnection connection = new SqlConnection("Data Source=BUKANADRIAN9\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pegawai", conn);
            TextWriter tw = new StreamWriter("D://Pesan//Pegawai2.csv");
            string output = "ID Pegawai,Nama Pegawai,Alamat Pegawai,Email Pegawai,Tanggal Lahir,Password,Telepon,ID Posisi,ID Cabang\n";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {  
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    output += (dataGridView1.Rows[i].Cells[j].Value.ToString().Trim() + ",");
                }
                output.Substring(0, output.Length-1);
                output+="\n";
            }
            tw.WriteLine(output);
            // tw.WriteLine("ID Pegawai,Nama Pegawai,Alamat Pegawai,Email Pegawai,Tanggal Lahir,Password,Telepon,ID Posisi,ID Cabang");
            // for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            // {  
            //     for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //     {
            //         tw.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ",");
            //     }
            //     tw.WriteLine("");
            // }
            tw.Close();
            MessageBox.Show("Data Exported");
        }
    }
}
