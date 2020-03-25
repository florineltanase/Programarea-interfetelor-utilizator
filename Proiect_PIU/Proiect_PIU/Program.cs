using System;

namespace Proiect_Piu
{

    class Program
    {
        static void Main(string[] args)
        {
            Masina m1 = new Masina("VW", "Polo", "albastru perlat", 1250, 2006);
            m1.Afisare();
            Masina m2 = new Masina("BMW", "X5", "negru", 15000, 2012);
            m2.Afisare();
            Masina m3 = new Masina("Dacia", "Logan", "verde", 5000, 2015);
            m3.Afisare();


        }
    }
}
