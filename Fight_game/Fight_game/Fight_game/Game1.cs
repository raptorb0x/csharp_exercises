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

namespace Fight_game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Игрок
        Player player;

        Texture2D target;

        //Состояния клавиатуры для опеределния нажатий клавиши
        KeyboardState currentKeyboardState;
        KeyboardState previousKeyboardState;

        Blood blood;
         
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

            //Инициализурием игрока
            player = new Player();

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
            Animation playerAnimation = new Animation();
            playerAnimation.Initialize(Content.Load<Texture2D>("walk"), Vector2.Zero, 60, 100, 6, 30, Color.White, 1f,true);
            //Позиция игрока
            Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            //Загружаем игрока
            player.Initialize(Content.Load<Texture2D>("base"),Content.Load<Texture2D>("punch"),playerAnimation,playerPosition);

            target = Content.Load<Texture2D>("target");

            List<Texture2D> textures = new List<Texture2D>();
            textures.Add(Content.Load<Texture2D>("blood"));
            blood = new Blood(textures, new Vector2(430, 350));
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
            //Сохроняем прошлое состояние клавиатуры 
            previousKeyboardState = currentKeyboardState;
            //получаем новое
            currentKeyboardState = Keyboard.GetState();

            player.Update(gameTime,currentKeyboardState, previousKeyboardState, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);

            UpdatePunch();
            blood.Update();

            base.Update(gameTime);
        }

        private void UpdatePunch()
        {
            Rectangle rectangle1;
            Rectangle rectangle2;
            rectangle1 = new Rectangle((int)player.Position.X, (int)player.Position.Y, player.Width, player.Height);
            rectangle2 = new Rectangle(400, 300, 60, 100);
            if (rectangle1.Intersects(rectangle2))
            {
                if(player.isPunch)
                {
                    //blood.EmitterLocation = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
                    blood.addParticle();
                }
            }
        }
        

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            //начинаем рисование
            spriteBatch.Begin();

            //рисуем игрока
            player.Draw(spriteBatch);

            spriteBatch.Draw(target, new Vector2(400,300), Color.White);
            //Заканчиваем рисование
            blood.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
