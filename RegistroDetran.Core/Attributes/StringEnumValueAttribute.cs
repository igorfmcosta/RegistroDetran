namespace RegistroDetran.Core.Attributes
{
    public class StringEnumValueAttribute : EnumValueAttributeBase<string>
    {
        public StringEnumValueAttribute(string value) : base(value)
        {
        }
    }
}
