using System;

namespace Uppgift_2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");

            int dagar = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många kilometer ska du köra?");

            float kilometer = float.Parse(Console.ReadLine());
            
            float totalaHyran = 300 + (dagar -1) * 500 + kilometer;

            System.Console.WriteLine($"Den totala hyran är: {totalaHyran}");

        }
    }
}
