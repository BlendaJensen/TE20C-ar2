using System;

namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uppgift 5.1");
                // Skapa array
                string[] stad = new string[3];
                //Stad 1
                stad[0] = "Örebro";
                //Stad 2
                stad[1] = "Stockholm";
                //Vilka städer som inte får användas
                Console.WriteLine($"Skriv namnet på en svenska stad förutom städerna {stad[0]} och {stad[1]}");
                stad[2] = Console.ReadLine();
                
                //Skriver ut
                Console.WriteLine($"Här är tre svenska städer: {stad[0]}, {stad[1]} och {stad[2]}");
                
                //Annat sätt för array
                string[] länder= {"Sverige", "Finland", "Danmark", "Norge"};
                länder[0] = "Tyskland";

                //Skriv ut alla länder
                //Loopa igenom arrayen länder
                foreach (var land in länder)
                {
                    Console.WriteLine(land);
                }
        }
    }
}
