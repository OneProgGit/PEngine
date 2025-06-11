namespace PEngine.Engine.Component_System;

public struct GameObject
{
    public string Name { get; private set; }
    public List<IComponent> Components { get; set; }

    public void Initialize(string name)
    {
        Name = name;
        foreach (IComponent component in Components)
        {
            component.Initialize(Name);
        }
    }
}