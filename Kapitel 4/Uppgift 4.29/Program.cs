using System;

namespace Uppgift_4._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            //Börjar på 50
            int i = 50;

            //Gör så att den inte räknar under noll
            while (i > 0)
            {
                Console.WriteLine(i);
                //räknar ner
                i--;
            }

        }
    }
}
