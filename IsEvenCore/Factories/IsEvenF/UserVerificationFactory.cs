using IsEvenCore.Verification;
using IsEvenCore._User;
using System.Runtime.CompilerServices;

namespace IsEvenCore.Factories.IsEvenF;

internal static class UserVerificationFactory
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UserVerification Get(User _user) => new(_user);
}
