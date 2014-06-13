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
        public int xDirection = -1;
        public int yDirection = -1;
        public bool isSticked = true;
        public Ball(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content)
        {
            this.Speed = 5;
            this.Width = 20;
            this.Height = 20;
            this.GraphicsDevice = graphicsDevice;
            this.Content = content;
            this.Screen = graphicsDevice.Viewport.Bounds;
            this.PositionRectangle = new Rectangle(Screen.Width / 2, Screen.Height - 47 , this.Width, this.Height);
            this.Color = Color.White;
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, PositionRectangle, Color);
        }

        public override void Move()
        {
            this.PositionRectangle.X += Speed * xDirection; 
            this.PositionRectangle.Y += Speed * yDirection;
        }

        public void MoveWithPaddle(Rectangle paddleRectangle)
        {
            this.PositionRectangle.X = paddleRectangle.X + this.Width;
        }

        public override void Load()
        {
            this.Texture = Content.Load<Texture2D>("GrayBall");
        }


        
    }
}
