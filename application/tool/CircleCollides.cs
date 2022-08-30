using Collisions.Application.Tool;
using Collisions.Domain;
using System.Collections.Generic;

namespace Collisions.Application.Tool
{
    public static class CircleCollides
    {
        public static void Check(Circle circle, List<Circle> circlesList){
            foreach(var tmpCircle in circlesList){
                if(!circle.Equals(tmpCircle) && 
                    circle.rectangle.Intersects(tmpCircle.rectangle)){
                    CircleMovement.Invert(circle);
                    CircleMovement.Invert(tmpCircle);
                }
            }
        }
    }
}