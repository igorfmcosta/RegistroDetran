using RegistroDetran.Core.Attributes;
using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoOperacaoEnum
    {
        [JsonStringEnumMemberName("INCLUSAO_CONTRATO")]
        [EnumValue<int>("DetranSC", 1)]
        INCLUSAO_CONTRATO,
        [JsonStringEnumMemberName("ALTERACAO_CONTRATO")]
        [EnumValue<int>("DetranSC", 2)]
        ALTERACAO_CONTRATO,
        [JsonStringEnumMemberName("INCLUSAO_ADITIVO")]
        [EnumValue<int>("DetranSC", 3)]
        INCLUSAO_ADITIVO,
        [JsonStringEnumMemberName("ALTERACAO_ADITIVO")]
        [EnumValue<int>("DetranSC", 4)]
        ALTERACAO_ADITIVO
    }
}
