using PEngine.Engine.DI;

namespace PEngine.Engine.Module_System;

public interface IEngineModule
{
    void Initialize(ref IDiContainer diContainer);
    void Update(double deltaTime);
}