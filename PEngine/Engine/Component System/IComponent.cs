namespace PEngine.Engine.Component_System;

public interface IComponent
{
    public string OwnerName { get; protected set; }

    // TODO: Make more methods
    void Initialize(string ownerName);
}