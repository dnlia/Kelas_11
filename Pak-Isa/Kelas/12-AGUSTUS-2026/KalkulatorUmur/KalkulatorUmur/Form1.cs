using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorUmur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUmur.Text, out int umur) || umur < 0)
            {
                MessageBox.Show("Silakan masukkan angka umur yang valid (minimal 0).",
                                "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ambil tanggal acuan dari form
            DateTime tanggalHariIni = DateTime.Today;

            // 3. Logika Perhitungan
            DateTime tanggalLahir = tanggalHariIni.AddYears(-umur);


            // 4. Tampilkan Hasil
            lblHasil.Text = $"Hasil Perkiraan Tanggal Lahir:\n" +
                    $"Tanggal: {tanggalLahir.Day}\n" +
                    $"Bulan: {tanggalLahir.ToString("MMMM")}\n" +
                    $"Tahun: {tanggalLahir.Year}\n\n" +
                    $"Format Lengkap: {tanggalLahir.ToString("dd MMMM yyyy")}";
        }
    }
}
