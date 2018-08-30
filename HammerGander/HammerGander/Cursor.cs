using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammerGander
{
    class Cursor
    {
        // Variables
        public Texture2D texture;
        public Vector2 position, offset;

        // Constructor
        public Cursor()
        {
            texture = null;
            position = new Vector2(0,0);
            offset = new Vector2(0, 0);
        }

        // Load Content
        public void LoadContent(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("graphics/cursor1");
            offset.X = texture.Bounds.Center.X;
            offset.Y = texture.Bounds.Center.Y;
        }

        // Update
        public void Update(GameTime gameTime)
        {
            position.X = Mouse.GetState().X - offset.X;
            position.Y = Mouse.GetState().Y - offset.Y;
        }

        // Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            if (texture != null)
            {
                spriteBatch.Draw(texture, position, Color.White);
            }
        }
    }
}
