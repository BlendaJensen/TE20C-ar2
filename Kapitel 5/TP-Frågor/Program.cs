using System;

namespace TP_Frågor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slumpa fram fråga");

            //Namnge korten
            string[] korten = {"När uppfördes Vendi?", //0
            "Vem vann fotbolls-EM 1984?",  //1
            "Vem skrev Frankenstein?",  //2
            "Vad är 5+5?",  //3
            "När startade andra världskriget?", //4
            "Vem är president i USA 2021"  //5
            };

            //Kasta tärningen
            Random tärning = new Random();
            int slumptal = tärning.Next(0,6); //0 till fem

            //Skriver utslaget
            System.Console.WriteLine($"Tärningen fick {slumptal}");

            // Skriv ut fråga
            System.Console.WriteLine($"Frågan: {korten[slumptal]}");
        }
    }
}
