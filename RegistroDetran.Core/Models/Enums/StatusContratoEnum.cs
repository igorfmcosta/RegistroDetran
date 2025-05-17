using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum StatusContratoEnum
    {
        [JsonStringEnumMemberName("Aguardando aprovação do Detran")]
        AGUARDANDO_APROVACAO_DETRAN,
        [JsonStringEnumMemberName("Erro ao validar contrato")]
        ERROR,
        [JsonStringEnumMemberName("ontrato registrado com sucesso")]
        REGISTRADO,
        [JsonStringEnumMemberName("Aguardando envio para o Detran")]
        AGUARDANDO_ENVIO_DETRAN,
        [JsonStringEnumMemberName("Contrato baixado")]
        BAIXADO,
        [JsonStringEnumMemberName("Contrato cancelado")]
        CANCELADO
    }
}
