using System;

namespace Uppgift_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");

            int[] talLista = { 34, 324, 578, -157, 675 };

            int summa = 0;

            foreach (int tal in talLista)
            {
                summa = summa + tal;
            }

            Console.WriteLine(summa);
        }
    }
}
