using Microsoft.CodeAnalysis;

namespace IsEvenGenerator
{
	[Generator]
	public class IsEvenSourceGenerator : IIncrementalGenerator
	{
		private const string ISEVENIDENTIFIER =
			"""
			using System.Runtime.CompilerServices;

			namespace IsEvenCore.Generated
			{

				[CompilerGenerated]
				public static class IsEvenIdentifier
				{
					public static bool IsEven(int _value)
					{
						// return _value switch 
						// {
						//	{0}
						// };
						return (_value & 1) == 0;
					}
				}
			}
			""";
		private const string SWITCHTEMPLATE =
			"""
			{0} => {1},
			""";

		public void Initialize(IncrementalGeneratorInitializationContext _sourceContext)
		{
			//StringBuilder _builder = new();
			//for(int i = int.MinValue; i < int.MaxValue; i++)
			//{
			//	_builder.AppendFormat(SWITCHTEMPLATE + "\n", i, i % 2);
			//}
			//_builder.Append("_ => throw new Exception(\"Unhandled value\"");
			//var _code = string.Format(ISEVENIDENTIFIER, _builder.ToString());

			_sourceContext.RegisterSourceOutput(_sourceContext.CompilationProvider, (_sourceProvider, _compilation) =>
			{
				_sourceProvider.AddSource("IsEvenIdentifier.g.cs", ISEVENIDENTIFIER);
			});
		}
	}
}
