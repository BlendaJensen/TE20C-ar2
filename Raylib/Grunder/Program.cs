using System;
using Raylib_cs;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej Raylib!");

            //starta fönster
            Raylib.InitWindow(800, 600 , "Ett raylib fönster");

            //Ställ in fps
            Raylib.SetTargetFPS(60);

            //Egen färg
            Color GoldenRod = new Color(218,165, 32, 170);

            //Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                //Börja rita
                Raylib.BeginDrawing();

                //Tömma ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                //Rita en fyrkant
                Raylib.DrawRectangle(235, 0, 100, 600, Color.GOLD);

                //Rita en till rekktangel
                Raylib.DrawRectangle(0, 220, 800, 110, Color.GOLD);

                Raylib.DrawCircle(500, 350, 100, GoldenRod);

                //Rita text
                Raylib.DrawText("Text", 100, 500, 50, Color.BLACK);

                //Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
