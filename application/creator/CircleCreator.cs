using Collisions.Domain;

namespace Collisions.Application.Creator
{
    public class CircleCreator
    {
        public static Circle New(){        
            return new Circle(DiameterCreator.New(),
                                PointCreator.New(),
                                DisplacementCreator.New(),
                                ColorCreator.New());
        }
    }
}