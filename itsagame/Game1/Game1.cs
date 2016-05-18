using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;


        //Different game states
        public enum GameState { Title, Collect, Boss, Pause, End };
        GameState gamestate = GameState.Title;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();



            if (gamestate == GameState.Title)
            {
                Shortcut shortcut = new Shortcut();
                gamestate =  shortcut.PerformShortcut(gamestate);
            }

            if (gamestate == GameState.Collect)
            {
                Shortcut shortcut = new Shortcut();
                gamestate = shortcut.PerformShortcut(gamestate);
            }

            if (gamestate == GameState.Pause)
            {
                Shortcut shortcut = new Shortcut();
                gamestate = shortcut.PerformShortcut(gamestate);
            }

            if (gamestate == GameState.Boss)
            {
                Shortcut shortcut = new Shortcut();
                gamestate = shortcut.PerformShortcut(gamestate);
            }

            if (gamestate == GameState.End)
            {
                Shortcut shortcut = new Shortcut();
                gamestate = shortcut.PerformShortcut(gamestate);
            }

            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

            if (gamestate == GameState.Title)
            {
                GraphicsDevice.Clear(Color.Blue);
            }

            if (gamestate == GameState.Collect)
            {
                GraphicsDevice.Clear(Color.Red);
            }

            if (gamestate == GameState.Pause)
            {
                GraphicsDevice.Clear(Color.Gray);
            }

            if (gamestate == GameState.Boss)
            {
                GraphicsDevice.Clear(Color.Purple);
            }

            if (gamestate == GameState.End)
            {
                GraphicsDevice.Clear(Color.Black);
            }
           

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
