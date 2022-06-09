using System;

internal class Program3
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Main {DateTime.Now.TimeOfDay}");
        Console.WriteLine(Singleton2.text);

        Singleton2 singleton1 = Singleton2.GetInstance();
        Console.WriteLine(singleton1.Date);
        Console.Read();
    }
}

public class Singleton3
{
    private static readonly Lazy<Singleton3> lazy =
        new Lazy<Singleton3>(() => new Singleton3());

    public string Name { get; private set; }

    private Singleton3()
    {
        Name = System.Guid.NewGuid().ToString();
    }

    public static Singleton3 GetInstance()
    {
        return lazy.Value;
    }
}