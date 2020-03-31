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
                Console.WriteLine("7.Compararea a doi ani de fabricatie\n");
                Console.WriteLine("8.Iesire meniu\n");
                Console.Write("\r\nAlegeti o optiune: ");
                opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "1":
                        {
                            m1= CitireTastatura();
                            Console.ReadKey();
                            break;

                        }
                    case "2":
                        {
                            Console.WriteLine("Selectati datele pe care doriti sa le modificati");
                            Console.WriteLine("1.Numele Vanzatorului\n");
                            Console.WriteLine("2.Numele cumparatorului\n");
                            Console.WriteLine("3.Marca masinii\n");
                            Console.WriteLine("4.Modelul masinii\n");
                            Console.WriteLine("5.Culoarea masinii\n");
                            Console.WriteLine("6.Pretul masinii\n");
                            Console.WriteLine("7.Anul fabricatiei\n");
                            Console.WriteLine("8.Iesire meniu\n");
                            Console.WriteLine("Alege o optiune\n");
                            string opt1 = Console.ReadLine();
                            if(opt1 == "1" )
                            {
                                Console.WriteLine("Dati numele vanzatorului\n");
                                m1.numeVanzator= Console.ReadLine();
                                Console.ReadKey();
                                break;
                            }

                            if(opt1 == "2")
                            {
                                Console.WriteLine("Dati numele cumparatorului");
                                m1.numeCumparator = Console.ReadLine();
                                Console.ReadKey();
                                break;
                            }

                            if(opt1 == "3")
                            {
                                Console.WriteLine("Dati marca masinii");
                                m1.marca = Console.ReadLine();
                                Console.ReadKey();
                                break;
                            }

                            if(opt1 == "4")
                            {
                                Console.WriteLine("Dati modelul masinii");
                                m1.model = Console.ReadLine();
                                Console.ReadKey();
                                break;

                            }

                            if(opt1 == "5")
                            {
                                Console.WriteLine("Dati culoarea masinii");
                                m1.culoare = Console.ReadLine();
                                Console.ReadKey();
                                break;
                            }

                            if (opt1 == "6")
                            {
                                Console.WriteLine("Dati pretul masinii");
                                m1.pret = Convert.ToDouble(Console.ReadLine());
                                Console.ReadKey();
                                break;
                            }

                            if (opt1 == "7")
                            {
                                Console.WriteLine("Dati anul fabricatiei");
                                m1.anFabricatie=Convert.ToInt32(Console.ReadLine());
                                Console.ReadKey();
                                break;

                            }
                            Console.ReadKey();
                            break;
                            
                        }
                    case "6":
                        {
                            Console.WriteLine(m1.ConversieLaSir());
                            Console.ReadKey();
                            break;
                        }

                    case "7":
                        {
                            Masina m2 = new Masina("Andrei,Ionel,bmw,x5,negru,15000,2016");
                            Masina m3 = new Masina("Dorel,Viorel,audi,a6,verde,14500,2015");

                            if (m2.Compare(m3) == Masina.MAI_MARE)
                            {
                                Console.WriteLine(m2.marca + " este mai noua decat " + m3.marca);
                            }
                            else if (m2.Compare(m3) == Masina.MAI_MIC)
                            {
                                Console.WriteLine(m2.marca + " este mai veche decat " + m3.marca);
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

