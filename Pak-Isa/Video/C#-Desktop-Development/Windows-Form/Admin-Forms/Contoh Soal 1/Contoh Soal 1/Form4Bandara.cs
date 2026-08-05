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
    public partial class Form4Bandara : Form
    {

        BandaraEntities db = new BandaraEntities();
        private int idBandara = -1;

        public Form4Bandara()
        {
            InitializeComponent();
        }

        private void Form4Dashboard_Load(object sender, EventArgs e)
        {

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

        private void Form4Bandara_Load(object sender, EventArgs e)
        {
            loadNegara();
            loadBandara();

            dataGridBandara.AutoGenerateColumns = false;
            dataGridBandara.AllowUserToAddRows = false;
            dataGridBandara.ReadOnly = true;
        }

        private void loadNegara()
        {
            negaraTxt.DataSource = db.Negaras.OrderBy(n => n.Nama).ToList();

            negaraTxt.DisplayMember = "Nama";
            negaraTxt.ValueMember = "ID";
            negaraTxt.SelectedIndex = -1;
        }

        private void loadBandara()
        {
            dataGridBandara.DataSource = db.Bandaras.Include("Negara")
                                         .OrderBy(b => b.Nama)
                                         .Select(b => new
                                         {
                                             b.ID,
                                             b.Nama,
                                             b.KodeIATA,
                                             b.Kota,
                                             Negara = b.Negara.Nama,
                                             b.JumlahTerminal,
                                             b.Alamat
                                         }).ToList();
        }

        private void resetForm()
        {
            namaTxt.Clear();
            iataTxt.Clear();
            cityTxt.Clear();
            addressTxt.Clear();
            negaraTxt.SelectedIndex = -1;
            terminalCount.Value = 1;
            idBandara = -1;
            saveBtn.Text = "Simpan";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (namaTxt.Text == "" || iataTxt.Text == "" || cityTxt.Text == "" || addressTxt.Text == ""
                || negaraTxt.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }



            if (iataTxt.Text.Length != 3)
            {
                MessageBox.Show("Kode IATA wajib memiliki 3 huruf!");
                return;
            }

            if (!iataTxt.Text.All(char.IsLetter))
            {
                MessageBox.Show("Kode IATA hanya boleh berisi huruf!");
                return;
            }

            bool adaIATA = db.Bandaras
                .Any(b => b.KodeIATA == iataTxt.Text && b.ID != idBandara);

            if (adaIATA)
            {
                MessageBox.Show("Kode IATA sudah digunakan!");
                return;
            }



            if (terminalCount.Value < 1)
            {
                MessageBox.Show("Jumlah terminal minimal 1!");
                return;
            }



            bool adaBandara = db.Bandaras
                .Any(b => b.Nama.ToLower() == namaTxt.Text.ToLower() && b.ID != idBandara);

            if (adaBandara)
            {
                MessageBox.Show("Nama bandara sudah dipakai!");
                return;
            }

            if (idBandara == -1)
            {
                Bandara bandara = new Bandara();

                bandara.Nama = namaTxt.Text;
                bandara.KodeIATA = iataTxt.Text;
                bandara.Kota = cityTxt.Text;
                bandara.NegaraID = Convert.ToInt32(negaraTxt.SelectedValue);
                bandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                bandara.Alamat = addressTxt.Text;

                db.Bandaras.Add(bandara);
                MessageBox.Show("Data Berhasil ditambahkan!");
            }
            else
            {
                Bandara editBandara = db.Bandaras.Find(idBandara);

                editBandara.Nama = namaTxt.Text;
                editBandara.KodeIATA = iataTxt.Text;
                editBandara.Kota = cityTxt.Text;
                editBandara.NegaraID = Convert.ToInt32(negaraTxt.SelectedValue);
                editBandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                editBandara.Alamat = addressTxt.Text;

                MessageBox.Show("Data Berhasil diedit!");
            }

            db.SaveChanges();

            loadBandara();
            resetForm();


        }

        private void dataGridBandara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridBandara.Columns[e.ColumnIndex].Name == "edit")
            {
                idBandara = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value);

                Bandara bandaraEdit = db.Bandaras.Find(idBandara);

                namaTxt.Text = bandaraEdit.Nama;
                iataTxt.Text = bandaraEdit.KodeIATA;
                cityTxt.Text = bandaraEdit.Kota;
                addressTxt.Text = bandaraEdit.Alamat;
                negaraTxt.SelectedValue = bandaraEdit.NegaraID;
                terminalCount.Value = bandaraEdit.JumlahTerminal;

                saveBtn.Text = "Update";

            } else if (dataGridBandara.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Bandara bandaraHapus = db.Bandaras.Find(id);
                    db.Bandaras.Remove(bandaraHapus);
                    db.SaveChanges();

                    MessageBox.Show("Data berhasil dihapus!");
                    loadBandara();
                    resetForm();
                }

            }
        }
    }
}
