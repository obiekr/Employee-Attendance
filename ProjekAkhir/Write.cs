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
using System.Text;

namespace ProjekAkhir
{
    public partial class Write : Form
    {
        public Write()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D://Pesan//"+textBox2.Text, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Dari " + textBox1.Text + " Pesan: " + richTextBox1.Text);
            sw.Close();
            fs.Close();
            MessageBox.Show("Pesan Berhasil Terkirim");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
