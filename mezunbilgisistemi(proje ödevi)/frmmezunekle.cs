using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mezunbilgisistemi_proje_ödevi_
{


    public partial class frmmezunekle : Form
    {
        private int ogrenci_no;
        public frmmezunekle(string ogrno)
        {
            InitializeComponent();
            ogrenci_no = Convert.ToInt32(ogrno);




        }

        private void frmmezunekle_Load(object sender, EventArgs e)
        {
            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                var kayit = context.mezunlar.Where(p => p.Ogrno == ogrenci_no).FirstOrDefault();

                if (kayit != null)
                {
                    txtogrno.Text = kayit.Ogrno.ToString();
                    txtsoyad.Text = kayit.Soyad.ToString();
                    txtad.Text = kayit.Ad.ToString();
                    txtceptel.Text = kayit.Ceptel.ToString();
                    txteposta.Text = kayit.Eposta.ToString();
                    txtevadres.Text = kayit.EvAdres.ToString();
                    txtmezuniyet.Text = kayit.MezuniyetTarih.ToString();
                    txtevsehir.Text = kayit.EvŞehir.ToString();
                    txtevulke.Text = kayit.EvUlke.ToString();
                    txtevtel.Text = kayit.EvTel.ToString();


                }




            }


        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtogrno.Text = "";
            txtsoyad.Text = "";
            txtad.Text = "";
            txtceptel.Text = "";
            txteposta.Text = "";
            txtevadres.Text = "";
            txtmezuniyet.Text = "";
            txtevsehir.Text = "";
            txtevulke.Text = "";
            txtevtel.Text = "";






        }

        private void btnkayıtekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtogrno.Text) || string.IsNullOrWhiteSpace(txtad.Text) || string.IsNullOrWhiteSpace(txtsoyad.Text) || string.IsNullOrWhiteSpace(txtmezuniyet.Text) || string.IsNullOrWhiteSpace(txtceptel.Text) || string.IsNullOrWhiteSpace(txteposta.Text) || string.IsNullOrWhiteSpace(txtevtel.Text) || string.IsNullOrWhiteSpace(txtevulke.Text) || string.IsNullOrWhiteSpace(txtevsehir.Text) || string.IsNullOrWhiteSpace(txtevadres.Text))
            {
                MessageBox.Show("boş alanları doldurunuz");
                return;
            }

            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                int ogr = Convert.ToInt32(txtogrno.Text);
                var durum = context.mezunlar.FirstOrDefault(p => p.Ogrno == ogr);
                if (durum != null)
                {
                    MessageBox.Show("Eklemek istediğiniz Öğrenci Numarası Mevcut");
                    return;
                }
                mezunlar mezun = new mezunlar();
                mezun.Ogrno = Convert.ToInt32(txtogrno.Text);
                mezun.Ad = txtad.Text;
                mezun.Soyad = txtsoyad.Text;
                mezun.MezuniyetTarih = txtmezuniyet.Text;
                mezun.Ceptel = txtceptel.Text;
                mezun.Eposta = txteposta.Text;
                mezun.EvTel = txtevtel.Text;
                mezun.EvUlke = txtevulke.Text;
                mezun.EvŞehir = txtevsehir.Text;
                mezun.EvAdres = txtevadres.Text;
                if (MessageBox.Show("Yeni mezun kaydı eklemek üzresiniz ", "Hatırlatma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.mezunlar.Add(mezun);
                    context.SaveChanges();
                    MessageBox.Show("Yeni kayıt başarıyla eklendi");
                }




            }
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtogrno.Text) || string.IsNullOrWhiteSpace(txtad.Text) || string.IsNullOrWhiteSpace(txtsoyad.Text) || string.IsNullOrWhiteSpace(txtmezuniyet.Text) || string.IsNullOrWhiteSpace(txtceptel.Text) || string.IsNullOrWhiteSpace(txteposta.Text) || string.IsNullOrWhiteSpace(txtevtel.Text) || string.IsNullOrWhiteSpace(txtevulke.Text) || string.IsNullOrWhiteSpace(txtevsehir.Text) || string.IsNullOrWhiteSpace(txtevadres.Text))
            {
                MessageBox.Show("boş alanları doldurunuz");
                return;
            }



            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                int no = Convert.ToInt32(txtogrno.Text);
                var kayit = context.mezunlar.Where(p => p.Ogrno == no).FirstOrDefault();
                if (kayit == null)
                {
                    MessageBox.Show(" veritabanınnda mevcut olmayan Öğrenci no girdiniz ");
                    return;
                }

                if (MessageBox.Show("Seçili kaydı güncellemek üzeresiniz ", "Hatırlatma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    kayit.Ad = txtad.Text;
                    kayit.Soyad = txtsoyad.Text;
                    kayit.MezuniyetTarih = txtmezuniyet.Text;
                    kayit.Ceptel = txtceptel.Text;
                    kayit.Eposta = txteposta.Text;
                    kayit.EvTel = txtevtel.Text;
                    kayit.EvUlke = txtevulke.Text;
                    kayit.EvŞehir = txtevsehir.Text;
                    kayit.EvAdres = txtevadres.Text;
                    context.SaveChanges();
                    MessageBox.Show("kayıt başarıyla güncellendi");
                }






            }









        }

        private void btnegitimbilgileri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtogrno.Text) || string.IsNullOrWhiteSpace(txtad.Text) || string.IsNullOrWhiteSpace(txtsoyad.Text) || string.IsNullOrWhiteSpace(txtmezuniyet.Text) || string.IsNullOrWhiteSpace(txtceptel.Text) || string.IsNullOrWhiteSpace(txteposta.Text) || string.IsNullOrWhiteSpace(txtevtel.Text) || string.IsNullOrWhiteSpace(txtevulke.Text) || string.IsNullOrWhiteSpace(txtevsehir.Text) || string.IsNullOrWhiteSpace(txtevadres.Text))
            {
                MessageBox.Show("boş alanları doldurunuz");
                return;
            }
            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                mezunlar mezun = new mezunlar();
                mezun.Ogrno = Convert.ToInt32(txtogrno.Text);
                mezun.Ad = txtad.Text;
                mezun.Soyad = txtsoyad.Text;
                mezun.MezuniyetTarih = txtmezuniyet.Text;
                mezun.Ceptel = txtceptel.Text;
                mezun.Eposta = txteposta.Text;
                mezun.EvTel = txtevtel.Text;
                mezun.EvUlke = txtevulke.Text;
                mezun.EvŞehir = txtevsehir.Text;
                mezun.EvAdres = txtevadres.Text;

                var ayniKayit = context.mezunlar.FirstOrDefault(p =>
               p.Ad == mezun.Ad &&
                 p.Soyad == mezun.Soyad &&
                  p.MezuniyetTarih == mezun.MezuniyetTarih &&
                p.Ceptel == mezun.Ceptel &&
                  p.Eposta == mezun.Eposta &&
                  p.EvTel == mezun.EvTel &&
                 p.EvUlke == mezun.EvUlke &&
                  p.EvŞehir == mezun.EvŞehir &&
                   p.EvAdres == mezun.EvAdres
                    );

                if (ayniKayit == null)
                {
                    MessageBox.Show("girilen bilgilerle eşleşen kayıt bulunamadı");
                    return;
                }






            }
            int ogr = Convert.ToInt32(txtogrno.Text);
            frmegitimbilgileri egitim = new frmegitimbilgileri(ogr);
            this.Hide();
            egitim.ShowDialog();
            this.Show();











        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmogrrapor frmogrrapor = new frmogrrapor();
            frmogrrapor.ShowDialog();
        }

        private void btnisbilgileri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtogrno.Text) || string.IsNullOrWhiteSpace(txtad.Text) || string.IsNullOrWhiteSpace(txtsoyad.Text) || string.IsNullOrWhiteSpace(txtmezuniyet.Text) || string.IsNullOrWhiteSpace(txtceptel.Text) || string.IsNullOrWhiteSpace(txteposta.Text) || string.IsNullOrWhiteSpace(txtevtel.Text) || string.IsNullOrWhiteSpace(txtevulke.Text) || string.IsNullOrWhiteSpace(txtevsehir.Text) || string.IsNullOrWhiteSpace(txtevadres.Text))
            {
                MessageBox.Show("boş alanları doldurunuz");
                return;
            }
            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                mezunlar mezun = new mezunlar();
                mezun.Ogrno = Convert.ToInt32(txtogrno.Text);
                mezun.Ad = txtad.Text;
                mezun.Soyad = txtsoyad.Text;
                mezun.MezuniyetTarih = txtmezuniyet.Text;
                mezun.Ceptel = txtceptel.Text;
                mezun.Eposta = txteposta.Text;
                mezun.EvTel = txtevtel.Text;
                mezun.EvUlke = txtevulke.Text;
                mezun.EvŞehir = txtevsehir.Text;
                mezun.EvAdres = txtevadres.Text;

                var ayniKayit = context.mezunlar.FirstOrDefault(p =>
               p.Ad == mezun.Ad &&
                 p.Soyad == mezun.Soyad &&
                  p.MezuniyetTarih == mezun.MezuniyetTarih &&
                p.Ceptel == mezun.Ceptel &&
                  p.Eposta == mezun.Eposta &&
                  p.EvTel == mezun.EvTel &&
                 p.EvUlke == mezun.EvUlke &&
                  p.EvŞehir == mezun.EvŞehir &&
                   p.EvAdres == mezun.EvAdres
                    );

                if (ayniKayit == null)
                {
                    MessageBox.Show("girilen bilgilerle eşleşen kayıt bulunamadı");
                    return;
                }






            }
            int ogr = Convert.ToInt32(txtogrno.Text);
            frmis is2 = new frmis(ogr);
            this.Hide();
            is2.ShowDialog();
            this.Show();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            int ogrno = Convert.ToInt32(txtogrno.Text);

            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                var kayit = context.mezunlar.FirstOrDefault(p => p.Ogrno == ogrno);
                var kayit1 = context.egitimbilgileri.Where(p => p.Ogrno == ogrno).ToList(); 
                var kayit2=context.isbilgileri.Where(p=>p.Ogrno==ogrno).ToList();


                if (kayit1 != null)
                {
                    foreach(var say in kayit1)
                    context.egitimbilgileri.Remove(say);
                }
                if (kayit2 != null)
                {
                    foreach (var say in kayit2)
                    {
                        context.isbilgileri.Remove(say);
                    }
                }

                if (kayit != null )
                {

                    if (MessageBox.Show("kayıt silinecek eminmisiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        context.mezunlar.Remove(kayit);
                        context.SaveChanges();
                        MessageBox.Show("kayıt silindi");
                    }
                }
                else
                {
                    MessageBox.Show("belirtilen öğrenci numarası sistemde yok");
                    return;
                }
                




            }

        }
    }
}

