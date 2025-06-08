using PEngine.Engine.Core;
using PEngine.Engine.DI;
using PEngine.Engine.Log;

// TODO: Implement GUI logger and replace to it
ILogger defaultLogger = new ConsoleLogger();
defaultLogger.Initialize();

defaultLogger.LogWarning("Main", "GUI logger has not implemented yet.");

IDiContainer diContainer = new DiContainer();
diContainer.Initialize(ref defaultLogger);

diContainer.Register(defaultLogger);

EngineCore engine = new EngineCore();
engine.Initialize(ref diContainer);