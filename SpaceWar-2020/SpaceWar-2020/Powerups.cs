using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spacewar
{
    class Powerup : GameObject
    {
        //Konstruktor
        public Powerup(Texture2D texture, Vector2 startPosition) : base(texture, startPosition)
        {
            velocity = new Vector2(4, 0);
        }

        public void SpeedUp()
        {

        }

        /*
        game
        List<Powerup> powerups;

        Texture2D powerupTexture;

        int powerupSpawnTime = 5000;

        load content
        powerups = new List<Powerup>();

        powerupTexture = Content.Load<Texture2D>("ball_1");

        update
        if (powerupSpawnTime <= 0)
            {
                powerups.Add(new Powerup(powerupTexture, new Vector2(0, 0)));
                powerupSpawnTime = 5000;
            }

        foreach (Powerup power in powerups)
        {
                power.Update();
        }

        powerupSpawnTime -= gameTime.ElapsedGameTime.Milliseconds;

        draw
        foreach (Powerup power in powerups)
            {
                power.Draw(spriteBatch);
            }

        */
    }
}