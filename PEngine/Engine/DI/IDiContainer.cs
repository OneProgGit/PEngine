using PEngine.Engine.Log;

namespace PEngine.Engine.DI;

public interface IDiContainer
{
    void Initialize(ref ILogger logger);
    void Register<T>(T instance, string tag = "");
    T Get<T>(string tag = "");
}