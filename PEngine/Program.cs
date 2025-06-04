using PEngine.Engine;

// TODO: Implement GUI logger and replace to it
ILogger defaultLogger = new ConsoleLogger();

// TODO: Maybe replace to DI
DataContext dataContext = new DataContext();
LogContext logContext = new LogContext();
logContext.Logger = defaultLogger;
dataContext.LogContext = logContext;

EngineCore engine = new EngineCore(ref dataContext);
engine.Initialize();