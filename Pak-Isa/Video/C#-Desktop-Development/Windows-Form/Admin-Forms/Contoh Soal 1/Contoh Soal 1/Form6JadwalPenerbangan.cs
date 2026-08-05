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
    public partial class Form6JadwalPenerbangan : Form
    {

        BandaraEntities db = new BandaraEntities();
        private int idJadwal = -1;

        public Form6JadwalPenerbangan()
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

        private void Form6JadwalPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridJadwal.AutoGenerateColumns = false;
            dataGridJadwal.AllowUserToAddRows = false;
            dataGridJadwal.ReadOnly = true;

            waktuTime.Format = DateTimePickerFormat.Custom;
            waktuTime.CustomFormat = "HH:mm";
            waktuTime.ShowUpDown = true;

            loadBandara();
            loadMaskapai();
            loadJadwal();
        }

        private void loadBandara()
        {
            //Keberangkatan
            dariBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            dariBox.DisplayMember = "Nama";
            dariBox.ValueMember = "ID";
            dariBox.SelectedIndex = -1;

            //Tujuan
            destinasiBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            destinasiBox.DisplayMember = "Nama";
            destinasiBox.ValueMember = "ID";
            destinasiBox.SelectedIndex = -1;
        }

        private void loadMaskapai()
        {
            maskapaiBox.DataSource = db.Maskapais.OrderBy(b => b.Nama).ToList();
            maskapaiBox.DisplayMember = "Nama";
            maskapaiBox.ValueMember = "ID";
            maskapaiBox.SelectedIndex = -1;

        }

        private void loadJadwal()
        {
            dataGridJadwal.DataSource = db.JadwalPenerbangans
                                          .OrderByDescending(j => j.TanggalWaktuKeberangkatan)
                                          .ThenByDescending(j => j.WaktuKeberangkatan)
                                          .ToList()
                                          .Select(j => new
                                          {
                                              j.ID,
                                              j.KodePenerbangan,
                                              BandaraAsal = j.Bandara.Nama,
                                              BandaraTujuan = j.Bandara1.Nama,
                                              Maskapai = j.Maskapai.Nama,
                                              Tanggal = j.TanggalWaktuKeberangkatan.ToString("dd/MM/yy"),
                                              WaktuKeberangkatan = j.TanggalWaktuKeberangkatan.ToString("HH:mm"),
                                              Durasi = (j.DurasiPenerbangan / 60) + " Jam " + (j.DurasiPenerbangan - 60) + " Menit",
                                              j.HargaPerTiket

                                          }).ToList();

        }

        private void clearForm()
        {
            kodeTxt.Clear();
            durasiTxt.Clear();

            dariBox.SelectedIndex = -1;
            destinasiBox.SelectedIndex = -1;
            maskapaiBox.SelectedIndex = -1;

            TanggalDate.Value = DateTime.Now;
            waktuTime.Value = DateTime.Now;

            hargaCount.Value = 0;

            idJadwal = -1;

            simpanBtn.Text = "Simpan";

        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            // Validasi input kosong
            if (kodeTxt.Text == "" || durasiTxt.Text == "" || dariBox.SelectedIndex == -1 
                || destinasiBox.SelectedIndex == -1 || maskapaiBox.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }




            // Validasi kode penerbangan
            if (kodeTxt.Text.Length != 7)
            {
                MessageBox.Show("Format kode: AA-0000");
                return;
            }

            if (!char.IsLetter(kodeTxt.Text[0]) || !char.IsLetter(kodeTxt.Text[1]))
            {
                MessageBox.Show("2 Karakter pertama harus berupa huruf");
                return;
            }

            if (kodeTxt.Text[2] != '-')
            {
                MessageBox.Show("Kode harus mengandung '-'");
                return;
            }

            if (!char.IsDigit(kodeTxt.Text[3]) || !char.IsDigit(kodeTxt.Text[4]) 
                || !char.IsDigit(kodeTxt.Text[5]) || !char.IsDigit(kodeTxt.Text[6]))
            {
                MessageBox.Show("4 Karakter terakhir harus berupa angka");
                return;
            }




            // Validasi Bandara
            if (dariBox.SelectedValue.Equals(destinasiBox.SelectedValue))
            {
                MessageBox.Show("Bandara asal dan tujuan tidak boleh sama!");
                return;
            }




            // Validasi durasi
            string[] durasi = durasiTxt.Text.Split(' ');

            if (durasi.Length != 4)
            {
                MessageBox.Show("Format durasi: XX Jam YY Menit");
                return;
            }

            if (durasi[1] != "Jam" || durasi[3] != "Menit")
            {
                MessageBox.Show("Format durasi: XX Jam YY Menit");
                return;
            }

            if (!durasi[0].All(char.IsDigit) || !durasi[2].All(char.IsDigit))
            {
                MessageBox.Show("Jam dan menit harus berupa angka");
                return;
            }

            int jam = Convert.ToInt32(durasi[0]);
            int menit = Convert.ToInt32(durasi[2]);

            int totalMenit = (jam * 60) + menit;




            // Validasi harga
            if (hargaCount.Value < 1)
            {
                MessageBox.Show("Harga tidak valid");
                return;
            }



            // Validasi tanggal
            if (TanggalDate.Value < DateTime.Today)
            {
                MessageBox.Show("Tanggal keberangkatan tidak valid");
                return;
            }


            if (idJadwal == -1)
            {
                JadwalPenerbangan jadwalBaru = new JadwalPenerbangan();

                jadwalBaru.KodePenerbangan = kodeTxt.Text;
                jadwalBaru.BandaraKeberangkatanID = Convert.ToInt32(dariBox.SelectedValue);
                jadwalBaru.BandaraTujuanID = Convert.ToInt32(destinasiBox.SelectedValue);
                jadwalBaru.MaskapaiID = Convert.ToInt32(maskapaiBox.SelectedValue);
                jadwalBaru.TanggalWaktuKeberangkatan = TanggalDate.Value + waktuTime.Value.TimeOfDay;
                jadwalBaru.DurasiPenerbangan = totalMenit;
                jadwalBaru.HargaPerTiket = Convert.ToInt32(hargaCount.Value);

                db.JadwalPenerbangans.Add(jadwalBaru);
                db.SaveChanges();

                MessageBox.Show("Jadwal berhasil dibuat");
                clearForm();
                loadJadwal();
            }
            else
            {
                JadwalPenerbangan editJadwal = db.JadwalPenerbangans.Find(idJadwal);

                editJadwal.KodePenerbangan = kodeTxt.Text;
                editJadwal.BandaraKeberangkatanID = Convert.ToInt32(dariBox.SelectedValue);
                editJadwal.BandaraTujuanID = Convert.ToInt32(destinasiBox.SelectedValue);
                editJadwal.MaskapaiID = Convert.ToInt32(maskapaiBox.SelectedValue);
                editJadwal.TanggalWaktuKeberangkatan = TanggalDate.Value + waktuTime.Value.TimeOfDay;
                editJadwal.DurasiPenerbangan = totalMenit;
                editJadwal.HargaPerTiket = Convert.ToInt32(hargaCount.Value);

                MessageBox.Show("Jadwal berhasil diubah");
                clearForm();
                loadJadwal();
            }
        }

        private void dataGridJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridJadwal.Columns[e.ColumnIndex].Name == "edit")
            {
                idJadwal = Convert.ToInt32(dataGridJadwal.Rows[e.RowIndex].Cells["ID"].Value);

                JadwalPenerbangan editJadwal = db.JadwalPenerbangans.Find(idJadwal);

                int jam = editJadwal.DurasiPenerbangan / 60;
                int menit = editJadwal.DurasiPenerbangan - 60;
                string menitDurasi = jam + " Jam " + menit + " Menit";

                kodeTxt.Text = editJadwal.KodePenerbangan;
                dariBox.SelectedValue = editJadwal.BandaraKeberangkatanID;
                destinasiBox.SelectedValue = editJadwal.BandaraTujuanID;
                maskapaiBox.SelectedValue = editJadwal.MaskapaiID;
                TanggalDate.Value = editJadwal.TanggalKeberangkatan;
                waktuTime.Value = DateTime.Today + editJadwal.WaktuKeberangkatan.Value;
                durasiTxt.Text = menitDurasi;
                hargaCount.Value = Convert.ToInt32(editJadwal.HargaPerTiket);

                simpanBtn.Text = "Update";
            }
            else if(dataGridJadwal.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridJadwal.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Apakah anda yakin ingin menghapus jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    var hapusJadwal = db.JadwalPenerbangans.Find(id);

                    db.JadwalPenerbangans.Remove(hapusJadwal);
                    db.SaveChanges();

                    loadJadwal();
                    clearForm();

                    MessageBox.Show("Data berhasil dihapus");
                }
            }
        }
    }
}
