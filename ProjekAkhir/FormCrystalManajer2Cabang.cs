using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekAkhir
{
    public partial class FormCrystalManajer2Cabang : Form
    {
        public FormCrystalManajer2Cabang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport2Cabang cr2c = new CrystalReport2Cabang();
            cr2c.SetParameterValue("P_Cabang", textBox1.Text);
            crystalReportViewer1.ReportSource = cr2c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
