using RegistroDetran.Core.Attributes;
using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum IndiceCorrecaoEnum
    {
        [JsonPropertyName("Pré-fixado")]
        [StringEnumValue("Pré-fixado")]
        PRE_FIXADO,
        [JsonPropertyName("Pós-fixado")]
        [StringEnumValue("Pós-fixado")]
        POS_FIXADO,
        [JsonPropertyName("Valor Bem")]
        [StringEnumValue("Valor Bem")]
        VALOR_BEM,
        [JsonPropertyName("IGP")]
        [StringEnumValue("IGP")]
        IGP,
        [JsonPropertyName("IPCA")]
        [StringEnumValue("IPCA")]
        IGPM
        
    }
}
