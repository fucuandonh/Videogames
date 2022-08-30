using System;
using System.Collections.Generic;
using Collisions.Application.Creator;
using Collisions.Domain;

namespace Collisions.Application.Tool
{
    public static class CirclesList
    {
        public static List<Circle> New(){
            var circlesList = new List<Circle>();
            var random = new Random();
            for(int i = 0; i < random.Next(5,10); i++){ 
                circlesList.Add(CircleCreator.New()); 
            }

            return circlesList;
            
        }
    }
}