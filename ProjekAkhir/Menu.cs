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
    public partial class Menu : Form
    {
        
        public DataTable Data { get; set; }
        public SqlConnection conn { get; set; }

        private static TimeSpan MASUK = TimeSpan.Parse("09:00");
        private static TimeSpan PULANG = TimeSpan.Parse("17:00");

        // private static string connstring = "Data Source=BUKANADRIAN9\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
        // private static SqlConnection conn = new SqlConnection(connstring);

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (Data.Rows[0]["IDPegawai"].ToString().Substring(0, 3).Equals("BOS") || Data.Rows[0]["IDPegawai"].ToString().Substring(0, 3).Equals("HRD"))
            {
                menuBossDanHRDToolStripMenuItem.Enabled = true;
                menuManajerToolStripMenuItem.Enabled = false;
            }
            else if (Data.Rows[0]["IDPegawai"].ToString().Substring(0, 3).Equals("MNJ"))
            {
                menuManajerToolStripMenuItem.Enabled = true;
                menuBossDanHRDToolStripMenuItem.Enabled = false;
            }
            else
            {
                menuBossDanHRDToolStripMenuItem.Enabled = false;
                menuManajerToolStripMenuItem.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e) //logout
        {
            Logout lo = new Logout();
            lo.ShowDialog();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Gaji gj = new Gaji();
            gj.Data = Data;
            gj.conn = conn;
            gj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string tanggal = currentDate.ToString("yyyy-MM-dd");
            string jam = currentDate.ToString("HH:mm");
            string IDPegawai = Data.Rows[0]["IDPegawai"].ToString();
            string IDAbsen = $"{IDPegawai}-{tanggal}";
            int lembur;

            if (currentDate.TimeOfDay.Hours > PULANG.Hours)
            {

                lembur = currentDate.TimeOfDay.Hours - PULANG.Hours;
            }
            else if (currentDate.TimeOfDay.Hours == PULANG.Hours)
            {
                lembur = 0;
            }
            else
            {
                MessageBox.Show("Anda belum boleh pulang");
                return;
            }

            conn.Open();
            string query = $"UPDATE Absen SET JamPulang = '{jam}', Lembur = {lembur} WHERE IDAbsen = '{IDAbsen}' and JamPulang = '23:59'";
            SqlCommand update = new SqlCommand(query, conn);
            update.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Anda dipersilahkan untuk pulang");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string tanggal = currentDate.ToString("yyyy-MM-dd");
            string jam = currentDate.ToString("HH:mm");
            string IDPegawai = Data.Rows[0]["IDPegawai"].ToString();
            string IDAbsen = $"{IDPegawai}-{tanggal}";
            string status;
            if (currentDate.TimeOfDay > MASUK)
            {
                status = "terlambat";
            }
            else
            {
                status = "tepat waktu";
            }

            string izin = "";
            int lembur = 0;

            try
            {
                SqlCommand check = new SqlCommand($"SELECT * FROM Absen WHERE IDAbsen = '{IDAbsen}'", conn);
                conn.Open();
                SqlDataReader reader = check.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);


                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Anda sudah melakukan absensi pada hari ini");
                    button1.Enabled = false;
                    return;
                }
                else
                {
                    SqlCommand query = new SqlCommand(
                                        $"INSERT INTO Absen(IDPegawai, IDAbsen, JamMasuk, JamPulang, Izin, Lembur, Status) VALUES ('{IDPegawai}', '{IDAbsen}', '{jam}', '23:59', '{izin}', {lembur}, '{status}')", conn
                                        );
                    query.ExecuteNonQuery();
                    MessageBox.Show("Anda berhasil melakukan absensi");
                    button1.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Anda gagal melakukan absensi");
            }
            finally
            {
                conn.Close();
            }
        }

        private void lihatReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhususBossdanHRD fkbhd = new FormKhususBossdanHRD();
            fkbhd.conn = conn;
            fkbhd.ShowDialog();
        }

        private void lihatReportUntukManajerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhususManajer fkm = new FormKhususManajer();
            fkm.conn = conn;
            fkm.ShowDialog();
        }
    }
}
