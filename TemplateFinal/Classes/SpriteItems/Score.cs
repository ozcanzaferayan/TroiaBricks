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
    public class Score : AbstractSprite
    {
        public int score = 0;
        public string formattedScore;
        public bool isDestroyed = false;
        public bool mobility { get; set; }
        public AbstractSprite powerUp;
        public SpriteFont font;
        public Score(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, ContentManager content, int X, int Y)
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
        }

        public override void Load()
        {
            font = Content.Load<SpriteFont>("Time"); 
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (score < 100)
            {
                formattedScore = "00000";
            }
            else if (score >= 100 && score < 1000)
            {
                formattedScore = "00" + score;
            }
            else if (score >= 1000 && score <= 10000)
            {
                if (score / 100 < 10)
                {
                    formattedScore = "0" + score;
                }
                formattedScore = "0" + score;
            }
            spriteBatch.DrawString(font, formattedScore, new Vector2(Screen.Right - 125, Y), Color.Chocolate);
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
