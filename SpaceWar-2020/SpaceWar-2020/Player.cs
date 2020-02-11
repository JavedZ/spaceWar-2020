using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWar_2020
{
    class Player
    {
        List<Dumpdisposal> projectiles;
        double timeSinceLastShot = 0;
        Texture2D dumpTexture;

        public Player()
        {
            projectiles = new List<Dumpdisposal>();
            this.dumpTexture = dumpTexture;
        }

        public void Update(GameWindow window, GameTime gameTime)
        {
            if (keyboardState.IsKeyDown(Keys.Space))
            {
                if(gameTime.TotalGameTime.TotalMilliseconds > timeSinceLastShot + 200)
                {
                    Dumpdisposal temp = new Dumpdisposal(dumpTexture/*, vector.X + Texture.width / 2, vector.Y*/);
                    projectiles.Add(temp);

                    timeSinceLastShot = gameTime.TotalGameTime.TotalMilliseconds;
                }
            }
        }
    }
}
