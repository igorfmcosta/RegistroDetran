using RegistroDetran.Core.Attributes;
using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum IndiceCorrecaoEnum
    {
        [JsonStringEnumMemberName("Pré-fixado")]
        [EnumValue<string>("DetranSC","Pré-fixado")]
        PRE_FIXADO,
        [JsonStringEnumMemberName("Pós-fixado")]
        [EnumValue<string>("DetranSC", "Pós-fixado")]
        POS_FIXADO,
        [JsonStringEnumMemberName("Valor Bem")]
        [EnumValue<string>("DetranSC", "Valor Bem")]
        VALOR_BEM,
        [JsonStringEnumMemberName("IGP")]
        [EnumValue<string>("DetranSC", "IGP")]
        IGP,
        [JsonStringEnumMemberName("IPCA")]
        [EnumValue<string>("DetranSC", "IPCA")]
        IGPM
        
    }
}
