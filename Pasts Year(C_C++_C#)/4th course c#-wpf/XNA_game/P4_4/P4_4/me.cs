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
    public class me : gBaseClass
    {

       
        
        //Количество кадров в изображении
        const int frames = 8;
        //Частота анимации - кадров в секунду
        const int framesPerSec = 10;
        //Текущий кадр для вывода на экран
        int numberOfFrame = 0;
        //Время, в течение которого отображается один кадр
        float timePerFrame;
        //Время, которое прошло с начала отображения текущего кадра
        float totalElapsed;        
        //Прямоугольник для задания позиции кадра в изображении
        Rectangle sprRec;
        //Ширина кадра
        int widthFrame = 30;
        //Прямоугольник, представляющий игровое окно
        Rectangle scrBounds;
        //Скорость, с которой будет перемещаться спрайт
        Game1 sprgame;
        //"Ускорение свободного падения"
        float sprAcceleration = 0.6f;
        //Скорость при падении
        float sprGrAcc = 5;
        //Скорость, с которой объект будет подпрыгивать
        float sprJump = 12;
        //Переменная для хранения количества "жизней" объекта
        int sprScores = 0;
        //Проверка на приземление для исключения nых прыжков
        int isLanded = 0;
        public me(Game1 game, ref Texture2D _sprTexture,
            Vector2 _sprPosition, Rectangle _sprRectangle)
            : base(game, ref _sprTexture, _sprPosition, _sprRectangle)
        {
           
            sprgame = game;
            _sprRectangle =sprRec;
            scrBounds = new Rectangle(0, 0,
                game.Window.ClientBounds.Width,
                game.Window.ClientBounds.Height);
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            timePerFrame = (float)1 / framesPerSec;
            sprRec = new Rectangle(0, 0, 30, 30);
           
            base.Initialize();
        }
        void ChangeFrame(float elpT)
        {
            //Увеличим общее время отображения спрайта на
            //время, прошедшее с последнего вызова процедуры
            totalElapsed += elpT;
            //если общее время отображения спрайта больше времени,
            //выделенного на один спрайт
            if (totalElapsed > timePerFrame)
            {
                //Если номер кадра равен количеству кадров-1
                if (numberOfFrame == frames - 1)
                {
                    //установим номер кадра в 0
                    numberOfFrame = 0;
                }
                //иначе увеличим номер кадра на 1
                else numberOfFrame++;
                //создадим новый прямоугольник
                //Его координата X соответствует координате левого верхнего угла
                //кадра, Y равно 0, длина и ширина всегда равны 30
                this.sprRectangle  = new Rectangle((int)widthFrame * numberOfFrame, 0, 30, 30);
                //сбросим totalElapsed в 0
                totalElapsed = 0;
            }

        }
        public Rectangle getrect()
        {
            return sprRec;
        }
        void Check()
        {
           
            if ((sprPosition.Y > scrBounds.Height - 30)||(IsCollideWithWall()!=null))
            
            {
                Game.Window.Title = "Вы проиграли";             
                this.Dispose();
                
            }
        }
        //Процедуры, которые используются для перемещения объекта в одном из указанных направлений
        void MoveUp(float speed)
        {
            if (isLanded==1)
            {
                
                sprGrAcc = sprJump;
                isLanded = 0;
            }
        }
        void MoveDown(float speed)
        {
            this.sprPosition.Y += speed;
        }
       
        bool IsWallIsInTheBottom()
        {
            

            foreach (gBaseClass spr in Game.Components)
            {

                if (spr.GetType() == (typeof(bild)))
                {
                    if (this.sprPosition.X + 30 >= spr.sprPosition.X &&
                         this.sprPosition.X <= spr.sprPosition.X + spr.sprRectangle.Width &&
                         this.sprPosition.Y  + 30 <= spr.sprPosition.Y+20 &&
                        this.sprPosition.Y  + 30 >= spr.sprPosition.Y-5
                        ) 
                    {
                        
                        this.sprPosition.Y = spr.sprPosition.Y-30 ;
                        return true;
                    }
                }
            }
             return false;

        }
        bool IsCollideWithObject(gBaseClass spr)
        {
            return (this.sprPosition.X + 30 > spr.sprPosition.X &&
                        this.sprPosition.X < spr.sprPosition.X + spr.sprRectangle.Width &&
                        this.sprPosition.Y + 30 > spr.sprPosition.Y);


        }
        void Move()
        {
            KeyboardState kbState = Keyboard.GetState();
            //При нажатии кнопки "Вверх"
            if (kbState.IsKeyDown(Keys.Up))
            { 
                    MoveUp(sprJump);
            }
        }
        gBaseClass IsCollideWithWall()
        {
            foreach (gBaseClass spr in Game.Components)
            {
                if (spr.GetType() == (typeof(bild)))
                {
                    if (IsCollideWithObject(spr)) return spr;
                }
            }
            return null;
        }
        void GoToDown()
        {
            // перемещается вниз
            //при перемещении проверяется столкновение объекта со 
            if(isLanded==0)
            {
                this.sprRectangle = new Rectangle((int)widthFrame * 9, 0, 30, 30);
                MoveDown(-sprGrAcc);
                sprGrAcc -= sprAcceleration ;
            }
            isLanded = 0;
            if (IsWallIsInTheBottom())
            {
                sprGrAcc = 0;
                isLanded = 1;
            }
            if ((sprPosition.Y > scrBounds.Height - 30))
            {
                    
                 isLanded = 1;
                 sprGrAcc = 0;
            }
            }
        
        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            //анимация
            ChangeFrame((float)gameTime.ElapsedGameTime.TotalSeconds);
            //Вызовем процедуру перемещения объекта по клавиатурным командам
            Move();
            //Проверим, не столкнулся или он с чем, если надо исправим его позицию
            Check();
            //Применим к объекту "силу тяжести"
            GoToDown();
            this.sprScores ++;
            Game.Window.Title = "Пробег " + sprScores + " m";
            
            base.Update(gameTime);
        }
        

    }
}
