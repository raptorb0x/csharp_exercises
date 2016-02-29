using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Fight_game
{
    class Animation
    {
        // Изображение со спрайтами анимации
        Texture2D spriteStrip;

        // шкала для отображения спрайтов 
        float scale;

        // Время с последнего обновления  фрейма
        int elapsedTime;

        // Время отображения фрейма
        int frameTime;

        // Число фреймов, которое содежит анимация
        int frameCount;

        // Индекс нынешнего фрейма
        int currentFrame;

        // Цвет фрейма
        Color color;

        // Зона для отображения с полоски 
        Rectangle sourceRect = new Rectangle();

        // Зона куда отображать
        Rectangle destinationRect = new Rectangle();

        // Ширина фрейма
        public int FrameWidth;

        // Высота Фрейма
        public int FrameHeight;

        // Состояние анимации
        public bool Active;

        // Повтор анимации
        public bool Looping;

        // Положение фрейма
        public Vector2 Position;

        public void Initialize(Texture2D texture, Vector2 position,
            int frameWidth, int frameHeight, int frameCount,
             int frametime, Color color, float scale, bool looping)
        {
            // Сохраняем локальные копии полученных данных
            this.color = color;
            this.FrameWidth = frameWidth;
            this.FrameHeight = frameHeight;
            this.frameCount = frameCount;
            this.frameTime = frametime;
            this.scale = scale;

            Looping = looping;
            Position = position;
            spriteStrip = texture;

            // Обнуляем время
            elapsedTime = 0;
            currentFrame = 0;

            // Включаем анимацию
            Active = true;
        }
        public void Update(GameTime gameTime)
        {
            // Если неактивно то ничего не делаем
            if (Active == false)
                return;

            // Изменяем игровое время
            elapsedTime += (int)gameTime.ElapsedGameTime.TotalMilliseconds;

            // Если время прошло больше чем мы отображаем один фрейм
            // нужно отобразить новый
            if (elapsedTime > frameTime)
            {
                //Дигаемся на след фрейм
                currentFrame++;

                // Если дошли до конца идем на начало
                if (currentFrame == frameCount)
                {
                    currentFrame = 0;
                    //Если анимация играем только раз, то деактивируем её
                    if (Looping == false)
                    {
                        Active = false;
                        
                    }
                }

                // J,yekztv dhtvz jnj,hf;tybz ahtqvf
                elapsedTime = 0;
            }

            // Берем необходимый фрейм из плоски умножая номер нынышнего фрейма на ширину фрейма
            sourceRect = new Rectangle(currentFrame * FrameWidth, 0, FrameWidth, FrameHeight);
            destinationRect = new Rectangle((int)Position.X,
            (int)Position.Y ,
            (int)(FrameWidth * scale),
            (int)(FrameHeight * scale));
        }
        public void Draw(SpriteBatch spriteBatch,bool isLeft)
        {
            if(Active)
            {
                spriteBatch.Draw(spriteStrip, destinationRect, sourceRect, color, 0f, Vector2.Zero, 
                    (isLeft) ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0f);
            }
        }
    }
}
