using System;
using System.Collections.Generic;

class Client
{
    public void Main()
    {
        Component root = new CompositeP("Root");
        Component leaf = new Leaf("Leaf");
        CompositeP subtree = new CompositeP("Subtree");
        root.Add(leaf);
        root.Add(subtree);
        root.Display();
    }
}
abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }

    public abstract void Display();
    public abstract void Add(Component c);
    public abstract void Remove(Component c);
}
class CompositeP : Component
{
    List<Component> children = new List<Component>();

    public CompositeP(string name)
        : base(name)
    { }

    public override void Add(Component component)
    {
        children.Add(component);
    }

    public override void Remove(Component component)
    {
        children.Remove(component);
    }

    public override void Display()
    {
        Console.WriteLine(name);

        foreach (Component component in children)
        {
            component.Display();
        }
    }
}
class Leaf : Component
{
    public Leaf(string name)
        : base(name)
    { }

    public override void Display()
    {
        Console.WriteLine(name);
    }

    public override void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public override void Remove(Component component)
    {
        throw new NotImplementedException();
    }
}