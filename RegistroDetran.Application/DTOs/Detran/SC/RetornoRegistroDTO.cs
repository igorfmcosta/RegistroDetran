using System.Xml.Serialization;

namespace RegistroDetran.Application.DTOs.Detran.SC
{
    [XmlRoot("Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class SoapEnvelopeRegistro
    {
        [XmlElement("Body")]
        public SoapBody Body { get; set; }
    }

    public class SoapBody
    {
        [XmlElement("RegistrarContratoResponse", Namespace = "http://webservicesh.sc.gov.br/detran/RegistroContrato")]
        public RegistrarContratoResponse RegistrarContratoResponse { get; set; }
    }

    public class RegistrarContratoResponse
    {
        [XmlElement("RegistrarContratoResult")]
        public RegistrarContratoResult RegistrarContratoResult { get; set; }
    }

    public class RegistrarContratoResult
    {
        [XmlElement("CodRetorno")]
        public int CodRetorno { get; set; }

        [XmlElement("DescRetorno")]
        public string DescRetorno { get; set; }

        [XmlElement("SequencialContrato")]
        public int SequencialContrato { get; set; }

        [XmlElement("SequencialAditivo")]
        public int SequencialAditivo { get; set; }
    }
}
