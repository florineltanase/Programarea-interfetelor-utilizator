//Florinel Alexandru Tanase,3123a
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
using System.Drawing.Text;

namespace InterfataUtilizatorv2
{
    public partial class CautareForma : Form
    {
        IStocareData adminMasina;
        List<string> dotariSelectate = new List<string>();

        public CautareForma()
        {
            InitializeComponent();
            adminMasina = StocareFactory.GetAdministratorStocare();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }
        private void btnCauta_Click(object sender, EventArgs e)
        {
            Masina s = adminMasina.GetMasina(txtNumeVanzator.Text, txtNumeCumparator.Text,cmbMarca.Text);
            ResetCuloareEtichete();
            CodEroare codValidare = Validare_Cauta(txtNumeVanzator.Text, txtNumeCumparator.Text, cmbMarca.Text);
            
            if(codValidare == CodEroare.CORECT)
            {
                if(s!=null)
                {
                    if(txtNumeVanzator.Text == s.Numevanzator && txtNumeCumparator.Text == s.Numecumparator && cmbMarca.Text == s.Marca)
                    {
                        MessageBox.Show("Tranzactia a fost gasita");
                        var bindingThing = new BindingSource();
                        bindingThing.Add(s);
                        dataGridCauta.DataSource = bindingThing;
                    }
                    else
                    {
                        MessageBox.Show("Tranzactia nu exista");
                    }
                }
                else
                {
                    MessageBox.Show("Tranzactia nu exista");
                }
            }
            else
            {
                MarcheazaControaleCuDateIncorecte_Cauta(codValidare);
                MessageBox.Show("Datele nu sunt corecte");
            }
           
        
        }
        
        private CodEroare Validare_Cauta(string numevanzator,string numecumparator,string marca)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if(numevanzator == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_VANZATOR_INCORECT;
            }
            if(numecumparator == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_CUMPARTOR_INCORECT;
            }
            if(marca == string.Empty)
            {
                rezultatValidare |= CodEroare.MARCA_NESELECTATA;
            }
            return rezultatValidare;

        }
        private void MarcheazaControaleCuDateIncorecte_Cauta(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_VANZATOR_INCORECT) == CodEroare.NUME_VANZATOR_INCORECT)
            {
                lblNumeVanzator.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.NUME_CUMPARTOR_INCORECT) == CodEroare.NUME_CUMPARTOR_INCORECT)
            {
                lblNumeCumparator.ForeColor = Color.Red;
            }
            if((codValidare & CodEroare.MARCA_NESELECTATA) == CodEroare.MARCA_NESELECTATA)
            {
                lblMarca.ForeColor = Color.Red;
            }
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

       

        private void btnModificare_Click(object sender, EventArgs e)
        {

            Masina s = adminMasina.GetMasina(txtNumeVanzator.Text, txtNumeCumparator.Text, cmbMarca.Text);
            ResetareCuloareEtichete_Modificare();
            CodEroare codValidare = Validare_Modifica(txtModel.Text,txtPret.Text,cmbAnFabricatie.Text);
            if(codValidare!=CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte_Modificare(codValidare);
                MessageBox.Show("Datele nu sunt valiide");
                ResetareControale_Modificare();
            }
            else
            {
                if (s != null)
                {
                    s.Anfabricatie = Convert.ToInt32(cmbAnFabricatie.Text);
                    s.Model = txtModel.Text;
                    s.Pret = Convert.ToInt32(txtPret.Text);
                    s.Dotari = new List<string>();
                    s.Dotari.AddRange(dotariSelectate);
                    s.CuloareMasina = GetCuloareSelectata();
                    adminMasina.UpdateMasina(s);

                    var bindingThing = new BindingSource();
                    bindingThing.Add(s);
                    dataGridCauta.DataSource = bindingThing;
                    txtNumeVanzator.Enabled = true;
                    txtNumeCumparator.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Nu exista tranzactia");
                }
                ResetareControale_Modificare();
                ResetCuloareEtichete();
            }
        }
        private void ResetareControale_Modificare()
        {
            txtModel.Text = string.Empty;
            txtPret.Text = string.Empty;
            cmbAnFabricatie.Text = string.Empty;
            rdbAlb.Checked = rdbAlbastru.Checked = rdbAuriu.Checked = rdbGri.Checked = rdbNegru.Checked = rdbPortocaliu.Checked = rdbRosu.Checked = rdbVerde.Checked
                = rdbViolet.Checked = false;
            ckbAC.Checked = ckbAutomata.Checked = ckbCruiseControl.Checked = ckbGeamuriElectrice.Checked = ckbJanteAliaj.Checked = ckbManuala.Checked = ckbNavigatie.Checked
                = ckbPiele.Checked = false;
            dotariSelectate.Clear();
            
        }
        private void ResetareCuloareEtichete_Modificare()
        {
            lblModel.ForeColor = Color.Black;
            lblAnFabricatie.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            lblCuloare.ForeColor = Color.Black;
            lblDotari.ForeColor = Color.Black;

        }
        private void MarcheazaControaleCuDateIncorecte_Modificare(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.MODEL_INCORECT) == CodEroare.MODEL_INCORECT)
            {
                lblModel.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRET_INCORECT) == CodEroare.PRET_INCORECT)
            {
                lblPret.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.ANFABRICATIE_NESELECTAT) == CodEroare.ANFABRICATIE_NESELECTAT)
            {
                lblAnFabricatie.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CULOARE_NESELECTATA) == CodEroare.CULOARE_NESELECTATA)
            {
                lblCuloare.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.DOTARI_NESELCTATE) == CodEroare.DOTARI_NESELCTATE)
            {
                lblDotari.ForeColor = Color.Red;
            }

        }
        private void ckbDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; 
            

            string dotareSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                dotariSelectate.Add(dotareSelectata);
            else
                dotariSelectate.Remove(dotareSelectata);
        }
        private void txtNumeVanzator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                MessageBox.Show("Nu introduceti cifre!");
        }
        private void txtPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsDigit(e.KeyChar))
                MessageBox.Show("Nu introduceti litere");
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
        private CodEroare Validare_Modifica(string model, string pret,string anFabricatie)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (model == string.Empty) 
            {
                rezultatValidare |= CodEroare.MODEL_INCORECT;
            }
            if(pret == string.Empty)
            {
                rezultatValidare |= CodEroare.PRET_INCORECT;
            }
            if(anFabricatie == string.Empty)
            {
                rezultatValidare |= CodEroare.ANFABRICATIE_NESELECTAT;
            }
            if (!ckbAC.Checked && !ckbAutomata.Checked && !ckbCruiseControl.Checked && !ckbGeamuriElectrice.Checked && !ckbJanteAliaj.Checked && !ckbManuala.Checked &&
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
    }
}
