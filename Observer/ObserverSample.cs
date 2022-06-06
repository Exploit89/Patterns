using System.Collections.Generic;

interface IObservable
{
    void AddObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}
class ConcreteObservable : IObservable
{
    private List<IObserver> observers;
    public ConcreteObservable()
    {
        observers = new List<IObserver>();
    }
    public void AddObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
            observer.Update();
    }
}

interface IObserver
{
    void Update();
}
class ConcreteObserver : IObserver
{
    public void Update()
    {
    }
}