using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWar_2020
{
    //Basklass för synliga objekt i spelet
    abstract class GameObject
    {
        protected Texture2D texture;
        protected Vector2 position, velocity;

        //Konstruktor
        public GameObject(Texture2D texture, Vector2 startPosition)
        {
            this.texture = texture;
            position = startPosition;
        }

        public void Update()
        {
            position += velocity;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }






























        //abstract


    }
}

