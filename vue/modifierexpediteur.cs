using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class modifierexpediteur : Form
    {
        private listExprditeur lexp;
        private List<string> gouvs;
        private int codeexp;
        gouvernemant g = new gouvernemant();
        ville ville = new ville();
        String gg = "";
        String vv = "";
        public modifierexpediteur(int codeexpediteur, listExprditeur listExprditeur)
        {
            InitializeComponent();
            this.codeexp=codeexpediteur;
            this.lexp = listExprditeur;
            gouvs = g.gouv();

            foreach (var item in gouvs)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void modifierexpediteur_Load(object sender, EventArgs e)
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            expediteur exp = db.expediteur.FirstOrDefault(x => x.Codeexpediteur == codeexp);
            textBox1.Text = exp.Nomexpediteur;
            richTextBox1.Text = exp.adresse;
            textBox3.Text = exp.Numtelexpéditeur;

            textBox4.Text = exp.Codetva;
            textBox5.Text = exp.Email;
            textBox7.Text = exp.Fraislivraison.ToString() ;
            textBox8.Text = exp.Fraisretour.ToString() ;
            comboBox1.Text=exp.gouvernemant;
           
            comboBox2.Text=exp.viille;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            expediteur exp = db.expediteur.FirstOrDefault(x => x.Codeexpediteur == codeexp);
            exp.Nomexpediteur=textBox1.Text;
            exp.Numtelexpéditeur = textBox3.Text;
            exp.Codetva = textBox4.Text;
            exp.Email = textBox5.Text;
            exp.Fraisretour=Convert.ToDouble(textBox8.Text);
            exp.Fraislivraison = Convert.ToDouble(textBox7.Text);
            exp.viille = vv;
            exp.gouvernemant = gg;
            db.SaveChanges();

            this.Close();
         //   this.lexp.loadexpiditeur();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;

            gg = comboBox1.Text;
            comboBox2.Items.Clear();
            List<List<string>> villes = new List<List<string>>();
            villes = ville.getville();

            foreach (var item in villes[i - 1])
            {
                comboBox2.Items.Add(item);
            }
        }
    }
}
