using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace GameName2.Classes.SpriteItems
{
    public class Paddle : AbstractSprite
    {
        private int paddleSpeed = 7;
        public int injuredCount = 0;
        public int lives = 3;
        public int initialWidth;
        public Rectangle initialPositionRectangle;
        public Paddle(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content)
        {
            this.Width = 200;
            this.initialWidth = this.Width;
            this.Height = 10;
            this.GraphicsDevice = graphicsDevice;
            this.Content = content;
            this.Screen = graphicsDevice.Viewport.Bounds;
            this.PositionRectangle = new Rectangle(Screen.Width / 2 - 50, Screen.Height - 25, this.Width, this.Height);
            this.initialPositionRectangle = this.PositionRectangle;
            this.Color = Color.White;
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, PositionRectangle, Color);
        }

        public override void Load()
        {
            Texture = Content.Load<Texture2D>("BluePaddle");
        }


        internal void GoRight()
        {
            if (this.PositionRectangle.X >= Screen.Width - Width) return;
            else
            {
                this.PositionRectangle.X += paddleSpeed;
            }
        }

        internal void GoLeft()
        {
            if (this.PositionRectangle.X <= 0) return;
            else this.PositionRectangle.X -= paddleSpeed;
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
