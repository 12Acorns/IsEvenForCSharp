using IsEvenCore.Factories.IsEvenF;
using IsEvenCore._User;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace IsEvenCore._IsEven;
public static class IsEvenInterfacer
{
    private static readonly ConcurrentDictionary<(User, int), IsEven> isEvenMapper = [];

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async ValueTask<IsEven> Get(User _user, int _value) => 
        await GetCacheOrNewIsEven(_user, _value);
    private static async ValueTask<IsEven> GetCacheOrNewIsEven(User _user, int _value)
    {
        if (!await UserVerificationFactory.Get(_user).IsAuthenticated())
        {
            throw new ArgumentException(nameof(_user) + " is not authenticated");
        }
        if(isEvenMapper.TryGetValue((_user, _value), out var _isEven))
        {
            return _isEven;
        }

        _isEven = IsEvenFactory.Get(_value);
        isEvenMapper.TryAdd((_user, _value), _isEven);
        RemoveFromCacheAfterNSeconds(TimeSpan.FromSeconds(120), _user, _value);
		return _isEven;
	}

    private static async void RemoveFromCacheAfterNSeconds(TimeSpan _time, User _user, int _value)
    {
        await Task.Factory.StartNew(async () =>
        {
            await Task.Delay(_time).ConfigureAwait(true);
            isEvenMapper.TryRemove((_user, _value), out _);
		}).ConfigureAwait(false);
    }
}
