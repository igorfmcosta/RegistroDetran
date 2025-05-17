using RegistroDetran.Core.Models.Enums;
using System.Text.Json.Serialization;

namespace RegistroDetran.Application.DTOs
{
    public class TesteDTO
    {
        public string Nome { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TipoContratoEnum TipoContrato { get; set; }
    }
}
