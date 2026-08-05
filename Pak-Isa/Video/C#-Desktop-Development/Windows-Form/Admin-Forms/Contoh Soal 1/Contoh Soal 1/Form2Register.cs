using Contoh_Soal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contoh_Soal_1
{
    public partial class Form2Register : Form
    {
        BandaraEntities db = new BandaraEntities(); 

        public Form2Register()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berhasil Daftar, Silakan Login");
        }

        private void daftarBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || namaTxt.Text == "" || lahirDate.Value.Date == DateTime.Today || phoneTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Tolong lengkapi semua data yang diperlukan untuk membuat akun baru");
                return;
            }

            bool usernameSudahAda = db.Akuns.Any(a => a.Username == usernameTxt.Text);

            if (usernameSudahAda)
            {
                MessageBox.Show("Username sudah digunakan");
                return;
            }

            if (!phoneTxt.Text.All(char.IsDigit))
            {
                MessageBox.Show("Nomor telepon hanya boleh berisikan angka");
                return;
            }

            if (phoneTxt.Text.Length < 10 || phoneTxt.Text.Length > 15)
            {
                MessageBox.Show("Nomor Telepon harus 10 - 15 digit");
                return;
            }

            if (passwordTxt.Text.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter");
                return;
            }

            int umur = DateTime.Now.Year - lahirDate.Value.Year;

            if (lahirDate.Value.Date > DateTime.Today.AddYears(-umur))
            {
                umur--;
            }

            if (umur < 17)
            {
                MessageBox.Show("Umur Minimal 17 tahun");
                return;
            }

            Akun akunBaru = new Akun();

            akunBaru.Username = usernameTxt.Text;
            akunBaru.Nama = namaTxt.Text;
            akunBaru.TanggalLahir = lahirDate.Value;
            akunBaru.NomorTelepon = phoneTxt.Text;
            akunBaru.Password = passwordTxt.Text;
            akunBaru.MerupakanAdmin = false;

            db.Akuns.Add(akunBaru);
            db.SaveChanges();

            MessageBox.Show("Berhasil membuat akun baru. \nSilahkan Login");

            Form1Login login = new Form1Login();

            login.Show();
            this.Hide();

        }
    }
}
