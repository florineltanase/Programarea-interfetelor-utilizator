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
        double pret;
        int anFabricatie;

        public Masina(string v)
        {
            marca = string.Empty;
            model = string.Empty;
            culoare = string.Empty;
            pret = 0;
            anFabricatie = 0;
        }

        public Masina(string _marca, string _model, string _culoare, double _pret, int _anFabricatie)
        {
            marca = _marca;
            model = _model;
            culoare = _culoare;
            pret = _pret;
            anFabricatie = _anFabricatie;

        }

        public void Afisare()
        {
            Console.WriteLine("Masina este {0}, modelul fiind {1}, are culoarea {2}, pretul de {3} euro , " +
                "fiind fabricata in {4}", marca, model, culoare, pret, anFabricatie);
        }

    }
}
