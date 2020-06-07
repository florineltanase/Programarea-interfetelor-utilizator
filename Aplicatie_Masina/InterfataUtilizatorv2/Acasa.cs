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
    public partial class Acasa : Form
    {
        public Acasa()
        {
            InitializeComponent();
            lblMesaj.Text = "Proiect realizat de Florinel Alexandru Tanase";
            label1.Text = "3123a";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
