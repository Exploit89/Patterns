abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Operation1();
        Operation2();
    }
    public abstract void Operation1();
    public abstract void Operation2();
}

class ConcreteClass : AbstractClass
{
    public override void Operation1()
    {
    }

    public override void Operation2()
    {
    }
}