using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum TipoContratoEnum
    {
        [JsonPropertyName("Contrato Principal")]
        CONTRATO_PRINCIPAL,
        [JsonPropertyName("Cessão de Direito – Devedor")]
        CESSAO_DIREITO_DEVEDOR,
        [JsonPropertyName("Cessão de Direito – Credor")]
        CESSAO_DIREITO_CREDOR,
        [JsonPropertyName("Substituição de Garantia")]
        SUBSTITUICAO_GARANTIA
    }
}
