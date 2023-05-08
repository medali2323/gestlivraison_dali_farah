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
    public partial class ajouter_livreur : Form
    {
        public ajouter_livreur()
        {
            InitializeComponent();
            gestlivraisonEntities6 ctx = new gestlivraisonEntities6();
            var req = from l in ctx.Depot
                      select l;
            var ll = req.ToList();
            foreach (var item in ll)
            {
                comboBox1.Items.Add("depot "+ item.ville) ;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestlivraisonEntities6 ctx = new gestlivraisonEntities6();

            livreur d = new livreur(1, textBox1.Text, textBox3.Text, textBox4.Text, Convert.ToDouble(textBox5.Text), textBox2.Text, comboBox1.SelectedIndex) ;
            ctx.livreur.Add(d);
            ctx.SaveChanges();
            MessageBox.Show("livreur ajouté avec succés!");
            this.Close();
            list_livreur lexp = new list_livreur();
            lexp.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
