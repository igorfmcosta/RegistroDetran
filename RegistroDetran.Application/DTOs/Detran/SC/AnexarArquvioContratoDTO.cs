using RegistroDetran.Application.DTOs.Contrato;
using System.Xml.Serialization;

namespace RegistroDetran.Application.DTOs.Detran.SC
{
    public class BodyAnexo
    {
        public BodyAnexo(AnexarArquvioContratoDto dados)
        {
            AnexarArquivo = new AnexarArquivo(dados);
        }
        public BodyAnexo()
        {
        }

        [XmlElement(ElementName = "AnexarArquivo ", Namespace = Envelope<object>.RegNs)]
        public AnexarArquivo AnexarArquivo { get; set; }
    }

    [XmlType(TypeName = "RegistrarContrato", Namespace = Envelope<object>.RegNs)]
    public class AnexarArquivo
    {
        public AnexarArquivo(AnexarArquvioContratoDto dados)
        {
            Dados = dados;
        }

        public AnexarArquivo()
        {
        }

        [XmlElement(ElementName = "Dados", Namespace = Envelope<object>.RegNs)]
        public AnexarArquvioContratoDto? Dados { get; set; }
    }


    [XmlType(TypeName = "Dados", Namespace = Envelope<object>.RegNs)]
    public class AnexarArquvioContratoDto
    {
        [XmlElement(ElementName = "SequencialContrato", IsNullable = true)]
        public long? SequencialContrato { get; set; }

        [XmlElement(ElementName = "SequencialAditivo", IsNullable = true)]
        public long? SequencialAditivo { get; set; }

        [XmlElement(ElementName = "ArquivoContrato", IsNullable = false)]
        public string ArquivoContrato { get; set; }


        public static implicit operator AnexarArquvioContratoDto((Contrato.Contrato request, VeiculoContrato veiculo) source) =>
            new AnexarArquvioContratoDto
            {
                SequencialContrato = source.veiculo.SequencialContrato,
                SequencialAditivo = source.veiculo.SequencialAditivo,
                ArquivoContrato = source.veiculo.AnexoContrato
            };
    }
}
