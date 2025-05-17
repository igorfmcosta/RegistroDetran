using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AditivoEnum
    {
        [JsonStringEnumMemberName("Substituição de Garantia")]
        SUBSTITUICAO_DE_GARANTIA,
        [JsonStringEnumMemberName("Cessão de Direito do Devedor")]
        CESSAO_DE_DIREITO_DO_DEVEDOR,
        [JsonStringEnumMemberName("Cessão de Direito do Credor")]
        CESSAO_DE_DIREITO_DO_CREDOR
    }
}
