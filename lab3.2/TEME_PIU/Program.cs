using System;

namespace TEME_PIU
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {


                string[][] mat = new string[26][];
                int[] n = new int[26];

                for (int i = 0; i < 26; i++)
                {
                    mat[i] = new string[20];
                }
                foreach (var v in args)
                {
                    if ((v[0] == 'a') || (v[0] == 'A'))
                    {

                        mat[0][n[0]] = v;
                        n[0]++;

                    }
                    if ((v[0] == 'b') || (v[0] == 'B'))
                    {

                        mat[1][n[1]] = v;
                        n[1]++;
                    }
                    if ((v[0] == 'c') || (v[0] == 'C'))
                    {

                        mat[2][n[2]] = v;
                        n[2]++;
                    }
                    if ((v[0] == 'd') || (v[0] == 'D'))
                    {

                        mat[3][n[3]] = v;
                        n[3]++;
                    }
                    if ((v[0] == 'e') || (v[0] == 'E'))
                    {

                        mat[4][n[4]] = v;
                        n[4]++;
                    }
                    if ((v[0] == 'f') || (v[0] == 'F'))
                    {

                        mat[5][n[5]] = v;
                        n[5]++;
                    }
                    if ((v[0] == 'g') || (v[0] == 'G'))
                    {

                        mat[6][n[6]] = v;
                        n[6]++;
                    }
                    if ((v[0] == 'h') || (v[0] == 'H'))
                    {

                        mat[7][n[7]] = v;
                        n[7]++;
                    }
                    if ((v[0] == 'i') || (v[0] == 'I'))
                    {

                        mat[8][n[8]] = v;
                        n[8]++;
                    }
                    if ((v[0] == 'j') || (v[0] == 'J'))
                    {

                        mat[9][n[9]] = v;
                        n[9]++;
                    }
                    if ((v[0] == 'k') || (v[0] == 'K'))
                    {

                        mat[11][n[11]] = v;
                        n[11]++;
                    }
                    if ((v[0] == 'l') || (v[0] == 'L'))
                    {

                        mat[12][n[12]] = v;
                        n[12]++;
                    }
                    if ((v[0] == 'm') || (v[0] == 'M'))
                    {

                        mat[13][n[13]] = v;
                        n[13]++;
                    }
                    if ((v[0] == 'n') || (v[0] == 'N'))
                    {

                        mat[14][n[14]] = v;
                        n[14]++;
                    }
                    if ((v[0] == 'o') || (v[0] == 'O'))
                    {

                        mat[15][n[15]] = v;
                        n[15]++;
                    }
                    if ((v[0] == 'p') || (v[0] == 'P'))
                    {

                        mat[16][n[16]] = v;
                        n[16]++;
                    }
                    if ((v[0] == 'q') || (v[0] == 'Q'))
                    {

                        mat[17][n[17]] = v;
                        n[17]++;
                    }
                    if ((v[0] == 'r') || (v[0] == 'R'))
                    {

                        mat[18][n[18]] = v;
                        n[18]++;
                    }
                    if ((v[0] == 's') || (v[0] == 'S'))
                    {

                        mat[19][n[19]] = v;
                        n[19]++;
                    }
                    if ((v[0] == 't') || (v[0] == 'T'))
                    {

                        mat[20][n[20]] = v;
                        n[20]++;
                    }
                    if ((v[0] == 'u') || (v[0] == 'U'))
                    {

                        mat[21][n[21]] = v;
                        n[21]++;
                    }
                    if ((v[0] == 'v') || (v[0] == 'V'))
                    {

                        mat[22][n[22]] = v;
                        n[22]++;
                    }
                    if ((v[0] == 'w') || (v[0] == 'W'))
                    {

                        mat[23][n[23]] = v;
                        n[23]++;
                    }
                    if ((v[0] == 'x') || (v[0] == 'X'))
                    {

                        mat[24][n[24]] = v;
                        n[24]++;
                    }
                    if ((v[0] == 'y') || (v[0] == 'Y'))
                    {

                        mat[25][n[25]] = v;
                        n[25]++;
                    }
                    if ((v[0] == 'z') || (v[0] == 'Z'))
                    {

                        mat[26][n[26]] = v;
                        n[26]++;
                    }

                }

                    Console.WriteLine("Cuvintele sunt : \n");
                    for (int i = 0; i < 26; i++)
                    {
                        for (int j = 0; j < n[i]; j++)
                        {
                            Console.Write("{0} ", mat[i][j]);
                        }
                        if (n[i] != 0)
                        {
                            Console.WriteLine();
                        }

                    }
                
                Console.ReadKey();
            }
        }
    }
}

