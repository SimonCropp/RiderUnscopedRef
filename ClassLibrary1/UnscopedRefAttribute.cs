#if !NET7_0_OR_GREATER

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(
    validOn: AttributeTargets.Method |
             AttributeTargets.Property |
             AttributeTargets.Parameter,
    Inherited = false)]
sealed class UnscopedRefAttribute :
    Attribute;
#endif