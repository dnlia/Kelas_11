using Contoh_Soal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contoh_Soal_1
{
    public partial class Form1Login : Form
    {
        BandaraEntities db = new BandaraEntities();

        public Form1Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2Register register = new Form2Register();
            this.Hide();
            register.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Username dan Password harus diisi");
                return;
            }

            var user = db.Akuns.FirstOrDefault(a => a.Username == usernameTxt.Text
            && a.Password == passwordTxt.Text);

            if (user != null)
            {
                MessageBox.Show("Login Berhasil");

                Form3Dashboard dashboard = new Form3Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password atau Username salah");
            }
        }
    }
}
