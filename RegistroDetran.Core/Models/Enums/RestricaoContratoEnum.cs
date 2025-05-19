using RegistroDetran.Core.Attributes;
using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RestricaoContratoEnum
    {
        [JsonStringEnumMemberName("ALIENACAO_FIDUCIARIA_CONSORCIO")]
        [EnumValue<int>("DetranSC", 3)]
        ALIENACAO_FIDUCIARIA_CONSORCIO,
        [JsonStringEnumMemberName("ALIENACAO_FIDUCIARIA_FINANCIAMENTO")]
        [EnumValue<int>("DetranSC", 3)]
        ALIENACAO_FIDUCIARIA_FINANCIAMENTO,
        [JsonStringEnumMemberName("PENHOR")]
        [EnumValue<int>("DetranSC", 9)]
        PENHOR,
        [JsonStringEnumMemberName("RESERVA_DOMINIO")]
        [EnumValue<int>("DetranSC", 2)]
        RESERVA_DOMINIO,
        [JsonStringEnumMemberName("ARRENDAMENTO_MERCANTIL")]
        [EnumValue<int>("DetranSC", 1)]
        ARRENDAMENTO_MERCANTIL,
        [JsonStringEnumMemberName("ALIENACAO_FIDUCIARIA_CEDULA_CREDITO")]
        [EnumValue<int>("DetranSC", 3)]
        ALIENACAO_FIDUCIARIA_CEDULA_CREDITO
    }
}
