using RegistroDetran.Application.DTOs.Contrato;
using RegistroDetran.Core.Extensions;
using System.Xml.Serialization;

namespace RegistroDetran.Application.DTOs.Detran.SC
{
    public class BodyConsulta
    {
        public BodyConsulta(ConsultarSequencialContratoDTO dados)
        {
            ConsultarSequencialContrato = new ConsultarSequencialContrato(dados);
        }
        public BodyConsulta()
        {
        }

        [XmlElement(ElementName = "ConsultarSequencialContrato", Namespace = Envelope<object>.RegNs)]
        public ConsultarSequencialContrato ConsultarSequencialContrato { get; set; }
    }

    [XmlType(TypeName = "RegistrarContrato", Namespace = Envelope<object>.RegNs)]
    public class ConsultarSequencialContrato
    {
        public ConsultarSequencialContrato(ConsultarSequencialContratoDTO dados)
        {
            Dados = dados;
        }

        public ConsultarSequencialContrato()
        {
        }

        [XmlElement(ElementName = "Dados", Namespace = Envelope<object>.RegNs)]
        public ConsultarSequencialContratoDTO? Dados { get; set; }
    }


    [XmlType(TypeName = "Dados", Namespace = Envelope<object>.RegNs)]
    public class ConsultarSequencialContratoDTO
    {
        [XmlElement(ElementName = "Chassi", IsNullable = true)]
        public string Chassi { get; set; } = string.Empty;

        [XmlElement(ElementName = "CNPJAgente", IsNullable = true)]
        public string CNPJAgente { get; set; }

        [XmlElement(ElementName = "Remarcacao", IsNullable = false)]
        public int Remarcacao { get; set; }

        [XmlElement(ElementName = "NumGravame", IsNullable = false)]
        public int NumGravame { get; set; }

        [XmlElement(ElementName = "TipoGravame", IsNullable = false)]
        public int TipoGravame { get; set; }

        public static implicit operator ConsultarSequencialContratoDTO((ContratoRequest request, VeiculoContrato veiculo) source) =>
            new ConsultarSequencialContratoDTO
            {
                Chassi = source.veiculo.Chassi,
                CNPJAgente = source.request.Contrato.AgenteFinanceiro?.CpfCnpj ?? string.Empty,
                Remarcacao = source.veiculo.Remarcado ? 1 : 2,
                NumGravame = source.veiculo.Gravame.ToInt(),
                TipoGravame = source.request.Contrato.RestricaoContrato.GetDetranScValue<int>(),
            };
    }
}
