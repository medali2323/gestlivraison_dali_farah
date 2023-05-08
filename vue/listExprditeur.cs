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
    public partial class listExprditeur : Form
    {
        private List<expediteur> listexp;

        public listExprditeur()
        {
            InitializeComponent();
            gestlivraisonEntities6 ctx = new gestlivraisonEntities6();
            var req = from l in ctx.expediteur
                      select l;

            listexp = req.ToList();
            dataGridView1.Rows.Add(listexp.Count);
            for (int i = 0; i < listexp.Count; i++)
            {

                dataGridView1.Rows[i].Cells[0].Value = listexp[i].Codeexpediteur;
                dataGridView1.Rows[i].Cells[1].Value = listexp[i].Nomexpediteur;
                dataGridView1.Rows[i].Cells[2].Value = listexp[i].Numtelexpéditeur;
                dataGridView1.Rows[i].Cells[3].Value = listexp[i].adresse+listexp[i].viille+ listexp[i].gouvernemant;
                dataGridView1.Rows[i].Cells[4].Value = listexp[i].Codetva;
                dataGridView1.Rows[i].Cells[5].Value = listexp[i].Modepaiement;
                dataGridView1.Rows[i].Cells[6].Value = listexp[i].Fraislivraison;
                dataGridView1.Rows[i].Cells[7].Value = listexp[i].Fraisretour;


            }

            //--------------------------------------------
            DataGridViewImageColumn btnEdit = new DataGridViewImageColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "";
            btnEdit.Image = Properties.Resources.edit1;
            dataGridView1.Columns.Add(btnEdit);
            //-------------------------------------------
            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "";
            btnDelete.Image = Properties.Resources.delete1;
            dataGridView1.Columns.Add(btnDelete);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                row.Selected = true;
            }
        }

        private object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {

        }

     

        private void nomexpediteurTextBox_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void listExprditeur_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

       

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void viilleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                row.Selected = true;
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                row.Selected = true;
            }
        }

        private void numtelexpéditeurLabel_Click(object sender, EventArgs e)
        {

        }

        private void numtelexpéditeurTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codetvaLabel_Click(object sender, EventArgs e)
        {

        }

        private void codetvaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adresseLabel_Click(object sender, EventArgs e)
        {

        }

        private void adresseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gouvernemantLabel_Click(object sender, EventArgs e)
        {

        }

        private void gouvernemantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viilleLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomexpediteurLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            row.Selected = true;
            int idArriveeCur = Convert.ToInt32(row.Cells[0].Value);

            if (ColName == "btnEdit")
            {
                if (e.RowIndex >= 0)
                {
                    int index = e.RowIndex;
                    row = dataGridView1.Rows[index];
                    row.Selected = true;
                    int Codeexpediteur = Convert.ToInt32(row.Cells[0].Value.ToString());
                    modifierexpediteur frmEdit = new modifierexpediteur(Codeexpediteur, this);
                    frmEdit.ShowDialog();

                }

            }
            if (ColName == "btnDelete")
            {
                DialogResult dr = MessageBox.Show("Voulez Vous vraiment supprimer ce expediteur ",
                    "Confirmation de suppression ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    gestlivraisonEntities6 db = new gestlivraisonEntities6();
                    {
                        expediteur ar = db.expediteur.FirstOrDefault(x => x.Codeexpediteur == idArriveeCur);
                        db.expediteur.Remove(ar);
                        db.SaveChanges();
                        // loaddata();
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ajouterexpediteur frmEdit = new ajouterexpediteur();
            frmEdit.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
            }
        
    
