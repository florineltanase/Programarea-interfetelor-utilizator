//Florinel Alexandru Tanase,3123a
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librarie;
using NivelAccesDate; 

namespace InterfataUtilizatorv2
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        IStocareData adminMasina;
        
        
        public Form1()
        {
            InitializeComponent();
            adminMasina = StocareFactory.GetAdministratorStocare();
        }

      private void btnAdauga_Click(Object sender, EventArgs e)
        {
            var myForm = new Forma_Adaugare();
            myForm.Show();
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {

            
            List<Masina> masini = adminMasina.GetMasina();

            AdaugaMasiniInControlListbox(masini);
            AdaugaMasiniInControlDataGridView(masini);
        }
        private void AdaugaMasiniInControlListbox(List<Masina> masini)
        {
            lstAfisare.Items.Clear();

            List<Masina> Masini = adminMasina.GetMasina();
            foreach (Masina s in Masini)
            {
                var linieTabel = String.Format("{0,-5}{1,15}{2,20}{3,25},{4,30}\n", s.Numevanzator, s.Numecumparator, s.CuloareMasina.ToString(), s.Anfabricatie.ToString(), s.DotariAsString);
                lstAfisare.Items.Add(linieTabel);
            }
        }
        private void AdaugaMasiniInControlDataGridView(List<Masina> masini)
        {

            dataGridMasina.DataSource = null;
            dataGridMasina.DataSource = masini.Select(s => new { s.IdMasina,s.Numevanzator, s.Numecumparator, s.Marca, s.Model, s.CuloareMasina, s.Pret, s.Anfabricatie, Dotari = string.Join(",", s.DotariAsString), s.DataTranzactie, s.DataActualizare }).ToList();
        }

        private void btnCauta_Click(Object sender, EventArgs e)
        {
            var myForm = new CautareForma();
            myForm.Show();
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {

            double sumaTotala = 0;
            List <Masina> masini2 = adminMasina.GetMasina();
            foreach (Masina m in masini2)
            {
                sumaTotala += m.Pret;
            }
            MessageBox.Show("In urma tranzactiilor, s-a incasat suma de " + sumaTotala + " euro");

        }
        /*
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) 
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Acasa());
        }
        */
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrare_Click(object sender, EventArgs e)
        {
            List < Masina > nucazan = adminMasina.GetAnFabricatie();
            dataGridMasina.DataSource = nucazan.Select(s => new { s.IdMasina, s.Numevanzator, s.Numecumparator, s.Marca, s.Model, s.CuloareMasina, s.Pret, s.Anfabricatie, Dotari = string.Join(",", s.DotariAsString), s.DataTranzactie, s.DataActualizare }).ToList();

        }
    }
}
