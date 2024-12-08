using IsEvenCore._IsEven;
using IsEvenCore._User;

namespace IsEvenCore.Extensions;

public static class IntExtensions
{
	public static async Task<IsEven> IsEven(this int _value, User _user) =>
		await IsEvenInterfacer.Get(_user, _value);
}
