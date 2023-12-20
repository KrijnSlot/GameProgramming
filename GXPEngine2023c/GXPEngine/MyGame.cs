using System;                                   // System contains a lot of default C# libraries 
using GXPEngine;                                // GXPEngine contains the engine
using System.Drawing;                           // System.Drawing contains drawing tools such as Color definitions

public class MyGame : Game
{
    Player player;
    Background background;

    public MyGame() : base(1280, 700, false, true, -1, -1, true)     // Create a window that's 800x600 and NOT fullscreen
    {
        player = new Player();
        background = new Background();
        AddChild(background);
        AddChild(player);
    }
    // For every game object, Update is called every frame, by the engine:
    void Update()
    {
        // Empty

        background.SetPos(player.x);

    }

    static void Main()                          // Main() is the first method that's called when the program is run
    {
        new MyGame().Start();                   // Create a "MyGame" and start it
    }
}
