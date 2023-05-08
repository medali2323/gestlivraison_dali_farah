using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
    public partial class modifier_livreur : Form
    {
        int codlv;
        public modifier_livreur(int Codelivreur, list_livreur list_livreur)
        {
            InitializeComponent();
           
            codlv = Codelivreur;
            InitializeComponent();
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            livreur exp = db.livreur.FirstOrDefault(x => x.Codelivreur == codlv);
            textBox1.Text = exp.Nomlivreur;
                       Console.WriteLine("***** " + exp.Nomlivreur);

            textBox3.Text = exp.Numtel;
            textBox4.Text = exp.numcin;
            textBox5.Text = exp.email;
            textBox2.Text= exp.Fraislivraison.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            livreur exp = db.livreur.FirstOrDefault(x => x.Codelivreur == codlv);
            exp.Nomlivreur=textBox1.Text;
            exp.Numtel=textBox3.Text;
            exp.numcin=textBox4.Text;
            exp.email=textBox5.Text;
            exp.Fraislivraison=Convert.ToDouble(textBox2.Text);
       

            db.SaveChanges();
            MessageBox.Show("livreur modifier");
            this.Close();
            new list_livreur().Show();
        }
    }
}
