using System;

namespace lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Clear();

            //Berättar om programmet
            Console.WriteLine("Lyckohjul, du har tre försök");

            //Skapa ett program som ska fungera som ett lyckohjul

            //När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på
            
            //Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev
            
            //Berätta också för användaren om hen vann eller förlorade
            
            //Användaren får 3 försök!

            Random generator = new Random();

            int räknare = 0;
            while (true)
            {
                //räknar varv
                räknare++;

                //Vad som händer om man inte lyckas gissa rätt någon gång
                if (räknare >= 4)
                {
                    Console.WriteLine("Tyvärr förlorade du!");
                    break;
                }

                //Frågar om användarens gissning
                Console.Write("Välj ett tal från 1-10: ");
                int gissning = int.Parse(Console.ReadLine());
                //slumpar fram tal
                int tal = generator.Next(1,11);

                //Vad som händer när man har rätt
                if (gissning == tal)
                {
                    Console.WriteLine("Grattis du vann!");
                    break;
                }

                //Vad som händer när man har fel
                if (gissning != tal)
                {
                    Console.WriteLine("Fel, försök igen");
                }
            }
        }
    }
}
