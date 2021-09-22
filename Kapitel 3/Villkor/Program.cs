using System;

namespace Villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användare om ålder
            Console.Write("Hur gammal är du (heltal): ");
            int ålder = int.Parse(Console.ReadLine());
            
            //Om ålder större än 18 "Du får ta körkort!"
            if (ålder >= 18)
            {
                System.Console.WriteLine("Du får ta körkort!");
            }

            // Om ålder 15 eller högre "Du får ta mopedkörkort"
            if (ålder >= 15)
            {
                System.Console.WriteLine("Du får ta mopedkörkort");
            }
            // Fråga användaren "Vad heter ABBAs senaste album?"
            System.Console.Write("Vad heter ABBAs senaste album?");
            string låt = Console.ReadLine();
            
            //är svaret korrekt?
            if (låt == "Voyage" || låt == "voyage")
            {
                System.Console.WriteLine("Bra svarat!");
            }
            else
            {
                System.Console.WriteLine("Fel! Albummet heter Voyage.");
            }

            //Sista TP-fråga
            System.Console.Write("Vem missade straffen i matchen England-Frankrike? (efternamn): ");

            // Läs in och tvinga till små bokstäver
            string spelare = Console.ReadLine().ToLower();
            
            if (spelare == "mbappe")
            {
                System.Console.WriteLine("Bra, du är en expert");
            }
            else
            {
                System.Console.WriteLine("Fel det var Mbappe");
            }
        }
    }
}
