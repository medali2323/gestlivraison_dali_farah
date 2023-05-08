using DocumentFormat.OpenXml.EMMA;
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
    public partial class modifier_depot : Form
    {
        int idd;
        private List<string> gouvs;
        private int codeexp;
        gouvernemant g = new gouvernemant();
        ville ville = new ville();
        String gg = "";
        String vv = "";
        public modifier_depot(int iddepot)
        {
          
            InitializeComponent();
            idd = iddepot;
            Console.WriteLine("***** " + idd);
            InitializeComponent();
            gouvs = g.gouv();

            foreach (var item in gouvs)
            {
                comboBox2.Items.Add(item);
            }
            


        }

        private void modifier_depot_Load(object sender, EventArgs e)
        {
gestlivraisonEntities6 db = new gestlivraisonEntities6();
            Depot exp = db.Depot.FirstOrDefault(x => x.iddepot == idd);
            textBox1.Text = "depot" + exp.ville;
            richTextBox1.Text = exp.adresse;
            textBox3.Text = exp.numtel;
            comboBox2.Text = exp.ville;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            Depot exp = db.Depot.FirstOrDefault(x => x.iddepot == idd);
            exp.ville = textBox1.Text;
            exp.adresse = richTextBox1.Text;
            exp.numtel = textBox3.Text;
            exp.ville = vv;
            db.SaveChanges();
            MessageBox.Show("depot modifier");
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
