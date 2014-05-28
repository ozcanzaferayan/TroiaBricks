using GameName2.Classes.SpriteItems;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameName2.Classes.Stages
{
    class Stage1
    {
        static Brick[,] bricks;
        static Paddle paddle;
        static Ball ball;
        internal static void CreateBricks(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, Microsoft.Xna.Framework.Content.ContentManager content, Rectangle screen)
        {
            
            bricks = new Brick[5, 5];
            Rectangle lastBrickPosition = screen;
            lastBrickPosition.X += 10;
            lastBrickPosition.Y += 10;

            for (int i = 0; i < bricks.GetLength(0); i++)
            {
                for (int j = 0; j < bricks.GetLength(1); j++)
                {
                    bricks[i, j] = new Brick(graphicsDevice, content, lastBrickPosition.X, lastBrickPosition.Y);
                    if (i % 2 == 0)
                    {
                        lastBrickPosition.X += bricks[i, j].Width + 10;
                    }
                    else
                    {
                        if (j == 0 || j == bricks.GetLength(1) - 1) bricks[i, j].isDestroyed = true;
                        lastBrickPosition.X -= bricks[i, j].Width + 10;
                    }
                }
                if (i % 2 == 0) lastBrickPosition.X -= bricks[0, 0].Width + 10;
                else lastBrickPosition.X += bricks[0, 0].Width + 10;
                lastBrickPosition.Y += bricks[0, 0].Height + 5;
            }
        }

        internal static void LoadBall()
        {
            ball.Load();
        }

        internal static void LoadBrick()
        {
            foreach (var brick in bricks)
            {
                brick.Load();
            }
        }

        internal static void LoadPaddle()
        {
            paddle.Load();
        }

        internal static void CreateBall(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, Microsoft.Xna.Framework.Content.ContentManager content, Rectangle screen)
        {
            ball = new Ball(graphicsDevice, content);
        }

        internal static void CreatePaddle(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, Microsoft.Xna.Framework.Content.ContentManager content, Rectangle screen)
        {
            paddle = new Paddle(graphicsDevice, content);
        }


        internal static void DrawBall()
        {
            //ball.Draw(spriteBatch);
        }

        internal static void DrawBricks()
        {
            //for (int i = 0; i < bricks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < bricks.GetLength(1); j++)
            //    {

            //        if (!bricks[i, j].isDestroyed)
            //        {
            //            bricks[i, j].Draw(spriteBatch);

            //        }
            //    }
            //}
        }

        internal static void DrawPaddle()
        {
            //paddle.Draw(spriteBatch);
        }

        internal static void UpdateBall()
        {
            ball.Move();
        }

        internal static void UpdatePaddle()
        {
            paddle.GoLeft();
            paddle.GoRight();
        }

        internal static void UpdateBricks()
        {
            throw new NotImplementedException();
        }
    }
}
