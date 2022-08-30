using System;
using Microsoft.Xna.Framework;

namespace Collisions.Application.Creator
{
    public static class DisplacementCreator
    {
        public static Point New(){
            var random = new Random();
            var x = random.Next(5,15);
            var y = random.Next(5,15);
            return new Point(x,y);
        }
    }
}