using System;

namespace MenyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enkelt menyprogramm!");
            
            //skapa en slumpgenerator
            Random tärning = new Random();
            
            //Programmloop
            while (true)
            {
                

                //Slumpa fram ett tal
                int slumptal = tärning.Next(1,4);

                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("Väljer du sten? (1)");
                Console.WriteLine("Väljer du sax? (2)");
                Console.WriteLine("Väljer du påse? (3)");
                Console.WriteLine("Vill du avsluta? (4)");
                string valString = Console.ReadLine();
                
                //Vill användaren avsluta
                if (valString == "4")
                {
                    break;
                }

                //Är det rätt svar
                if (slumptal == 1)
                {
                    if (valString == "1")
                    {
                        Console.WriteLine("Lika, försök igen");
                    }

                    if (valString == "2")
                    {
                        Console.WriteLine("Du förlorade, försök igen");
                    }

                    if (valString == "3")
                    {
                        Console.WriteLine("Grattis du vann!");
                    }
                }

                if (slumptal == 2)
                {
                    if (valString == "1")
                    {
                        Console.WriteLine("Grattis du vann!");
                    }

                    if (valString == "2")
                    {
                        Console.WriteLine("Lika, försök igen");
                    }

                    if (valString == "3")
                    {
                        Console.WriteLine("Du förlorade, försök igen");
                    }
                }

                if (slumptal == 3)
                {
                    if (valString == "1")
                    {
                        Console.WriteLine("Du förlorade, försök igen");
                    }

                }
            }
        }
    }
}
