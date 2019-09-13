using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Template
{
    class Box
    {
        Vector2 position;
        Texture2D texture;
        Rectangle plattan;
        public Box(Texture2D texture, Vector2 position)
        {
            this.position = position;
            this.texture = texture;
            plattan = new Rectangle((int)position.X, (int)position.Y, 300, 50);

        }
        public void Draw( SpriteBatch spriteBatch)
        {            
           spriteBatch.Draw(texture, plattan, Color.Green);
        }
    }
}
