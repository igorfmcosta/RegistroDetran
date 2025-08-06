namespace RegistroDetran.Application.DTOs.Contrato
{
    public class AgenteFinanceiro
    {
        public long Id { get; set; }
        public string CpfCnpj { get; set; } = string.Empty;
        public string NomeRazaoSocial { get; set; } = string.Empty;
        public string InscricaoEstadual { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string TipoCategoria { get; set; } = string.Empty;
        public bool? EnvioRelatorioCobranca { get; set; } = false;
        public bool? EnvioEmailNaoFaturamento { get; set; } = false;
        public bool? UnificarCobranca { get; set; } = false;
        public bool? ObservatorioAtivo { get; set; } = false;
        public bool? Ativo { get; set; } = false;

        public List<string>? ListaDocumentos { get; set; }
        public List<FinanceiraEstado>? FinanceiraEstadoList { get; set; }
        public DadosCobranca? DadosCobranca { get; set; }
        public bool? Deletado { get; set; } = false;
        public List<Arquivo>? Arquivos { get; set; }
        public bool? Despachante { get; set; }
    }
}
