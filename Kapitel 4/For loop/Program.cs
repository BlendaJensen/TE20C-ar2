using System;

namespace For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Räkna 1 till 10 ");
            
/*             for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            } */
            //Läs in ett meddelande
            Console.WriteLine("Skriv ett meddelande");
            string meddelande = Console.ReadLine();
            
            //Loopa igenom meddelandet
            for (var i = 0; i < meddelande.Length; i++)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
