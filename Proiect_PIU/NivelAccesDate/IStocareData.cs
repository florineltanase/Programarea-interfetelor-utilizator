using System;
using System.Collections.Generic;
using System.Text;
using LibrarieC;


namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMasina(Masina x);
        Masina[] GetMasina(out int nrMasini);
    }
}