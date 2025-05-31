using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mezunbilgisistemi_proje_ödevi_
{
    public partial class frmogrrapor : Form
    {
        public frmogrrapor()
        {
            InitializeComponent();
        }
        public void listele(string durum)
        {

            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                switch (durum)
                {
                    case "doktora":
                      var  sorgu1 = context.egitimbilgileri.Where(p => p.AkademikEgitim == "Doktora").ToList(); dataGridView1.DataSource = sorgu1;
                        break;
                    case "türkiyede doktora":
                        var sorgu2 = context.egitimbilgileri.Where(p => p.AkademikEgitim == "Doktora" && p.Ulke == "Türkiye").ToList(); dataGridView1.DataSource = sorgu2;
                        break;

                    case "yurtdısı doktora":
                        var sorgu3 = context.egitimbilgileri.Where(p => p.AkademikEgitim == "Doktora" && p.Ulke != "Türkiye").ToList(); dataGridView1.DataSource = sorgu3;
                        break;

                    case "yukseklisans":
                        var sorgu4 = context.egitimbilgileri.Where(p => p.AkademikEgitim == "Yüksek Lisans").ToList(); dataGridView1.DataSource = sorgu4;
                        break;
                    case "türkiyedeyükseklisans":
                       var sorgu5 = context.egitimbilgileri.Where(p => p.AkademikEgitim == "Yüksek Lisans" && p.Ulke == "Türkiye").ToList(); dataGridView1.DataSource = sorgu5;
                        break;
                    case "yurtdisiyükseklisans":
                        var sorgu6 = context.egitimbilgileri.Where(p => p.AkademikEgitim == "Yüksek Lisans" && p.Ulke != "Türkiye").ToList(); dataGridView1.DataSource = sorgu6;
                        break;
                    case "yonetici":
                        var sorgu8 = (from mezun in context.mezunlar.ToList()
                                     join isBilgi in context.isbilgileri.ToList()
                                         on mezun.Ogrno equals isBilgi.Ogrno
                                     where !string.IsNullOrEmpty(mezun.MezuniyetTarih)
                                           && isBilgi.IseGirisTarih.HasValue
                                           && !string.IsNullOrEmpty(isBilgi.Pozisyon)
                                     let mezunTarih = DateTime.Parse(mezun.MezuniyetTarih)
                                     let iseGirisTarih = isBilgi.IseGirisTarih.Value
                                     let farkGun = (iseGirisTarih - mezunTarih).TotalDays
                                     let yilFarki = farkGun / 365.0
                                     where yilFarki <= 10
                                           && isBilgi.Pozisyon.ToLower().Contains("yönetici")
                                     select new
                                     {
                                         mezun.Ogrno,
                                         MezuniyetTarih = mezunTarih.ToShortDateString(),
                                         IseGirisTarih = iseGirisTarih.ToShortDateString(),
                                         Pozisyon = isBilgi.Pozisyon,
                                         YilFarki = Math.Round(yilFarki, 2)
                                     }).ToList();

                        dataGridView1.DataSource = sorgu8;

                        break;


                    // DataGridView'e aktarma örneği (varsa):
                    // dataGridView1.DataSource = sonuc;



                    case "yonetici3ile5yil":
                        var sorgu = (from mezun in context.mezunlar.ToList()
                                     join isBilgi in context.isbilgileri.ToList()
                                         on mezun.Ogrno equals isBilgi.Ogrno
                                     where !string.IsNullOrEmpty(mezun.MezuniyetTarih)
                                           && isBilgi.IseGirisTarih.HasValue
                                           && isBilgi.Pozisyon != null
                                     let mezunTarih = DateTime.Parse(mezun.MezuniyetTarih)
                                     let iseGirisTarih = isBilgi.IseGirisTarih.Value
                                     let farkGun = (iseGirisTarih - mezunTarih).TotalDays
                                     let yilFarki = farkGun / 365.0
                                     where yilFarki >= 3 && yilFarki <= 5
                                           && isBilgi.Pozisyon.ToLower().Contains("yönetici")
                                     select new
                                     {
                                         mezun.Ogrno,
                                         MezuniyetTarih = mezunTarih.ToShortDateString(),
                                         IseGirisTarih = iseGirisTarih.ToShortDateString(),
                                         YilFarki = Math.Round(yilFarki, 2)
                                     }).ToList();

                        dataGridView1.DataSource = sorgu;



                        break;


                        
                        
                       
                        
                       






                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele("türkiyede doktora");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele("doktora");
        }

        private void frmogrrapor_Load(object sender, EventArgs e)
        {
               
        }    

        private void btnyurtdısıdoktora_Click(object sender, EventArgs e)
        {
            listele("yurtdısı doktora");
        }

        private void btnyukseklisans_Click(object sender, EventArgs e)
        {
            listele("yukseklisans");
        }

        private void btnturkiyeyukseklisans_Click(object sender, EventArgs e)
        {
            listele("türkiyedeyükseklisans");

        }

        private void btnyurtdısıyukseklisans_Click(object sender, EventArgs e)
        {
            listele("yurtdisiyükseklisans");
        }

        private void btn35yil_Click(object sender, EventArgs e)
        {
            listele("yonetici3ile5yil");
        }

        private void btn10yil_Click(object sender, EventArgs e)
        {
            listele("yonetici");
        }
    }
}
