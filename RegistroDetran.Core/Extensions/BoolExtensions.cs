namespace RegistroDetran.Core.Extensions
{
    public static class BoolExtensions
    {
        public static string ToXMLString(this bool value)
        {
            return value ? "SIM" : "NAO";
        }
        public static string ToXMLString(this bool? value)
        {
            return value.HasValue ? (value.Value ? "SIM" : "NAO") : string.Empty;
        }
        public static string ToXMLString(this bool? value, string trueValue, string falseValue)
        {
            return value.HasValue ? (value.Value ? trueValue : falseValue) : string.Empty;
        }
    }
}
