using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWar_2020
{
    class Dumpdisposal : Gameobject
    {
        Vector2 dumpPosition;
        Vector2 dumpVelocity;

        public Dumpdisposal(Texture2D dumpTexture, float X, float Y) : base(dumpTexture, X, Y, 0, 3f)
        {

        }

        public Rectangle Hitbox
        {
            get
            {
                Rectangle hitbox = new Rectangle();
                hitbox.Height = texture.Height;
                hitbox.Width = texture.Width;
                hitbox.X = (int)dumpPosition.X;
                hitbox.Y = (int)dumpPosition.Y;

                return hitbox;
            }
        }

        public void Update()
        {
            dumpPosition.Y -= dumpVelocity.Y;
            if (dumpPosition.Y < 0)
                isAlive = false;
        }
    }

}
}
