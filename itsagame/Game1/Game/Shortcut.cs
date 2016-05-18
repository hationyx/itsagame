using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class Shortcut
    {

        public Game1.GameState PerformShortcut(Game1.GameState OldState)
        {   // lets us skip to different gamestates for testing
            // U - Title
            // I - Collect
            // O - Boss
            // P - Pause
            // Y - End


            Game1.GameState NewState = OldState;

            if (Keyboard.GetState().IsKeyDown(Keys.U))
            {
                NewState = Game1.GameState.Title;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.I))
            {
                NewState = Game1.GameState.Collect;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.O))
            {
                NewState = Game1.GameState.Boss;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.P))
            {
                NewState = Game1.GameState.Pause;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Y))
            {
                NewState = Game1.GameState.End;
            }

            return NewState;
        }
    }
}
