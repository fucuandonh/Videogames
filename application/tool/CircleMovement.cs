using Collisions.Application.Tool.Movement;
using Collisions.Domain;

namespace Collisions.Application.Tool
{
    public static class CircleMovement
    {
        public static void Change(Circle circle){
            if(IsInFirstCuadrant(circle)){ CircleLeftAndUp.Move(circle); }                
            if(IsInSecondCuadrant(circle)){ CircleRightAndUp.Move(circle); }
            if(IsInThirdCuadrant(circle)){ CircleLeftAndDown.Move(circle); }                
            if(IsInFourthCuadrant(circle)){ CircleRightAndDown.Move(circle); }                   
        } 
        public static void Invert(Circle circle){
            circle.left = !circle.left;
            circle.down = !circle.down;
        }

        public static bool IsInFirstCuadrant(Circle circle){ return circle.left && circle.up; }
        public static bool IsInSecondCuadrant(Circle circle){ return !circle.left && circle.up; }
        public static bool IsInThirdCuadrant(Circle circle){ return circle.left && !circle.up; }
        public static bool IsInFourthCuadrant(Circle circle){ return !circle.left && !circle.up; }
    }
}