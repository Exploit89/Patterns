using System.Collections;

class FlyweightFactory
{
    Hashtable flyweights = new Hashtable();
    public FlyweightFactory()
    {
        flyweights.Add("X", new ConcreteFlyweight());
        flyweights.Add("Y", new ConcreteFlyweight());
        flyweights.Add("Z", new ConcreteFlyweight());
    }
    public FlyweightP GetFlyweight(string key)
    {
        if (!flyweights.ContainsKey(key))
            flyweights.Add(key, new ConcreteFlyweight());
        return flyweights[key] as FlyweightP;
    }
}

abstract class FlyweightP
{
    public abstract void Operation(int extrinsicState);
}

class ConcreteFlyweight : FlyweightP
{
    int intrinsicState;
    public override void Operation(int extrinsicState)
    {
    }
}

class UnsharedConcreteFlyweight : FlyweightP
{
    int allState;
    public override void Operation(int extrinsicState)
    {
        allState = extrinsicState;
    }
}

class Client
{
    void Main()
    {
        int extrinsicstate = 22;

        FlyweightFactory f = new FlyweightFactory();

        FlyweightP fx = f.GetFlyweight("X");
        fx.Operation(--extrinsicstate);

        FlyweightP fy = f.GetFlyweight("Y");
        fy.Operation(--extrinsicstate);

        FlyweightP fd = f.GetFlyweight("D");
        fd.Operation(--extrinsicstate);

        UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();

        uf.Operation(--extrinsicstate);
    }
}