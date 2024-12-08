namespace IsEvenCore._User.Name;

public sealed class BaseUserName : IUserName
{
    public BaseUserName(string _first, string _last)
    {
        FirstName = _first;
        LastName = _last;
    }
    internal BaseUserName()
    {
        FirstName = LastName = string.Empty;
    }

    public string FirstName { get; }
    public string LastName { get; }
}
