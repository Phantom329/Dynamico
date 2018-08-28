using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace HammerGander
{
    public class Player 
    {

        // Variables
        public Texture2D texture;
        public Vector2 position, facing;
        public int speed, health;

        // Rektangle
        public Rectangle boundingBox;

        // Constructor
        public Player()
        {
            texture = null;
            position = new Vector2(300, 300);
            speed = 5;
        }

        // Load Content
        public void LoadContent(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("graphics/ship");
        }

        // Update
        public void Update(GameTime gameTime)
        {

            // Getting Keyboard State / Input
            KeyboardState keyState = Keyboard.GetState();

            boundingBox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);

            if (keyState.IsKeyDown(Keys.W) || keyState.IsKeyDown(Keys.Up))
            {
                position.Y = position.Y - speed;
            }

            if (keyState.IsKeyDown(Keys.A) || keyState.IsKeyDown(Keys.Left))
            {
                position.X = position.X - speed;
            }

            if (keyState.IsKeyDown(Keys.S) || keyState.IsKeyDown(Keys.Down))
            {
                position.Y = position.Y + speed;
            }

            if (keyState.IsKeyDown(Keys.D) || keyState.IsKeyDown(Keys.Right))
            {
                position.X = position.X + speed;
            }

            // Keeping the player on the screen
            if (position.X <= 0) position.X = 0;
            if (position.X >= 800 - texture.Width) position.X = 800 - texture.Width;
            if (position.Y <= 0) position.Y = 0;
            if (position.Y >= 600 - texture.Height) position.Y = 600 - texture.Height;
        }
                
        // Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
