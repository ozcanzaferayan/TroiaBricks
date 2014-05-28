using System;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Devices.Sensors;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using GameName2.Classes;

namespace TemplateFinal
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //private SoundEffect effect;
        Register register;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            register = new Register(GraphicsDevice, Content);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            register.SetSpriteBatch(spriteBatch);
            register.LoadContent();
        }
        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            register.UpdateElements();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            register.DrawElements();
            register.CheckCollision();
            base.Draw(gameTime);
        }
    }

    //#region Original
    ///// <summary>
    ///// This is the main type for your game
    ///// </summary>
    //public class Game1 : Game
    //{
    //    GraphicsDeviceManager _graphics;
    //    SpriteBatch _spriteBatch;

    //    private Texture2D monsterTex;
    //    private Vector2 monsterPosition;
    //    private Vector2 monsterSpeed = Vector2.Zero;


    //    //Change this depending on your WP8 device (don't forget to add the supported resolution in the project's WMAppManifest.xml file)
    //    //Possible resolutions are 800x480(wvga), 1280x768(wxga), 1280x720(720p)

    //    private int screenHeight = 800;
    //    private int screenWidth = 480;

    //    Accelerometer accelSensor;
    //    Vector3 accelReading = new Vector3();
    //    private bool accelActive = false;

    //    public Game1()
    //    {
    //        _graphics = new GraphicsDeviceManager(this);
    //        Content.RootDirectory = "Content";
    //    }

    //    /// <summary>
    //    /// Allows the game to perform any initialization it needs to before starting to run.
    //    /// This is where it can query for any required services and load any non-graphic
    //    /// related content.  Calling base.Initialize will enumerate through any components
    //    /// and initialize them as well.
    //    /// </summary>
    //    protected override void Initialize()
    //    {
    //        monsterPosition = new Vector2(screenWidth / 2.0f-40, screenHeight - 80);
    //        monsterSpeed.Y = -25;
    //        accelSensor = new Accelerometer();

    //        // Add the accelerometer event handler to the accelerometer sensor.
    //        accelSensor.ReadingChanged +=
    //            new EventHandler<AccelerometerReadingEventArgs>(AccelerometerReadingChanged);

    //        try
    //        {
    //            accelSensor.Start();
    //            accelActive = true;
    //        }
    //        catch (AccelerometerFailedException e)
    //        {
    //            // the accelerometer couldn't be started.  No fun!
    //            accelActive = false;
    //        }
    //        catch (UnauthorizedAccessException e)
    //        {

    //            accelActive = false;
    //        }




    //        base.Initialize();
    //    }

    //    public void AccelerometerReadingChanged(object sender, AccelerometerReadingEventArgs e)
    //    {
    //        accelReading.X = (float)e.X;
    //        accelReading.Y = (float)e.Y;
    //        accelReading.Z = (float)e.Z;
    //    }

    //    /// <summary>
    //    /// LoadContent will be called once per game and is the place to load
    //    /// all of your content.
    //    /// </summary>
    //    protected override void LoadContent()
    //    {
    //        // Create a new SpriteBatch, which can be used to draw textures.
    //        _spriteBatch = new SpriteBatch(GraphicsDevice);
    //        monsterTex = Content.Load<Texture2D>("monster");

    //    }



    //    /// <summary>
    //    /// UnloadContent will be called once per game and is the place to unload
    //    /// all content.
    //    /// </summary>
    //    protected override void UnloadContent()
    //    {
    //        // TODO: Unload any non ContentManager content here
    //    }

    //    /// <summary>
    //    /// Allows the game to run logic such as updating the world,
    //    /// checking for collisions, gathering input, and playing audio.
    //    /// </summary>
    //    /// <param name="gameTime">Provides a snapshot of timing values.</param>
    //    protected override void Update(GameTime gameTime)
    //    {
    //        // TODO: Add your update logic here
    //        monsterPosition += monsterSpeed;
    //        monsterSpeed.Y += 0.5f;
    //        if (monsterPosition.Y>screenHeight - 80)
    //        {
    //            monsterPosition.Y = screenHeight - 80;
    //            monsterSpeed.Y = -25;
    //        }

    //        if (accelActive)
    //        {

    //            monsterSpeed.X = accelReading.X * 50f;

    //        }

    //        if (monsterPosition.X>screenWidth)
    //        {
    //            monsterPosition.X = -80;
    //        }
    //        else
    //            if (monsterPosition.X <-80)
    //            {
    //                monsterPosition.X = screenWidth;
    //            }
    //        base.Update(gameTime);
    //    }

    //    /// <summary>
    //    /// This is called when the game should draw itself.
    //    /// </summary>
    //    /// <param name="gameTime">Provides a snapshot of timing values.</param>
    //    protected override void Draw(GameTime gameTime)
    //    {
    //        GraphicsDevice.Clear(Color.CornflowerBlue);


    //        int Yoffset = monsterSpeed.Y > 0 ? 0 : 80;
    //        // TODO: Add your drawing code here
    //        _spriteBatch.Begin();
    //        _spriteBatch.Draw(monsterTex, monsterPosition,new Rectangle(0, Yoffset, 80, 80), Color.White);
    //        _spriteBatch.End();
    //        base.Draw(gameTime);
    //    }
    //}
    //#endregion
}
