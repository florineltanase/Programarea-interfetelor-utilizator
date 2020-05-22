using Librarie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;

namespace InterfataUtilizatorv2
{
    public partial class CautareForma : Form
    {
        IStocareData adminMasina;
        public CautareForma()
        {
            InitializeComponent();
            adminMasina = StocareFactory.GetAdministratorStocare();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCauta_Click(object sender, EventArgs e)
        {
            Masina s = adminMasina.GetMasina(txtNumeVanzator.Text, txtNumeCumparator.Text);
            if (s != null)
            {
                lblMesaj.Text = (s.ConversieLaSir());
            }
            else
                MessageBox.Show("Tranzactia nu a fost gasita");
           
        }
    }
}
