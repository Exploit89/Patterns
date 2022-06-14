class Client
{
    public void Request(Target target)
    {
        target.Request();
    }
}
// класс, к которому надо адаптировать другой класс   
class Target
{
    public virtual void Request()
    { }
}

// Адаптер
class AdapterP : Target
{
    private Adaptee adaptee = new Adaptee();

    public override void Request()
    {
        adaptee.SpecificRequest();
    }
}

// Адаптируемый класс
class Adaptee
{
    public void SpecificRequest()
    { }
}