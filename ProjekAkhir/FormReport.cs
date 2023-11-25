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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReportUntukBoss crub = new CrystalReportUntukBoss();
            crystalReportViewer1.ReportSource = crub;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalReportUntukBoss2 crub2 = new CrystalReportUntukBoss2();
            crystalReportViewer1.ReportSource = crub2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
