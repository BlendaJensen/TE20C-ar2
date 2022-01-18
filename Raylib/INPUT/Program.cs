using System;
using Raylib_cs;

namespace INPUT
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

            //skapa en spelare av en rektangel
            Rectangle spelare = new Rectangle(500, 100, 50, 50);¨

            //ladda bild spelare
            Texture2D raket = Raylib.LoadTexture(@"./resurser/raket.png");

            //skapa en fiende av en rektangel
            Rectangle fiende = new Rectangle(100, 100, 50, 50);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                /*Rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();
                
                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                //rita ut spelarens bild istället för rektangel

                // rita spelaren
                Raylib.DrawRectangleRec(spelare, Color.RED);

                //rita fiende
                Raylib.DrawRectangleRec(fiende, Color.BLACK);
                
                // Ritat ut på fönstret
                Raylib.EndDrawing();

                /*Interaktion med användaren*/
                //lyssna på tangenter spelare
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += 2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= 2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += 2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= 2;
                }

                //lyssna på tangenter fiende
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    fiende.x += 2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    fiende.x -= 2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    fiende.y += 2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    fiende.y -= 2;
                }
            }
        }
    }
}