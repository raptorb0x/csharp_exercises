using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace P4_4.GameObj
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class bild : gBaseClass
    {
        Game1 sprgame;
        Random randNum;
       
        public bild(Game1 game, ref Texture2D _sprTexture,
            Vector2 _sprPosition, Rectangle _sprRectangle)
            : base(game, ref _sprTexture, _sprPosition, _sprRectangle)
        {
            sprgame = game;
            randNum = new Random();
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
       
       
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            
            base.Initialize();
        }
        void clear()
        {
            gBaseClass FindObj = null;
            foreach (gBaseClass spr in Game.Components)
            {

                if (spr.GetType() == (typeof(bild)))
                {

                    if (spr.sprPosition.X + spr.sprRectangle.Width  <= 0)
                    {
                        FindObj = spr;

                    }
                }
            }
            if (FindObj != null)
            {
                FindObj.Dispose();
                FindObj = null;
            }
        }
       
        void newbild()
        {
            bool ok=true;
            
                foreach (gBaseClass spr in Game.Components)
                {

                    if (spr.GetType() == (typeof(bild)))
                    {
                        if (spr.sprPosition.X + spr.sprRectangle.Width >= sprgame.Window.ClientBounds.Width - randNum.Next(200,300))
                        {
                            ok = false;
                        }
                    }
                }

                if (ok)
                {
                    sprgame.buid();
                }
            
        }
        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            this.sprPosition.X-=10;
            
            
            clear();
            newbild();
            
            base.Update(gameTime);
            

        }
       
    }
}
