using RegistroDetran.Application.DTOs.Contrato;
using RegistroDetran.Core.Extensions;
using System.Xml.Serialization;

namespace RegistroDetran.Application.DTOs.Detran.SC
{
    public class BodyContrato
    {
        public BodyContrato(RegistrarContratoDTO dados)
        {
            RegistrarContrato = new RegistrarContrato(dados);
        }
        public BodyContrato()
        {
        }
        [XmlElement(ElementName = "RegistrarContrato", Namespace = Envelope<object>.RegNs)]
        public RegistrarContrato RegistrarContrato { get; set; }
    }

    [XmlType(TypeName = "RegistrarContrato", Namespace = Envelope<object>.RegNs)]
    public class RegistrarContrato
    {
        public RegistrarContrato(RegistrarContratoDTO dados)
        {
            Dados = dados;
        }

        public RegistrarContrato()
        {
        }

        [XmlElement(ElementName = "Dados", Namespace = Envelope<object>.RegNs)]
        public RegistrarContratoDTO? Dados { get; set; }
    }

    public class RegistrarContratoDTO
    {
        [XmlElement(ElementName = "TipoOperacao", IsNullable = true)]
        public int? TipoOperacao { get; set; }

        [XmlElement(ElementName = "SequencialContrato", IsNullable = true)]
        public long? SequencialContrato { get; set; }

        [XmlElement(ElementName = "Chassi", IsNullable = true)]
        public string Chassi { get; set; }

        [XmlElement(ElementName = "Remarcacao", IsNullable = true)]
        public int? Remarcacao { get; set; }

        [XmlElement(ElementName = "UFPlaca", IsNullable = true)]
        public string UFPlaca { get; set; }

        [XmlElement(ElementName = "Placa", IsNullable = true)]
        public string Placa { get; set; }

        [XmlElement(ElementName = "RENAVAM", IsNullable = true)]
        public long? RENAVAM { get; set; }

        [XmlElement(ElementName = "AnoFabricacao", IsNullable = true)]
        public int? AnoFabricacao { get; set; }

        [XmlElement(ElementName = "AnoModelo", IsNullable = true)]
        public int? AnoModelo { get; set; }

        [XmlElement(ElementName = "NomeAgente", IsNullable = true)]
        public string NomeAgente { get; set; }

        [XmlElement(ElementName = "CNPJAgente", IsNullable = true)]
        public string CNPJAgente { get; set; }

        [XmlElement(ElementName = "NumContrato", IsNullable = true)]
        public string NumContrato { get; set; }

        [XmlElement(ElementName = "DataContrato", IsNullable = true)]
        public int? DataContrato { get; set; }

        [XmlElement(ElementName = "QtdParcelas", IsNullable = true)]
        public int? QtdParcelas { get; set; }

        [XmlElement(ElementName = "NumGravame", IsNullable = true)]
        public long? NumGravame { get; set; }

        [XmlElement(ElementName = "TipoGravame", IsNullable = true)]
        public int? TipoGravame { get; set; }

        [XmlElement(ElementName = "TaxaJuroMes", IsNullable = true)]
        public int? TaxaJuroMes { get; set; }

        [XmlElement(ElementName = "TaxaJuroAno", IsNullable = true)]
        public int? TaxaJuroAno { get; set; }

        [XmlElement(ElementName = "TaxaJuroMulta", IsNullable = true)]
        public string TaxaJuroMulta { get; set; }

        [XmlElement(ElementName = "TaxaMoraDia", IsNullable = true)]
        public string TaxaMoraDia { get; set; }

        [XmlElement(ElementName = "TaxaMulta", IsNullable = true)]
        public int? TaxaMulta { get; set; }

        [XmlElement(ElementName = "TaxaMora", IsNullable = true)]
        public int? TaxaMora { get; set; }

        [XmlElement(ElementName = "IndicativoPenalidade", IsNullable = true)]
        public string IndicativoPenalidade { get; set; }

        [XmlElement(ElementName = "Penalidade", IsNullable = true)]
        public string Penalidade { get; set; }

        [XmlElement(ElementName = "IndicativoComissao", IsNullable = true)]
        public string IndicativoComissao { get; set; }

        [XmlElement(ElementName = "Comissao", IsNullable = true)]
        public decimal? Comissao { get; set; }

        [XmlElement(ElementName = "ValorTaxaContrato", IsNullable = true)]
        public int? ValorTaxaContrato { get; set; }

        [XmlElement(ElementName = "ValorTotalFinanciamento", IsNullable = true)]
        public int? ValorTotalFinanciamento { get; set; }

        [XmlElement(ElementName = "ValorIOF", IsNullable = true)]
        public int? ValorIOF { get; set; }

        [XmlElement(ElementName = "ValorParcela", IsNullable = true)]
        public int? ValorParcela { get; set; }

        [XmlElement(ElementName = "DataVectoPrimeiraParcela", IsNullable = true)]
        public int? DataVectoPrimeiraParcela { get; set; }

        [XmlElement(ElementName = "DataVectoUltimaParcela", IsNullable = true)]
        public int? DataVectoUltimaParcela { get; set; }

        [XmlElement(ElementName = "DataLiberacaoCredito", IsNullable = true)]
        public int? DataLiberacaoCredito { get; set; }

        [XmlElement(ElementName = "UFLiberacaoCredito", IsNullable = true)]
        public string UFLiberacaoCredito { get; set; }

        [XmlElement(ElementName = "MunicipioLiberacaoCredito", IsNullable = true)]
        public string MunicipioLiberacaoCredito { get; set; }

        [XmlElement(ElementName = "Indice", IsNullable = true)]
        public string Indice { get; set; }

        [XmlElement(ElementName = "NumGrupoConsorcio", IsNullable = true)]
        public string NumGrupoConsorcio { get; set; }

        [XmlElement(ElementName = "NumCotaConsorcio", IsNullable = true)]
        public int? NumCotaConsorcio { get; set; }

        [XmlElement(ElementName = "NumAditivo", IsNullable = true)]
        public string NumAditivo { get; set; }

        [XmlElement(ElementName = "DataAditivo", IsNullable = true)]
        public int? DataAditivo { get; set; }

        [XmlElement(ElementName = "NomeLogradouroAgente", IsNullable = true)]
        public string NomeLogradouroAgente { get; set; }

        [XmlElement(ElementName = "NumImovelAgente", IsNullable = true)]
        public string NumImovelAgente { get; set; }

        [XmlElement(ElementName = "ComplementoImovelAgente", IsNullable = true)]
        public string ComplementoImovelAgente { get; set; }

        [XmlElement(ElementName = "BairroAgente", IsNullable = true)]
        public string BairroAgente { get; set; }

        [XmlElement(ElementName = "NomeMunicipioAgente", IsNullable = true)]
        public string NomeMunicipioAgente { get; set; }

        [XmlElement(ElementName = "UFAgente", IsNullable = true)]
        public string UFAgente { get; set; }

        [XmlElement(ElementName = "CEPAgente", IsNullable = true)]
        public int? CEPAgente { get; set; }

        [XmlElement(ElementName = "DDDAgente", IsNullable = true)]
        public int? DDDAgente { get; set; }

        [XmlElement(ElementName = "TelefoneAgente", IsNullable = true)]
        public string TelefoneAgente { get; set; }

        [XmlElement(ElementName = "CPFCNPJDevedor", IsNullable = true)]
        public string CPFCNPJDevedor { get; set; }

        [XmlElement(ElementName = "NomeDevedor", IsNullable = true)]
        public string NomeDevedor { get; set; }

        [XmlElement(ElementName = "NomeLogradouroDevedor", IsNullable = true)]
        public string NomeLogradouroDevedor { get; set; }

        [XmlElement(ElementName = "NumImovelDevedor", IsNullable = true)]
        public string NumImovelDevedor { get; set; }

        [XmlElement(ElementName = "ComplementoImovelDevedor", IsNullable = true)]
        public string ComplementoImovelDevedor { get; set; }

        [XmlElement(ElementName = "BairroDevedor", IsNullable = true)]
        public string BairroDevedor { get; set; }

        [XmlElement(ElementName = "NomeMunicipioDevedor", IsNullable = true)]
        public string NomeMunicipioDevedor { get; set; }

        [XmlElement(ElementName = "UFDevedor", IsNullable = true)]
        public string UFDevedor { get; set; }

        [XmlElement(ElementName = "CEPDevedor", IsNullable = true)]
        public int? CEPDevedor { get; set; }

        [XmlElement(ElementName = "DDDDevedor", IsNullable = true)]
        public int? DDDDevedor { get; set; }

        [XmlElement(ElementName = "TelefoneDevedor", IsNullable = true)]
        public string TelefoneDevedor { get; set; }

        [XmlElement(ElementName = "UFLicenciamento", IsNullable = true)]
        public string UFLicenciamento { get; set; }

        [XmlElement(ElementName = "NumContratoOrigem", IsNullable = true)]
        public string NumContratoOrigem { get; set; }

        [XmlElement(ElementName = "NumAditivoOrigem", IsNullable = true)]
        public string NumAditivoOrigem { get; set; }


        public static implicit operator RegistrarContratoDTO((Contrato.Contrato request, VeiculoContrato veiculo) source)
        {
            try
            {
                var result = new RegistrarContratoDTO();
                #region Inclusão de novo contrato
                result.TipoOperacao = source.request.TipoOperacao.GetDetranScValue<int>();
                result.SequencialContrato = source.veiculo.SequencialContrato;
                result.NumAditivo = source.veiculo.SequencialAditivo?.ToString();
                result.NumContratoOrigem = source.veiculo.NumContratoOrigem;
                result.NumAditivoOrigem = source.veiculo.NumAditivoOrigem;

                #endregion

                #region Dados Veiculo
                result.Chassi = source.veiculo.Chassi;
                result.Remarcacao = source.veiculo.Remarcado ? 1 : 2;
                result.UFLicenciamento = source.veiculo.UfPlaca;
                result.UFPlaca = source.veiculo.UfPlaca;
                result.Placa = source.veiculo.Placa;
                result.RENAVAM = source.veiculo.Renavam.ToLong();
                result.AnoFabricacao = source.veiculo.AnoFabricacao ?? 0;
                result.AnoModelo = source.veiculo.AnoModelo ?? 0;
                #endregion

                #region Agente Financeiro
                result.NomeAgente = source.request.AgenteFinanceiro?.NomeRazaoSocial;
                result.CNPJAgente = source.request.AgenteFinanceiro?.CpfCnpj;
                #endregion

                #region Dados do Contrato
                result.NumContrato = source.request.NumeroContrato;
                result.DataContrato = source.request.DataCadastro.ToInt();
                result.QtdParcelas = source.request.QuantidadeMeses ?? 1;
                #endregion

                #region Gravame
                result.NumGravame = source.veiculo.Gravame.ToLong();
                result.TipoGravame = source.request.RestricaoContrato.GetDetranScValue<int>();
                #endregion

                #region Taxas
                result.TaxaJuroMes = (int)(source.request.TaxaJurosMes * 1000);
                result.TaxaJuroAno = (int)(source.request.TaxaJurosAno * 1000);
                result.TaxaJuroMulta = source.request.TaxaJurosMulta.ToXMLString();
                result.TaxaMoraDia = source.request.IndicativoMoraDia.ToXMLString();
                result.TaxaMulta = (int)(source.request.TaxaMulta * 1000);
                result.TaxaMora = (int)(source.request.TaxaMora * 1000);
                #endregion

                #region Penalidade e Comissões
                result.IndicativoPenalidade = source.request.IndicativoPenalidade.ToXMLString();
                result.Penalidade = source.request.DescricaoPenalidade;
                result.IndicativoComissao = source.request.IndicativoComissao.ToXMLString();
                result.Comissao = source.request.Comissao.ToDecimal();
                #endregion

                #region Valores
                result.ValorTaxaContrato = (int)(source.request.TaxaContrato * 100);
                result.ValorTotalFinanciamento = (int)(source.request.ValorTotalDivida * 100);
                result.ValorIOF = (int)(source.request.ValorIOF * 100);
                result.ValorParcela = (int)(source.request.ValorParcela * 100);
                #endregion

                #region Vencimentos
                result.DataVectoPrimeiraParcela = source.request.VencimentoPrimeiraParcela.ToInt();
                result.DataVectoUltimaParcela = source.request.VencimentoUltimaParcela.ToInt();
                #endregion

                #region Liberação Crédito
                result.DataLiberacaoCredito = source.request.DataLiberacaoCredito.ToInt();
                result.UFLiberacaoCredito = source.request.UfLiberacao;
                result.MunicipioLiberacaoCredito = source.request.MunicipioLiberacao;
                #endregion

                #region Indice; Consórcio e Aditivo
                result.Indice = source.request.IndiceCorrecao.GetDetranScValue<string>() ?? "0";
                result.NumGrupoConsorcio = source.request.GrupoConsorcio;
                result.NumCotaConsorcio = source.request.CotaConsorcio.ToInt();
                result.DataAditivo = source.request.DataCadastro.ToInt();
                #endregion

                #region Endereço Agente
                result.NomeLogradouroAgente = source.request.AgenteFinanceiro?.Endereco;
                result.NumImovelAgente = source.request.AgenteFinanceiro?.Numero;
                result.ComplementoImovelAgente = source.request.AgenteFinanceiro?.Complemento;
                result.BairroAgente = source.request.AgenteFinanceiro?.Bairro;
                result.NomeMunicipioAgente = source.request.AgenteFinanceiro?.Municipio;
                result.UFAgente = source.request.AgenteFinanceiro?.Estado;
                result.CEPAgente = source.request.AgenteFinanceiro?.Cep.ToInt() ?? 0;
                result.DDDAgente = source.request.AgenteFinanceiro.Telefone.ToIntSubString(0, 2);
                result.TelefoneAgente = source.request.AgenteFinanceiro?.Telefone.Substring(2);
                #endregion

                #region Dados do Devedor
                result.CPFCNPJDevedor = source.request.DonoDoVeiculo?.CpfOuCnpj;
                result.NomeDevedor = source.request.DonoDoVeiculo?.NomeOuRazaoSocial;
                result.NomeLogradouroDevedor = source.request.DonoDoVeiculo?.Endereco;
                result.NumImovelDevedor = source.request.DonoDoVeiculo?.Numero;
                result.ComplementoImovelDevedor = source.request.DonoDoVeiculo?.Complemento;
                result.BairroDevedor = source.request.DonoDoVeiculo?.Bairro;
                result.NomeMunicipioDevedor = source.request.DonoDoVeiculo?.Municipio;
                result.UFDevedor = source.request.DonoDoVeiculo?.Estado;
                result.CEPDevedor = source.request.DonoDoVeiculo?.Cep.ToInt() ?? 0;
                result.DDDDevedor = source.request.DonoDoVeiculo.CelularComDdd is null ?
                            source.request.DonoDoVeiculo.TelefoneComDdd.ToIntSubString(0, 2)
                            : source.request.DonoDoVeiculo.CelularComDdd.ToIntSubString(0, 2);
                result.TelefoneDevedor = source.request.DonoDoVeiculo.CelularComDdd is null ?
                            source.request.DonoDoVeiculo.TelefoneComDdd.Substring(2)
                            : source.request.DonoDoVeiculo.CelularComDdd.Substring(2);
                #endregion

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
            
    }
}
