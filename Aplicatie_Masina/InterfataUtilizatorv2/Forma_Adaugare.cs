﻿//Florinel Alexandru Tanase,3123a
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
    public partial class Forma_Adaugare : Form
    {
        IStocareData adminMasina;
        List<string> dotariSelectate = new List<string>();
        public Forma_Adaugare()
        {
            InitializeComponent();
            adminMasina = StocareFactory.GetAdministratorStocare();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();

            CodEroare codValidare = Validare(txtNumeVanzator.Text, txtNumeCumparator.Text, txtModel.Text, txtPret.Text,cmbMarca.Text,cmbAnFabricatie.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                //Masina s = new Masina(txtNumeVanzator.Text, txtNumeCumparator.Text, txtModel.Text, Convert.ToDouble(txtPret.Text));
                Masina s = new Masina();
                s.Numevanzator = txtNumeVanzator.Text;
                s.Numecumparator = txtNumeCumparator.Text;
                s.Model = txtModel.Text;
                s.Pret = Convert.ToDouble(txtPret.Text);
                s.Marca = cmbMarca.Text;
                s.CuloareMasina = GetCuloareSelectata();
                s.Dotari = new List<string>();
                s.Dotari.AddRange(dotariSelectate);
                s.Anfabricatie = Convert.ToInt32(cmbAnFabricatie.Text);
                s.DataActualizare = DateTime.Now;
                s.DataTranzactie = dtpTranzactie.Value;
                adminMasina.AddMasina(s);
                MessageBox.Show("Tranzactia a fost adaugata");
                ResetareControale();
                
            }

        }
       
        private void txtNumeVanzator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsLetter(e.KeyChar))
                MessageBox.Show("Nu introduceti cifre!");
        }
        private void txtPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsDigit(e.KeyChar))
                MessageBox.Show("Nu introduceti litere");
        }
        private void ResetCuloareEtichete()
        {
            lblNumeVanzator.ForeColor = Color.Black;
            lblNumeCumparator.ForeColor = Color.Black;
            lblMarca.ForeColor = Color.Black;
            lblModel.ForeColor = Color.Black;
            lblCuloare.ForeColor = Color.Black;
            lblDotari.ForeColor = Color.Black;
            lblAnFabricatie.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
        }

        private CodEroare Validare(string numeVanzator, string numeCumparator, string model, string pret,string marca,string anFabricatie)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (numeVanzator == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_VANZATOR_INCORECT;
            }
            if (numeCumparator == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_CUMPARTOR_INCORECT;
            }
            if (model == string.Empty)
            {
                rezultatValidare |= CodEroare.MODEL_INCORECT;
            }
            if (pret == string.Empty)
            {
                rezultatValidare |= CodEroare.PRET_INCORECT;
            }
            if(marca == string.Empty)
            {
                rezultatValidare |= CodEroare.MARCA_NESELECTATA;
            }
            if (anFabricatie == string.Empty)
            {
                rezultatValidare |= CodEroare.ANFABRICATIE_NESELECTAT;
            }
            if(!ckbAC.Checked && !ckbAutomata.Checked && !ckbCruiseControl.Checked && !ckbGeamuriElectrice.Checked && !ckbJanteAliaj.Checked && !ckbManuala.Checked &&
                !ckbNavigatie.Checked && !ckbPiele.Checked)
            {
                rezultatValidare |= CodEroare.DOTARI_NESELCTATE;
            }
            int culoareSelectata = 0;
            foreach (var control in gpbCulori.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Checked == true)
                    culoareSelectata = 1;
            }
            if (culoareSelectata == 0)
                rezultatValidare |= CodEroare.CULOARE_NESELECTATA;
            return rezultatValidare;
        }

        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_VANZATOR_INCORECT) == CodEroare.NUME_VANZATOR_INCORECT)
            {
                lblNumeVanzator.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.NUME_CUMPARTOR_INCORECT) == CodEroare.NUME_CUMPARTOR_INCORECT)
            {
                lblNumeCumparator.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRET_INCORECT) == CodEroare.PRET_INCORECT)
            {
                lblPret.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.MODEL_INCORECT) == CodEroare.MODEL_INCORECT)
            {
                lblModel.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CULOARE_NESELECTATA) == CodEroare.CULOARE_NESELECTATA)
            {
                lblCuloare.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.DOTARI_NESELCTATE) == CodEroare.DOTARI_NESELCTATE)
            {
                lblDotari.ForeColor = Color.Red;
               
            }
            if ((codValidare & CodEroare.MARCA_NESELECTATA) == CodEroare.MARCA_NESELECTATA)
            {
                lblMarca.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.ANFABRICATIE_NESELECTAT) == CodEroare.ANFABRICATIE_NESELECTAT)
            {
                lblAnFabricatie.ForeColor = Color.Red;
            }
        }

        private Grup GetCuloareSelectata()
        {
            if (rdbAlb.Checked)
                return Grup.Alb;
            if (rdbAlbastru.Checked)
                return Grup.Albastru;
            if (rdbViolet.Checked)
                return Grup.Violet;
            if (rdbNegru.Checked)
                return Grup.Negru;
            if (rdbRosu.Checked)
                return Grup.Rosu;
            if (rdbGri.Checked)
                return Grup.Gri;
            if (rdbPortocaliu.Checked)
                return Grup.Portocaliu;
            if (rdbVerde.Checked)
                return Grup.Verde;
            if (rdbAuriu.Checked)
                return Grup.Auriu;
            return Grup.Culoare_neselectata;
        }

        private void ResetareControale()
        {
            txtNumeVanzator.Text = txtNumeCumparator.Text = txtModel.Text = txtPret.Text = string.Empty;
            rdbAlb.Checked = false;
            rdbAlbastru.Checked = false;
            rdbViolet.Checked = false;
            rdbNegru.Checked = false;
            rdbRosu.Checked = false;
            rdbGri.Checked = false;
            rdbPortocaliu.Checked = false;
            rdbVerde.Checked = false;
            rdbAuriu.Checked = false;
            ckbAC.Checked = false;
            ckbManuala.Checked = false;
            ckbJanteAliaj.Checked = false;
            ckbNavigatie.Checked = false;
            ckbPiele.Checked = false;
            ckbCruiseControl.Checked = false;
            ckbGeamuriElectrice.Checked = false;
            ckbAutomata.Checked = false;
            dotariSelectate.Clear();
            cmbMarca.Text = string.Empty;
            cmbAnFabricatie.Text = string.Empty;

        }
        private void ckbDotari_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;
            string dotareSelectata = checkBoxControl.Text;
            if (checkBoxControl.Checked == true)
                dotariSelectate.Add(dotareSelectata);
            else
                dotariSelectate.Remove(dotareSelectata);
        }
        

    }
}
