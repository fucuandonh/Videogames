using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Collisions.Domain
{
    public class Circle
    {
        public string imageName { get; set; }
        public int diameter { get; }
        public Point point { get; set;}
        public Point displacement { get; set;}
        public Color color { get; }
        public Rectangle rectangle { get; set; }
        public Texture2D texture { get; set; }
        public bool left { get; set; }
        public bool right { get; set; }
        public bool up { get; set; }
        public bool down { get; set; }

        public Circle(int newDiameter, Point newPoint, Point newDisplacement, Color newColor)
        {
            imageName = "circle";
            diameter = newDiameter;
            point = newPoint;
            displacement = newDisplacement;
            color = newColor;
            left = false;
            up = false;
        }
    }
}