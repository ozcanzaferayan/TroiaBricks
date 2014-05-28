using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameName2.Classes
{
    public class GameGesture
    {
        public enum GestureMoves
        {
            Left, Top, Right, Bottom, Null
        }

        internal static GestureMoves ReadGesture()
        {
            var touchCol = TouchPanel.GetState();
            

            foreach (var touch in touchCol)
            {

                TouchLocation prevLoc;

                // Sometimes TryGetPreviousLocation can fail. Bail out early if this happened
                // or if the last state didn't move
                if (!touch.TryGetPreviousLocation(out prevLoc) || prevLoc.State != TouchLocationState.Moved)
                    continue;
                //touch.TryGetPreviousLocation(out prevLoc);
                // get your delta
                var delta = touch.Position - prevLoc.Position;

                if (delta.X < 0 || delta.Y < 0)
                    return GestureMoves.Right;

                if (delta.X > 0 || delta.Y > 0)
                    return GestureMoves.Left;
            }
            return GestureMoves.Null;
        }

        internal static bool IsDoubleTapped()
        {
            TouchPanel.EnabledGestures = GestureType.Tap;
            while (TouchPanel.IsGestureAvailable)
            {
                GestureSample gs = TouchPanel.ReadGesture();
                switch (gs.GestureType)
                {
                    case GestureType.Tap:
                        return true;
                    default: 
                        break;
                }
            }
            return false;
        }

        //internal static GestureMoves ReadGesture()
        //{
        //    var gesture = default(GestureSample);

        //    while (TouchPanel.IsGestureAvailable)
        //    {
        //        gesture = TouchPanel.ReadGesture();

        //        if (gesture.GestureType == GestureType.DragComplete)
        //        {
        //            if (gesture.Delta.Y < 0 || gesture.Delta.X < 0)
        //                return GestureMoves.Left;
        //            else if (gesture.Delta.Y > 0 || gesture.Delta.X > 0)
        //                return GestureMoves.Right;
        //        }
        //    }
        //    return GestureMoves.Null;
        //}
    }
}
