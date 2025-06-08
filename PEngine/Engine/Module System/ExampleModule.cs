using PEngine.Engine.DI;
using PEngine.Engine.Log;

namespace PEngine.Engine.Module_System;

public class ExampleModule : IEngineModule
{
    private ILogger _logger;
    
    public void Initialize(ref IDiContainer diContainer)
    {
        _logger = diContainer.Get<ILogger>();
        _logger.LogInfo(this,"Example module has just initialized.");
    }

    public void Update(double deltaTime)
    {
        _logger.LogInfo(this, "Example module is updating.");
    }
}