class Client
{
    void Main()
    {
        Context context = new Context();

        var expression = new NonterminalExpression();
        expression.Interpret(context);

    }
}

class Context
{
}

abstract class AbstractExpression
{
    public abstract void Interpret(Context context);
}

class TerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
    }
}

class NonterminalExpression : AbstractExpression
{
    AbstractExpression expression1;
    AbstractExpression expression2;
    public override void Interpret(Context context)
    {

    }
}