using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_Piu
{
    
    public class Masina
    {

        string marca;
        string model;
        string culoare;
        string numeCumparator;
        string numeVanzator;
        double pret;
        int anFabricatie;

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

        public string NumeVanzator { set; get ; }
        public string NumeCumparator { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public string Culoare { get; set; }
        public double Pret { get; set; }
        public int AnFabricatie { get; set;  }

       



        
        public string GetNumeCumparator()
        {
            return numeCumparator;
        }
        public string GetNumeVanzator()
        {
              return numeVanzator;
        }

        public string GetMarca()
        {
            return marca;
        }

        public string GetModel()
        {
            return model;

        }

        public string GetCuloare()
        {
            return culoare;
        }

        public double GetPret()
        {
            return pret;
        }

        public int GetAnFabricatie()
        {
            return anFabricatie;
        }

        public void SetNumeCumparator(string _numeCumparator)
        {
            numeCumparator = _numeCumparator;
        }  

        public void SetNumeVanzator(string _numeVanzator)
        {
            numeVanzator = _numeVanzator;

        }

        public void SetNumeMarca(string _marca)
        {
            marca = _marca;
        }

        public void SetNumeModel(string _model)
        {
            model = _model;
        }

        public void SetCuloare(string _culoare)
        {
            culoare = _culoare;
        }

        public void SetPret(double _pret)
        {
            pret = _pret;
        }

        public void SetAnFabricatie(int _anFabricatie)
        {
            anFabricatie = _anFabricatie;
        }

        public  Masina CitireTastatura()
        {
            Masina m1 = new Masina();

            Console.WriteLine("Dati numele vanzatorului");
            m1.numeVanzator = Console.ReadLine();

            Console.WriteLine("Dati numele cumparatorului");
            m1.numeCumparator = Console.ReadLine();

            Console.WriteLine("Dati marca masinii");
            m1.marca = Console.ReadLine();

            Console.WriteLine("Dati modelul masinii");
            m1.model = Console.ReadLine();

            Console.WriteLine("Dati culoarea masinii");
            m1.culoare = Console.ReadLine();

            Console.WriteLine("Dati Pretul masinii");
            m1.pret = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dati anul fabricatiei masinii");
            m1.anFabricatie = Convert.ToInt32(Console.ReadLine());
            return m1;


        }

        public void Afisare()
        {
            Console.WriteLine("Masina a fost vanduta de {0}" +
                " " +
                "fiind cumparata de {1}," +
                " " +
                "masina avand marca {2}" +
                " " +
                "modelul fiind {3}" +
                " " + 
                "culoare {4}" +
                " " +
                "avand un pret de {5}" +
                " " +
                "fiind fabricata in {6}", numeVanzator,numeCumparator, marca, model, culoare, pret, anFabricatie);
        }

        public string ConversieLaSir()
        {
            string sDate = "Nu exista (Nu ati apelat metoda SetDate)";
            if (numeCumparator != null)
            {
                sDate = string.Join(", ", numeVanzator, numeCumparator, marca, model, culoare, pret, anFabricatie);
            }
            string s = string.Format(" {0} ", sDate);
            return s;
        }

    }
}
