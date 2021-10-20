using System;

namespace Uppgift_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string meddelande = "Hej detta är ett meddelande!";

            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                System.Console.Write(meddelande[i]);
            }
        }
    }
}
