using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetran.Core.Extensions
{
    public static class StringExtensions
    {
        public static long? ToLong(this string value)
        {
            if (long.TryParse(value, out long result))
            {
                return result;
            }
            return null;
        }

        public static int? ToInt(this string value)
        {
            if (int.TryParse(value, out int result))
            {
                return result;
            }
            return null;
        }

        public static decimal? ToDecimal(this string value)
        {
            if (decimal.TryParse(value, out decimal result))
            {
                return result;
            }
            return null;
        }

        public static string FitToLength(this string input, int length, char padChar = ' ', bool padLeft = true)
        {
            if (length <= 0)
                throw new ArgumentException("Length must be greater than zero", nameof(length));

            input ??= string.Empty;

            // Truncate if needed
            if (input.Length > length)
                return input[..length];

            // Pad if needed
            return padLeft
                ? input.PadLeft(length, padChar)
                : input.PadRight(length, padChar);
        }

        public static string GetNumbers(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return new string(input.Where(char.IsDigit).ToArray());
        }

        public static int ToIntSubString(this string value, int startIndex, int lenght)
        {
            var result = value.GetNumbers().Substring(startIndex, lenght);
            
            return result.ToInt() ?? 0;
        }

        public static int ToIntSubString(this string value, int startIndex)
        {
            var result = value.GetNumbers().Substring(startIndex);

            return result.ToInt() ?? 0;
        }

        public static long ToLongSubString(this string value, int startIndex, int lenght)
        {
            var result = value.GetNumbers().Substring(startIndex, lenght);

            return result.ToLong() ?? 0;
        }

        public static long ToLongSubString(this string value, int startIndex)
        {
            var result = value.GetNumbers().Substring(startIndex);

            return result.ToLong() ?? 0;
        }
    }
}
