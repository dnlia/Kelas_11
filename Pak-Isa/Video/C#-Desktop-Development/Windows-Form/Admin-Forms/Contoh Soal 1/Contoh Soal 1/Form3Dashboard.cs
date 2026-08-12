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
    public partial class Form3Dashboard : Form
    {
        public Form3Dashboard()
        {
            InitializeComponent();
        }

        private void Form3Dashboard_Load(object sender, EventArgs e)
        {

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
    }
}
