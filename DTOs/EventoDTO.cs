namespace TimeLineApi.DTOs
{
    public class EventoDTO
    {
    public string Titulo { get; set; } = string.Empty; // Sem null, só vazio
    public string Descricao { get; set; } = string.Empty;
    public DateTime Data { get; set; }
    }
}
