using System;
using System.Collections.Generic;
using System.Text;

namespace Librarie

{

    public class Masina
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ' ';

        //constanta
        public const int MAI_MARE = 1;
        public const int MAI_MIC = -1;
        public const int EGAl = 0;

        private const int NUMEV = 0;
        private const int NUMEC = 1;
        private const int MARCA = 2;
        private const int MODEL = 3;
        private const int CULOARE = 4;
        private const int PRET = 5;
        private const int ANF = 6;
        private const int DOT = 7;
        Grup dotari;




        public string Numevanzator { set; get; }
        public string Numecumparator { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public string Culoare { get; set; }
        public double Pret { get; set; }
        public int Anfabricatie { get; set; }

        public Grup Dotari
        {
            get
            {
                return dotari;
            }
            set
            {
                dotari = value;
            }
        }


        public Masina()
        {
            Marca = string.Empty;
            Model = string.Empty;
            Culoare = string.Empty;
            Pret = 0;
            Anfabricatie = 0;
        }

        public Masina(string _numevanzator, string _numecumparator, string _marca, string _model, string _culoare, double _pret, int _anfabricatie, Grup _grup)
        {
            Numevanzator = _numevanzator;
            Numecumparator = _numecumparator;
            Marca = _marca;
            Model = _model;
            Culoare = _culoare;
            Pret = _pret;
            Anfabricatie = _anfabricatie;
            dotari = _grup;

        }
        public Masina(string date_initializare)
        {
            //constructor cu datele de initializare intr-un singur sir , despartite prin ;
            string[] date = date_initializare.Split(SEPARATOR_PRINCIPAL_FISIER);
            Numevanzator = date[NUMEV];
            Numecumparator = date[NUMEC];
            Marca = date[MARCA];
            Model = date[MODEL];
            Culoare = date[CULOARE];
            Pret = Convert.ToDouble(date[PRET]);
            Anfabricatie = Convert.ToInt32(date[ANF]);
            Enum.TryParse(date[DOT], out dotari);


        }

        public int Compare(Masina m)
        {
            return this.Anfabricatie.CompareTo(m.Anfabricatie);
        }

        public string ConversieLaSir_Fisier()
        {
            string sMasina = string.Empty;
            if (Numevanzator != null)
            {
                sMasina = string.Join(SEPARATOR_AFISARE, Pret);
            }
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}", SEPARATOR_PRINCIPAL_FISIER, (Numevanzator ?? " NECUNOSCUT "),
                (Numecumparator ?? " NECUNOSCUT "), (Marca ?? " NECUNOSCUT "),
                (Model ?? " NECUNOSCUT "), (Culoare ?? " NECUNOSCUT "),
                Pret, Anfabricatie, Dotari);


            return s;
        }


        public string ConversieLaSir()
        {
            string sDate = "Nu exista (Nu ati apelat metoda SetDate)";
            if (Numecumparator != null)
            {
                sDate = string.Join(", ", "Masina a fost vanduta de \n" + Numevanzator,
                    " fiind cumparata de \n" + Numecumparator,
                     " masina avand marca \n" + Marca,
                     " modelul fiind \n" + Model,
                     " culoarea \n" + Culoare,
                     " avand un pret de " + Pret + " euro \n",
                     " fiind fabricata in \n" + Anfabricatie,
                     " avand dotarea " + Dotari);
            }
            string s = string.Format(" {0} ", sDate);
            return s;


        }
    }
}