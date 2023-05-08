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
    public partial class Dashboard_depot : Form
    {
        public Dashboard_depot(int id_user)
        {
            InitializeComponent();
            InitializeComponent();
            gestlivraisonEntities6 ctx1 = new gestlivraisonEntities6();
            user u = ctx1.user.FirstOrDefault(x => x.id_user == id_user);

            label14.Text = u.username;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
