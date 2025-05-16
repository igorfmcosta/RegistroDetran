using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum TipoConsorcioEnum
    {
        [JsonPropertyName("Grupo")]
        GRUPO,
        [JsonPropertyName("Cota")]
        COTA
    }
}
