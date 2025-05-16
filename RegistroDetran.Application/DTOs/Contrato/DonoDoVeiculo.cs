namespace RegistroDetran.Application.DTOs.Contrato
{
    public class DonoDoVeiculo
    {
        public long Id { get; set; }
        public string CpfOuCnpj { get; set; } = string.Empty;
        public string NomeOuRazaoSocial { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string TelefoneComDdd { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CelularComDdd { get; set; } = string.Empty;
    }
}
