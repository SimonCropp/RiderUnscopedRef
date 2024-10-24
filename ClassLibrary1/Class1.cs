using System.Diagnostics.CodeAnalysis;

public class Class1
{
    public static Wrapper<T> Method<T>([UnscopedRef] params ReadOnlySpan<T> args)
    {
       return new Wrapper<T>(args);
    }
}

public class Wrapper<T>
{
    public Wrapper(ReadOnlySpan<T> args)
    {
    }
}

