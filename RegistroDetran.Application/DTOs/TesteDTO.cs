using RegistroDetran.Core.Models.Enums;

namespace RegistroDetran.Application.DTOs
{
    public class TesteDTO
    {
        public string Nome { get; set; }
        public StatusContratoEnum Status { get; set; }
        public DateTime? DataCadastro { get; set; }
        public RestricaoContratoEnum RestricaoContrato { get; set; }
    }
}
