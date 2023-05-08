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
    public partial class detail_colis : Form
    {
        public List<etatcolis> ll;
        public List<Etat> l1;
        string et;
        public detail_colis( int c)
        {
            InitializeComponent();
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var req = from l in db.etatcolis
                      where l.Codecolis == c
                      select l;
           
            ll = req.ToList();
            dataGridView1.Rows.Add(ll.Count);
            for (int i = 0; i < ll.Count; i++)
            {
                if (ll[i].Codeetat == 1)
                    
             
                dataGridView1.Rows[i].Cells[0].Value = conv(ll[i].Codeetat) ;
                dataGridView1.Rows[i].Cells[1].Value = ll[i].Date;
               

            }
        }
       public String conv(int c)
        {
            string ch="";
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
    
}
