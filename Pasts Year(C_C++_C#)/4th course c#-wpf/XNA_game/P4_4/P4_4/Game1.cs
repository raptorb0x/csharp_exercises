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

namespace P4_4
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D txtMe;
        Texture2D txtBild;
        public Vector2 newv;
       
        Random randNum;
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
            //Устанавливаем разрешение игрового окна
            //640х512

            graphics.PreferredBackBufferWidth = 600;
            graphics.PreferredBackBufferHeight = 500;
            graphics.ApplyChanges();
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
            Services.AddService(typeof(SpriteBatch), spriteBatch);
            txtMe = Content.Load<Texture2D>("me");
            txtBild = Content.Load<Texture2D>("bilt");
            randNum = new Random();
            AddSprites();
            // TODO: use this.Content to load your game content here
        }
        void AddSprites()
        {
            Components.Add(new GameObj.me(this, ref txtMe, new Vector2(50,graphics.PreferredBackBufferHeight-150), new Rectangle(0, 0, 30, 30)));
            Components.Add(new GameObj.bild(this, ref txtBild, new Vector2(100, graphics.PreferredBackBufferHeight - 112), new Rectangle(0, 0, 447, 400)));
            
        }
        public void buid()
        {
            Components.Add(new GameObj.bild(this, ref txtBild, new Vector2(graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight - 50 - randNum.Next(10, 100)), new Rectangle(0, 0, graphics.PreferredBackBufferWidth - randNum.Next(50, 150), graphics.PreferredBackBufferHeight - 200)));
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

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            base.Draw(gameTime);
            spriteBatch.End();
            
        }
    }
}
