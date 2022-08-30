using Collisions.Domain;

namespace Collisions.Application.Validator
{
    public static class IsTheCircleOnTheTopEdge
    {
        public static bool Check(Circle circle){
            return circle.rectangle.Y <= 0;
        }
    }
}