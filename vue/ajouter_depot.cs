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
    public partial class ajouter_depot : Form
    {
        List<string> gouvs = new List<string>();
        gouvernemant g = new gouvernemant();
        private string gg;

        public ajouter_depot()
        {
            InitializeComponent();
            gouvs = g.gouv();

            foreach (var item in gouvs)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void ajouter_depot_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestlivraisonEntities6 ctx = new gestlivraisonEntities6();

            user u = new user(1, "", textBox3.Text, "depot", 1);
            ctx.user.Add(u);
            ctx.SaveChanges();
            var req = from l in ctx.user
                      select l;
            List<user> lu = req.ToList();
            var X = lu.Count();
            gg = comboBox2.Text;

            Depot d = new Depot(1, gg,richTextBox1.Text, textBox3.Text, X);
            ctx.Depot.Add(d);
            ctx.SaveChanges();
            MessageBox.Show("depot ajouté avec succés!");
            this.Close();
            new list_depot().Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            ajouter_etatcolis a = new ajouter_etatcolis();
            a.Show();
        }
    }
}
