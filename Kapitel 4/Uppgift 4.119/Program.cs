using System;

namespace Uppgift_4._119
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ställer frågan
            Console.WriteLine("Vilket land är Europas folkrikaste land?");
            string svar = Console.ReadLine();

            //Gissningar
            int antalGissningar = 1;

            //Loop medan man har svarat fel 
            while (svar != "Tyskland")
            {
                //Gör så att man har 5 gissningar
                if (antalGissningar >= 5)
                {
                    Console.WriteLine("Du har fått slut på gissningar.");
                    break;
                }
                Console.WriteLine("Fel svar, försök igen");
                svar = Console.ReadLine();
                antalGissningar++;
            }

            //Rätt svar
            if (svar == "Tyskland")
            {
                Console.WriteLine("Rätt svar");
            }
        }
    }
}
