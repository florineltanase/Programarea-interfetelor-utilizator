using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarieC

{

    public class Masina
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ' ';

        //constanta
        public const int MAI_MARE = 1;
        public const int MAI_MIC = -1;
        public const int EGAl = 0;

        public string Numevanzator { set; get; }
        public string Numecumparator { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public string Culoare { get; set; }
        public double Pret { get; set; }
        public int Anfabricatie { get; set; }


        public Masina()
        {
            Marca = string.Empty;
            Model = string.Empty;
            Culoare = string.Empty;
            Pret = 0;
            Anfabricatie = 0;
        }

        public Masina(string _numevanzator, string _numecumparator, string _marca, string _model, string _culoare, double _pret, int _anfabricatie)
        {
            Numevanzator = _numevanzator;
            Numecumparator = _numecumparator;
            Marca = _marca;
            Model = _model;
            Culoare = _culoare;
            Pret = _pret;
            Anfabricatie = _anfabricatie;

        }
        public Masina(string Nume)
        {
            string[] buff = Nume.Split(" ");
            Numecumparator = buff[0];
            Numevanzator = buff[1];
            Marca = buff[2];
            Model = buff[3];
            Culoare = buff[4];
            Pret = Convert.ToDouble(buff[5]);
            Anfabricatie = Convert.ToInt32(buff[6]);

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
             string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}", SEPARATOR_PRINCIPAL_FISIER, (Numevanzator ?? " NECUNOSCUT "),
                 (Numecumparator ?? " NECUNOSCUT "), (Marca ?? " NECUNOSCUT "),
                 (Model ?? " NECUNOSCUT "), (Culoare ?? " NECUNOSCUT "),
                 Pret, Anfabricatie);
            

            return s;
        }


        public string ConversieLaSir()
        {
            string sDate = "Nu exista (Nu ati apelat metoda SetDate)";
            if (Numecumparator != null)
            {
                sDate = string.Join(", ", "Masina a fost vanduta de " + Numevanzator,
                    " fiind cumparata de " + Numecumparator,
                     " masina avand Marca " + Marca,
                     " Modelul fiind " + Model,
                     " Culoarea " + Culoare,
                     " avand un Pret de " + Pret + " euro ",
                     " fiind fabricata in " + Anfabricatie);
            }
            string s = string.Format(" {0} ", sDate);
            return s;


        }
    }
}
