using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GXPEngine;

public class Player : AnimationSprite
{
    public Player() : base("Shark/Walk.png", 4, 1)
    {
        scale = 2;
        SetOrigin(width / 2, height / 2);
    }


    void Update()
    {
        x = (x * 0.96f) + (Input.mouseX * 0.045f);
        y = (y * 0.96f) + (Input.mouseY * 0.045f);

        Animate(0.1f);
    }
}


