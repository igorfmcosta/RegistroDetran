using System.Xml.Serialization;

namespace RegistroDetran.Application.DTOs.Detran.SC
{
    [XmlRoot("Envelope", Namespace = SoapNs)]
    public class Envelope<TBody> where TBody : class
    {
        public Envelope()
        {
            Header = new Header();
        }

        [XmlElement("Header")]
        public Header? Header { get; set; }

        [XmlElement("Body")]
        public TBody? Body { get; set; }

        public const string SoapNs = "http://www.w3.org/2003/05/soap-envelope";
        public const string RegNs = "http://webservicesh.sc.gov.br/detran/RegistroContrato";
    }

    [XmlType(Namespace = Envelope<object>.RegNs)]
    public class Header
    {
        public Header()
        {
            Credenciais = new Credenciais();
        }

        [XmlElement("Credenciais")]
        public Credenciais? Credenciais { get; set; }
    }

    [XmlType(Namespace = Envelope<object>.RegNs)]
    public class Credenciais
    {
        public string? Usuario { get; set; }
        public string? Senha { get; set; }
    }
}
