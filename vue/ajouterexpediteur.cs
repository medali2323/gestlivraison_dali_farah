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
    public partial class ajouterexpediteur : Form
    {
        List<string> gouvs = new List<string>();
        gouvernemant g = new gouvernemant();
        ville ville = new ville();
        String gg = "";
        String vv = "";
        public ajouterexpediteur()
        {
            InitializeComponent();
            gouvs = g.gouv();

            foreach (var item in gouvs)
            {
                comboBox1.Items.Add(item);
            }
            comboBox3.Items.Add("espece");
            comboBox3.Items.Add("chequz");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            user u = new user(1, textBox5.Text, textBox3.Text, "expediteur", 1);
            db.user.Add(u);
            db.SaveChanges();
            var req = from l in db.user
                      select l;
            List<user> lu = req.ToList();
            var X = lu.Count();

            expediteur exp = new expediteur();
            exp.Codeexpediteur = 1;
            exp.Nomexpediteur = textBox1.Text;
            exp.Numtelexpéditeur = textBox3.Text;
            exp.adresse = richTextBox1.Text;
            exp.viille = vv;
            exp.gouvernemant = gg;
            exp.Codetva = textBox4.Text;
            exp.Email = textBox5.Text;
            exp.Fraisretour = Convert.ToDouble(textBox8.Text);
            exp.Fraislivraison = Convert.ToDouble(textBox7.Text);
            exp.Modepaiement = comboBox3.Text;
            exp.id_user=X; ;
            db.expediteur.Add(exp);
            db.SaveChanges();
            MessageBox.Show("expediteur ajoutee");
            listExprditeur lexp = new listExprditeur();
            lexp.ShowDialog();
        }
        private void loadcombox2(int i)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            loadcombox2(i);
            gg = comboBox1.Text;
            comboBox2.Items.Clear();
            List<List<string>> villes = new List<List<string>>();
            villes = ville.getville();

            foreach (var item in villes[i-1 ])
            {
                comboBox2.Items.Add(item);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            vv = comboBox2.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
