class Client
{
    void Operation()
    {
        PrototypeP prototype = new ConcretePrototype1(1);
        PrototypeP clone = prototype.Clone();
        prototype = new ConcretePrototype2(2);
        clone = prototype.Clone();
    }
}

abstract class PrototypeP
{
    public int Id { get; private set; }
    public PrototypeP(int id)
    {
        this.Id = id;
    }
    public abstract PrototypeP Clone();
}

class ConcretePrototype1 : PrototypeP
{
    public ConcretePrototype1(int id)
        : base(id)
    { }
    public override PrototypeP Clone()
    {
        return new ConcretePrototype1(Id);
    }
}

class ConcretePrototype2 : PrototypeP
{
    public ConcretePrototype2(int id)
        : base(id)
    { }
    public override PrototypeP Clone()
    {
        return new ConcretePrototype2(Id);
    }
}