using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GXPEngine;

public class Background : GameObject
{
    float repeatPos = 0;

    public Background(float pScale = 2) 
    {
        //float requiredScale = Game.main.height / (float)height;
        //SetScaleXY(pScale);
        //Console.WriteLine(height*requiredScale);
        //  width = 512 * 2;
        // height = 192 * 2;
        //y = Game.main.height - height;

        Sprite sprite = null;
        float bGWidth = 0;

        do
        {
            sprite = new Sprite("layers/foregound-merged.png");
            sprite.SetScaleXY(pScale);
            AddChild(sprite);
            sprite.x = bGWidth;
            bGWidth += sprite.width;
        } while (bGWidth < Game.main.width + sprite.width);

            y = Game.main.height - sprite.height;
        repeatPos = sprite.width;

    }

    public void SetPos(float pPlayerPosition)
    {
        x = -pPlayerPosition;
        if (x < -repeatPos) x += repeatPos;
    }
}

