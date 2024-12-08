using IsEvenCore._User.Name;
using IsEvenCore.Extensions;
using IsEvenCore._IsEven;
using IsEvenCore._User;

var _user = new User(new BaseUserName("John", "Smith"), new UserEmail("JaneSmith@SmithMail.com"));

var _isEven1 = await IsEvenInterfacer.Get(_user, 22);
var _isEven2 = await 22.IsEven(_user);

Console.WriteLine(_isEven1);
Console.WriteLine(_isEven2);