using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameName2.Classes.SpriteItems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TemplateFinal.Classes.SpriteItems.SpecialFeatures
{
    public class SplitBall : AbstractSprite
    {
        public SplitBall(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content)
        {
            this.isActivated = false;
            this.Speed = 1;
            this.Width = 50;
            this.Height = 50;
            this.GraphicsDevice = graphicsDevice;
            this.Content = content;
            this.Screen = graphicsDevice.Viewport.Bounds;
            this.PositionRectangle = new Rectangle(Screen.Width / 2 - 50, Screen.Height - 25, this.Width, this.Height);
            this.Color = Color.White;
        }

        public override void Load()
        {
            this.Texture = Content.Load<Texture2D>("ShrinkPaddle");
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            if (this.isActivated)
            {
                spriteBatch.Draw(Texture, PositionRectangle, Color);
            }
            
        }

        public override void Move()
        {
            if (this.isActivated)
            {
                this.PositionRectangle.Y += this.Speed * 1;
            }
        }
    }
}
