namespace MusicasAPI;

public class Musica
{
    public int Id { get; set; }
    public required string Titulo { get; set; }
    public required string Artista { get; set; }
    public required string Album { get; set; }
    public required string Genero { get; set; }
    public int AnoLancamento { get; set; }
    public required string Duracao { get; set; }
}