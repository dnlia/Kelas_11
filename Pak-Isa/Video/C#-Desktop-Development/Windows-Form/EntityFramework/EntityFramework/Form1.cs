using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {

        SekolahDBEntities db = new SekolahDBEntities();
        int idSiswa =  0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            loadData();

            jurusanBox.DataSource = db.Jurusan.ToList();
            jurusanBox.DisplayMember = "NamaJurusan";
            jurusanBox.ValueMember = "Id";
            jurusanBox.SelectedIndex = -1;
        }

        private void loadData()
        {
            dataGridView1.DataSource = db.Siswa.Select(s => new
            {
                s.Id,
                s.Nama,
                s.Umur,
                s.Alamat,
                Jurusan = s.Jurusan.NamaJurusan
            }).ToList();
        }

        private void ClearForm()
        {
            namaBox.Clear();
            umurBox.Clear();
            alamatBox.Clear();
            jurusanBox.SelectedIndex = 1;
        }

        int IdSiswa;

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (namaBox.Text == "" || umurBox.Text == "" || alamatBox.Text == "" || jurusanBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lengkapi data yang diperlukan telebih dahulu!");
                return;
            }

            var siswa = new Siswa();

            siswa.Nama = namaBox.Text;
            siswa.Umur = Convert.ToInt32(umurBox.Text);
            siswa.Alamat = alamatBox.Text;
            siswa.JurusanID = Convert.ToInt32(jurusanBox.SelectedValue);

            db.Siswa.Add(siswa);
            db.SaveChanges();

            MessageBox.Show("Data Berhasil Ditambahkan");
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            String columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (columnName == "Update")
            {
                IdSiswa = Convert.ToInt32(row.Cells["Id"].Value);

                namaBox.Text = row.Cells["Nama"].Value.ToString();
                umurBox.Text = row.Cells["Umur"].Value.ToString();
                alamatBox.Text = row.Cells["Alamat"].Value.ToString();
                jurusanBox.Text = row.Cells["Jurusan"].Value.ToString();

                addBtn.Text = "Update";
            }
            else if (columnName == "delete")
            {
                var result = MessageBox.Show("Hapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int idDelete = Convert.ToInt32(row.Cells["Id"].Value);

                    var siswa = db.Siswa.Find(idDelete);

                    if (siswa != null)
                    {
                        db.Siswa.Remove(siswa);
                        db.SaveChanges();

                        MessageBox.Show("Data berhasil dihapus");
                    }
                }

                loadData();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string key = searchBox.Text;

            if (key == "")
            {
                loadData();
                return;
            }

            dataGridView1.DataSource = db.Siswa
                .Where(s => s.Nama.Contains(key) || s.Umur.ToString().Contains(key) 
                || s.Alamat.Contains(key) || s.Jurusan.NamaJurusan.Contains(key))
                .Select(s => new
                {
                    s.Id,
                    s.Nama,
                    s.Umur,
                    s.Alamat,
                    Jurusan = s.Jurusan.NamaJurusan
                })
                .ToList();
        }
    }
}
