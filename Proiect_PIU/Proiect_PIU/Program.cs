using System;
using LibrarieC;
using NivelAccesDate;
using Proiect_PIU;

namespace Program_PIU
{

    class Program
    {
        static void Main(string[] args)
        {

            IStocareData adminMasina = StocareFactory.GetAdministratorStocare();
            //Masina m1 = new Masina();
            Masina[] masini;
            int nrMasini;
            masini = adminMasina.GetMasina(out nrMasini);
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
                Console.WriteLine("7.Compararea a doi ani de fabricatie\n");
                Console.WriteLine("8.Iesire meniu\n");
                Console.Write("\r\nAlegeti o optiune: ");
                opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "1":
                       {
                            Console.Clear();
                            Masina m = CitireTastatura();
                            masini[nrMasini] = m;
                            nrMasini++;
                            adminMasina.AddMasina(m);
                            Console.ReadKey();
                            break;
                       }

                    
                    case "2":
                      {
                            Console.WriteLine("Dati numele vanzatorului: ");
                            string nume_vanzator_temporar = Console.ReadLine();
                            Console.WriteLine("Dati numele cumparatorului");
                            string nume_cumparator_temporar = Console.ReadLine();
                            Console.WriteLine("Dati Marca masinii");
                            string marca = Console.ReadLine();
                            Masina m = CautMasina(nume_vanzator_temporar, nume_cumparator_temporar, marca, nrMasini, masini);
                            if(m!=null)
                            {
                                Console.WriteLine("Dati Modelul masinii");
                                m.Model = Console.ReadLine();
                                Console.WriteLine("Dati Culoarea masinii");
                                m.Culoare = Console.ReadLine();
                                Console.WriteLine("Dati pretul masinii");
                                m.Pret = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Dati anul Fabricatiei masinii");
                                m.Anfabricatie = Convert.ToInt32(Console.ReadLine());
                            }

                          Console.ReadKey();
                          break;
                      }

                    case "6":
                        {
                            Console.WriteLine("Masinile sunt: ");
                            for(int i=0; i< nrMasini; i++)
                            {
                                Console.WriteLine(masini[i].ConversieLaSir_Fisier() + "\n ");
                            }
                            Console.ReadKey();
                            break;
                        }

                    case "7":
                        {
                            Masina m2 = new Masina("Andrei,Ionel,bmw,x5,negru,15000,2016");
                            Masina m3 = new Masina("Dorel,Viorel,audi,a6,verde,14500,2015");

                            if (m2.Compare(m3) == Masina.MAI_MARE)
                            {
                                Console.WriteLine(m2.Marca + " este mai noua decat " + m3.Marca);
                            }
                            else if (m2.Compare(m3) == Masina.MAI_MIC)
                            {
                                Console.WriteLine(m2.Marca + " este mai veche decat " + m3.Marca);
                            }
                            else
                            {
                                Console.WriteLine("Masinile au fost fabricate in acelasi an ");
                            }
                            Console.ReadKey();
                            break;

                        }

                    case "8":
                        {
                            ok = false;
                            break;
                        }
                }

            }
            Console.ReadKey();
        }

        public static Masina CautMasina(string numevanzator,string numecumparator,string marca,int nrMasini, Masina[] sir_Masina)
        {
            for(int i=0; i< nrMasini; i++)
            {
                if ((string.Equals(numevanzator, sir_Masina[i].Numevanzator)) && (string.Equals(numecumparator, sir_Masina[i].Numecumparator))&& (string.Equals(marca,sir_Masina[i].Marca)))
                    return sir_Masina[i];
            }
            return null;
        }
  
        public static Masina CitireTastatura()
        {


            Console.WriteLine("Dati numele vanzatorului");
            string numeVanzator = Console.ReadLine();

            Console.WriteLine("Dati numele cumparatorului");
            string numeCumparator = Console.ReadLine();

            Console.WriteLine("Dati marca masinii");
            string marca = Console.ReadLine();

            Console.WriteLine("Dati modelul masinii");
            string model = Console.ReadLine();

            Console.WriteLine("Dati culoarea masinii");
            string culoare = Console.ReadLine();

            Console.WriteLine("Dati Pretul masinii");
            double pret = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dati anul fabricatiei masinii");
            int anFabricatie = Convert.ToInt32(Console.ReadLine());

            Masina m1 = new Masina(numeVanzator, numeCumparator, marca, model, culoare, pret, anFabricatie);
            return m1;
        }
    }
}

