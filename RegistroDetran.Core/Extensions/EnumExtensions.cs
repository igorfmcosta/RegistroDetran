using RegistroDetran.Core.Attributes;
using System.Reflection;

namespace RegistroDetran.Core.Extensions
{
    public static class EnumExtensions
    {
        public static TValue GetValue<TValue>(this Enum value, string apiName)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field?.GetCustomAttribute<EnumValueAttribute<TValue>>();

            return attribute != null
                ? attribute.Value
                : throw new InvalidOperationException(
                    $"{typeof(EnumValueAttribute<TValue>).Name} not found for {value}");
        }

        public static T GetDetranScValue<T>(this Enum value)
        {
            return value.GetValue<T>("DetranSC");
        }

        public static T ToEnum<T>(this string value) where T : struct
        {
            if (Enum.TryParse(value, true, out T result))
            {
                return result;
            }
            throw new ArgumentException($"Invalid value '{value}' for enum '{typeof(T).Name}'");
        }

        public static T ToEnum<T>(this int value) where T : struct
        {
            if (Enum.IsDefined(typeof(T), value))
            {
                return (T)(object)value;
            }
            throw new ArgumentException($"Invalid value '{value}' for enum '{typeof(T).Name}'");
        }
    }
}
