using PEngine.Engine.DI;

namespace PEngine.Engine.Module_System;

public interface IPhysicsModule
{
    void Initialize(ref IDiContainer diContainer);
    void Update(double deltaTime);
    // TODO: Make more arguments
    void CreatePhysicObject();
}