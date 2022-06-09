using System;
using System.Threading;

internal class Program2
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

public class Singleton2
{
    public string Date { get; private set; }
    public static string text = "hello";
    private Singleton2()
    {
        Console.WriteLine($"Singleton ctor {DateTime.Now.TimeOfDay}");
        Date = DateTime.Now.TimeOfDay.ToString();
    }

    public static Singleton2 GetInstance()
    {
        Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
        Thread.Sleep(500);
        return Nested.instance;
    }

    private class Nested
    {
        static Nested() { }
        internal static readonly Singleton2 instance = new Singleton2();
    }
}