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
    public class Ball : AbstractSprite
    {
        public int ballSpeed = 5;
        public int xDirection = -1;
        public int yDirection = -1;
        public bool isSticked = true;
        public Ball(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content)
        {
            this.Width = 20;
            this.Height = 20;
            this.GraphicsDevice = graphicsDevice;
            this.Content = content;
            this.Screen = graphicsDevice.Viewport.Bounds;
            this.PositionRectangle = new Rectangle(Screen.Width / 2, Screen.Height - 47 , this.Width, this.Height);
            this.Color = Color.White;
        }

        internal void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, PositionRectangle, Color);
        }

        internal void Move()
        {
            this.PositionRectangle.X += ballSpeed * xDirection; 
            this.PositionRectangle.Y += ballSpeed * yDirection;
        }

        internal void MoveWithPaddle(Rectangle paddleRectangle)
        {
            this.PositionRectangle.X = paddleRectangle.X + this.Width;
        }

        internal void Load()
        {
            this.Texture = Content.Load<Texture2D>("GrayBall");
        }


        
    }
}
