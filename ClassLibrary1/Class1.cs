using System.Diagnostics.CodeAnalysis;

public class Class1
{
    public static void Method<T>([UnscopedRef] params ReadOnlySpan<T> args)
    {
    }
}

