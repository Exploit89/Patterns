using System.Collections;

class Client
{
    public void Main()
    {
        Aggregate a = new ConcreteAggregate();

        IteratorP i = a.CreateIterator();

        object item = i.First();
        while (!i.IsDone())
        {
            item = i.Next();
        }
    }
}

abstract class Aggregate
{
    public abstract IteratorP CreateIterator();
    public abstract int Count { get; protected set; }
    public abstract object this[int index] { get; set; }
}

class ConcreteAggregate : Aggregate
{
    private readonly ArrayList _items = new ArrayList();

    public override IteratorP CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public override int Count
    {
        get { return _items.Count; }
        protected set { }
    }

    public override object this[int index]
    {
        get { return _items[index]; }
        set { _items.Insert(index, value); }
    }
}
abstract class IteratorP
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}

class ConcreteIterator : IteratorP
{
    private readonly Aggregate _aggregate;
    private int _current;

    public ConcreteIterator(Aggregate aggregate)
    {
        this._aggregate = aggregate;
    }

    public override object First()
    {
        return _aggregate[0];
    }

    public override object Next()
    {
        object ret = null;

        _current++;

        if (_current < _aggregate.Count)
        {
            ret = _aggregate[_current];
        }

        return ret;
    }

    public override object CurrentItem()
    {
        return _aggregate[_current];
    }

    public override bool IsDone()
    {
        return _current >= _aggregate.Count;
    }
}