using PEngine.Engine.DI;

namespace PEngine.Engine.Module_System;

public interface IRenderModule
{
    void Initialize(ref IDiContainer diContainer);
    void Update(double deltaTime);
    void CreateWindow(int width, int height, string title);
}