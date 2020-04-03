using System;
using System.Collections.Generic;
using System.Text;
using LibrarieC;

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
    }
}