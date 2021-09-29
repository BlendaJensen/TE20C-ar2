using System;

namespace BoolskaOpwrationer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coronasymptom");

            Console.WriteLine("Har du feber? (j/n) ");
            string feber = Console.ReadLine();

            Console.WriteLine("Har du tappat smaken (j/n)");
            string smak = Console.ReadLine();
            
            Console.WriteLine("Har du hosta? (j/n)");
            string hosta = Console.ReadLine();
      
            if (feber == "j"|| hosta == "j" && smak == "j")
            {
                Console.WriteLine("Du kan ha Covid-19");
            }
        }
    }
}
