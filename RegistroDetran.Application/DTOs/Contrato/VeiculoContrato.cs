namespace RegistroDetran.Application.DTOs.Contrato
{
    public class VeiculoContrato
    {
        public long Id { get; set; }
        public Marca? Marca { get; set; }
        public Modelo? Modelo { get; set; }
        public int? AnoFabricacao { get; set; }
        public int? AnoModelo { get; set; }
        public string Placa { get; set; } = "";
        public string Chassi { get; set; } = "";
        public CorVeiculo? Cor { get; set; }
        public string Renavam { get; set; } = "";
        public string Gravame { get; set; } = "";
        public bool Remarcado { get; set; } = false;
        public bool? ZeroKm { get; set; }
        public string UfPlaca { get; set; } = "";
        public TipoVeiculo TipoVeiculo { get; set; }
        public long? SequencialContrato { get; set; } = 0;
        public long? SequencialAditivo { get; set; } = 0;
        public string NumContratoOrigem { get; set; } = "0";
        public string NumAditivoOrigem { get; set; } = "0";
        public string AnexoContrato { get; set; } = string.Empty;
    }
}
