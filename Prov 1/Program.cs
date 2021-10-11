using System;

namespace Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Det här programmet berättar din lön efter skatt");


            //Vad användaren heter
            Console.Write("Vad heter du?: ");
            string namn = Console.ReadLine();
            
            //Vad användaren tjänar inann skatt
            Console.Write("Vad tjänar du inann skatt?: ");
            int bruttolön = int.Parse(Console.ReadLine());

            //Ser till att talet är mellan 10000 och 45000
            if (bruttolön < 10000 || bruttolön > 45000)
            {
                Console.WriteLine("Du måste skriva ett tal mellan 10000 och 45000. Försök igen!");
            }

            //Vad användarens skattesats är
            Console.Write("Vad är din skattesats?: ");
            int skattesats = int.Parse(Console.ReadLine());
            
            if (skattesats < 10 || skattesats > 45)
            {
                Console.WriteLine("Talet ska vara mellan 10 och 45. Försök igen!");
            }
            //Räknar ut nettolön
            int nettolön = bruttolön * (100 - skattesats) / 100;
            
            //Gör om int till string
            string nettolönstring = nettolön.ToString();

            //Skriver användarens nettolön
            Console.WriteLine($"{namn} din nettolön är {nettolön}kr");

            //Frågar om man vill köra igen
            Console.Write("Vill du göra om? (ja/nej)");
            string jaNej = Console.ReadLine();
            
        }
    }
}
