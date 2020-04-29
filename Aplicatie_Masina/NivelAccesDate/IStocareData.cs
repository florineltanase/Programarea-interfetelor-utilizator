using System;
using System.Collections.Generic;
using System.Text;
using Librarie;


namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMasina(Masina x);
        Masina[] GetMasina(out int nrMasini);
        bool UpdateMasina(Masina[] masini, int nrMasini);
    }
}