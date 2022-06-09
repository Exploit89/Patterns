class MementoP
{
    public string State { get; private set; }
    public MementoP(string state)
    {
        this.State = state;
    }
}

class Caretaker
{
    public MementoP Memento { get; set; }
}

class Originator
{
    public string State { get; set; }
    public void SetMemento(MementoP memento)
    {
        State = memento.State;
    }
    public MementoP CreateMemento()
    {
        return new MementoP(State);
    }
}