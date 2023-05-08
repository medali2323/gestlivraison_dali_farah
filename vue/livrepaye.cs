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
    public partial class livrepaye : Form
    {
        List<colis> cls = new List<colis>();
        private List<colis> ll;
        public int c;
        public livrepaye(int codeexp)
        {
            InitializeComponent();
            c = codeexp;
            loaddata();
        }
        public void loaddata()
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var req2 = from l in db.etatcolis
                       where l.Codeetat == 13
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
                MessageBox.Show("vous n' avez pas aucun cols livree payees");
            }


        }

        private void livrepaye_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
