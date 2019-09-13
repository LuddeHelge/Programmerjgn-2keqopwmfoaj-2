using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
namespace Template
{
    class Player
    {
        Vector2 position;
        Texture2D texture;
        Vector2 velocity;
        Rectangle Boxen;


        const float GRAVITY = 9.82f;

        public Player(Texture2D texture, Vector2 position)
        {
            this.position = position;
            this.texture = texture;

        }

        public void Update( GameTime gameTime)
        {

            Boxen = new Rectangle((int)position.X, (int)position.Y, 50, 50);
            velocity.Y += GRAVITY * (float)gameTime.ElapsedGameTime.TotalSeconds;

            position += velocity;
        }
        public void Draw( SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Boxen, Color.Red);
        }
    }


}
