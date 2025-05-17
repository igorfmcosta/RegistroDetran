using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusContratoEnum
    {
        [JsonStringEnumMemberName("Aguardando aprovação do Detran")]
        AGUARDANDO_APROVACAO_DETRAN,
        [JsonStringEnumMemberName("Erro ao validar contrato")]
        ERROR,
        [JsonStringEnumMemberName("Contrato registrado com sucesso")]
        REGISTRADO,
        [JsonStringEnumMemberName("Aguardando envio para o Detran")]
        AGUARDANDO_ENVIO_DETRAN,
        [JsonStringEnumMemberName("Contrato baixado")]
        BAIXADO,
        [JsonStringEnumMemberName("Contrato cancelado")]
        CANCELADO
    }
}
