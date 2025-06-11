using PEngine.Engine.DI;

namespace PEngine.Engine.Module_System;

public interface IUiModule
{
    void Initialize(ref IDiContainer diContainer);
    void Update(double deltaTime);
    // TODO: Make more arguments
    void CreateElement(string name);
}