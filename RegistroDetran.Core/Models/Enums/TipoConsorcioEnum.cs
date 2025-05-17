using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoConsorcioEnum
    {
        [JsonStringEnumMemberName("Grupo")]
        GRUPO,
        [JsonStringEnumMemberName("Cota")]
        COTA
    }
}
