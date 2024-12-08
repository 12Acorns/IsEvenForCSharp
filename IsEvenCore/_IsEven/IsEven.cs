using IsEvenCore.Generated;

namespace IsEvenCore._IsEven
{
	/// <summary>
	/// To check if true just do:
	/// <code>
	/// var _isEven = var _isEven1 = await IsEvenInterfacer.GetNewIsEven(_user, 22);
	/// 
	/// if(_isEven)
    /// {
    ///     // code
    /// }
	/// </code>
	/// </summary>
	public sealed class IsEven
    {
        private static readonly Exception installIsOddException =
			new Exception("Cannot check if not is even (is false), please check out IsFalseForCSharp to do falsy checks");

		internal IsEven(int _value)
        {
            value = _value;
        }
        internal IsEven() { }

        private readonly int value;

        internal bool ValueIsEven =>
            IsEvenIdentifier.IsEven(value);

        public static implicit operator bool(IsEven _this)
        {
            return _this.ValueIsEven;
        }

		public static bool operator ==(IsEven _this, IsEven _other) => _this == _other.ValueIsEven;
		public static bool operator !=(IsEven _this, IsEven _other) => !(_this == _other.ValueIsEven);
		public static bool operator ==(IsEven _this, bool _other)
        {
            if(_other is false)
            {
                throw installIsOddException;
            }
            return _this.ValueIsEven == _other;
        }
        public static bool operator !=(IsEven _this, bool _other)
        {
			if(_other is true)
			{
				throw installIsOddException;
			}
			return _this.ValueIsEven != _other;
		}
        public static bool operator !(IsEven _this)
        {
            throw installIsOddException;
		}
    }
}
