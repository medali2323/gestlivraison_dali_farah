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
    public partial class list_depot : Form
    {
        public list_depot()
        {
            InitializeComponent();
            gestlivraisonEntities6 ctx = new gestlivraisonEntities6();
            var req = from l in ctx.Depot
                      select l;

            dataGridView1.DataSource = req.ToList();
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

        private void list_depot_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajouter_depot depot = new ajouter_depot();
            depot.ShowDialog(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
                    int iddepot = Convert.ToInt32(row.Cells[0].Value.ToString());
                    modifier_depot frmEdit = new modifier_depot(iddepot);
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
                        Depot ar = db.Depot.FirstOrDefault(x => x.iddepot == idArriveeCur);
                        db.Depot.Remove(ar);
                        db.SaveChanges();
                                loaddata();
                    }
                }
            }
        }

        private void loaddata()
        {
            gestlivraisonEntities6 ctx = new gestlivraisonEntities6();
            var req = from l in ctx.Depot
                      select l;

            dataGridView1.DataSource = req.ToList();
            //--------------------------------------------
            DataGridViewImageColumn btnEdit = new DataGridViewImageColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "";
            //  btnEdit.Image = Properties.Resources.edit2;
            dataGridView1.Columns.Add(btnEdit);
            //-------------------------------------------
            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "";
            //  btnDelete.Image = Properties.Resources.delete1
            dataGridView1.Columns.Add(btnDelete);
        }
    }
}
