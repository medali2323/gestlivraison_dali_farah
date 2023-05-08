using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data.Entity.Validation;

namespace vue
{
    public partial class Form3 : Form
    { int codeexp;
        List<string> gouvs= new List<string>();
        gouvernemant g =new gouvernemant();
        ville ville = new ville();
        String gg = "";
        String vv = "";
        public Form3(int id_use)
        {
            InitializeComponent();
            this.codeexp = id_use;
            gouvs = g.gouv();
            
            foreach (var item in gouvs)
            {
                comboBox1.Items.Add(item);
            }
         

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            loadcombox2(i);
            gg=comboBox1.Text;
            comboBox2.Items.Clear();
            List<List<string>> villes = new List<List<string>>();
            villes = ville.getville();
                
                foreach (var item in villes[i-1])
                {
                    comboBox2.Items.Add(item);
                }
                
            
        }

        private void loadcombox2(int i)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String  ch = "espece";
            if(radioButton1.Checked)
                ch=radioButton1.Text;
            if (radioButton2.Checked)
                ch = radioButton2.Text;
            
            colis colis = new colis(1, textBox1.Text, gg, vv, richTextBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToDouble(textBox7.Text), Convert.ToInt32(textBox2.Text), textBox6.Text,ch, codeexp) ;
            gestlivraisonEntities6 ctx = new gestlivraisonEntities6();
            ctx.colis.Add(colis);
            ctx.SaveChanges();
            var req = from l in ctx.colis
                      select l;
            List<colis> lu = req.ToList();
            var X = lu.Count()-1;
            DateTime now = DateTime.Now;
               








                etatcolis etatcolis = new etatcolis(1, X, 1, null, now, "  ");
                ctx.etatcolis.Add(etatcolis);
                ctx.SaveChanges();
                MessageBox.Show("colis ajouté avec succés!");
                this.Close();
                new enattente(codeexp).Show();
            }
            catch (DbEntityValidationException ex)
            {
                // Boucle à travers chaque erreur de validation et les affiche
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var validationError in error.ValidationErrors)
                    {
                        Console.WriteLine("Propriété: {0} Erreur: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }














        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            vv = comboBox2.Text;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new dashboard(codeexp).Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new recherche().Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
    
}
