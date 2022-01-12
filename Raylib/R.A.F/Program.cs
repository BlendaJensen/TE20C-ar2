using System;
using Raylib_cs;


namespace R.A.F
{
    class Program
    {
        static void Main(string[] args)
        {
            //starta fönster
            Raylib.InitWindow(800, 600 , "Ett raylib fönster");

            //Ställ in fps
            Raylib.SetTargetFPS(60);

            //Egen färg
            Color Militarygreen = new Color();

            //Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                //Börja rita
                Raylib.BeginDrawing();

                //Tömma ritytan
                Raylib.ClearBackground(Color.DARKBLUE);



                //Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
