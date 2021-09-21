using System;

namespace övning_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Förklarar vad som kommer ske och lön 1
            Console.WriteLine("Hej, det här programmet räknar ut medellönen för tre på ett företag. Skriv in lön ett:");
            int lönEtt = int.Parse(Console.ReadLine());

            //Lön två
            Console.WriteLine("Skriv in den andra lönen:");
            int lönTvå = int.Parse(Console.ReadLine());

            //Lön tre
            System.Console.WriteLine("Skriv in den tredje lönen:");
            int lönTre = int.Parse(Console.ReadLine());

            //Medellönen
            float medelVärde = (lönEtt + lönTvå + lönTre) / 3;

            //Skriver ut medelvärdet
            System.Console.WriteLine($"Medellönen är {medelVärde}");
        }
    }
}
