using Collisions.Application.Tool;
using Collisions.Application.Creator;
using Collisions.Domain;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Collisions;

public class Game1 : Game
{
    private Color backgroundColor;
    private List<Circle> circlesList;
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        backgroundColor = ColorCreator.New();
        Content.RootDirectory = "content";
    }

    protected override void Initialize()
    {
        circlesList = CirclesList.New();
        Circles.Initialize(circlesList);
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        Circles.LoadContent(circlesList, Content);
    }

    protected override void Update(GameTime gameTime)
    {
        Circles.Update(circlesList, _graphics);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(backgroundColor);
        Circles.Draw(circlesList, _spriteBatch);
        base.Draw(gameTime);
    }
}
