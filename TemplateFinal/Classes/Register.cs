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
using TemplateFinal.Classes.SpriteItems;
using Microsoft.Xna.Framework.GamerServices;
using System.Windows;
using System.Windows.Navigation;
namespace GameName2.Classes
{
    public class Register
    {




        static Paddle paddle;
        GraphicsDevice graphicsDevice;
        Rectangle screen;
        SpriteBatch spriteBatch;
        Brick[,] bricks;
        Ball ball;
        List<Ball> balls;
        ContentManager content;
        MusicPlayer musicPlayer;
        Time time;
        Rectangle stageScreen;
        Random r;
        Score score;
        bool isMessageShowing = false;
        List<Health> lives;
        Background background;
        public Register(GraphicsDevice GraphicsDevice, ContentManager Content)
        {
            r = new Random();
            this.graphicsDevice = GraphicsDevice;
            this.content = Content;
            this.musicPlayer = new MusicPlayer(Content);
            screen = graphicsDevice.Viewport.Bounds;
            paddle = new Paddle(graphicsDevice, content);
            lives = new List<Health>(paddle.lives);
            bricks = new Brick[5, 5];
            balls = new List<Ball>();
            Ball b = new Ball(graphicsDevice, Content);
            stageScreen = screen;
            background = new Background(graphicsDevice, content);
            time = new Time(graphicsDevice, content, 10, 10);
            score = new Score(graphicsDevice, content, 10, 10);
            b.isActivated = true;
            balls.Add(b);
            GenerateStage();
        }

        internal void SetSpriteBatch(SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }

        private void GenerateStage()
        {
            Rectangle lastBrickPosition = stageScreen;
            lastBrickPosition.X += 20;
            lastBrickPosition.Y += 50;
            stageScreen.X = lastBrickPosition.X;
            stageScreen.Y = lastBrickPosition.Y;


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

            Rectangle lastPaddlePosition = new Rectangle(5, 20, 0, 0);
            for (int i = 0; i < lives.Capacity; i++)
            {
                lives.Add(new Health(graphicsDevice, content,
                    lastPaddlePosition.X, lastPaddlePosition.Y));
                lastPaddlePosition.X += lives[i].Width + 5;
            }
        }

        #region Drawing Elements

        internal void DrawElements()
        {
            spriteBatch.Begin();
            DrawBackground();
            DrawPaddle();
            DrawBricks();
            DrawBalls();
            DrawTime();
            DrawScore();
            DrawLives();
            spriteBatch.End();
        }

        private void DrawBackground()
        {
            background.Draw(spriteBatch);
        }

        private void DrawLives()
        {
            foreach (var life in lives)
            {
                life.Draw(spriteBatch);
            }
        }

        private void DrawScore()
        {
            score.Draw(spriteBatch);
        }

        private void DrawTime()
        {
            time.Draw(spriteBatch);
        }


        private void DrawBalls()
        {
            foreach (var ball in balls)
            {
                if (ball.isActivated)
                {
                    ball.Draw(spriteBatch);
                }
            }
        }

        private void DrawBricks()
        {
            for (int i = 0; i < bricks.GetLength(0); i++)
            {
                for (int j = 0; j < bricks.GetLength(1); j++)
                {
                    if (bricks[i,j].powerUp != null)
                    {
                        bricks[i, j].powerUp.Draw(spriteBatch);
                    }
                    if (!bricks[i, j].isDestroyed)
                    {
                        bricks[i, j].Draw(spriteBatch);
                        if (bricks[i,j] != null && bricks[i,j].powerUp != null)
                        {
                            if (bricks[i,j].powerUp.isActivated )
                            {
                                bricks[i, j].powerUp.Draw(spriteBatch);
                            }
                            
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
        public void UpdateElements()
        {
            ReadGesture();
            UpdateBall();
            UpdateBricks();
        }

        private void UpdateBall()
        {
            foreach (var ball in balls)
            {
                if (ball.isSticked)
                {
                    if (GameGesture.IsDoubleTapped())
                    {
                        ball.isSticked = false;
                        ball.xDirection = -1;
                        ball.yDirection = -1;
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
            
        }

        private void UpdateBricks()
        {
            for (int i = 0; i < bricks.GetLength(0); i++)
            {
                for (int j = 0; j < bricks.GetLength(1); j++)
                {
                    bricks[i, j].Move();
                    if (bricks[i,j].powerUp != null)
                    {
                        balls.First().Speed = (paddle.injuredCount + 2)*2;
                        bricks[i, j].powerUp.Move();
                    }
                    
                }
            }
        }

        private static void UpdatePaddleLeft()
        {
            paddle.GoRight();
        }
        private static void UpdatePaddleRight()
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
                foreach (var ball in balls)
                {
                    if (ball.PositionRectangle.Intersects(brick.PositionRectangle))
                    {
                        if (!brick.isDestroyed)
                        {
                            musicPlayer.PlayBrickBall();
                            CheckBrickSideCollusion(ball, ball.PositionRectangle, brick.PositionRectangle);
                            brick.isDestroyed = true;
                            score.score += 100;
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
                }
                if (brick.powerUp!= null)
                {
                    if (paddle.PositionRectangle.Intersects(brick.powerUp.PositionRectangle))
                    {
                        paddle.injuredCount++;
                        brick.powerUp.isActivated = false;
                        brick.powerUp = null;
                        paddle.PositionRectangle.Width /= 2;
                        paddle.Width /= 2;

                    }
                }
                
            }
        }


        private void CheckBrickSideCollusion(Ball ball, Rectangle ballRectangle, Rectangle brickRectangle)
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
            foreach (var ball in balls)
            {
                if (ball.PositionRectangle.X >= screen.Width - ball.Width)
                {
                    ball.xDirection *= -1;
                }
            }
        }

        private void CheckBallScreenCollision()
        {
            foreach (var ball in balls)
            {
                if (ball.PositionRectangle.X <= 0)
                {
                    ball.xDirection *= -1;
                }
            }
        }

        private void CheckTopScreenCollision()
        {
            foreach (var ball in balls)
            {
                if (ball.PositionRectangle.Y <= stageScreen.Y)
                {
                    ball.yDirection *= -1;
                }
            }
        }

        private void CheckBottomScreenCollision()
        {
            
                if (balls.First().PositionRectangle.Y >= screen.Height)
                {
                    if (lives.Count == 0)
                    {
                        IAsyncResult result = Guide.BeginShowMessageBox(
                            "Hiç canınız kalmadı!",
                            "Skorunuz: " + score.score,
                            new string[] { "Tamam" },
                            0,
                            Microsoft.Xna.Framework.GamerServices.MessageBoxIcon.Warning,
                            null,
                            null);
                        //int? choice = Microsoft.Xna.Framework.GamerServices.Guide.EndShowMessageBox(result);
                        //if (choice.HasValue)
                        //{
                        //    balls.First().MoveWithPaddle(paddle.PositionRectangle);
                        //    UpdateBall();
                        //}
                    }
                    else
                    {
                        lives.Remove(lives.Last());
                        IAsyncResult result = Guide.BeginShowMessageBox(
                            "Canlarınızdan biri gitti!",
                            "Dikkatli olun, böyle giderse oyunu kaybedeceksiniz.",
                            new string[] { "Tamam" },
                            0,
                            Microsoft.Xna.Framework.GamerServices.MessageBoxIcon.Warning,
                            null,
                            null);
                        int? choice = Microsoft.Xna.Framework.GamerServices.Guide.EndShowMessageBox(result);
                        if (choice.HasValue)
                        {
                            balls.First().MoveWithPaddle(paddle.PositionRectangle);
                            UpdateBall();
                        }
                    }
                }
                   
        }
            

        private void CheckPaddleCollision()
        {
            foreach (var ball in balls)
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
        }
        #endregion



        public static void ReadGesture()
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
            LoadTime();
            LoadScore();
            LoadLives();
            LoadBackground();
        }

        private void LoadBackground()
        {
            background.Load();
        }

        private void LoadLives()
        {
            foreach (var life in lives)
            {
                life.Load();
            }
        }

        private void LoadScore()
        {
            score.Load();
        }

        private void LoadTime()
        {
            time.Load();
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
                brick.powerUp.Load();
            }
        }

        private void LoadBall()
        {
            foreach (var ball in balls)
            {
                ball.Load();
            }
        }
        #endregion
    }
}
