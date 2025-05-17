using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum TipoConsorcioEnum
    {
        [JsonStringEnumMemberName("Grupo")]
        GRUPO,
        [JsonStringEnumMemberName("Cota")]
        COTA
    }
}
