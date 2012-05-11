using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class MacGame : Game {
    private GraphicsDeviceManager graphics;

    public MacGame() {
        graphics = new GraphicsDeviceManager (this);
        Content.RootDirectory = "Content";
    }

    protected override void Initialize () {
        graphics.PreferredBackBufferWidth = 1280;
        graphics.PreferredBackBufferHeight = 720;
        graphics.ApplyChanges();

        base.Initialize();
    }

    protected override void Draw(GameTime gameTime) {
        graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
    }
}
