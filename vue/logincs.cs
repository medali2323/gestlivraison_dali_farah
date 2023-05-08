using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vue
{
    public partial class logincs : Form
    {
        public logincs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestlivraisonEntities6 ctx1 = new gestlivraisonEntities6();

            user user = ctx1.user.FirstOrDefault(x => x.username == textBox1.Text && x.password==textBox2.Text);
            if( user !=null ){
                if ( user.role == "expediteur") {
                    new dashboard(user.id_user).Show();
                }
                if ( user.role == "depot")
                {
                    new Dashboard_depot(user.id_user).Show();
                }
                if( user.role == "admin")
                {
                    new Form2(user.id_user).Show();
                }
            }
            else
            {
                MessageBox.Show("svp verifier vos cordonnéés");
            }

        }

        private void logincs_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
