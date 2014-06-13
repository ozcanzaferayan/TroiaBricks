using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateFinal.Classes.SpriteItems.SpecialFeatures;

namespace GameName2.Classes.SpriteItems
{
    public class Brick : AbstractSprite
    {
        public bool isDestroyed = false;
        public bool mobility { get; set; }
        public AbstractSprite powerUp;
        public Brick(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content, int X, int Y)
        {
            powerUp = new SplitBall(graphicsDevice, content);
            powerUp.PositionRectangle.X = X;
            powerUp.PositionRectangle.Y = Y;
            this.Speed = 1;
            this.mobility = false;
            this.Width = 80;
            this.Height = 30;
            this.GraphicsDevice = graphicsDevice;
            this.Content = content;
            this.Screen = graphicsDevice.Viewport.Bounds;
            this.PositionRectangle = new Rectangle(X, Y, this.Width, this.Height);
            this.Color = Color.White;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, PositionRectangle, Color);
        }

        public override void Load()
        {
            Texture = Content.Load<Texture2D>("RedBrick");
        }

        public override void Move()
        {
            if (this.mobility)
            {
                this.PositionRectangle.Y += Speed * 1;
            }
            
        }

    }
}
