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

namespace Simple_Xna_game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //объ€вл€ем текстуры
        private Texture2D Wolf_LL;
        private Texture2D Wolf_LU;
        private Texture2D Wolf_RL;
        private Texture2D Wolf_RU;
        private Texture2D Background;

        //объ€вл€ем шрифт
        private SpriteFont font;

        private int score = 0;
        private int Wolf_state = 0;
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //подгружаем в текстуры ресурсы
            Wolf_LL = Content.Load<Texture2D>("Wolf_LL");
            Wolf_LU = Content.Load<Texture2D>("Wolf_LU");
            Wolf_RL = Content.Load<Texture2D>("Wolf_RL");
            Wolf_RU = Content.Load<Texture2D>("Wolf_RU");

            Background = Content.Load<Texture2D>("fone");

            //подгружаем шрифт
            font = Content.Load<SpriteFont>("score");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            //score++;


            //—павн €йца

            //ƒвижение €иц - провер€ем поймал - не поймал
            //не поймал лишаем жизни 
            //поймал + в очки


            //перемещени€ игрока
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.Q))
                Wolf_state = 0;
            if (state.IsKeyDown(Keys.A))
                Wolf_state = 1;
            if (state.IsKeyDown(Keys.E))
                Wolf_state = 2;
            if (state.IsKeyDown(Keys.D))
                Wolf_state = 3;
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here


            //начало использовани€ spritebatch
            spriteBatch.Begin();

            // помещаем в него тестуры
            spriteBatch.Draw(Background, new Rectangle(0, 0, 800, 480), Color.White);


            switch (Wolf_state)
            {
                case 0: { spriteBatch.Draw(Wolf_LU, new Vector2(300, 200), null, Color.White, 0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0f); break; };
                case 1: { spriteBatch.Draw(Wolf_LL, new Vector2(300, 200), null, Color.White, 0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0f); break; };
                case 2: { spriteBatch.Draw(Wolf_RU, new Vector2(400, 200), null, Color.White, 0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0f); break; };
                case 3: { spriteBatch.Draw(Wolf_RL, new Vector2(400, 200), null, Color.White, 0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0f); break; };
            }
            //рисуем очки
           // spriteBatch.DrawString(font, "Score" + score, new Vector2(100, 100), Color.White );

            //заканчиваем запись
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
