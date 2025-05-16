namespace RegistroDetran.Application.DTOs.Contrato
{
    public class Arquivo
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string MimeType { get; set; } = string.Empty;
        public string Extensao { get; set; } = string.Empty;
    }
}
