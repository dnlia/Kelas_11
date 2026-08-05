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
    public partial class Form5Maskapai : Form
    {

        BandaraEntities db = new BandaraEntities();
        private int idMaskapai = -1;

        public Form5Maskapai()
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

        private void Form5Maskapai_Load(object sender, EventArgs e)
        {
            dataGridMaskapai.AutoGenerateColumns = false;
            dataGridMaskapai.AllowUserToAddRows = false;
            dataGridMaskapai.ReadOnly = true;

            loadMaskapai();
        }

        private void loadMaskapai()
        {
            dataGridMaskapai.DataSource = db.Maskapais.OrderBy(m => m.Nama).ToList();
        }

        private void clearForm()
        {
            namaTxt.Clear();
            perusahaanTxt.Clear();
            deskripsiTxt.Clear();
            kruCount.Value = 10;
            idMaskapai = -1;
            saveBtn.Text = "Simpan";

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (namaTxt.Text == "" || perusahaanTxt.Text == "" || deskripsiTxt.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi!");
                return;
            }

            if (kruCount.Value < 1)
            {
                MessageBox.Show("Jumlah kru minimal 1.");
                return;
            }

            if (idMaskapai == -1)
            {
                Maskapai maskapaiBaru = new Maskapai();

                maskapaiBaru.Nama = namaTxt.Text;
                maskapaiBaru.Perusahaan = perusahaanTxt.Text;
                maskapaiBaru.JumlahKru = Convert.ToInt32(kruCount.Value);
                maskapaiBaru.Deskripsi = deskripsiTxt.Text;

                db.Maskapais.Add(maskapaiBaru);
                MessageBox.Show("Data berhasil ditambahkan!");

            } else
            {
                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);
                editMaskapai.Nama = namaTxt.Text;
                editMaskapai.Perusahaan = perusahaanTxt.Text;
                editMaskapai.JumlahKru = Convert.ToInt32(kruCount.Value);
                editMaskapai.Deskripsi = deskripsiTxt.Text;

                MessageBox.Show("Berhasil mengubah data Maskapai!");
            }

            db.SaveChanges();
            loadMaskapai();
            clearForm();
        }

        private void dataGridMaskapai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridMaskapai.Columns[e.ColumnIndex].Name == "edit")
            {
                idMaskapai = Convert.ToInt32(dataGridMaskapai.Rows[e.RowIndex].Cells["ID"].Value);

                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);
                namaTxt.Text = editMaskapai.Nama;
                perusahaanTxt.Text = editMaskapai.Perusahaan;
                kruCount.Value = editMaskapai.JumlahKru;
                deskripsiTxt.Text = editMaskapai.Deskripsi;

                saveBtn.Text = "Update";
            }
            else if (dataGridMaskapai.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridMaskapai.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (hasil == DialogResult.Yes)
                {
                    Maskapai hapusMaskapai = db.Maskapais.Find(id);
                    db.Maskapais.Remove(hapusMaskapai);
                    db.SaveChanges();
                    
                    MessageBox.Show("Data Maskapai Berhasil dihapus!");
                    loadMaskapai();
                    clearForm();
                }
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}