using System;

namespace Genomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            string inmatat = string.Empty;

            while(inmatat != "hej")
            {
                Console.WriteLine("Mata in något:");
                inmatat = Console.ReadLine();

                Console.WriteLine("Du skrev; " + inmatat);

                if (inmatat == "hej")
                {
                    break;
                }
                Console.WriteLine("Nu är programmet slut");
            }
        }
    }
}
