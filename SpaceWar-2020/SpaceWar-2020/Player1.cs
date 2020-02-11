using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace SpaceWar_2020
{
    class Player1 : GameObject
    {
        //Knapptryckningar
        KeyboardState oldState;
        KeyboardState newState;


        //Konstruktor
        public Player1(Texture2D texture, Vector2 startPosition) : base(texture, startPosition)
        {
          //  velocity = new Vector2(3, -1);
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
                    position.Y = 500;
                }
                //Minsta Y väggen
                else
                {
                    if (position.Y > 500 + texture.Height)
                    {
                        position.Y = 0 - texture.Height;
                    }
                }
            }

            float MaxVelocity = 2.0f;
            position += velocity;

            if (newState.IsKeyDown(Keys.W))
            {
                velocity.Y -= 0.25f;
            }
            if (newState.IsKeyDown(Keys.A))
            {
                velocity.X -= 0.25f;
            }
            if (newState.IsKeyDown(Keys.S))
            {
                velocity.Y -= -0.25f;
            }
            if (newState.IsKeyDown(Keys.D))
            {
                velocity.X += 0.25f;
            }
            if (newState.IsKeyDown(Keys.X))
            {
                // Lägga till en projektil till tangenten X.
            }
            if (velocity.X > MaxVelocity)
            {
                velocity.X = MaxVelocity;
            }
            if (velocity.X > -MaxVelocity)
            {
                velocity.X = MaxVelocity;
            }
            oldState = newState;
        }
    }
}

