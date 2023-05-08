using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vue
{
    public partial class rtnpaye : Form
    {
        List<colis> cls = new List<colis>();
        private List<colis> ll;
        public int c;
        public rtnpaye(int codeexp)
        {
            InitializeComponent();
            c = codeexp;
            loaddata();
        }
        public void loaddata()
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var req2 = from l in db.etatcolis
                       where l.Codeetat == 11
                       select l;
            var req = from l in db.colis
                      where l.Codeexpediteur == c
                      select l;
            ll = req.ToList();
            List<etatcolis> ets = req2.ToList();
            foreach (var item in ets)
            {
                foreach (var item1 in ll)
                {
                    if (item.Codecolis == item1.codecolis)
                    {
                        cls.Add(item1);
                    }
                }
            }
            if (cls.Count > 0)
            {


                dataGridView1.Rows.Add(cls.Count);
                for (int i = 0; i < cls.Count; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = ll[i].codecolis;
                    dataGridView1.Rows[i].Cells[1].Value = ll[i].nomclt;
                    dataGridView1.Rows[i].Cells[2].Value = ll[i].adresseclt + " " + ll[i].ville + " " + ll[i].gouvernemant;
                    dataGridView1.Rows[i].Cells[3].Value = ll[i].telclt;
                    dataGridView1.Rows[i].Cells[4].Value = ll[i].prix;
                    dataGridView1.Rows[i].Cells[5].Value = ll[i].des;


                }

            }
            else
            {
                MessageBox.Show("vous n' avez pas aucun cols en retour expediteur payees");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void colisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
