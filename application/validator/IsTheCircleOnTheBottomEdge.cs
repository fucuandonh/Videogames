using Collisions.Domain;
using Microsoft.Xna.Framework;

namespace Collisions.Application.Validator
{
    public static class IsTheCircleOnTheBottomEdge
    {
        public static bool Check(Circle circle, GraphicsDeviceManager graphics){
            return (circle.rectangle.Y + circle.diameter) > graphics.PreferredBackBufferHeight;
        }
    }
}