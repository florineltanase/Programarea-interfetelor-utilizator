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

namespace Form_Masini
{
    public partial class Form1 : Form
    {
        IStocareData adminMasina;
        List<string> dotariSelectate = new List<string>();
        public Form1()
        {
            InitializeComponent();
            adminMasina = StocareFactory.GetAdministratorStocare();
            this.Width = 825;

        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();

            CodEroare codValidare = Validare(txtNumeVanzator.Text, txtNumeCumparator.Text,txtModel.Text, txtPret.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Masina s = new Masina(txtNumeVanzator.Text, txtNumeCumparator.Text,txtModel.Text,Convert.ToDouble(txtPret.Text));
                s.Marca = cmbMarca.Text;
                s.CuloareMasina = GetCuloareSelectata();
                s.Dotari = new List<string>();
                s.Dotari.AddRange(dotariSelectate);
                s.Anfabricatie = Int32.Parse(cmbAnFabricatie.Text);
                s.DataActualizare = DateTime.Now;
                s.DataTranzactie = dtpTranzactie.Value;
                adminMasina.AddMasina(s);
                ResetareControale();
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

        private CodEroare Validare(string numeVanzator, string numeCumparator,string model, string pret)
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
            if(model  == string.Empty)
            {
                rezultatValidare |= CodEroare.MODEL_INCORECT;
            }
            if (pret == string.Empty)
            {
                rezultatValidare |= CodEroare.PRET_INCORECT;
            }
            // verificare ca este cel putin o culoare selectata
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
                lblMarca.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CULOARE_NESELECTATA) == CodEroare.CULOARE_NESELECTATA)
            {
                lblCuloare.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.DOTARI_NESELCTATE) == CodEroare.DOTARI_NESELCTATE)
            {
                lblDotari.ForeColor = Color.Red;
                lblAnFabricatie.ForeColor = Color.Red;
            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {

            this.Width = 1330;
            List<Masina> masini = adminMasina.GetMasina();

            

            AdaugaMasiniInControlListbox(masini);
            AdaugaMasiniInControlDataGridView(masini);
        }
        private void AdaugaMasiniInControlListbox(List<Masina> masini)
        {
            lstAfisare.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,-25}{2,20}{3,10}\n", "Nume Vanzator", "Nume Cumparator", "Culoare", "An Fabricatie");
            lstAfisare.Items.Add(antetTabel);

            List<Masina> Masini = adminMasina.GetMasina();
            foreach (Masina s in Masini)
            {
                var linieTabel = String.Format("{0,-5}{1,-25}{2,20}{3,10}\n", s.Numevanzator, s.Numecumparator, s.CuloareMasina.ToString(), s.Anfabricatie.ToString());
                lstAfisare.Items.Add(linieTabel);
            }
        }
        private void AdaugaMasiniInControlDataGridView(List<Masina> studenti)
        {
            
            dataGridStudenti.DataSource = null;
            dataGridStudenti.DataSource = studenti.Select(s => new { s.Numevanzator, s.Numecumparator, s.Marca, s.Model, s.CuloareMasina, s.Pret, s.Anfabricatie, Dotari = string.Join(",", s.DotariAsString),s.DataTranzactie,s.DataActualizare }).ToList();
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
            txtNumeVanzator.Text = txtNumeCumparator.Text =txtModel.Text= txtPret.Text = string.Empty;
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
        private void ckbDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string disciplinaSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                dotariSelectate.Add(disciplinaSelectata);
            else
                dotariSelectate.Remove(disciplinaSelectata);
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();

            CodEroare codValidare = Validare(txtNumeVanzator.Text, txtNumeCumparator.Text, txtModel.Text, txtPret.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Masina s = new Masina(txtNumeVanzator.Text, txtNumeCumparator.Text, txtModel.Text, Convert.ToDouble(txtPret.Text));
                s.Marca = cmbMarca.Text;
                s.CuloareMasina = GetCuloareSelectata();
                s.Dotari = new List<string>();
                s.Dotari.AddRange(dotariSelectate);
                s.Anfabricatie = Int32.Parse(cmbAnFabricatie.Text);

                adminMasina.UpdateMasina(s);
                lblMesaj.Text = "Studentul a fost actualizat";

                //resetarea controalelor pentru a introduce datele unui student nou
                ResetareControale();
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            Masina s = adminMasina.GetMasina(txtNumeVanzator.Text, txtNumeCumparator.Text);
            if (s != null)
            {
                lblMesaj.Text = s.ConversieLaSir();
                foreach (var dotari in gpbDotari.Controls)
                {
                    if (dotari is CheckBox)
                    {
                        var disciplinaBox = dotari as CheckBox;
                        foreach (String dis in s.Dotari)
                            if (disciplinaBox.Text.Equals(dis))
                                disciplinaBox.Checked = true;
                    }
                }
            }
            else
                lblMesaj.Text = "Nu s-a gasit tranzactia";
            if (txtNumeVanzator.Enabled == true && txtNumeCumparator.Enabled == true)
            {
                txtNumeVanzator.Enabled = false;
                txtNumeVanzator.Enabled = false;
                //dezactivare butoane radio
                foreach (var button in gpbCulori.Controls)
                {
                    if (button is RadioButton)
                    {
                        var radioButton = button as RadioButton;
                        radioButton.Enabled = false;
                    }
                }
            }
            else
            {
                txtNumeVanzator.Enabled = true;
                txtNumeCumparator.Enabled = true;
                //activare butoane radio
                foreach (var button in gpbCulori.Controls)
                {
                    if (button is RadioButton)
                    {
                        var radioButton = button as RadioButton;
                        radioButton.Enabled = true;
                    }
                }
            }
        }


    }
}
