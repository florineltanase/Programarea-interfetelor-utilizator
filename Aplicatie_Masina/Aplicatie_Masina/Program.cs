using System;
using Librarie;
using NivelAccesDate;


namespace Aplicatie_Masina
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
                            if (m != null)
                            {
                                bool da = true;
                                string opt1;
                                while (da)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Alegeti ce doriti sa modificati: \n");
                                    Console.WriteLine("1.Modelul masinii \n");
                                    Console.WriteLine("2.Culoarea masini \n");
                                    Console.WriteLine("3.Pretul masinii\n");
                                    Console.WriteLine("4.Anul Fabricatie\n");
                                    Console.WriteLine("5.Dotarea\n");
                                    Console.WriteLine("6.Iesire\n");
                                    opt1 = Console.ReadLine();
                                    switch (opt1.ToUpper())
                                    {
                                        case "1":
                                            Console.WriteLine("Dati Modelul masinii");
                                            m.Model = Console.ReadLine();
                                            adminMasina.UpdateMasina(masini, nrMasini);
                                            Console.ReadKey();
                                            break;

                                        case "2":
                                            Console.WriteLine("Dati Culoarea masinii");
                                            m.Culoare = Console.ReadLine();
                                            adminMasina.UpdateMasina(masini, nrMasini);
                                            Console.ReadKey();
                                            break;

                                        case "3":
                                            Console.WriteLine("Dati pretul masinii");
                                            m.Pret = Convert.ToDouble(Console.ReadLine());
                                            adminMasina.UpdateMasina(masini, nrMasini);
                                            Console.ReadKey();
                                            break;

                                        case "4":
                                            Console.WriteLine("Dati anul Fabricatiei masinii");
                                            m.Anfabricatie = Convert.ToInt32(Console.ReadLine());
                                            adminMasina.UpdateMasina(masini, nrMasini);
                                            Console.ReadKey();
                                            break;

                                        case "5":

                                            Console.WriteLine("Alegeti dotarea\n");
                                            Console.WriteLine("Alegeti optiunile: \n1.Aer_conditionat\n2.Navigatie\n3.Cutie_automata\n4.Cutie_manuala\n5.Tapiterie_Piele\n6.Jante_aliaj\n7.Geamuri_electrice\n8.Cruise_control\n.9.Fara_optiuni\n");
                                            m.CuloareMasina = (Grup)Convert.ToInt32(Console.ReadLine());
                                            adminMasina.UpdateMasina(masini, nrMasini);
                                            Console.ReadKey();
                                            break;

                                        case "6":
                                            da = false;
                                            break;

                                    }
                                }


                            }

                            Console.ReadKey();
                            break;
                        }

                    case "6":
                        {
                            Console.WriteLine("Masinile sunt: ");
                            for (int i = 0; i < nrMasini; i++)
                            {
                                Console.WriteLine(masini[i].ConversieLaSir() + "\n ");
                            }
                            Console.ReadKey();
                            break;
                        }

                    case "7":
                        {
                            Masina m2 = new Masina("Andrei Ionel bmw x5 negru 15000 2014");
                            Masina m3 = new Masina("Dorel Viorel audi a6 verde 14500 2015");

                            if (m2.Compare(m3) == Masina.MAI_MARE)
                            {
                                Console.WriteLine("Masina " + m2.Marca + " este mai noua decat " + " masina " + m3.Marca);
                            }
                            else if (m2.Compare(m3) == Masina.MAI_MIC)
                            {
                                Console.WriteLine("Masina " + m2.Marca + " este mai veche decat " + " masina " + m3.Marca);
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

        public static Masina CautMasina(string numevanzator, string numecumparator, string marca, int nrMasini, Masina[] sir_Masina)
        {
            for (int i = 0; i < nrMasini; i++)
            {
                if ((string.Equals(numevanzator, sir_Masina[i].Numevanzator)) && (string.Equals(numecumparator, sir_Masina[i].Numecumparator)) && (string.Equals(marca, sir_Masina[i].Marca)))
                    return sir_Masina[i];
            }
            return null;
        }

        public static Masina CitireTastatura()
        {
            string numeVanzator, numeCumparator, marca, model, culoare, dotari1;
            double pret;
            int anFabricatie;
            Grup dotari;

            Console.WriteLine("Dati numele vanzatorului");
            numeVanzator = Console.ReadLine();

            Console.WriteLine("Dati numele cumparatorului");
            numeCumparator = Console.ReadLine();

            Console.WriteLine("Dati marca masinii");
            marca = Console.ReadLine();

            Console.WriteLine("Dati modelul masinii");
            model = Console.ReadLine();

            Console.WriteLine("Dati culoarea masinii");
            culoare = Console.ReadLine();

            Console.WriteLine("Dati Pretul masinii");
            pret = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dati anul fabricatiei masinii");
            anFabricatie = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Alegeti optiunile: \n1.Aer_conditionat\n2.Navigatie\n3.Cutie_automata\n4.Cutie_manuala\n5.Tapiterie_Piele\n6.Jante_aliaj\n7.Geamuri_electrice\n8.Cruise_control\n.9.Fara_optiuni\n");
            dotari1 = Console.ReadLine();
            Enum.TryParse(dotari1, out dotari);

            return new Masina(numeVanzator, numeCumparator, marca, model, culoare, pret, anFabricatie, dotari);






        }
    }
}