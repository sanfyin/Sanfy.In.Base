using System;
namespace Sanfy.In.Base.Core
{
	public abstract class BaseTypedIdValue : IEquatable<BaseTypedIdValue>
    {
        public Guid Value { get; }

        protected BaseTypedIdValue(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new InvalidOperationException("Id value cannot be empty!");
            }

            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is BaseTypedIdValue other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public bool Equals(BaseTypedIdValue other)
        {
            return this.Value == other?.Value;
        }

        public static bool operator ==(BaseTypedIdValue obj1, BaseTypedIdValue obj2)
        {
            if (object.Equals(obj1, null))
            {
                if (object.Equals(obj2, null))
                {
                    return true;
                }

                return false;
            }

            return obj1.Equals(obj2);
        }

        public static bool operator !=(BaseTypedIdValue x, BaseTypedIdValue y)
        {
            return !(x == y);
        }
    }
}

