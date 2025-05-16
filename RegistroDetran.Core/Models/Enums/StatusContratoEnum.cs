using System.Text.Json.Serialization;

namespace RegistroDetran.Core.Models.Enums
{
    public enum StatusContratoEnum
    {
        [JsonPropertyName("Aguardando aprovação do Detran")]
        AGUARDANDO_APROVACAO_DETRAN,
        [JsonPropertyName("Erro ao validar contrato")]
        ERROR,
        [JsonPropertyName("ontrato registrado com sucesso")]
        REGISTRADO,
        [JsonPropertyName("Aguardando envio para o Detran")]
        AGUARDANDO_ENVIO_DETRAN,
        [JsonPropertyName("Contrato baixado")]
        BAIXADO,
        [JsonPropertyName("Contrato cancelado")]
        CANCELADO
    }
}
