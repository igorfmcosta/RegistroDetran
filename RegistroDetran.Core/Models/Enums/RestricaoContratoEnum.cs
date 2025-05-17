using RegistroDetran.Core.Attributes;
using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum RestricaoContratoEnum
    {
        [JsonStringEnumMemberName("Alienação Fiduciária Consórcio")]
        [EnumValue<int>("DetranSC", 3)]
        ALIENACAO_FIDUCIARIA_CONSORCIO,
        [JsonStringEnumMemberName("Alienação Fiduciária Financiamento")]
        [EnumValue<int>("DetranSC", 3)]
        ALIENACAO_FIDUCIARIA_FINANCIAMENTO,
        [JsonStringEnumMemberName("Penhor")]
        [EnumValue<int>("DetranSC", 9)]
        PENHOR,
        [JsonStringEnumMemberName("Reserva de Domínio")]
        [EnumValue<int>("DetranSC", 2)]
        RESERVA_DOMINIO,
        [JsonStringEnumMemberName("Arrendamento Mercantil")]
        [EnumValue<int>("DetranSC", 1)]
        ARRENDAMENTO_MERCANTIL,
        [JsonStringEnumMemberName("Alienação Fiduciária Cédula de Crédito")]
        [EnumValue<int>("DetranSC", 3)]
        ALIENACAO_FIDUCIARIA_CEDULA_CREDITO
    }
}
