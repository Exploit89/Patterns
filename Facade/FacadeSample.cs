class Client
{
    public void Main(string[] args)
    {
        FacadeP facade = new FacadeP(new SubsystemA(), new SubsystemB(), new SubsystemC());
        facade.Operation1();
        facade.Operation2();
    }
}

class SubsystemA
{
    public void A1()
    { }
}
class SubsystemB
{
    public void B1()
    { }
}
class SubsystemC
{
    public void C1()
    { }
}

class FacadeP
{
    SubsystemA subsystemA;
    SubsystemB subsystemB;
    SubsystemC subsystemC;

    public FacadeP(SubsystemA sa, SubsystemB sb, SubsystemC sc)
    {
        subsystemA = sa;
        subsystemB = sb;
        subsystemC = sc;
    }
    public void Operation1()
    {
        subsystemA.A1();
        subsystemB.B1();
        subsystemC.C1();
    }
    public void Operation2()
    {
        subsystemB.B1();
        subsystemC.C1();
    }
}

