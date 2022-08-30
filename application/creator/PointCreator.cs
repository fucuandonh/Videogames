using System;
using Microsoft.Xna.Framework;

namespace Collisions.Application.Creator
{
    public class PointCreator
    {
        public static Point New(){
            var random = new Random();
            var x = random.Next(0,600);
            var y = random.Next(0,300);
            return new Point(x,y);
        }
    }
}