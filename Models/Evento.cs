using System.ComponentModel.DataAnnotations;
namespace TimeLineApi.Models;

public class Evento
{
    public int Id { get; set; }

    public required string Titulo { get; set; }
    public required string Descricao { get; set; }
    public required DateTime Data { get; set; }

    public Evento() { }

    public Evento(string titulo, string descricao, DateTime data)
    {
        Titulo = titulo;
        Descricao = descricao;
        Data = data;
    }
}
