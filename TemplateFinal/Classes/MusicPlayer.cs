using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameName2.Classes
{
    public class MusicPlayer
    {
        private SoundEffect brickBallEffect;
        private Microsoft.Xna.Framework.Content.ContentManager Content;

        public MusicPlayer(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            this.Content = Content;
            //brickBallEffect = Content.Load<SoundEffect>("woop");
        }

        internal void PlayBrickBall()
        {
            //brickBallEffect.Play();
        }
    }
}
