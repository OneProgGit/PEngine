using PEngine.Engine.Core;
using PEngine.Engine.Data;
using PEngine.Engine.DI;
using PEngine.Engine.Log;

// TODO: Implement GUI logger and replace to it
ILogger defaultLogger = new ConsoleLogger();
defaultLogger.Initialize();

DataContext dataContext = new DataContext();
EngineContext engineContext = new EngineContext()
{
    EngineVersion = 1,
    TargetFrameRate = 60.0
};
dataContext.EngineContext = engineContext;

defaultLogger.LogWarning("Main", "GUI logger has not implemented yet.");

IDiContainer diContainer = new DiContainer();
diContainer.Initialize(ref defaultLogger);
diContainer.Register(defaultLogger);
diContainer.Register(dataContext);

EngineCore engine = new EngineCore();
engine.Initialize(ref diContainer);

// Nothing to do more in Program.cs