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

    public class gBaseClass : Microsoft.Xna.Framework.DrawableGameComponent
    {
        Texture2D sprTexture;
        public Vector2 sprPosition;
        public Rectangle sprRectangle;
        public gBaseClass(Game game, ref Texture2D _sprTexture,
            Vector2 _sprPosition, Rectangle _sprRectangle)
            : base(game)
        {
            sprTexture = _sprTexture;
            //Именно здесь производится перевод индекса элемента массива
            //в координаты на игровом экране
            sprPosition = _sprPosition;
            sprRectangle = _sprRectangle;
        }


        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            SpriteBatch sprBatch =(SpriteBatch)Game.Services.GetService(typeof(SpriteBatch));
           foreach (gBaseClass spr in Game.Components)
               if (spr.GetType() == (typeof(bild)))
               {
                   sprBatch.Draw(sprTexture, sprPosition, sprRectangle, Color.White);
                  
               }
           base.Draw(gameTime);
        }
    }
}