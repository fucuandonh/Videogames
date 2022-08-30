using System;

namespace Collisions.Application.Creator
{
    public class DiameterCreator
    {
        public static int New(){
            var random = new Random();
            return random.Next(25,100);
        }
    }
}