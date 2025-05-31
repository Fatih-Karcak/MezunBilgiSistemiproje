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
    public partial class frmis : Form
    {
        private int ogr_no;
        public frmis(int no)

        {
          ogr_no = no;
            InitializeComponent();
        }

        private void frmis_Load(object sender, EventArgs e)
        {
            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {



                var liste = context.isbilgileri.Where(p => p.Ogrno == ogr_no).ToList();
                BindingList<isbilgileri> bindinglist = new BindingList<isbilgileri>(liste);
                dataGridView1.DataSource = bindinglist;




                dataGridView1.Columns[8].Visible = false;
            }

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {





                foreach (DataGridViewRow drow in dataGridView1.Rows)
                {
                    if (drow.IsNewRow) continue;
                    var kayit = Convert.ToInt32(drow.Cells["no"].Value);
                    var mezun = context.isbilgileri.FirstOrDefault(p => p.no == kayit);
                    if (mezun != null)
                    {

                        mezun.IseGirisTarih = DateTime.Parse(drow.Cells["IseGirisTarih"].Value?.ToString());
                        mezun.IstenAyrilisTar = DateTime.Parse(drow.Cells["IstenAyrilisTar"].Value?.ToString());
                        mezun.KamuOzel = drow.Cells["KamuOzel"].Value?.ToString();
                        mezun.Sektor = drow.Cells["Sektor"].Value?.ToString();
                        mezun.Unvan = drow.Cells["Unvan"].Value?.ToString();
                        mezun.Pozisyon = drow.Cells["Pozisyon"].Value?.ToString();



                    }
                    else
                    {
                        isbilgileri a = new isbilgileri();
                        a.Ogrno = ogr_no;
                        a.IseGirisTarih = DateTime.Parse(drow.Cells["IseGirisTarih"].Value?.ToString());
                        a.IstenAyrilisTar = DateTime.Parse(drow.Cells["IstenAyrilisTar"].Value?.ToString());
                        a.KamuOzel = drow.Cells["KamuOzel"].Value?.ToString();
                         a.Sektor = drow.Cells["Sektor"].Value?.ToString();
                        a.Unvan = drow.Cells["Unvan"].Value?.ToString();
                        a.Pozisyon = drow.Cells["Pozisyon"].Value?.ToString();
                        context.isbilgileri.Add(a);



                    }







                }

                context.SaveChanges();
                MessageBox.Show("kayıt başşarıyla Güncellendi");



                var liste = context.isbilgileri.Where(p => p.Ogrno == ogr_no).ToList();
                dataGridView1.DataSource = liste;




                dataGridView1.Columns[8].Visible = false;

            }








        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtisegiris.Text) || string.IsNullOrWhiteSpace(txtistenayrilis.Text) || string.IsNullOrWhiteSpace(txtkamuozel.Text) || string.IsNullOrWhiteSpace(txtpozisyon.Text) || string.IsNullOrWhiteSpace(txtunvan.Text) || string.IsNullOrWhiteSpace(txtsektor.Text))
            {
                MessageBox.Show("boş alanları doldurunuz");
                return;
            }
            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                isbilgileri eg = new isbilgileri();
                eg.Ogrno = ogr_no;
                eg.IseGirisTarih = DateTime.Parse(txtisegiris.Text.ToString());
                eg.IstenAyrilisTar = DateTime.Parse(txtistenayrilis.Text);
                eg.Pozisyon = txtpozisyon.Text;
                eg.KamuOzel = txtkamuozel.Text;
                eg.Unvan = txtunvan.Text;
                eg.Sektor = txtsektor.Text;

                context.isbilgileri.Add(eg);
                context.SaveChanges();
                MessageBox.Show("yeni eğitim bilgisi eklendi");
                var liste = context.egitimbilgileri.Where(p => p.Ogrno == ogr_no).ToList();

                dataGridView1.DataSource = liste;

            }
        
        
        
        
        }

        private void btnhepsindençık_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int ogrno1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Ogrno"].Value.ToString());
            int ogrno = Convert.ToInt32(dataGridView1.CurrentRow.Cells["no"].Value.ToString());
            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {                                                                                                                      
                var kayit = context.isbilgileri.FirstOrDefault(p => p.no == ogrno);
                if (kayit != null && MessageBox.Show("seçilen kayıt silinecek eminmisiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.isbilgileri.Remove(kayit);
                    context.SaveChanges();

                    MessageBox.Show("kayıt başarıyla silindi");
                }
                dataGridView1.DataSource = context.isbilgileri.Where(p => p.Ogrno == ogrno1).ToList();

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
