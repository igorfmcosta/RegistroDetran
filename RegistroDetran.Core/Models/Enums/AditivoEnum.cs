using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum AditivoEnum
    {
        [JsonPropertyName("Substituição de Garantia")]
        SUBSTITUICAO_DE_GARANTIA,
        [JsonPropertyName("Cessão de Direito do Devedor")]
        CESSAO_DE_DIREITO_DO_DEVEDOR,
        [JsonPropertyName("Cessão de Direito do Credor")]
        CESSAO_DE_DIREITO_DO_CREDOR
    }
}
