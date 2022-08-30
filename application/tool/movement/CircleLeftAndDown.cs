using Collisions.Domain;

namespace Collisions.Application.Tool.Movement
{
    public static class CircleLeftAndDown
    {
        public static void Move(Circle circle){
            var tmpRectangle = circle.rectangle;
            tmpRectangle.X -= circle.displacement.X;
            tmpRectangle.Y += circle.displacement.Y;
            circle.rectangle = tmpRectangle;
        }
    }
}