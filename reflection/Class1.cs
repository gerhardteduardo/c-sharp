namespace reflection;

public class Class1
{
    private readonly int test;

    public Class1() 
    {
        test = Generic<int>();
    }

    private static T Generic<T>()
    {
        T teste = Activator.CreateInstance<T>();
        return teste;
    }
}