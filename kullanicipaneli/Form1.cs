using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanicipaneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled= false;
            kullaniciaditxt.TabIndex = 1;
            sifretxt.TabIndex= 2;
            loginbtn.TabIndex= 3;
            sifregoster.TabIndex= 4;
            yenisifretxt.TabIndex= 5;
            sifretekrartxt.TabIndex= 6;
            savebtn.TabIndex= 7;
            exitbtn.TabIndex= 8;
            sifretxt.PasswordChar = '*';
        }

        string sifre = "1234";

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(kullaniciaditxt.Text == "meta" &&  sifretxt.Text == sifre)
            {
                MessageBox.Show("Giriş Başarılı", "Bilgilendirme");
                groupBox2.Enabled = true;
                groupBox1.Enabled= false;
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Bilgilendirme");
                groupBox2.Enabled = false;

            }
        }

        private void sifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if(sifregoster.Checked)
            {
                sifretxt.PasswordChar = '\0';
            }
            else
            {
                sifretxt.PasswordChar = '*';
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (yenisifretxt.Text == sifretekrartxt.Text)
            {
                sifre = yenisifretxt.Text;
                MessageBox.Show("Şifre başarılı bir şekilde değiştirildi.Çıkış Yapmayı Unutmayın", "Bilgilendirme");
            }
            else
            {


                MessageBox.Show("Girilen Şifreler Aynı Değil.Lütfen Tekrar Deneyin", "HATA");

            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            yenisifretxt.Clear();
            sifretekrartxt.Clear();
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
        }
    }
}
