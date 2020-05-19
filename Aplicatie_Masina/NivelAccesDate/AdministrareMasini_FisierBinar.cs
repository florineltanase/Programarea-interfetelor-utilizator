using System;
using System.Collections.Generic;
using System.Text;
using Librarie;

namespace NivelAccesDate
{

    public class AdministrareMasini_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareMasini_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddMasina(Masina s)
        {
            throw new Exception("Optiunea AddMasina nu este implementata");
        }

        public Masina[] GetMasina(out int nrStudenti)
        {
            throw new Exception("Optiunea GetMasina nu este implementata");
        }

        public bool UpdateMasina(Masina[] masini, int nrMasini)
        {
            throw new Exception("Optiunea GetMasina nu este implementata");
        }

        public List<Masina> GetMasina()
        {
            throw new NotImplementedException();
        }

        public Masina GetMasinaByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public Masina GetMasina(string nume, string prenume)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMasina(Masina s)
        {
            throw new NotImplementedException();
        }
    }
}