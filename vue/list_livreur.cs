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
    public partial class list_livreur : Form
    {
        List<livreur> ll;
        public list_livreur()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();

            var req = from l in db.livreur

                      select l;
            ll = req.ToList();
            Console.WriteLine("livssssssssssssss" +

                ll.Count);
            dataGridView1.Rows.Add(ll.Count);
            for (int i = 0; i < ll.Count; i++)
            {

                dataGridView1.Rows[i].Cells[0].Value = ll[i].Codelivreur;
                dataGridView1.Rows[i].Cells[1].Value = ll[i].Nomlivreur;
                dataGridView1.Rows[i].Cells[2].Value = ll[i].Numtel;
                dataGridView1.Rows[i].Cells[3].Value = ll[i].numcin;
                dataGridView1.Rows[i].Cells[4].Value = ll[i].Fraislivraison;
                dataGridView1.Rows[i].Cells[5].Value = ll[i].email;
                dataGridView1.Rows[i].Cells[6].Value = ll[i].Depot.ville;


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
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                row.Selected = true;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    int Codelivreur = Convert.ToInt32(row.Cells[0].Value.ToString());
                    modifier_livreur frmEdit = new modifier_livreur(Codelivreur, this);
                    frmEdit.ShowDialog();

                }

            }
            if (ColName == "btnDelete")
            {
                DialogResult dr = MessageBox.Show("Voulez Vous vraiment supprimer ce livreur ",
                    "Confirmation de suppression ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    gestlivraisonEntities6 db = new gestlivraisonEntities6();
                    {
                        livreur ar = db.livreur.FirstOrDefault(x => x.Codelivreur == idArriveeCur);
                        db.livreur.Remove(ar);
                        db.SaveChanges();
                        loaddata();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajouter_livreur frmEdit = new ajouter_livreur();
            frmEdit.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void list_livreur_Load(object sender, EventArgs e)
        {

        }
    }
}
