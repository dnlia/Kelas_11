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
    public partial class Form7KodePromo : Form
    {
        BandaraEntities db = new BandaraEntities();
        private int idPromo = -1;

        public Form7KodePromo()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Close();
            dashboard.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Close();
            dashboard.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4Bandara bandara = new Form4Bandara();
            this.Close();
            bandara.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4Bandara bandara = new Form4Bandara();
            this.Close();
            bandara.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Close();
            maskapai.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Close();
            maskapai.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();
            this.Close();
            jadwal.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();
            this.Close();
            jadwal.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form7KodePromo promo = new Form7KodePromo();
            this.Close();
            promo.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7KodePromo promo = new Form7KodePromo();
            this.Close();
            promo.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();
            this.Close();
            status.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();
            this.Close();
            status.Show();
        }

        private void Form7KodePromo_Load(object sender, EventArgs e)
        {
            dataGridPromo.AutoGenerateColumns = false;
            dataGridPromo.AllowUserToAddRows = false;
            dataGridPromo.ReadOnly = true;

            loadData();
        }

        private void loadData()
        {
            dataGridPromo.DataSource = db.KodePromoes.ToList();

        }

        private void clearForm()
        {
            promoTxt.Clear();
            deskripsiTxt.Clear();

            persentCount.Value = 0;
            maxCount.Value = 0;

            berlakuDate.Value = DateTime.Now;

            idPromo = -1;

            simpanBtn.Text = "Simpan";
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void promoTxt_TextChanged(object sender, EventArgs e)
        {
            promoTxt.Text = promoTxt.Text.ToUpper();
            promoTxt.SelectionStart = promoTxt.Text.Length;
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            // Validasi data tidak boleh kosong
            if (promoTxt.Text == "" || deskripsiTxt.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi");
                return;
            }


            // validasi kode promo harus unik
            bool kodeSudahAda = db.KodePromoes.Any(p => p.Kode == promoTxt.Text && p.ID != idPromo);
            if (kodeSudahAda)
            {
                MessageBox.Show("Kode promo sudah digunakan");
                return;
            }


            // Validasi persentase dan maksimal
            if (persentCount.Value < 1 || maxCount.Value < 1)
            {
                MessageBox.Show("Input nilai tidak boleh kurang dari 1");
                return;
            }

            // Validasi tanggal berlaku
            if (berlakuDate.Value < DateTime.Today)
            {
                MessageBox.Show("Tanggal berlaku tidak boleh kurang dari hari ini");
                return;
            }

            if (idPromo == -1)
            {
                KodePromo tambahPromo = new KodePromo();

                tambahPromo.Kode = promoTxt.Text;
                tambahPromo.BerlakuSampai = berlakuDate.Value;
                tambahPromo.PersentaseDiskon = Convert.ToInt32(persentCount.Value);
                tambahPromo.MaksimumDiskon = Convert.ToInt32(maxCount.Value);
                tambahPromo.Deskripsi = deskripsiTxt.Text;
                
                db.KodePromoes.Add(tambahPromo);
                db.SaveChanges();

                MessageBox.Show("Data berhasil ditambahkan");
                loadData();
                clearForm();
            }
            else
            {
                KodePromo editPromo = db.KodePromoes.Find(idPromo);

                editPromo.Kode = promoTxt.Text;
                editPromo.BerlakuSampai = berlakuDate.Value;
                editPromo.PersentaseDiskon = Convert.ToInt32(persentCount.Value);
                editPromo.MaksimumDiskon = Convert.ToInt32(maxCount.Value);
                editPromo.Deskripsi = deskripsiTxt.Text;

                MessageBox.Show("Data berhasil diubah");
                loadData();
                clearForm();
            }
        }

        private void dataGridPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridPromo.Columns[e.ColumnIndex].Name == "edit")
            {
                idPromo = Convert.ToInt32(dataGridPromo.Rows[e.RowIndex].Cells["ID"].Value);

                KodePromo editPromo = db.KodePromoes.Find(idPromo);

                promoTxt.Text = editPromo.Kode;
                berlakuDate.Value = editPromo.BerlakuSampai;
                persentCount.Value = Convert.ToInt32(editPromo.PersentaseDiskon);
                maxCount.Value = Convert.ToInt32(editPromo.MaksimumDiskon);
                deskripsiTxt.Text = editPromo.Deskripsi;

                simpanBtn.Text = "Edit";
            }
            else if (dataGridPromo.Columns[e.ColumnIndex].Name == "hapus")
            {
                int idHapus = Convert.ToInt32(dataGridPromo.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    KodePromo hapusPromo = db.KodePromoes.Find(idHapus);
                    db.KodePromoes.Remove(hapusPromo);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil dihapus");
                    loadData();
                    clearForm();
                }
            }
        }
    }
}
