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
    public partial class dashboard : Form
    { int codeexp;
        private int tot;
        List<colis> cls = new List<colis>();
        private List<colis> ll;
        public int c;
        public dashboard(int id_user)
        {
            InitializeComponent();
            Console.WriteLine(id_user);
            gestlivraisonEntities6 ctx1 = new gestlivraisonEntities6();
            expediteur exp = ctx1.expediteur.FirstOrDefault(x => x.id_user == id_user);
            Console.WriteLine(exp.Nomexpediteur) ;

            label14.Text = exp.Nomexpediteur;
            this.codeexp = exp.Codeexpediteur;
            var req = from l in ctx1.colis
                      where l.Codeexpediteur == codeexp
                      select l;
            tot = req.ToList().Count;
          
            


        }
        private void label8_Click(object sender, EventArgs e)
        {
           
            new  Form3(codeexp).Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new recherche().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
       
                new enattente(codeexp).Show();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            new total(codeexp).Show();


        }

        private void label17_Click(object sender, EventArgs e)
        {
            new total(codeexp).Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)

        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var req2 = from l in db.etatcolis
                       where l.Codeetat == 1
                       select l;
            var req = from l in db.colis
                      where l.Codeexpediteur == codeexp
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
                new enattente(codeexp).Show();

            }
            else
            {
                MessageBox.Show("aucun colis en attente");
            }

        }

        private void label16_Click(object sender, EventArgs e)
        {
            new enattente(codeexp).Show();
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new livrees(codeexp).Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new encours(codeexp).Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            new livrepaye(codeexp).Show();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            new audepot(codeexp).Show();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new audepot(codeexp).Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new rtndepot(codeexp).Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            new rtndefinitif(codeexp).Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            new rtnnonpaye(codeexp).Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            new rtnpaye(codeexp).Show();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            new enattente(codeexp).Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            new enattente(codeexp).Show();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            new encours(codeexp).Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            new encours(codeexp).Show();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            new livrees(codeexp).Show();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            new livrees(codeexp).Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            new livrepaye(codeexp).Show();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            new audepot(codeexp).Show();

        }

        private void label40_Click(object sender, EventArgs e)
        {
            new rtndepot(codeexp).Show();

        }

        private void label39_Click(object sender, EventArgs e)
        {
            new rtndepot(codeexp).Show();

        }

        private void label43_Click(object sender, EventArgs e)
        {
            new rtndefinitif(codeexp).Show();

        }

        private void label42_Click(object sender, EventArgs e)
        {
            new rtndefinitif(codeexp).Show();

        }
    }
}
