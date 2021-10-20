using System;

namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv in din summa
            Console.WriteLine("Skriv in din summa");
            string summaText = Console.ReadLine();

            int summa = 0;
            
            //Loopa igenom summaText
            for (var i = 0; i < summaText.Length; i++)
            {
                char siffra = summaText[i];
                Console.WriteLine(siffra);

                //Omvandla char till string till int
                //Omvandla char med .ToString()
                int siffraTal = int.Parse(siffra.ToString()); 

                summa += siffraTal;              
            }

            Console.WriteLine($"Siffersumman av talet {summaText} är {summa}");
        }
    }
}
