using Collisions.Domain;
using Microsoft.Xna.Framework;

namespace Collisions.Application.Validator
{
    public static class IsTheCircleOnTheRightEdge
    {
        public static bool Check(Circle circle, GraphicsDeviceManager graphics){
            return (circle.rectangle.X + circle.diameter) > graphics.PreferredBackBufferWidth;
        }
    }
}