namespace RegistroDetran.Application.DTOs.Detran.SC
{
    public class ResultDTO<T>
    {
        public T? Result { get; set; }
        public string Erro { get; set; }
        public string Placa { get; set; }
    }
}
