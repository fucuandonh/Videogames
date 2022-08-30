using Microsoft.Xna.Framework;
using System;


namespace Collisions.Application.Creator
{
    public static class ColorCreator
    {
        public static Color New(){
            var random = new Random();
            var red = random.Next(0,255);
            var green = random.Next(0,255);
            var blue = random.Next(0,255);
            return new Color(red, green, blue);
        }
    }
}