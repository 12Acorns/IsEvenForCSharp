using IsEvenCore._User.Name;

namespace IsEvenCore._User;

public sealed class User
{
	public User(IUserName _userName, UserEmail _email)
	{
		UserName = _userName;
		Email = _email;
	}
	internal User() 
	{
		UserName = new BaseUserName();
		Email = new UserEmail();
	}

	public IUserName UserName { get; }
	public UserEmail Email { get; }
}
