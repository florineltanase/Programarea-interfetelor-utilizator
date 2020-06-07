//Florinel Alexandru Tanase,3123a
using Librarie;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMasina(Masina s);
        List<Masina> GetMasina();
       

        Masina GetMasina(string nume, string prenume,string marca);

        bool UpdateMasina(Masina s);

        List<Masina> GetAnFabricatie();



    }
}
