using System;
using System.Collections.Generic;
using System.Text;

namespace Librarie
{
    
    public class Masina
    {
        //constanta
        public const int MAI_MARE = 1;
        public const int MAI_MIC = -1;
        public const int EGAl = 0;

        public string numeVanzator { set; get; }
        public string numeCumparator { get; set; }
        public string marca { get; set; }
        public string model { get; set; }
        public string culoare { get; set; }
        public double pret { get; set; }
        public int anFabricatie { get; set; }


        public Masina()
        {
            marca = string.Empty;
            model = string.Empty;
            culoare = string.Empty;
            pret = 0;
            anFabricatie = 0;
        }

        public Masina(string _numeVanzator, string _numeCumparator, string _marca, string _model, string _culoare, double _pret, int _anFabricatie)
        {
            numeCumparator = _numeCumparator;
            numeVanzator = _numeVanzator;
            marca = _marca;
            model = _model;
            culoare = _culoare;
            pret = _pret;
            anFabricatie = _anFabricatie;

        }
        public Masina(string Nume)
        {
            string[] buff = Nume.Split(",");
            numeCumparator = buff[0];
            numeVanzator = buff[1];
            marca = buff[2];
            model = buff[3];
            culoare = buff[4];
            pret = Convert.ToInt32(buff[5]);
            anFabricatie = Convert.ToInt32(buff[6]);

        }

        public int Compare(Masina m)
        {
            return this.anFabricatie.CompareTo(m.anFabricatie);
        }

        public string ConversieLaSir()
        {
            string sDate = "Nu exista (Nu ati apelat metoda SetDate)";
            if (numeCumparator != null)
            {
                sDate = string.Join(", ", "Masina a fost vanduta de " + numeVanzator, 
                    " fiind cumparata de " +numeCumparator,
                     " masina avand marca " +marca,
                     " modelul fiind " +model,
                     " culoarea " +culoare,
                     " avand un pret de " +pret + " euro ",
                     " fiind fabricata in " +anFabricatie);
            }
            string s = string.Format(" {0} ", sDate);
            return s;
        }

    }
}
