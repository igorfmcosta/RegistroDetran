namespace RegistroDetran.Application.DTOs.Contrato
{
    public class FinanceiraEstado
    {
        public long Id { get; set; }
        public string Uf { get; set; }
        public bool Ativa { get; set; }
        public string CodigoDetran { get; set; } = string.Empty;
        public DateTime DataInicioCredenciamento { get; set; }
        public DateTime DataFimCredenciamento { get; set; }

        public bool ReembolsoValorDetran { get; set; }
        public int DiaCobranca { get; set; }
    }
}
