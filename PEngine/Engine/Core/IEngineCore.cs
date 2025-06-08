using PEngine.Engine.DI;

namespace PEngine.Engine.Core;

public interface IEngineCore
{
    void Initialize(ref IDiContainer diContainer);
}