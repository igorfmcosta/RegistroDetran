using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

public class CustomDateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var raw = reader.GetString();

        // Fix timezone format: +0000 => +00:00
        if (!string.IsNullOrWhiteSpace(raw) && raw.Length >= 5 && (raw[^5] == '+' || raw[^5] == '-'))
        {
            raw = raw.Insert(raw.Length - 2, ":");
        }

        return DateTime.Parse(raw, null, DateTimeStyles.RoundtripKind);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString("O")); // ISO 8601
}