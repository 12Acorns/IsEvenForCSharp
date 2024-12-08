namespace IsEvenCore._User.Name;

public sealed class UserEmail
{
    public UserEmail(string _email)
    {
        Email = _email;
    }
    internal UserEmail()
    {
        Email = string.Empty;
    }

    public string Email { get; }
}
