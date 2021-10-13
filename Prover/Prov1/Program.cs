using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berättar vad programmet gör
            Console.WriteLine("Uträkning av nettolön/n---------------------");

            //Upprepa med en loop
            while (true)
            {
                //Frågar efter namn
            Console.Write("Vad heter du?");
            string namn = Console.ReadLine();
            
            //Fråga efter bruttolön
            Console.Write("Ange din bruttolön i kronor: ");
            int bruttolön = int.Parse(Console.ReadLine());
            
            //Kollar att vilkoren är uppfylda
            if (bruttolön >= 10000 && bruttolön <= 45000)
            {
                //Fråga efter skattesats
                Console.Write("Ange din skattesats");
                int skattesats = int.Parse(Console.ReadLine());

                if (skattesats >= 10 && skattesats <= 45)
                {
                    //Räkna ut nettolön
                    int nettolön = bruttolön * (100 - skattesats) / 100;
                    Console.WriteLine($"Din nettolön är {nettolön}kr");

                
                }
                else
                {
                    Console.Write("Skattesatsen måste vara mellan 10 och 45 %");
                }
                
            }
            else
            {
                Console.Write("Bruttolönen måste vara mellan 10000 och 45000kr");
            }
            
            //Vill du köra igen
            Console.WriteLine("Vill du köra igen? (j/n)");
            string svar= Console.ReadLine();
            if (svar != "j") // (svar = n)
            {
                break;
            }
            }
        }
    }
}
