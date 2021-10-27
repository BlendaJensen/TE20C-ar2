using System;

namespace Tärning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa ett program som ska fungera som en tärningssimulator
            //När användaren startar programmet ska hen få säga hur många tärningar hen vill kasta och hur många sidor varje tärning ska ha
            //Simulera därefter det antal tärningskast som användaren vill göra med det antal sidor som användaren valde
            //Skriv ut värdet av varje tärningskast

            Console.WriteLine("En tärningsimulator");
            Random generator = new Random();

            Console.Write("Hur många tärningar vill du ha: ");
            int antal = int.Parse(Console.ReadLine());

            Console.Write("Hur många sidor ska tärningen ha");

        }
    }
}
