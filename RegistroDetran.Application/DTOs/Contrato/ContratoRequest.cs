namespace RegistroDetran.Application.DTOs.Contrato
{
    public class ContratoRequest
    {
        public long? Sequencial { get; set; } = 0;
        public string NumContratoOrigem { get; set; } = "0";
        public string NumAditivo { get; set; } = "0";
        public string NumAditivoOrigem { get; set; } = "0";
        public int TipoOperacao { get; set; }
        public Contrato Contrato { get; set; }
    }
}
