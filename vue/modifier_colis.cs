using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vue
{
    public partial class modifier_colis : Form
    {
        int codecl;
        private List<string> gouvs= new List<string>();
        private int codeexp;
        gouvernemant g = new gouvernemant();
        ville ville = new ville();
        String gg = "";
        String vv = "";
        public modifier_colis(int codecolis,enattente enattente)
        {
           
            InitializeComponent();
            gouvs = g.gouv();

            foreach (var item in gouvs)
            {
                comboBox1.Items.Add(item);
            }
            codecl = codecolis;
            Console.WriteLine("***** " + codecolis);
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            colis exp = db.colis.FirstOrDefault(x => x.codecolis == codecolis);
            textBox1.Text = exp.nomclt;
            richTextBox1.Text = exp.adresseclt;
            textBox3.Text = exp.telclt;
            comboBox1.Text = exp.gouvernemant;

            comboBox2.Text = exp.ville;
            textBox4.Text = exp.telclt2;
            textBox5.Text = exp.des;
            textBox2.Text = exp.nbartticle.ToString();
            textBox7.Text = exp.prix.ToString();
            textBox6.Text = exp.commentaire;
            if (exp.modepaiment == "espece")
            {
                radioButton1.Checked = true;
            }
            if (exp.modepaiment == "cheque")
            {
                radioButton2.Checked = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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

        }

        private void label24_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            colis exp = db.colis.FirstOrDefault(x => x.codecolis == codecl);
            exp.nomclt=textBox1.Text;
            exp.adresseclt=richTextBox1.Text;
            exp.telclt=textBox3.Text;
            exp.telclt2 = textBox4.Text;
            exp.des = textBox5.Text;
           exp.nbartticle = Convert.ToInt32(textBox2.Text);
            exp.prix = Convert.ToDouble(textBox7.Text);
            exp.commentaire = textBox6.Text;
            if (radioButton1.Checked)
            {
                exp.modepaiment = "Espece";
            }
            if (radioButton2.Checked)
            {
                exp.modepaiment = "cheque";
            }
            db.SaveChanges();
            MessageBox.Show("colis modifier");

        }

        private void label15_Click(object sender, EventArgs e)
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
