using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using GameName2.Classes.SpriteItems;
using GameName2.Classes.Stages;
namespace GameName2.Classes
{
    public class Register
    {




        Paddle paddle;
        GraphicsDevice graphicsDevice;
        Rectangle screen;
        SpriteBatch spriteBatch;
        Brick[,] bricks;
        Ball ball;
        ContentManager content;
        MusicPlayer musicPlayer;

        public Register(GraphicsDevice GraphicsDevice, ContentManager Content)
        {
            this.graphicsDevice = GraphicsDevice;
            this.content = Content;
            this.musicPlayer = new MusicPlayer(Content);
            screen = graphicsDevice.Viewport.Bounds;
            paddle = new Paddle(graphicsDevice, content);
            bricks = new Brick[5, 5];
            ball = new Ball(graphicsDevice, Content);
            GenerateStage();
        }

        internal void SetSpriteBatch(SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }

        private void GenerateStage()
        {
            Rectangle lastBrickPosition = screen;
            lastBrickPosition.X += 10;
            lastBrickPosition.Y += 10;

            for (int i = 0; i < bricks.GetLength(0); i++)
            {
                for (int j = 0; j < bricks.GetLength(1); j++)
                {
                    //#region Değiştirdiğim alan
                    //bricks[i, j] = new Brick(graphicsDevice, content, 200, 200);
                    //bricks[i, j].hasPowerUp = true;
                    //#endregion

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

        #region Drawing Elements

        internal void DrawElements()
        {
            spriteBatch.Begin();
            DrawPaddle();
            DrawBricks();
            DrawBall();
            spriteBatch.End();
        }


        private void DrawBall()
        {
            ball.Draw(spriteBatch);
        }

        private void DrawBricks()
        {

            for (int i = 0; i < bricks.GetLength(0); i++)
            {
                for (int j = 0; j < bricks.GetLength(1); j++)
                {
                    bricks[i, j].powerUp.Draw(spriteBatch);
                    if (!bricks[i, j].isDestroyed)
                    {
                        bricks[i, j].Draw(spriteBatch);
                        if (bricks[i,j].powerUp.isActivated)
                        {
                            bricks[i, j].powerUp.Draw(spriteBatch);
                        }
                        
                    }
                }
            }
        }

        private void DrawPaddle()
        {
            paddle.Draw(spriteBatch);
        }

        #endregion

        #region Updating Elements
        internal void UpdateElements()
        {
            ReadGesture();
            UpdateBall();
            UpdateBricks();
        }

        private void UpdateBall()
        {
            if (ball.isSticked)
            {
                if (GameGesture.IsDoubleTapped())
                {
                    ball.isSticked = false;
                    ball.Move();
                }
                else
                {
                    ball.MoveWithPaddle(paddle.PositionRectangle);
                }
            }
            else
            {
                ball.Move();
            }
        }

        private void UpdateBricks()
        {
            for (int i = 0; i < bricks.GetLength(0); i++)
            {
                for (int j = 0; j < bricks.GetLength(1); j++)
                {
                    bricks[i, j].Move();
                    bricks[i, j].powerUp.Move();
                }
            }
        }

        private void UpdatePaddleLeft()
        {
            paddle.GoRight();
        }
        private void UpdatePaddleRight()
        {
            paddle.GoLeft();
        }
        #endregion


        #region Checking Collusion

        internal void CheckCollision()
        {
            CheckPaddleCollision();
            CheckTopScreenCollision();
            CheckBallScreenCollision();
            CheckRightScreenCollision();
            CheckBottomScreenCollision();
            CheckBrickCollusion();
        }


        #region Brick Collusion
        private void CheckBrickCollusion()
        {
            foreach (var brick in bricks)
            {
                if (ball.PositionRectangle.Intersects(brick.PositionRectangle))
                {
                    if (!brick.isDestroyed)
                    {
                        musicPlayer.PlayBrickBall();
                        CheckBrickSideCollusion(ball.PositionRectangle, brick.PositionRectangle);
                        brick.isDestroyed = true;
                        if (brick.powerUp != null)
                        {
                            brick.powerUp.isActivated = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (paddle.PositionRectangle.Intersects(brick.powerUp.PositionRectangle))
                {
                    brick.powerUp.isActivated = false;
                }
            }
        }


        private void CheckBrickSideCollusion(Rectangle ballRectangle, Rectangle brickRectangle)
        {
            if (brickRectangle.Center.Y < (ballRectangle.Center.Y + ballRectangle.Height / 2)) // Brick Bottom or Top
            {
                ball.yDirection *= -1;
            }
            else
            {
                ball.xDirection *= -1;
            }
        }

        #endregion

        private void CheckRightScreenCollision()
        {
            if (ball.PositionRectangle.X >= screen.Width - ball.Width)
            {
                ball.xDirection *= -1;
            }
        }

        private void CheckBallScreenCollision()
        {
            if (ball.PositionRectangle.X <= 0)
            {
                ball.xDirection *= -1;
            }
        }

        private void CheckTopScreenCollision()
        {
            if (ball.PositionRectangle.Y <= 0)
            {
                ball.yDirection *= -1;
            }
        }

        private void CheckBottomScreenCollision()
        {
            if (ball.PositionRectangle.Y >= screen.Height)
            {
                ball.PositionRectangle = new Rectangle(screen.Width / 2, screen.Height - 200, ball.Width, ball.Height);
            }
        }

        private void CheckPaddleCollision()
        {
            if (ball.PositionRectangle.Intersects(paddle.PositionRectangle))
            {
                ball.yDirection *= -1;
                if (ball.PositionRectangle.Center.X >= paddle.PositionRectangle.Center.X) // Paddle right side
                {
                    if (ball.xDirection == -1)
                    {
                        ball.xDirection *= -1; // Send ball the way which came
                    }
                    else
                    {
                        ball.xDirection = 1; // Send ball the opposite way which came
                    }
                }
                else if (ball.PositionRectangle.Center.X < paddle.PositionRectangle.Center.X) // Paddle left side
                {
                    if (ball.xDirection == -1)
                    {
                        ball.xDirection = -1; // Send ball the opposite way which came
                    }
                    else
                    {
                        ball.xDirection *= -1; // Send ball the way which came
                    }

                }
            }
        }
        #endregion



        internal void ReadGesture()
        {
            GameGesture.GestureMoves gest = GameGesture.ReadGesture();
            switch (gest)
            {
                case GameGesture.GestureMoves.Left:
                    UpdatePaddleLeft();
                    break;
                case GameGesture.GestureMoves.Right:
                    UpdatePaddleRight();
                    break;
                case GameGesture.GestureMoves.Top:
                    break;
                case GameGesture.GestureMoves.Bottom:
                    break;
                case GameGesture.GestureMoves.Null:
                    break;
                default:
                    break;
            }
        }

        #region Loading Content
        internal void LoadContent()
        {
            LoadBall();
            LoadBrick();
            LoadPaddle();
        }

        private void LoadPaddle()
        {
            paddle.Load();
        }

        private void LoadBrick()
        {
            foreach (var brick in bricks)
            {
                brick.Load();
                if (brick.powerUp != null)
                {
                    brick.powerUp.Load();
                }
            }
        }

        private void LoadBall()
        {
            ball.Load();
        }
        #endregion
    }
}
