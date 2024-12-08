using IsEvenCore._IsEven;
using System.Runtime.CompilerServices;

namespace IsEvenCore.Factories.IsEvenF;

internal static class IsEvenFactory
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IsEven Get(int _value) => new(_value);
}