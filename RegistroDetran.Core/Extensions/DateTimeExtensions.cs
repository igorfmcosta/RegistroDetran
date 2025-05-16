namespace RegistroDetran.Core.Extensions
{
    public static class DateTimeExtensions
    {
        public static int ToInt(this DateTime dateTime)
        {
            return int.Parse(dateTime.ToString("yyyyMMdd"));
        }
    }
}
