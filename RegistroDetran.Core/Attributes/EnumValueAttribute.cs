namespace RegistroDetran.Core.Attributes
{
    public class EnumValueAttribute<T> : Attribute
    {
        public string ApiName { get; set; }
        public T Value { get; }

        public EnumValueAttribute(string apiName,T value)
        {
            ApiName = apiName;
            Value = value;
        }
    }
}
