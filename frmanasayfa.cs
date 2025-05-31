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
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();

          






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            using (mezunbilgisistemiEntities1 context = new mezunbilgisistemiEntities1())
            {
                dataGridView1.DataSource=context.mezunlar.ToList();
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;


            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                frmmezunekle mezun = new frmmezunekle(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                mezun.ShowDialog();
                this.Show();
            }


        }
    }
}
