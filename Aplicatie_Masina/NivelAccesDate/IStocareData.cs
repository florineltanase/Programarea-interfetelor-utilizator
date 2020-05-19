using Librarie;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMasina(Masina s);
        List<Masina> GetMasina();
       

        Masina GetMasina(string nume, string prenume);

        bool UpdateMasina(Masina s);

       
    }
}
