using RegistroDetran.Application.DTOs.Contrato;
using RegistroDetran.Core.Models.Options;
using System.Xml.Linq;

namespace RegistroDetran.Application.Services.Detran.Requests.RJ
{
    public abstract class SoapRequestBase
    {
        public abstract string CodigoTransacao { get; }
        public abstract XElement CreateRequestBody(Contrato contrato);

        protected string GenerateFixaValue(Contrato contrato)
        {
            return "";
            //return string.Concat(
            //    contrato.Sequencial.ToString().PadLeft(6, '0'),                 // NÚMERO SEQUENCIAL
            //    CodigoTransacao,                                                // CÓDIGO TRANSAÇÃO
            //    "4",                                                            // MODALIDADE
            //    contrato.DonoDoVeiculo?.NomeOuRazaoSocial.FitToLength(11, ' '), // CLIENTE
            //    "RJ",                                                           // UF ORIGEM TRANSAÇÃO
            //    "RJ",                                                           // UF ORIGEM TRANSMISSÃO
            //    "RJ",                                                           // UF DESTINO TRANSMISSÃO
            //    "1",                                                            // TIPO CONDICIONALIDADE
            //    "0000",                                                         // TAMANHO TRANSAÇÃO
            //    "00",                                                           // CÓDIGO RET. TRANSAÇÃO
            //    contrato.DiaJuliano.ToString().PadLeft(3, '0')                  // DIA JULIANO
            //);
        }

        public XElement CreateEnvelope(Contrato contrato, SoapServiceOptions options)
        {
            XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace urn = "urn:com-softwareag-entirex-rpc:LIBBRK-GTRN0003";
            XNamespace x = "urn:com.softwareag.entirex.xml.rt";
            XNamespace xml = XNamespace.Xml;

            return new XElement(soapenv + "Envelope",
                new XAttribute(XNamespace.Xmlns + "soapenv", soapenv),
                new XAttribute(XNamespace.Xmlns + "urn", urn),

                new XElement(soapenv + "Header",
                    new XElement(x + "EntireX",
                        new XAttribute(XNamespace.Xmlns + "x", x),
                        new XElement("exx-natural-library", "LIBBRK"),
                        new XElement("exx-rpc-userID", options.UserId),
                        new XElement("exx-rpc-password", options.Password),
                        new XElement("exx-natural-security", "true")
                    )
                ),

                new XElement(soapenv + "Body",
                    new XElement(urn + "GTRN0003",
                        new XElement("Fixa",
                            new XAttribute(xml + "space", "preserve"),
                            GenerateFixaValue(contrato)),
                        CreateRequestBody(contrato)
                    )
                )
            );
        }
    }
}
