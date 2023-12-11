using System;
using Raylib_cs;

Raylib.InitWindow(512, 480, "Raylib");
Raylib.SetTargetFPS(60);

// skapa en array för trianglar
Rectangle[] raketer = new Rectangle[9];
int[] hastighet = new int[9];
Random generator = new Random();

// upprepa 5 gånger
for (var i = 0; i < 5; i++)
{
    Rectangle raket = new Rectangle(generator.Next(0,512), 0, 20, 20);

}

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    
    Raylib.EndDrawing();
}

