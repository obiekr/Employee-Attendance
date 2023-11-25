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
    public partial class FormKhususBossdanHRD : Form
    {
        public FormKhususBossdanHRD()
        {
            InitializeComponent();
        }

        public SqlConnection conn { get; set; }

        private void FormKhususBossdanHRD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalprojectDataSet3.Pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.finalprojectDataSet3.Pegawai);
            // TODO: This line of code loads data into the 'finalprojectDataSet2.Posisi' table. You can move, or remove it, as needed.
            this.posisiTableAdapter.Fill(this.finalprojectDataSet2.Posisi);
            // TODO: This line of code loads data into the 'finalprojectDataSet1.Cabang' table. You can move, or remove it, as needed.
            this.cabangTableAdapter.Fill(this.finalprojectDataSet1.Cabang);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            fr.ShowDialog();
        }

        private void addDeleteCabangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditCabang fec = new FormEditCabang();
            fec.conn = conn;
            fec.ShowDialog();
        }
    }
}
