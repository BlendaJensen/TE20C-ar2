﻿using System;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string meddelande = "Hej på dig!";

            //skriv ut hela strängen
            Console.WriteLine(meddelande);

            //skriv ut första bokstaven  "H"
            Console.WriteLine(meddelande[0]);

            //Skriv ut sista tecknet
            Console.WriteLine(meddelande[10]);

            char bokstav = 'z';

            //skriv ut alla bokstäver
            for (var i = 0; i < 11; i++)
            {
                Console.WriteLine($"index {i} {meddelande[i]}");
            }
        }
    }
}
