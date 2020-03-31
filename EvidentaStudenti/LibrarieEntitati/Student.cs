using System;
namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        public string nume { set; get; }
        public int[][] note { set; get; }

        // contructor implicit
        public Student()
        {
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
            note = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                note[i] = new int[15];
            }


        }
        public void SetNote(int[][] notes, int[][] notess)
        {
            notes = notess;

        }

        public void SetNote(string sirNote)
        {
            note = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                note[i] = new int[15];
            }

            if (!sirNote.Equals(""))
            {
                string[] buff1 = sirNote.Split(',');
                // diml = buff1.Length;
                for (int i = 0; i < buff1.Length; i++)
                {
                    string[] buff2 = buff1[i].Split(' ');

                    for (int j = 0; j < buff2.Length; j++)
                    {
                        int number;
                        bool succes = Int32.TryParse(buff2[j], out number);
                        if (succes)
                        {
                            note[i][j] = number;
                        }

                    }
                }
            }

        }

        public string ConversieLaSir()
        {
            string sNote = "Nu exista (Nu ati apelat metoda **setNote**)";
            if (note == null)
            {
                return sNote;
            }
            else
            {
                sNote = String.Empty;
                for (int i = 0; i < 4; i++)
                {

                    sNote = String.Concat(sNote, "\nNotele pentru anul nr.", string.Format("{0} sunt:\n", i + 1));

                    for (int j = 0; j < 10; j++)
                    {

                        if (note[i][j] != 0)
                        {
                            sNote = String.Concat(sNote, string.Format("nota este: {0} \n", note[i][j]));
                        }

                    }
                }



            }
            return sNote;
        }

    }
}
