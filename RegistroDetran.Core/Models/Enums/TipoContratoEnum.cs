using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoContratoEnum
    {
        [JsonStringEnumMemberName("Contrato Principal")]
        CONTRATO_PRINCIPAL,
        [JsonStringEnumMemberName("Cessão de Direito – Devedor")]
        CESSAO_DIREITO_DEVEDOR,
        [JsonStringEnumMemberName("Cessão de Direito – Credor")]
        CESSAO_DIREITO_CREDOR,
        [JsonStringEnumMemberName("Substituição de Garantia")]
        SUBSTITUICAO_GARANTIA
    }
}
