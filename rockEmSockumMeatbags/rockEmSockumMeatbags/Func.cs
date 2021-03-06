﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace rockEmSockumMeatbags
{
    class Func
    {
        public delegate void F<T>(T x);
        public static void safeDraw(SpriteBatch spriteBatch, Action f)
        {
            spriteBatch.Begin();
            f();
            spriteBatch.End();
        }
        public static F<Action> getDrawFunc(SpriteBatch spriteBatch) {
            return (f) =>
            {
                spriteBatch.Begin();
                f();
                spriteBatch.End();
            };
        }
    }
}
