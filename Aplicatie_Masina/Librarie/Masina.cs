using System;
using System.Collections.Generic;
using System.Text;

namespace Librarie

{

    public class Masina
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ' ';
        private const char SEPARATOR_SECUNDAR_FISIER = ';';

        //constanta
        public const int MAI_MARE = 1;
        public const int MAI_MIC = -1;
        public const int EGAl = 0;

       
        Grup dotari;



        public int IdMasina { get; set; }
        public string Numevanzator { set; get; }
        public string Numecumparator { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        // public string Culoare { get; set; }
        public Grup CuloareMasina
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
        public double Pret { get; set; }
        public int Anfabricatie { get; set; }

        public List<string> Dotari { get; set; }

       
        public string DotariAsString
        {
            get
            {
                string sDotari = string.Empty;

                foreach (string dotari in Dotari)
                {
                    if (sDotari != string.Empty)
                    {
                        sDotari += SEPARATOR_SECUNDAR_FISIER;
                    }
                    sDotari += dotari;
                }

                return sDotari;
            }
        }
        public DateTime DataTranzactie { get; set; }
        public DateTime DataActualizare { get; set; }

        public Masina()
        {
            Numevanzator = Numecumparator = Model=string.Empty;
            Pret = 0;
        }
        public Masina(string _numeVanzator, string _numeCumparator,string _model, double pret)
        {
            Numevanzator = _numeVanzator;
            Numecumparator = _numeCumparator;
            Model = _model;
            Pret = pret;

        }
/*
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
        */

       /* public Masina(string date_initializare)
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
        */

        public Masina(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            Numevanzator = dateFisier[(int)CampuriMasina.NUMEV];
            Numecumparator = dateFisier[(int)CampuriMasina.NUMEC];
            Model = dateFisier[(int)CampuriMasina.MODEL];
            Pret = Convert.ToInt32(dateFisier[(int)CampuriMasina.PRET]);
            Marca = dateFisier[(int)CampuriMasina.MARCA];
            CuloareMasina = (Grup)Enum.Parse(typeof(Grup), dateFisier[(int)CampuriMasina.CULOARE]);
            Anfabricatie = Int32.Parse(dateFisier[(int)CampuriMasina.ANF]);
            Dotari = new List<string>();
            Dotari.AddRange(dateFisier[(int)CampuriMasina.DOT].Split(SEPARATOR_SECUNDAR_FISIER));
            DataTranzactie = Convert.ToDateTime(dateFisier[(int)CampuriMasina.DATA_TRANZACTIE]);
            DataActualizare = Convert.ToDateTime(dateFisier[(int)CampuriMasina.DATA_ACTUALIZARE]);


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
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}", SEPARATOR_PRINCIPAL_FISIER, (Numevanzator ?? " NECUNOSCUT "),
                Numecumparator, Model ,
                Pret ,Marca, CuloareMasina,
                Anfabricatie, DotariAsString,DataTranzactie,DataActualizare);


            return s;
        }


        public string ConversieLaSir()
        {
            string sDate = "Nu exista (Nu ati apelat metoda SetDate)";
            if (Numecumparator != null)
            {
                sDate = string.Join(", ", "Masina a fost vanduta de " + Numevanzator,
                    " fiind cumparata de  " + Numecumparator,
                      " \navand marca "+Marca, " modelul fiind " + Model, " avand Culoarea " +CuloareMasina," fiind fabricata in "+Anfabricatie,
                      " \navand urmatoarele dotari " +DotariAsString);
            }
            string s = string.Format(" {0} ", sDate);
            return s;


        }
    }
}