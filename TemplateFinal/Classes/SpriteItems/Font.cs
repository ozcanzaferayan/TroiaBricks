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
    public class Time : AbstractSprite
    {
        public bool isDestroyed = false;
        public bool mobility { get; set; }
        public AbstractSprite powerUp;
        public SpriteFont font;
        private DateTime beforeTime;
        private DateTime afterTime;
        private string nowTime;
        int remainSeconds;
        int nowTimeValue;
        public Time(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content, int X, int Y)
        {
            this.Speed = 1;
            this.mobility = false;
            this.Width = 80;
            this.Height = 30;
            this.GraphicsDevice = graphicsDevice;
            this.Content = content;
            this.Screen = graphicsDevice.Viewport.Bounds;
            this.PositionRectangle = new Rectangle(X, Y, this.Width, this.Height);
            this.Color = Color.White;
            beforeTime = DateTime.Now;
        }

        public override void Load()
        {
            font = Content.Load<SpriteFont>("Time"); 
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            afterTime = DateTime.Now;
            nowTimeValue = (afterTime - beforeTime).Seconds;
            if (nowTimeValue <= 9)
                nowTime = "00:0" + nowTimeValue;
            else if (nowTimeValue > 9 && nowTimeValue <= 59)
                nowTime = "00:" + nowTimeValue;
            else if (nowTimeValue > 59 && nowTimeValue <= 3600)
            {
                remainSeconds = (nowTimeValue - (nowTimeValue / 60) * 60);
                if (remainSeconds<=9)
	            {
                    nowTime = "0" + nowTimeValue / 60 + ":0" + remainSeconds;
	            }
                else
                {
                    nowTime = "0" + nowTimeValue / 60 + ":" + remainSeconds;
                }
                
            }
                
            spriteBatch.DrawString(font, nowTime, new Vector2(Screen.Center.X - 50, Y), Color.Black);
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
