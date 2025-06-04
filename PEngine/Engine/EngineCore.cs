namespace PEngine.Engine;

public class EngineCore
{
    public ILogger Logger { get; private set; }

    public EngineCore(ref DataContext dataContext)
    {
        Logger = dataContext.LogContext.Logger;
    }
    
    public void Initialize()
    {
        Logger.LogInfo(this, "Initializing engine");
        Logger.LogWarning(this, "You are stupid");
        Logger.LogError(this, "Fucking errors *%*(");
    }
}