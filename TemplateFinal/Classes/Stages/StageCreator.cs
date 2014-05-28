using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameName2.Classes.Stages
{
    class StageCreator
    {

        internal static void CreateStage1(Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice, 
            Microsoft.Xna.Framework.Content.ContentManager content, 
            Microsoft.Xna.Framework.Rectangle screen)
        {
            Stage1.CreateBricks(graphicsDevice, content, screen);
            Stage1.CreateBall(graphicsDevice, content, screen);
            Stage1.CreatePaddle(graphicsDevice, content, screen);
        }

        internal static void LoadContent()
        {
            Stage1.LoadBall();
            Stage1.LoadBrick();
            Stage1.LoadPaddle();
        }

        internal static void DrawElements()
        {
            
        }

        internal static void UpdateElements()
        {
            Stage1.UpdateBall();
            Stage1.UpdatePaddle();
            //Stage1.UpdateBricks();
        }

        internal static void DrawElements(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            Stage1.DrawBall();
            Stage1.DrawBricks();
            Stage1.DrawPaddle();
        }
    }
}
