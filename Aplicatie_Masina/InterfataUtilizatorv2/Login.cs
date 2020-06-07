//Florinel Alexandru Tanase,3123a
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizatorv2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user="florinel", par="florinel";
            
            if(txtUser.Text == string.Empty || txtParola.Text==string.Empty ) 
            {
                MessageBox.Show("Introduceti date valide");
                
            }
           if(txtUser.Text != user || txtParola.Text != par)
            {
                MessageBox.Show("Datele nu sunt corecte");
            }
            if (txtUser.Text == user && txtParola.Text ==par )
            {
                MessageBox.Show("Buna ziua!");
                this.Hide();
                Form1 ss = new Form1();
                ss.ShowDialog();
                this.Close();
            }
            
        }
    }
}
