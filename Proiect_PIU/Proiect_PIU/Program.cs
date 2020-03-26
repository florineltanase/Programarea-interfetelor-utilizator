using System;

namespace Proiect_Piu
{

    class Program
    {
        static void Main(string[] args)
        {
            Masina m1 = new Masina();

            bool ok = true;
            string opt;
            while (ok)
            {
                Console.Clear();
                Console.WriteLine("MENIU\n------------------------------------------------------\n");
                Console.WriteLine("1. Introduceti datele.\n");
                Console.WriteLine("2. Editati datele adaugate\n");
                Console.WriteLine("3. Stergere date\n");
                Console.WriteLine("4. Cea mai cautata masina ca si firma sau model\n");
                Console.WriteLine("5.Grafic al pretului pentru un anumit model\n");
                Console.WriteLine("6.Afisarea tranzactiilor dintr-o anumita zi\n");
                Console.WriteLine("7.Iesire meniu\n");
                Console.Write("\r\nAlegeti o optiune: ");
                opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "1":
                        {
                           
                            Console.WriteLine("Introduceti datele(NumeCumparator,NumeVanzator,marca,model," +
                                "culoarea,pret,anFabricatie)");
                            m1 = new Masina( Console.ReadLine());
                            Console.ReadKey();
                            break;

                        }
                    case "2":
                        {
                            Console.WriteLine("Selectati datele pe care doriti sa le modificat");
                            Console.WriteLine("1.Numele Vanzatorului\n");
                            Console.WriteLine("2.Numele cumparatprului\n");
                            Console.WriteLine("3.Marca masinii\n");
                            Console.WriteLine("4.Modelul masinii\n");
                            Console.WriteLine("5.Culoarea masinii\n");
                            Console.WriteLine("6.Pretul masinii\n");
                            Console.WriteLine("7.Anul fabricatiei\n");
                            Console.WriteLine("Alege o optiune\n");
                            string opt1 = Console.ReadLine();
                            if(opt1 == "1" )
                            {
                                Console.WriteLine("Dati numele vanzatorului\n");
                                m1.SetNumeVanzator(Console.ReadLine());

                            }
                            if(opt1 == "2")
                            {

                            }
                                
                            Console.ReadKey();
                            break;
                        }
                    case "6":
                        {
                            m1.Afisare();
                            Console.ReadKey();
                            break;
                        }


                }





            }
            Console.ReadKey();
        }
    }
}
