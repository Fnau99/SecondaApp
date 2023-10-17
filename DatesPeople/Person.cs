using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

//Classe persona
namespace DatesPeople 
{
    internal class Person
    {
        /*Definiscono le proprietà della persona
         * FirstName
         * SecondName
         * Gender
         * Birthcity
         * Birthdate
        */
        #region Attribute
        public string FirstName;
        public string SecondName;
        public String Gender;
        public string Birthcity;
        public DateTime Birthdate;
        #endregion


        //Definisco il costruttore (con e senza parametri).
       public Person()
       {
            this.FirstName = "Nawfal";
            this.SecondName = "Fikri";
            this.Gender = "M";
            this.Birthcity = "Casalgrande";
            this.Birthdate = new DateTime(1999, 12, 10);
       }

       public Person(string FirstName, string SecondName, string Gender, string BirthCity, DateTime Birthdate)
       {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Gender = Gender;
            this.Birthcity = BirthCity;
            this.Birthdate = Birthdate;
       }

       //Metodo che mostra a schermo l'età
       private int Age()
       {
            return DateTime.Now.Year - Birthdate.Year; //DateTime effettua in automatico la conversione in intero.
       }
       public void ShowAge()
       {
            Console.WriteLine(this.Age());
       }

        private string FiscalCode()
        {
            CodiceFiscaleUtility.CodiceFiscale CF;
            CF = new CodiceFiscaleUtility.CodiceFiscale(this.SecondName, this.FirstName, this.Gender, this.Birthdate, this.Birthcity, "reggio emilia");

            return CF.Codice;
        }

        public void ShowFiscalCode() 
        {
            Console.WriteLine(this.FiscalCode());
        }


    }
}
