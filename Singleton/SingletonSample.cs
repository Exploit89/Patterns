class SingletonP
{
    private static SingletonP instance;

    private SingletonP()
    { }

    public static SingletonP getInstance()
    {
        if (instance == null)
            instance = new SingletonP();
        return instance;
    }
}