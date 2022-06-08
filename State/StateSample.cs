class Program
{
    static void Main()
    {
        Context context = new Context(new StateA());
        context.Request(); // Переход в состояние StateB
        context.Request();  // Переход в состояние StateA
    }
}
abstract class StateP
{
    public abstract void Handle(Context context);
}
class StateA : StateP
{
    public override void Handle(Context context)
    {
        context.State = new StateB();
    }
}
class StateB : StateP
{
    public override void Handle(Context context)
    {
        context.State = new StateA();
    }
}

class Context
{
    public StateP State { get; set; }
    public Context(StateP state)
    {
        this.State = state;
    }
    public void Request()
    {
        this.State.Handle(this);
    }
}