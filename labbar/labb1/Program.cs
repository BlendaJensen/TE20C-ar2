using System;

namespace labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

        // Berättar om programmet
        Console.WriteLine("Program för Ceasar-kryptering");

        // Användarens ord
        Console.Write("Ange ett ord: ");
        string ord = Console.ReadLine();

        Console.Write("Ange en nyckel (1-9): ");
        int nyckel = int.Parse(Console.ReadLine());

        //Samlar in de krypterade bokstäverna
        string meddelandeKrypterad = "";

        //Loopar igenom varje bokstav
        for (int i = 0; i < ord.Length; i++)
        {
            
            //Plocka ut bokstäver
            char bokstav = ord[i];

            //ta fram ASCII kod
            int kod = (int)bokstav;

            // Lägg till nyckeln
            kod += nyckel;

            // Tecken av ASCII-kod
            char bokstavKrypterad = (char)(kod);
            
            //Fyller i meddelande krypterad med bokstäverna
            meddelandeKrypterad += bokstavKrypterad.ToString();
         
            
        }

        Console.WriteLine($"'{ord}' blir '{meddelandeKrypterad}'");

        }
    }
}
