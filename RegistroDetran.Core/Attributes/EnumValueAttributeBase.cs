namespace RegistroDetran.Core.Attributes
{
    public class EnumValueAttributeBase<T> : Attribute
    {
        public T Value { get; }

        public EnumValueAttributeBase(T value)
        {
            Value = value;
        }
    }
}
