﻿using RegistroDetran.Application.DTOs.Contrato;
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


        public static implicit operator RegistrarContratoDTO((ContratoRequest request, VeiculoContrato veiculo) source) =>
            new RegistrarContratoDTO()
            {
                #region Inclusão de novo contrato
                TipoOperacao = source.request.TipoOperacao,
                SequencialContrato = source.request.Sequencial.GetValueOrDefault(),
                NumContratoOrigem = source.request.NumContratoOrigem,
                NumAditivoOrigem = source.request.NumAditivoOrigem,
                #endregion

                #region Dados Veiculo
                Chassi = source.veiculo.Chassi,
                Remarcacao = source.veiculo.Remarcado ? 1 : 2,
                UFLicenciamento = source.veiculo.UfPlaca,
                UFPlaca = source.veiculo.UfPlaca,
                Placa = source.veiculo.Placa,
                RENAVAM = source.veiculo.Renavam.ToLong(),
                AnoFabricacao = source.veiculo.AnoFabricacao ?? 0,
                AnoModelo = source.veiculo.AnoModelo ?? 0,
                #endregion

                #region Agente Financeiro
                NomeAgente = source.request.Contrato.AgenteFinanceiro?.NomeRazaoSocial,
                CNPJAgente = source.request.Contrato.AgenteFinanceiro?.CpfCnpj,
                #endregion

                #region Dados do Contrato
                NumContrato = source.request.Contrato.NumeroContrato,
                DataContrato = source.request.Contrato.DataCadastro.ToInt(),
                QtdParcelas = source.request.Contrato.QuantidadeMeses ?? 1,
                #endregion

                #region Gravame
                NumGravame = source.veiculo.Gravame.ToLong(),
                TipoGravame = source.request.Contrato.RestricaoContrato.GetDetranScValue<int>(),
                #endregion

                #region Taxas
                TaxaJuroMes = (int)(source.request.Contrato.TaxaJurosMes * 100),
                TaxaJuroAno = (int)(source.request.Contrato.TaxaJurosAno * 100),
                TaxaJuroMulta = source.request.Contrato.TaxaJurosMulta.ToXMLString(),
                TaxaMoraDia = source.request.Contrato.IndicativoMoraDia.ToXMLString(),
                TaxaMulta = (int)(source.request.Contrato.TaxaMulta * 100),
                TaxaMora = (int)(source.request.Contrato.TaxaMora * 100),
                #endregion

                #region Penalidade e Comissões
                IndicativoPenalidade = source.request.Contrato.IndicativoPenalidade.ToXMLString(),
                Penalidade = source.request.Contrato.DescricaoPenalidade,
                IndicativoComissao = source.request.Contrato.IndicativoComissao.ToXMLString(),
                Comissao = source.request.Contrato.Comissao.ToDecimal(),
                #endregion

                #region Valores
                ValorTaxaContrato = (int)(source.request.Contrato.TaxaContrato * 100),
                ValorTotalFinanciamento = (int)(source.request.Contrato.ValorTotalDivida * 100),
                ValorIOF = (int)(source.request.Contrato.ValorIOF * 100),
                ValorParcela = (int)(source.request.Contrato.ValorParcela * 100),
                #endregion

                #region Vencimentos
                DataVectoPrimeiraParcela = source.request.Contrato.VencimentoPrimeiraParcela.ToInt(),
                DataVectoUltimaParcela = source.request.Contrato.VencimentoUltimaParcela.ToInt(),
                #endregion

                #region Liberação Crédito
                DataLiberacaoCredito = source.request.Contrato.DataLiberacaoCredito.ToInt(),
                UFLiberacaoCredito = source.request.Contrato.UfLiberacao,
                MunicipioLiberacaoCredito = source.request.Contrato.MunicipioLiberacao,
                #endregion

                #region Indice, Consórcio e Aditivo
                Indice = source.request.Contrato.IndiceCorrecao.GetDetranScValue<string>() ?? "0",
                NumGrupoConsorcio = source.request.Contrato.GrupoConsorcio,
                NumCotaConsorcio = source.request.Contrato.CotaConsorcio.ToInt(),
                NumAditivo = source.request.NumAditivo,
                DataAditivo = source.request.Contrato.DataCadastro.ToInt(),
                #endregion

                #region Endereço Agente
                NomeLogradouroAgente = source.request.Contrato.AgenteFinanceiro?.Endereco,
                NumImovelAgente = source.request.Contrato.AgenteFinanceiro?.Numero,
                ComplementoImovelAgente = source.request.Contrato.AgenteFinanceiro?.Complemento,
                BairroAgente = source.request.Contrato.AgenteFinanceiro?.Bairro,
                NomeMunicipioAgente = source.request.Contrato.AgenteFinanceiro?.Municipio,
                UFAgente = source.request.Contrato.AgenteFinanceiro?.Estado,
                CEPAgente = source.request.Contrato.AgenteFinanceiro?.Cep.ToInt() ?? 0,
                DDDAgente = source.request.Contrato.AgenteFinanceiro.Telefone.ToIntSubString(0, 2),
                TelefoneAgente = source.request.Contrato.AgenteFinanceiro?.Telefone.Substring(2),
                #endregion

                #region Dados do Devedor
                CPFCNPJDevedor = source.request.Contrato.DonoDoVeiculo?.CpfOuCnpj,
                NomeDevedor = source.request.Contrato.DonoDoVeiculo?.NomeOuRazaoSocial,
                NomeLogradouroDevedor = source.request.Contrato.DonoDoVeiculo?.Endereco,
                NumImovelDevedor = source.request.Contrato.DonoDoVeiculo?.Numero,
                ComplementoImovelDevedor = source.request.Contrato.DonoDoVeiculo?.Complemento,
                BairroDevedor = source.request.Contrato.DonoDoVeiculo?.Bairro,
                NomeMunicipioDevedor = source.request.Contrato.DonoDoVeiculo?.Municipio,
                UFDevedor = source.request.Contrato.DonoDoVeiculo?.Estado,
                CEPDevedor = source.request.Contrato.DonoDoVeiculo?.Cep.ToInt() ?? 0,
                DDDDevedor = source.request.Contrato.DonoDoVeiculo.CelularComDdd is null ?
                    source.request.Contrato.DonoDoVeiculo.TelefoneComDdd.ToIntSubString(0, 2)
                    : source.request.Contrato.DonoDoVeiculo.CelularComDdd.ToIntSubString(0,2),
                TelefoneDevedor = source.request.Contrato.DonoDoVeiculo.CelularComDdd.Substring(2) is null ?
                    source.request.Contrato.DonoDoVeiculo.TelefoneComDdd.Substring(2)
                    : source.request.Contrato.DonoDoVeiculo.CelularComDdd.Substring(2),
                #endregion
            };
    }
}
