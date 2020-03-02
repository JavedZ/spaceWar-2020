using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceWar_2020
{
    class Player2 : GameObject
    {
        //Knapptryckningar
        KeyboardState oldState;
        KeyboardState newState;


        //Konstruktor
        public Player2(Texture2D texture, Vector2 startPosition) : base(texture, startPosition)
        {
           // velocity = new Vector2(3, -1);
        }

        //All spellogik som har med spelaren att göra
        public new void Update()
        {
            newState = Keyboard.GetState();

            //Vänster vägg
            if (position.X < 0 - texture.Width)
            {
                position.X = 1000;
            }
            //Höger vägg
            else
            {
                if (position.X > 1000 + texture.Width)
                {
                    position.X = 0 - texture.Width;
                }
                //Största Y väggen
                if (position.Y < 0 - texture.Height)
                {
                    position.Y = 1000;
                }
                //Minsta Y väggen
                else
                {
                    if (position.Y > 1000 + texture.Height)
                    {
                        position.Y = 0 - texture.Height;
                    }
                }
            }

            position += velocity;

            if (newState.IsKeyDown(Keys.Up))
            {
                velocity.Y -= 0.25f;
            }
            if (newState.IsKeyDown(Keys.Left))
            {
                velocity.X -= 0.25f;
            }
            if (newState.IsKeyDown(Keys.Down))
            {
                velocity.Y -= -0.25f;
            }
            if (newState.IsKeyDown(Keys.Right))
            {
                velocity.X += 0.25f;
            }
            if (newState.IsKeyDown(Keys.NumPad0))
            {
              // Lägga till en projektil till Numpad 0.
            }

            oldState = newState;
        }
    }
}

