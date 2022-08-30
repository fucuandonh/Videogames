using Collisions.Application.Validator;
using Collisions.Domain;
using Microsoft.Xna.Framework;

namespace Collisions.Application.Tool
{
    public static class CircleDirection
    {
        public static void Change(Circle circle, GraphicsDeviceManager graphics){
            if(IsTheCircleOnTheLeftEdge.Check(circle)){ circle.left = false; }                        
            if(IsTheCircleOnTheRightEdge.Check(circle, graphics)){ circle.left = true; }
            if(IsTheCircleOnTheTopEdge.Check(circle)){ circle.up = false; }                        
            if(IsTheCircleOnTheBottomEdge.Check(circle, graphics)){ circle.up = true; }                        
        }
    }
}