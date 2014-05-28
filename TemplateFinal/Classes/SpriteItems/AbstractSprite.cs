using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameName2.Classes.SpriteItems
{
    public abstract class AbstractSprite
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Texture2D Texture { get; set; }
        public Rectangle PositionRectangle;
        public Color Color { get; set; }
        public GraphicsDevice GraphicsDevice { get; set; }
        public Rectangle Screen { get; set; }
        public ContentManager Content { get; set; }
    }
}
