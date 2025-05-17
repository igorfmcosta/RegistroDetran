using RegistroDetran.Core.Models.Enums;

namespace RegistroDetran.Application.DTOs.Contrato
{
    public class Contrato
    {
        public long Id { get; set; }
        public string TipoFinanciamento { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public TipoContratoEnum? TipoContrato { get; set; }
        public string NumeroContrato { get; set; } = string.Empty;
        public string CodigoContratoFisico { get; set; } = string.Empty;
        public decimal? ValorTotalDivida { get; set; }
        public decimal? ValorRegistroContrato { get; set; }
        public decimal? ValorIOF { get; set; }
        public decimal? ValorParcela { get; set; }
        public decimal? ValorCredito { get; set; }
        public DateTime? DataLiberacaoCredito { get; set; }
        public decimal? JurosMes { get; set; }
        public bool? TaxaJurosMulta { get; set; } = false;
        public bool? TaxaMoraDia { get; set; } = false;
        public double? TaxaMora { get; set; }
        public int? DiaVencimento { get; set; }
        public double? TaxaMulta { get; set; }
        public double? TaxaContrato { get; set; }
        public double? TaxaJurosMes { get; set; }
        public double? TaxaJurosAno { get; set; }
        public double? TaxaComissao { get; set; }
        public int? DiaVencimentoUltima { get; set; }
        public int? Parcelas { get; set; }
        public string UfFinanciamento { get; set; } = string.Empty;
        public string CodigoMunicipioLiberacaoCredito { get; set; } = string.Empty;
        public DateTime? VencimentoPrimeiraParcela { get; set; }
        public DateTime? VencimentoUltimaParcela { get; set; }
        public int? QuantidadeMeses { get; set; }
        public string Observacao { get; set; } = string.Empty;
        public bool? IndicativoComissao { get; set; }
        public string Comissao { get; set; } = string.Empty;
        public DateTime? DataCompra { get; set; }
        public DateTime? DataContrato { get; set; }
        public string LocalPagamento { get; set; } = string.Empty;
        public string CorrecaoMonetaria { get; set; } = string.Empty;
        public bool? IndicativoPenalidade { get; set; }
        public string DescricaoPenalidade { get; set; } = string.Empty;
        public string CelularComDdd { get; set; } = string.Empty;
        public bool IndicativoMulta { get; set; } = false;
        public bool IndicativoMoraDia { get; set; } = false;
        public IndiceCorrecaoEnum? IndiceCorrecao { get; set; }
        public string GrupoConsorcio { get; set; } = string.Empty;
        public string CotaConsorcio { get; set; } = string.Empty;
        public AditivoEnum? TipoAditivo { get; set; }
        public AgenteFinanceiro? AgenteFinanceiro { get; set; }
        public DonoDoVeiculo? DonoDoVeiculo { get; set; }
        public DonoDoVeiculo? NovoDevedor { get; set; }
        public DonoDoVeiculo? TerceiroGarantidor { get; set; }
        public List<VeiculoContrato> VeiculoContrato { get; set; } = new List<VeiculoContrato>();
        public StatusContratoEnum Status { get; set; }
        public string UfLiberacao { get; set; } = string.Empty;
        public string MunicipioLiberacao { get; set; } = string.Empty;
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataRegistro { get; set; }
        public DateTime? DataBaixa { get; set; }
        public DateTime? DataAnulacao { get; set; }
        public DateTime? DataEnvioImagem { get; set; }
        public DateTime? DataRegistroDetran { get; set; }
        public List<Arquivo> Arquivos { get; set; } = new List<Arquivo>();
        public Contrato? ContratoAnterior { get; set; }
        public List<string> ErrosContrato { get; set; } = new List<string>();
        public RestricaoContratoEnum RestricaoContrato { get; set; }
        public Contrato? ContratoPai { get; set; }
        public bool Deletado { get; set; } = false;
        public string UrlEspelho { get; set; } = string.Empty;
    }
}
