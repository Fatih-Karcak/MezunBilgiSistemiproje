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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {






        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkullanıcı.Text) && string.IsNullOrWhiteSpace(txtsifre.Text)) {
                MessageBox.Show("lütfen boş geçmeyin");
                return;
            }
            

            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
             var kayit =context.tblkullanici.FirstOrDefault(p=>p.kullanıcıad==txtkullanıcı.Text&& p.sifre==txtsifre.Text);
                if (kayit != null)
                {
                    frmanasayfa ana = new frmanasayfa();
                    this.Hide();
                    ana.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre yanlış lütfen tekrar deneyiniz");

                }



            }


    

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
