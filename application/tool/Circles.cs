using Collisions.Domain;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace Collisions.Application.Tool
{
    public static class Circles
    {
        public static void Initialize(List<Circle> circlesList){
            foreach(var circle in circlesList){ 
                var size = new Point(circle.diameter, circle.diameter);
                circle.rectangle = new Rectangle(circle.point, size);
            }
        }
        public static void LoadContent(List<Circle> circlesList, ContentManager content){
            foreach(var circle in circlesList){ 
                circle.texture = content.Load<Texture2D>(circle.imageName);
            }
        }
        public static void Draw(List<Circle> circlesList, SpriteBatch sprite){
            foreach(var circle in circlesList){ 
                sprite.Begin();
                sprite.Draw(circle.texture, circle.rectangle, circle.color);
                sprite.End();
            }
        }
        public static void Update(List<Circle> circlesList, GraphicsDeviceManager graphics){
            foreach(var circle in circlesList){ 
                CircleDirection.Change(circle, graphics);
                CircleMovement.Change(circle);
                CircleCollides.Check(circle,circlesList);
            }
        }
    }
}
