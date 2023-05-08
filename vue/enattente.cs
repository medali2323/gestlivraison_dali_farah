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
    public partial class enattente : Form
    {
        List<colis> cls=new List<colis>();
        private List<colis> ll;
        public int c;
        public enattente(int codeexp)
        {
            InitializeComponent();
            c = codeexp;
            loaddata();
        }
        public void loaddata()
        {
            gestlivraisonEntities6 db = new gestlivraisonEntities6();
            var req2 = from l in db.etatcolis
                       where l.Codeetat == 1 && l.Codecolis == c
                       select l;
            var req = from l in db.colis
                     
                      select l;
            ll = req.ToList();
            List<etatcolis> ets = req2.ToList();
            foreach (var item in ets)
            {
                foreach (var item1 in ll)
                {
                    if (item.Codecolis == item1.codecolis)
                    {
                        cls.Add(item1);
                    }
                }
            }
            if( cls.Count > 0) {
                dataGridView1.Rows.Add(cls.Count);
                for (int i = 0; i < cls.Count; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = ll[i].codecolis;
                    dataGridView1.Rows[i].Cells[1].Value = ll[i].nomclt;
                    dataGridView1.Rows[i].Cells[2].Value = ll[i].adresseclt + " " + ll[i].ville + " " + ll[i].gouvernemant;
                    dataGridView1.Rows[i].Cells[3].Value = ll[i].telclt;
                    dataGridView1.Rows[i].Cells[4].Value = ll[i].prix;
                    dataGridView1.Rows[i].Cells[5].Value = ll[i].des;


                }
                //-------------------------------------------
                DataGridViewImageColumn btnPrint = new DataGridViewImageColumn();
                btnPrint.Name = "btnPrint";
                btnPrint.HeaderText = "";
                // btnPrint.Image = Properties.Resources.print0;
                dataGridView1.Columns.Add(btnPrint);
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
            else
            {
                MessageBox.Show("aucun colis en attente");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void enattente_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            row.Selected = true;
            int idArriveeCur = Convert.ToInt32(row.Cells["codecolis"].Value);

            if (ColName == "btnEdit")
            {
                if (e.RowIndex >= 0)
                {
                    int index = e.RowIndex;
                    row = dataGridView1.Rows[index];
                    row.Selected = true;
                    int codecolis = Convert.ToInt32(row.Cells["codecolis"].Value.ToString());
                    modifier_colis frmEdit = new modifier_colis(codecolis, this);
                    frmEdit.ShowDialog();

                }
              
            }
            if (ColName == "btnDelete")
            {
                DialogResult dr = MessageBox.Show("Voulez Vous vraiment supprimer ce colis ",
                    "Confirmation de suppression ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    gestlivraisonEntities6 db = new gestlivraisonEntities6();
                    {
                        colis ar = db.colis.FirstOrDefault(x => x.codecolis == idArriveeCur);
                        db.colis.Remove(ar);
                        db.SaveChanges();
                        loaddata();
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
