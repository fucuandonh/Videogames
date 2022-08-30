using Collisions.Domain;

namespace Collisions.Application.Validator
{
    public static class IsTheCircleOnTheLeftEdge
    {
        public static bool Check(Circle circle){
            return circle.rectangle.X <= 0;
        } 
    }
}