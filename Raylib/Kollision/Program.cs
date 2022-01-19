using System;
using Raylib_cs;

namespace Kollision
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initiera grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");
            Raylib.SetTargetFPS(60);

            //Några variabler
            int hastighet = 3;
            Random generator = new Random();
            int poäng = 0;
            int timer = 0;

            /* Skapa objekt */
            Rectangle spelare = new Rectangle(100, 100, 50, 50);
            Rectangle fiende = new Rectangle(generator.Next(400, 720), generator.Next(0, 520), 72, 72);
            Texture2D cake = Raylib.LoadTexture(@"./resurser/cake.png");

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                timer ++;
                //Räkna antalet frames
                if (timer > 1000)
                {
                    Raylib.DrawText($"GAME OVER", 385, 200,100, Color.WHITE);
                }
                else
                {
                    /* Rita ut grafiken */
                    // Börja rita
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.DARKBLUE);
                // Rita ut objekt
                Raylib.DrawRectangleRec(fiende, Color.BLACK);
                //Raylib.DrawTexture(cake, fiende.x, fiende.y, Color.WHITE);
                Raylib.DrawRectangleRec(spelare, Color.RED);
                

                //Upptäcka kollision
                if (Raylib.CheckCollisionRecs(spelare, fiende))
                {
                    poäng ++;
                    fiende.x = generator.Next(400, 720);
                    fiende.y = generator.Next(0, 520);
                }

                //Visar poängen
                Raylib.DrawText($"Tid {timer/10} Poäng {poäng}", 385, 50,50, Color.WHITE);

                // Ritat ut på fönstret
                Raylib.EndDrawing();

                /* Interaktion med användare */
                //spelare
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += hastighet;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= hastighet;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += hastighet;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= hastighet;
                }
                }
            }
        }
    }
}
