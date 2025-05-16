using RegistroDetran.Application.DTOs.Contrato;
using System.Xml.Linq;

namespace RegistroDetran.Application.Services.Detran.Requests.RJ
{
    public class SoapRequest002 : SoapRequestBase
    {
        public override string CodigoTransacao => "002";

        public override XElement CreateRequestBody(Contrato contrato)
        {
            return new XElement("Variavel",
                new XAttribute(XNamespace.Xml + "space", "preserve"),
                new XElement("string", ""));
        }
    }
}
