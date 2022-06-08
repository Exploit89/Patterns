abstract class CommandP
{
    public abstract void Execute();
    public abstract void Undo();
}
// конкретная команда
class ConcreteCommand : CommandP
{
    Receiver receiver;
    public ConcreteCommand(Receiver r)
    {
        receiver = r;
    }
    public override void Execute()
    {
        receiver.Operation();
    }

    public override void Undo()
    { }
}

// получатель команды
class Receiver
{
    public void Operation()
    { }
}
// инициатор команды
class Invoker
{
    CommandP command;
    public void SetCommand(CommandP c)
    {
        command = c;
    }
    public void Run()
    {
        command.Execute();
    }
    public void Cancel()
    {
        command.Undo();
    }
}
class Client
{
    void Main()
    {
        Invoker invoker = new Invoker();
        Receiver receiver = new Receiver();
        ConcreteCommand command = new ConcreteCommand(receiver);
        invoker.SetCommand(command);
        invoker.Run();
    }
}