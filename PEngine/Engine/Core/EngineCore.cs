using System.Diagnostics;
using PEngine.Engine.Data;
using PEngine.Engine.DI;
using PEngine.Engine.Log;
using PEngine.Engine.Module_System;

namespace PEngine.Engine.Core;

public class EngineCore : IEngineCore
{
    private ILogger _logger;
    private IDiContainer _diContainer;

    private List<IEngineModule> _modules;

    public void Initialize(ref IDiContainer diContainer)
    {
        _diContainer = diContainer;
        _logger = _diContainer.Get<ILogger>();
        _logger.LogInfo(this, "Default engine core has just initialized.");
        // There you can add your modules
        _modules = new List<IEngineModule>();
        // Uncomment to see how it works on example
        _modules.Add(new ExampleModule());
        foreach (IEngineModule module in _modules)
        {
            module.Initialize(ref _diContainer);
        }

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
        foreach (IEngineModule module in _modules)
        {
            module.Update(deltaTime);
        }   
    }
}