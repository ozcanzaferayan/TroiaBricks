using GameName2.Classes.SpriteItems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateFinal.Classes.SpriteItems
{
    public class Health : AbstractSprite
    {

        public Health(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content, int X, int Y)
        {
            this.Width = 20;
            this.Height = 10;
            this.GraphicsDevice = graphicsDevice;
            this.Content = content;
            this.Screen = graphicsDevice.Viewport.Bounds;
            this.PositionRectangle = new Rectangle(X, Y, this.Width, this.Height);
            this.Color = Color.White;
        }
        public override void Load()
        {
            Texture = Content.Load<Texture2D>("BluePaddle");
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, PositionRectangle, Color);
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
