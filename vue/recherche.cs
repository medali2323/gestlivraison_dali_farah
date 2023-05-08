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
    public partial class recherche : Form
    {
        List<colis> lC;
        List<etatcolis> ll;
        int codecol;
        public recherche()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var req1 = from l in db.colis
                      where l.telclt == textBox1.Text
                      select l;
         dataGridView1.Show();

            lC = req1.ToList();
            codecol = lC[0].codecolis;
            label23.Text = lC[0].nomclt;
            label24.Text = lC[0].adresseclt + " " + lC[0].ville + " "+ lC[0].gouvernemant;
            label25.Text = lC[0].telclt;
            label26.Text = lC[0].nbartticle.ToString();
            label27.Text = lC[0].prix.ToString();
          

            var req = from l in db.etatcolis
                      where l.Codecolis == codecol
                      select l;

            ll = req.ToList();
           if(ll.Count > 0)
            {
                dataGridView1.Rows.Add(ll.Count);
                for (int i = 0; i < ll.Count; i++)
                {



                    dataGridView1.Rows[i].Cells[0].Value = conv(ll[i].Codeetat);
                    dataGridView1.Rows[i].Cells[1].Value = ll[i].Date;


                }
            }
            else
            {
                MessageBox.Show("aucun colis existe avec ce numero");
            }
        }
        public String conv(int c)
        {
            string ch = "";
            if (c == 1)
                ch = "en attente";
            if (c == 2)
                ch = "Au depot";
            if (c == 3)
                ch = "En cours";
            if (c == 4)
                ch = "livrés";
            if (c == 7)
                ch = "Retour Depot";
            if (c == 10)
                ch = "Retour Définitif";
            if (c == 11)
                ch = "Retour payee";
            if (c == 12)
                ch = "Retour Non Payee";
            if (c == 13)
                ch = "livrés payee";


            return ch;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void recherche_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
         //   new dashboard(c).Show();
        }
    }
}
