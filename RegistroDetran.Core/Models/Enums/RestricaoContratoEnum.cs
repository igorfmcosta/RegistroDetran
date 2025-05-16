using RegistroDetran.Core.Attributes;
using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum RestricaoContratoEnum
    {
        [JsonPropertyName("Alienação Fiduciária Consórcio")]
        [EnumValueAttributeBase<int>(3)]
        ALIENACAO_FIDUCIARIA_CONSORCIO,
        [JsonPropertyName("Alienação Fiduciária Financiamento")]
        [EnumValueAttributeBase<int>(3)]
        ALIENACAO_FIDUCIARIA_FINANCIAMENTO,
        [JsonPropertyName("Penhor")]
        [EnumValueAttributeBase<int>(9)]
        PENHOR,
        [JsonPropertyName("Reserva de Domínio")]
        [EnumValueAttributeBase<int>(2)]
        RESERVA_DOMINIO,
        [JsonPropertyName("Arrendamento Mercantil")]
        [EnumValueAttributeBase<int>(1)]
        ARRENDAMENTO_MERCANTIL,
        [JsonPropertyName("Alienação Fiduciária Cédula de Crédito")]
        [EnumValueAttributeBase<int>(3)]
        ALIENACAO_FIDUCIARIA_CEDULA_CREDITO
    }
}
