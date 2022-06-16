abstract class Component
{
    public abstract void Operation();
}
class ConcreteComponent : Component
{
    public override void Operation()
    { }
}
abstract class DecoratorP : Component
{
    protected Component component;

    public void SetComponent(Component component)
    {
        this.component = component;
    }

    public override void Operation()
    {
        if (component != null)
            component.Operation();
    }
}
class ConcreteDecoratorA : DecoratorP
{
    public override void Operation()
    {
        base.Operation();
    }
}
class ConcreteDecoratorB : DecoratorP
{
    public override void Operation()
    {
        base.Operation();
    }
}