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
        private Texture2D Egg;

        List<Vector2> list = new List<Vector2>();

        //объ€вл€ем шрифт
        private SpriteFont font;

        private int step = 100;
        private int current = 100;

        private int score = 0;
        private int maxscore = 0;
        private int Wolf_state = 0;

        private Random rand;
        private int gameend = 0;

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

            
            //подгружаем в текстуры ресурсы
            Wolf_LL = Content.Load<Texture2D>("Wolf_LL");
            Wolf_LU = Content.Load<Texture2D>("Wolf_LU");
            Wolf_RL = Content.Load<Texture2D>("Wolf_RL");
            Wolf_RU = Content.Load<Texture2D>("Wolf_RU");

            Egg = Content.Load<Texture2D>("whole_egg");

            Background = Content.Load<Texture2D>("fone");

            rand = new Random();

            //подгружаем шрифт
            font = Content.Load<SpriteFont>("score");

            list.Add(new Vector2(0, 0));
            list.Add(new Vector2(0, 0));
            list.Add(new Vector2(0, 0));
            list.Add(new Vector2(0, 0));
            list.Add(new Vector2(0, 0));
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
           
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

            if (score > maxscore) maxscore = score;


            //движение €йца
            step--;
            if (step == 0)
            {
                step = current;

                //двигаем €йца                
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].X == 0) continue;
                    if (list[i].X < 400)
                        list[i] += new Vector2(20, 10);
                    else
                        list[i] += new Vector2(-20, 10);
                }

                //провер€ем на выход за пределы
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].X >= 300 && list[i].X <= 480)
                    //проверка на подхват
                    {
                        //подхват слева
                        if (list[i].X == 300)
                        {
                            if (list[i].Y > 225 && Wolf_state == 1)
                            {
                                score++;
                                current--;
                            }
                            else
                            {
                                if(list[i].Y < 225 && Wolf_state == 0)
                                {
                                    score++;
                                    current--;
                                }
                                else
                                {
                                    score -= 10;
                                }
                            }
                        }
                        
                        //подхват справа
                        if (list[i].X == 480)
                        {
                            if (list[i].Y > 225 && Wolf_state == 3)
                            {
                                score++;
                                current--;
                            }
                            else
                            {
                                if (list[i].Y < 225 && Wolf_state == 2)
                                {
                                    score++;
                                    current--;
                                }
                                else
                                {
                                    score -= 10;
                                }
                            }
                        }

                        list[i] = new Vector2(0, 0);
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].X == 0)
                    {
                        switch (rand.Next(4))
                        {
                            case 0:{ list[i] = new Vector2(220, 170); break; }
                            case 1:{ list[i] = new Vector2(220, 225);break; }
                            case 2:{ list[i] = new Vector2(560, 170); break; }
                            case 3:{ list[i] = new Vector2(560, 225); break; }
                        }
                        break;
                    }
                }

            }

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

            if (score < 0) gameend= 1;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            if (gameend == 1)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(Background, new Rectangle(0, 0, 800, 480), Color.White);
                spriteBatch.DrawString(font, "Game Over!", new Vector2(290, 130), Color.Black);
                spriteBatch.DrawString(font, "Max score " + maxscore, new Vector2(290, 150), Color.Black);
                spriteBatch.End();
            }

            else
            {
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

                //рисуем €йца
                foreach (Vector2 egg_vec in list)
                {
                    if (egg_vec.X == 0) continue;
                    spriteBatch.Draw(Egg, egg_vec, Color.White);
                }
                //рисуем очки
                spriteBatch.DrawString(font, "Score " + score, new Vector2(290, 130), Color.Black);
                spriteBatch.DrawString(font, "Max score " + maxscore, new Vector2(290, 150), Color.Black);


                //заканчиваем запись
                spriteBatch.End();

            }
            base.Draw(gameTime);
        }
    }
}
