using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GXPEngine;

public class Player : Sprite
{
    int playerSpeed = 2;
    public Player() : base("circle.png")
    {
        SetOrigin(width / 2, height / 2);
    }

    void Update()
    {
        x = (x * 0.96f) + (Input.mouseX * 0.04f);
        y = (y * 0.96f) + (Input.mouseY * 0.04f);
    }
}


