using Microsoft.EntityFrameworkCore;

namespace MusicasAPI;

public class MusicaDb(DbContextOptions<MusicaDb> options) : DbContext(options)
{
    public DbSet<Musica> Musicas => Set<Musica>();
}