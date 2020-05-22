using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librarie;
using NivelAccesDate; 

namespace InterfataUtilizatorv2
{
    public partial class Form1 : Form
    {
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
                var linieTabel = String.Format("{0,-5}{1,15}{2,20}{3,25}\n", s.Numevanzator, s.Numecumparator, s.CuloareMasina.ToString(), s.Anfabricatie.ToString());
                lstAfisare.Items.Add(linieTabel);
            }
        }
        private void AdaugaMasiniInControlDataGridView(List<Masina> studenti)
        {

            dataGridMasina.DataSource = null;
            dataGridMasina.DataSource = studenti.Select(s => new { s.Numevanzator, s.Numecumparator, s.Marca, s.Model, s.CuloareMasina, s.Pret, s.Anfabricatie, Dotari = string.Join(",", s.DotariAsString), s.DataTranzactie, s.DataActualizare }).ToList();
        }

        private void btnCauta_Click(Object sender, EventArgs e)
        {
            var myForm = new CautareForma();
            myForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
