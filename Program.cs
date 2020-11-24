using System;

namespace _19_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abfangen einer NullReferenceException Exception.
            Cup teeCup = new Cup();
            Cup espressoCup = new Cup();
            espressoCup.Color = "pink";
            Cup cafeCup = null;
            teeCup.Color = "blue";

            try
            {
                cafeCup.Color = "red";
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Die Tasse existiert nicht");
            }
           // Console.WriteLine(cafeCup.Color + " und " + teeCup.Color);


            // Mit Exception Klasse
            try
            {
                teeCup.AddCup(teeCup); 
                teeCup.AddCup(espressoCup); // nur die vorherige Seite wird geprüft
            }
            catch (SameCupException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WhiteColorException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // IndexOutOfRangeExceptioin

            var color = new string[] { "blau", "rot", "grün" };
            try
            {
                string myFavoriteColor = color[3];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Diese Farbe gibt nicht");
            }


            // Formatexception
            try
            {
                Console.WriteLine("Geben Sie die Zahl ein");
                string antwort = Console.ReadLine();
                int res = int.Parse(antwort);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Es muss eine Ziffer sein");
            }

            Owner me = new Owner();



        }
    }
}
