namespace RegistroDetran.Application.DTOs.Contrato
{
    public class DadosCobranca
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CpfCnpj { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
    }
}
