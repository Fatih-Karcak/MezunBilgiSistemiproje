using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mezunbilgisistemi_proje_ödevi_
{
    public partial class frmegitimbilgileri : Form
    {
        private int ogr_no;
        public frmegitimbilgileri(int ogr)
        {
            ogr_no = ogr;

            InitializeComponent();
        }

        private void frmegitimbilgileri_Load(object sender, EventArgs e)
        {

            using (mezunbilgisistemiEntities1 context =new mezunbilgisistemiEntities1())
            {



                var liste = context.egitimbilgileri.Where(p=>p.Ogrno==ogr_no).ToList();
            
                dataGridView1.DataSource = liste;

                
                
                
                dataGridView1.Columns[8].Visible = false;
            }




        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1()) {
              
                
                
                
                
                foreach(DataGridViewRow drow in dataGridView1.Rows){
                    if (drow.IsNewRow) continue;
                     var kayit=Convert.ToInt32(drow.Cells["no"].Value);
                    var mezun = context.egitimbilgileri.FirstOrDefault(p => p.no == kayit);
                    if (mezun != null)
                    {
                       
                        mezun.AkademikEgitim = drow.Cells["AkademikEgitim"].Value?.ToString();
                        mezun.Baslangic = drow.Cells["Baslangic"].Value?.ToString();
                        mezun.Bitis = drow.Cells["Bitis"].Value?.ToString();
                        mezun.Ulke = drow.Cells["Ulke"].Value?.ToString();
                        mezun.Universite = drow.Cells["Universite"].Value?.ToString();
                        mezun.Sehir = drow.Cells["Sehir"].Value?.ToString();
                            


                    }
                    
                       






                }
                    
             context.SaveChanges();
                MessageBox.Show("kayıt başşarıyla Güncellendi");



                var liste = context.egitimbilgileri.Where(p => p.Ogrno == ogr_no).ToList();
                
                dataGridView1.DataSource = liste;



                
                dataGridView1.Columns[8].Visible = false;

            }

         











        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtakademik.Text) || string.IsNullOrWhiteSpace(txtbaslangic.Text) || string.IsNullOrWhiteSpace(txtbitis.Text) || string.IsNullOrWhiteSpace(txtsehir.Text) || string.IsNullOrWhiteSpace(txtulke.Text) || string.IsNullOrWhiteSpace(txtuniversite.Text) )
            {
                MessageBox.Show("boş alanları doldurunuz");
                return;
            }
            using (mezunbilgisistemiEntities1 context= new mezunbilgisistemiEntities1())
            {
                egitimbilgileri eg = new egitimbilgileri();
                eg.Ogrno = ogr_no;
                eg.AkademikEgitim=txtakademik.Text;
                eg.Baslangic = txtbaslangic.Text;
                eg.Bitis = txtbitis.Text;    
                eg.Universite = txtuniversite.Text;  
                eg.Ulke = txtulke.Text; 
                eg.Sehir = txtsehir.Text;

                context.egitimbilgileri.Add(eg);
                context.SaveChanges();
                MessageBox.Show("yeni eğitim bilgisi eklendi");
                var liste = context.egitimbilgileri.Where(p => p.Ogrno == ogr_no).ToList();

                dataGridView1.DataSource = liste;
            }

            





        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            int ogrno1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Ogrno"].Value.ToString());
            int ogrno=Convert.ToInt32(dataGridView1.CurrentRow.Cells["no"].Value.ToString());
            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                var kayit=context.egitimbilgileri.FirstOrDefault(p=>p.no==ogrno);
                if(kayit!=null&&MessageBox.Show("seçilen kayıt silinecek eminmisiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.egitimbilgileri.Remove(kayit);
                    context.SaveChanges();
                
                    MessageBox.Show("kayıt başarıyla silindi");
                }
                dataGridView1.DataSource=context.egitimbilgileri.Where(p=>p.Ogrno==ogrno1).ToList();

                
                
            }







        }
    }
}
