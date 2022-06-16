class Client
{
    void Main()
    {
        Subject subject = new ProxyP();
        subject.Request();
    }
}
abstract class Subject
{
    public abstract void Request();
}

class RealSubject : Subject
{
    public override void Request()
    { }
}
class ProxyP : Subject
{
    RealSubject realSubject;
    public override void Request()
    {
        if (realSubject == null)
            realSubject = new RealSubject();
        realSubject.Request();
    }
}