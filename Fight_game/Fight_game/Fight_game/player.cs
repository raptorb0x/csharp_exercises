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
    class Player
    {
        //�������� ������
        public Texture2D PlayerTexture;

        //�������� ������ ��� �����
        public Texture2D PunchTexture;

        //�������� ������ 
        public Animation PlayerAnimationMove;

        //������� ������
        public Vector2 Position;
        
        //������� �� �����
        public bool Active;

        //�������� ������
        public int Health;

        //������ ������
        public int Width
        {
            get { return PlayerTexture.Width; }
        }

        //������ ������
        public int Height
        {
            get { return PlayerTexture.Height; }
        }


        //�������� ������
        float playerMoveSpeed;


        bool isMoving;
        public bool isLeft { get; set; }

        public bool isPunch { get; set; }

        //������������� ������
        public void Initialize(Texture2D texture,Texture2D punch,Animation animation, Vector2 position)
        {
            //�������� ��������
            PlayerTexture = texture;
            PunchTexture = punch;

            PlayerAnimationMove = animation;

            //������������� �������� �����������
            playerMoveSpeed = 3.0f;

            //�������� �������
            Position = position;
            //���������� ������
            Active = true;
            //������ ��������
            Health = 100;

            //������� ������� � �����
            isLeft = false;
        }

        public void Update(GameTime gameTime,KeyboardState currentKeyboardState, KeyboardState previousKeyboardState, int X,int Y)
        {
            PlayerAnimationMove.Position = Position;
            PlayerAnimationMove.Update(gameTime);

            //���������� ������
            isMoving = false;
            isPunch = false;

            if (currentKeyboardState.IsKeyDown(Keys.Left))
            {
                Position.X -= playerMoveSpeed;
                isMoving = true;
                isLeft = true;
            }

            if (currentKeyboardState.IsKeyDown(Keys.Right))
            {
                Position.X += playerMoveSpeed;
                isMoving = true;
                isLeft = false;
            }

            if (currentKeyboardState.IsKeyDown(Keys.Down))
            {
                Position.Y += playerMoveSpeed;
                isMoving = true;
            }

            if (currentKeyboardState.IsKeyDown(Keys.Up))
            {
                Position.Y -= playerMoveSpeed;
                isMoving = true;
            }

            if (currentKeyboardState.IsKeyDown(Keys.LeftControl) && isMoving == false && previousKeyboardState.IsKeyUp(Keys.LeftControl))
            {
                isPunch = true;
            }

            //��������� �� ����� �� ������� ������
            Position.X = MathHelper.Clamp(Position.X, 0, X - Width);
            Position.Y = MathHelper.Clamp(Position.Y, 0, Y - Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            //������ ������
            if (isMoving)
            {
                PlayerAnimationMove.Draw(spriteBatch, isLeft);
            }
            else
            {
                //PlayerAnimationMove.Draw(spriteBatch);
                if (isPunch)
                {
                    spriteBatch.Draw(PunchTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f,
                        (isLeft) ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0f);
                }
                else
                {
                    spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f,
                        (isLeft) ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0f);
                }
            }
        }
    }
}