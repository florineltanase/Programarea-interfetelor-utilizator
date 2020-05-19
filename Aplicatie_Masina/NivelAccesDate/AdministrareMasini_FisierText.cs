using System;
using System.Collections.Generic;
using System.Text;
using Librarie;
using System.IO;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierText implementeaza interfata IStocareData
    public class AdministrareMasini_FisierText : IStocareData
    {
        private const int ID_PRIMA_MASINA = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }
        public AdministrareMasini_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddMasina(Masina masina)
        {
            
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {

                    swFisierText.WriteLine(masina.ConversieLaSir_Fisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<Masina> GetMasina()
        {
            List<Masina> masini = new List<Masina>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Masina s = new Masina(line);
                        masini.Add(s);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return masini;
        }

        public Masina GetMasina(string nume, string prenume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Masina masina = new Masina(line);
                        if (masina.Numevanzator.Equals(nume) && masina.Numecumparator.Equals(prenume))
                            return masina;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

       

        public bool UpdateMasina(Masina studentActualizat)
        {
            List<Masina> masini = GetMasina();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Masina stud in masini)
                    {
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (stud.IdMasina != studentActualizat.IdMasina)
                        {
                            swFisierText.WriteLine(stud.ConversieLaSir_Fisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(studentActualizat.ConversieLaSir_Fisier());
                        }
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }

        
 
    }
}
