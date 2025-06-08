using PEngine.Engine.DI;
using PEngine.Engine.Log;

namespace PEngine.Engine.Core;

public class EngineCore : IEngineCore
{
    private ILogger _logger;
    private IDiContainer _diContainer;

    public void Initialize(ref IDiContainer diContainer)
    {
        _diContainer = diContainer;
        _logger = _diContainer.Get<ILogger>();
        _logger.LogInfo(this, "Default engine core has just initialized.");
    }
}