using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            bool ok = true;
            string opt;
            while (ok)
            {
                Console.Clear();
                Console.WriteLine("MENIU\n");
                Console.WriteLine("S.Citeste note de la tastatura ca un sir de caractere\n");
                Console.WriteLine("T.Citeste note de la tastatura (cate o nota pe rand)\n");
                Console.WriteLine("C.Citeste note din linia de comanda\n");
                Console.WriteLine("A.Afisare note\n");
                Console.WriteLine("I.Info autor\n");
                Console.WriteLine("X.Iesire\n");
                Console.Write("\r\nAlegeti o optiune: ");

                opt = Console.ReadLine();
                opt = opt.ToUpper();
                switch (opt)
                {
                    case "S":
                        Console.WriteLine("Introduceti notele separate prin <,>");
                        s.SetNote(Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case "T":
                        int an;
                        Console.WriteLine("Dati numarul de ani inregistrati cu note");
                        an = Int32.Parse(Console.ReadLine());
                        int[][] notes = new int[4][];
                        for (int i = 0; i < 4; i++)
                        {
                            notes[i] = new int[15];
                        }
                        for (int i = 0; i < an; i++)
                        {
                            Console.WriteLine("Dati numarul de note din anul {0}", i);
                            int note1 = Int32.Parse(Console.ReadLine());
                            for (int j = 0; j < note1; j++)
                            {
                                Console.WriteLine("Introduceti nota nr{0}", j);
                                int x = Convert.ToInt32(Console.ReadLine());
                                notes[i][j] = x;
                            }
                        }
                        s.note = notes;
                        Console.ReadKey();
                        break;
                    case "C":
                        s.SetNote(String.Join(" ", args));

                        Console.ReadKey();
                        break;
                    case "A":
                        Console.WriteLine(s.ConversieLaSir());
                        Console.ReadKey();
                        break;
                    case "I":
                        Console.WriteLine("Florinel Alexandru Tanase\nGrupa 3123a\n");

                        Console.ReadKey();
                        break;

                    case "X":
                        ok = false;
                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}