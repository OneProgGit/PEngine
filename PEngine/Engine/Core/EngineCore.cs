using System.Diagnostics;
using PEngine.Engine.Component_System;
using PEngine.Engine.Data;
using PEngine.Engine.DI;
using PEngine.Engine.Log;
using PEngine.Engine.Module_System;

namespace PEngine.Engine.Core;

public class EngineCore : IEngineCore
{
    private ILogger _logger;
    private IDiContainer _diContainer;

    private IRenderModule _renderModule;
    private IPhysicsModule _physicsModule;
    private IUiModule _uiModule;
    
    private GameContext _gameContext;

    public void Initialize(ref IDiContainer diContainer)
    {
        _diContainer = diContainer;
        _logger = _diContainer.Get<ILogger>();
        _logger.LogInfo(this, "Default engine core has just initialized.");
        _renderModule = null;
        _physicsModule = null;
        _uiModule = null;
        _logger.LogWarning(this, "No modules loaded.");
        
        // You can add your game objects here
        GameObject exampleObject = new GameObject();
        exampleObject.Initialize("Bublik");
        _gameContext = _diContainer.Get<DataContext>().GameContext;
        _gameContext.GameObjects["Bublik"] = exampleObject;
        
        StartUpdateCycle();
    }

    public void StartUpdateCycle()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        double targetFrameRate = _diContainer.Get<DataContext>().EngineContext.TargetFrameRate;
        double frameTime = 1000.0 / targetFrameRate;
        double deltaTime = frameTime;

        while (true)
        {
            // TODO: What the hell is here??
            
            var start = stopWatch.Elapsed.TotalMilliseconds;
            
            Update(deltaTime);
            
            var elapsed = stopWatch.Elapsed.TotalMilliseconds - start;
            deltaTime = frameTime - elapsed;
            if (deltaTime > 0)
            {
                Thread.Sleep((int)deltaTime);
            }
        }
    }

    public void Update(double deltaTime)
    {
        _renderModule.Update(deltaTime);
        _physicsModule.Update(deltaTime);
        _uiModule.Update(deltaTime);

        // TODO: Make update yoooo
    }
}