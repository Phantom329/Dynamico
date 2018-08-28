using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HammerGander
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    
    // Main
    public class Game1 : Game
    {
        
        //State Enum
        /*public enum State
        {
            MainMenu,
            Playing
        }*/

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;


        // Instatiate classes
        Player p = new Player();

        //Sets first gamestate to "Playing"
        //State gameState = State.Playing;

        // Constructor
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 480;
        }

        protected override void Initialize()
        {
            
            base.Initialize();
        }
               
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            p.LoadContent(Content);
        }

        
        protected override void UnloadContent()
        {

        }

               protected override void Update(GameTime gameTime)
        {
            //Remove once we get memus working
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            p.Update(gameTime);

            /*switch(gameState)
            {
                case State.Playing:
                    {

                    }
            }*/

            base.Update(gameTime);
        }
       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            p.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
