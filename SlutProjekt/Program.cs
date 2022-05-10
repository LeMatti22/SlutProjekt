using System;
using Raylib_cs;

Random rainPos = new Random(1270);


Rain[] rain =  new Rain[1000];
Rain[] rainX =  new Rain[rain.Length];



for(int i = 0; i < rain.Length; i++)
{
    rain[i] = new Rain(rainPos.Next(1270), rainPos.Next(720));

}

Raylib.InitWindow(1270, 720, "SlutProjekt");
while(!Raylib.WindowShouldClose()){
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);

    for(int i = 0; i < rain.Length; i++)
    {
        Raylib.DrawRectangleRec(rain[(i)].raindrop, Color.BLUE);
    }

    Raylib.EndDrawing();
}

class Rain
{
    public int xOffset;
    public int yOffset;
    public Rectangle raindrop = new Rectangle();
    public Rain(int _xOffset, int _yOffset)
    {
        xOffset = _xOffset;
        yOffset = _yOffset;
        raindrop = new Rectangle(_xOffset, _yOffset, 1, 3);
    }

} 



