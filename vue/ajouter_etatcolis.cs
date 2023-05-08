using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vue
{
    public partial class ajouter_etatcolis : Form
    {       private int etatchoisi;
        private int newetat;
        private int livreurchoisit;
        private List<colis> ll;
        private List<livreur> livreurs;

        private List<colis> cls=new List<colis>();
        private List<Etat> etats = new List<Etat>();
        private List<colis> listcolis;
        private List<etatcolis> etatscolis;
        etatcolis dernieretat;
        List<int> tab;
        public struct etcl
        {
            public int ccl;
            public int cet;
        }
        public ajouter_etatcolis()
        {
            InitializeComponent();
            loaddata();
        }
        public colis getcolisbyid(int c)
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            return db.colis.FirstOrDefault(x => x.codecolis == c);
            

        }
        private void loaddata()
        {
            
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var req3 = from l in db.Etat
                       select l;
            etats = req3.ToList();
            foreach (var item in etats)
            {
                comboBox1.Items.Add(item.Libelle);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<etatcolis> aa(int et)
        {
            Console.WriteLine("etat choisit : " + et);
            List<etatcolis> tab1 =new List<etatcolis>() ;
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var reqlistcolis = from l in db.colis

                      select l;
            listcolis = reqlistcolis.ToList();
            foreach (var item in listcolis)
            {
                var reqetatcolis = from l in db.etatcolis
                                   where l.Codecolis == item.codecolis
                                   select l;
                etatscolis = reqetatcolis.ToList();

                if (etatscolis.Count > 0)
                {
                    dernieretat = etatscolis[(etatscolis.Count) - 1];

                    if (dernieretat.Codeetat == et)
                    {
                    
                        tab1.Add(dernieretat);
                        
                    }
                }
            }


           







            return tab1;
           
            

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            etatchoisi = comboBox1.SelectedIndex + 1;
            foreach (var item in aa(etatchoisi))
            {
                Console.WriteLine("tab 1 in combox   :" + item);
            }
            if (aa(etatchoisi).Count>0)
            {
                dataGridView1.Rows.Add(aa(etatchoisi).Count);
                for (int i = 0; i < aa(etatchoisi).Count; i++)
                {

                    dataGridView1.Rows[i].Cells[1].Value = getcolisbyid(aa(etatchoisi)[i].Codecolis).codecolis;
                    dataGridView1.Rows[i].Cells[2].Value =  getcolisbyid(aa(etatchoisi)[i].Codecolis).nomclt;
                    dataGridView1.Rows[i].Cells[3].Value =  getcolisbyid(aa(etatchoisi)[i].Codecolis).adresseclt + " " +  getcolisbyid(aa(etatchoisi)[i].Codecolis).ville + " " +  getcolisbyid(aa(etatchoisi)[i].Codecolis).gouvernemant;
                    dataGridView1.Rows[i].Cells[4].Value =  getcolisbyid(aa(etatchoisi)[i].Codecolis).telclt;
                    dataGridView1.Rows[i].Cells[5].Value =  getcolisbyid(aa(etatchoisi)[i].Codecolis).prix;
                    dataGridView1.Rows[i].Cells[6].Value =  getcolisbyid(aa(etatchoisi)[i].Codecolis).des;
                    dataGridView1.Rows[i].Cells[7].Value = aa(etatchoisi)[i].Codelivreur;
                    //   dataGridView1.Rows[i].Cells[7].Value = d;

                }
                loadcombox();
                loadlivreur();

            }
            else
            {
                MessageBox.Show("aucun colis est trouve pour l'etat  choisit");
            }
        }
        




        private void loadlivreur()
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var req3 = from l in db.livreur
                       select l;
            livreurs = req3.ToList();
            foreach (var item in livreurs)
            {
                comboBox3.Items.Add(item.Nomlivreur);
            }
        }

        private void loadcombox()
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var req3 = from l in db.Etat
                       select l;
            etats = req3.ToList();
            foreach (var item in etats)
            {
                comboBox2.Items.Add(item.Libelle);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkBox = dataGridView1.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                if (checkBox != null && (bool)checkBox.Value == true)
                {
                    DateTime d = DateTime.Now;
                   
                 
                        etatcolis etatcolis = new etatcolis(1, Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), newetat, livreurchoisit, d, textBox2.Text);
                        gestlivraisonEntities6 db = new gestlivraisonEntities6();
                        db.etatcolis.Add(etatcolis);
                        db.SaveChanges();
                        MessageBox.Show("etat enrigistre");
                    
                }
                else
                {
                    MessageBox.Show("hors selected");
                }
            }

            //   dataGridView1.Rows.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            newetat = comboBox2.SelectedIndex + 1;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            livreurchoisit = comboBox3.SelectedIndex + 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
