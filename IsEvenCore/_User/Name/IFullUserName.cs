namespace IsEvenCore._User.Name;

public interface IFullUserName : IUserName
{
    public string MiddleName { get; }
    //public bool HasMultipleMiddleNames { get; }
}
