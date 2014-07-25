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
    public class Background : AbstractSprite
    {
        public Background(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content)
        {
            
            this.GraphicsDevice = graphicsDevice;
            this.Content = content;
            this.Screen = graphicsDevice.Viewport.Bounds;
            this.Width = Screen.Width;
            this.Height = Screen.Height;
            this.PositionRectangle = new Rectangle(0, 0, this.Width, this.Height);
            this.Color = Color.White;
        }
        public override void Load()
        {
            Texture = Content.Load<Texture2D>("GreenBackground");
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
