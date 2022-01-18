using System;
using Raylib_cs;

namespace bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");
            
            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            // Ladda in bilden
            Texture2D flygplan = Raylib.LoadTexture(@"./resurser/Flygplan.png");
            Texture2D moon = Raylib.LoadTexture(@"./resurser/moon.png");

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();
                
                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                //rita ut bild
                Raylib.DrawTexture(flygplan, 100, 200, Color.WHITE);
                Raylib.DrawTexture(moon, 500, 30, Color.WHITE);
                
                // Ritat ut på fönstret
                Raylib.EndDrawing();
                }
        }
    }
}
