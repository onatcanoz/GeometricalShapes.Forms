using GeometrikSekillerForms.Classes.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometrikSekillerForms
{
    public partial class Form1 : Form
    {
        DateTime simdi;
        string formTitle = "Geometrik Şekiller";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SimdiyiGetir();
            timer1.Enabled = true;
        }

        #region SekilSecme;
        private void rbKare_CheckedChanged(object sender, EventArgs e)
        {
            gbUcgen.Visible = false;
            gbDaire.Visible = false;
            gbKareDikdortgen.Visible = true;
            tbUzunKenar.Enabled = false;

            tbKısaKenar.Clear();
            tbUzunKenar.Clear();
        }

        private void rbDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            gbUcgen.Visible = false;
            gbDaire.Visible = false;
            gbKareDikdortgen.Visible = true;
            tbUzunKenar.Enabled = true;
        }

        private void rbEskenarUcgen_CheckedChanged(object sender, EventArgs e)
        {
            gbKareDikdortgen.Visible = false;
            gbDaire.Visible = false;
            gbUcgen.Visible = true;
            tbDik2.Enabled = false;
            tbDik1.Clear();
            tbDik2.Clear();
        }

        private void rbDikUcgen_CheckedChanged(object sender, EventArgs e)
        {
            gbKareDikdortgen.Visible = false;
            gbDaire.Visible = false;
            gbUcgen.Visible = true;
            tbDik2.Enabled = true;
        }

        private void rbDaire_CheckedChanged(object sender, EventArgs e)
        {
            gbKareDikdortgen.Visible = false;
            gbUcgen.Visible = false;
            gbDaire.Visible = true;
        }
        #endregion
        private void bTemizle_Click(object sender, EventArgs e)
        {
            lSonuc.Text = "";
            tbDik1.Text = "";
            tbDik2.Clear();
            tbKısaKenar.Text = "";
            tbUzunKenar.Text = "";
            tbYariCap.Text = "";
            rbKare.Checked = false;
            rbDaire.Checked = false;
            rbDikdortgen.Checked = false;
            rbDikUcgen.Checked = false;
            rbEskenarUcgen.Checked = false;
            gbUcgen.Visible = false;
            gbDaire.Visible = false;
            gbKareDikdortgen.Visible = false;
        }

        private void bAlanHesapla_Click(object sender, EventArgs e)
        {
            lSonuc.Text = "";
            //double sayi;
            if (gbUcgen.Visible && rbEskenarUcgen.Checked && tbDik1.Text=="")
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız!", "HATA!",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (gbUcgen.Visible && rbDikUcgen.Checked && (tbDik1.Text == "" || tbDik2.Text==""))
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız!", "HATA!",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (gbKareDikdortgen.Visible && rbKare.Checked && tbKısaKenar.Text == "" )
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız!", "HATA!",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (gbKareDikdortgen.Visible && rbDikdortgen.Checked && (tbUzunKenar.Text == "" || tbKısaKenar.Text == ""))
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız!", "HATA!",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (gbDaire.Visible && tbYariCap.Text == "")
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız!", "HATA!",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                return;
            }
            //if (!double.TryParse(tbKısaKenar.Text.Trim(), out sayi))
            //{
            //    MessageBox.Show("Lütfen karakter girmeyiniz!", "UYARI!",
            //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}


            if (rbKare.Checked == true)
            {
                Kare kare = new Kare()
                {
                    TemelUzunluk = Convert.ToDouble(tbKısaKenar.Text)
                };
                lSonuc.Text += "Karenin Alanı: " + kare.AlanHesapla() + "-Çevresi: " + kare.CevreHesapla() + "\r\n";
            }
            if (rbDikdortgen.Checked == true)
            {
                Dikdortgen dikdortgen = new Dikdortgen()
                {
                    TemelUzunluk = Convert.ToDouble(tbKısaKenar.Text),
                    Yukseklik = Convert.ToDouble(tbUzunKenar.Text)
                };
                lSonuc.Text += "Dikdörtgenin Alanı: " + dikdortgen.AlanHesapla() + "-Çevresi: " + dikdortgen.CevreHesapla() + "\r\n";
            }
            if (rbEskenarUcgen.Checked == true)
            {
                EskenarUcgen eskenarUcgen = new EskenarUcgen()
                {
                    TemelUzunluk = Convert.ToDouble(tbDik1.Text)
                };
                lSonuc.Text += "Eşkenar Üçgenin Alanı: " + eskenarUcgen.AlanHesapla() + "-Çevresi: " + eskenarUcgen.CevreHesapla() + "\r\n";
            }
            if (rbDikUcgen.Checked == true)
            {
                DikUcgen dikUcgen = new DikUcgen()
                {
                    TemelUzunluk = Convert.ToDouble(tbDik1.Text),
                    Yukseklik = Convert.ToDouble(tbDik2.Text)
                };
                lSonuc.Text += "Dik Üçgenin Alanı: " + dikUcgen.AlanHesapla() + "-Çevresi: " + dikUcgen.CevreHesapla() + "\r\n";
            }
            if (rbDaire.Checked == true)
            {
                Daire daire = new Daire()
                {
                    TemelUzunluk = Convert.ToDouble(tbYariCap.Text)
                };
                lSonuc.Text += "Dairenin Alanı: " + daire.AlanHesapla() + "-Çevresi: " + daire.CevreHesapla() + "\r\n";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SimdiyiGetir();
        }

        private void SimdiyiGetir()
        {
            simdi = DateTime.Now;
            this.Text = formTitle + " | " + simdi.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
