using IsEvenCore._User;

namespace IsEvenCore.Verification;

internal sealed class UserVerification
{
    internal UserVerification(User _user)
    {
        user = _user;
    }
    internal UserVerification() 
    {
        user = default!;
    }

    private readonly User user;

    public async ValueTask<bool> IsAuthenticated() =>
        await GetUserAuthenticationStatus(user);

    private static async ValueTask<bool> GetUserAuthenticationStatus(User _user) =>
        await Task.Run(() => true);
}
