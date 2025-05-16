namespace RegistroDetran.Application.DTOs.Contrato
{
    public class Modelo
    {
        public long Id { get; set; }
        public string CodigoDetran { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Ano { get; set; } = string.Empty;
        public bool Ativo { get; set; }
        public Marca? Marca;
    }
}
