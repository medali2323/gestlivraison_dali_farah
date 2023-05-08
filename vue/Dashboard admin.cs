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
    public partial class Form2 : Form
    {
        public Form2(int id_user)
        {
            InitializeComponent();
            gestlivraisonEntities6 ctx1 = new gestlivraisonEntities6();
            user u = ctx1.user.FirstOrDefault(x => x.id_user == id_user);

            label14.Text = u.username;
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            new contactsociete().Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
          
            new list_reclamation().Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
            new recettesociete().Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
            new listExprditeur().Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
          
            new list_depot().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new recherche().Show(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
          
            new list_livreur().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {
         new    ajouter_etatcolis().Show();
        }
    }
}
