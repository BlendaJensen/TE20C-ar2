using System;

namespace Ny_mapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string ålder = Console.ReadLine();

            Console.WriteLine($"Du är {ålder} gammal");
            int ålderTal = int.Parse(ålder);

            Console.WriteLine($"Du har {20 -ålderTal} år kvar tills du får gå på systemet"); 

            System.Console.WriteLine("Hur mycket väger du?");
            float vikt = float.Parse(Console.ReadLine());

            Console.WriteLine($"Din vikt blir {vikt * 2.2} Lbs");
            
            float viktLbs = vikt * 2.2f;

            //Formatera till snygg utskrift
            string viktString = viktLbs.ToString("0.##");
            System.Console.WriteLine($"Din vikt är {viktString} Lbs");
        }
    }
}
