using System;
using Raylib_cs;


Rain[] rain =  new Rain[1000];

for(int i = 0; i < rain.Length; i++)
{
    rain[i] = new Rain();

    rain[i].lol(i*2, -20);

}

Raylib.InitWindow(1280, 720, "SlutProjekt");
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
    public Rectangle raindrop = new Rectangle();
    public void lol(int xOffset, int yOffset)
    {
    raindrop = new Rectangle(xOffset, yOffset, 1, 3);
    }

} 

void rainDownfall()
{
    while()
}


