using System.Diagnostics.CodeAnalysis;

namespace ClassLibrary1;

public class Class1
{
    public static void Method<T>([UnscopedRef] params ReadOnlySpan<T> args)
    {
    }
}