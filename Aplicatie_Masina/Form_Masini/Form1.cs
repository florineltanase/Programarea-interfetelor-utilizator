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
using Librarie;

namespace Form_Masini
{
    public partial class Form1 : Form
    {
        IStocareData adminMasini;

        public Form1()
        {
            InitializeComponent();
            adminMasini = StocareFactory.GetAdministratorStocare();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Masina m;
            txtNumeVanzator.ForeColor = Color.Black;
            txtNumeCumparator.ForeColor = Color.Black;
            txtMarca.ForeColor = Color.Black;
            txtModel.ForeColor = Color.Black;
            txtCuloare.ForeColor = Color.Black;
            txtPret.ForeColor = Color.Black;
            txtAnFabricatie.ForeColor = Color.Black;
            txtDotari.ForeColor = Color.Black;
            CodEroare valideaza = Validare(txtNumeVanzator.Text, txtNumeCumparator.Text, txtMarca.Text,txtModel.Text,txtCuloare.Text,txtPret.Text,txtAnFabricatie.Text,txtDotari.Text);
            if (valideaza != CodEroare.CORECT)
            {
                switch (valideaza)
                {
                    case CodEroare.NUME_VANZATOR_INCORECT:
                        txtNumeVanzator.ForeColor = Color.Red;
                        break;
                    case CodEroare.NUME_CUMPARTOR_INCORECT:
                        txtNumeCumparator.ForeColor = Color.Red;
                        break;
                    case CodEroare.MARCA_INCORECT:
                        txtMarca.ForeColor = Color.Red;
                        break;
                    case CodEroare.MODEL_INCORECTA:
                        txtModel.ForeColor = Color.Red;
                        break;
                    case CodEroare.CULOARE_INCORECTA:
                        txtCuloare.ForeColor = Color.Red;
                        break;
                    case CodEroare.PRET_INCORECT:
                        txtPret.ForeColor = Color.Red;
                        break;
                    case CodEroare.AN_FABRICATIE_INCORECT:
                        txtAnFabricatie.ForeColor = Color.Red;
                        break;
                    case CodEroare.DOTARI_INCORECTE:
                        txtDotari.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                m = new Masina(txtNume.Text, txtPrenume.Text);
                s.SetNote(txtNote.Text);
                adminMasini.AddMasina(m);
                lblAdauga.Text = "Studentul a fost adaugat";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNumeVanzator_Click(object sender, EventArgs e)
        {

        }
    }
}
