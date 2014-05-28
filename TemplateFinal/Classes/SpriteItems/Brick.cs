using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameName2.Classes.SpriteItems
{
    public class Brick : AbstractSprite
    {
        public bool isDestroyed = false;
        public bool hasPowerUp = false;
        public Brick(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content, int X, int Y)
        {
            this.Width = 80;
            this.Height = 30;
            this.GraphicsDevice = graphicsDevice;
            this.Content = content;
            this.Screen = graphicsDevice.Viewport.Bounds;
            this.PositionRectangle = new Rectangle(X, Y, this.Width, this.Height);
            this.Color = Color.White;
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, PositionRectangle, Color);
        }

        internal void Load()
        {
            Texture = Content.Load<Texture2D>("RedBrick");
        }
    }
}
