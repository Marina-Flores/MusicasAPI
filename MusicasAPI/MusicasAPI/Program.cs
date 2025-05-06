using Microsoft.EntityFrameworkCore;
using MusicasAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<MusicaDb>(opt => opt.UseInMemoryDatabase("MusicaList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<MusicaDb>();

    if (!db.Musicas.Any())
    {
        db.Musicas.AddRange(
            new Musica
            {
                Titulo = "Tá Vendo Aquela Lua",
                Artista = "Sorriso Maroto",
                Album = "Sorriso Maroto (Ao Vivo)",
                Genero = "Pagode",
                AnoLancamento = 2010,
                Duracao = "4:06"
            },
            new Musica
            {
                Titulo = "Me Apaixonei Pela Pessoa Errada",
                Artista = "Exaltasamba",
                Album = "Ao Vivo",
                Genero = "Pagode",
                AnoLancamento = 2008,
                Duracao = "4:15"
            },
            new Musica
            {
                Titulo = "Deixa Acontecer",
                Artista = "Grupo Revelação",
                Album = "Revelação Ao Vivo",
                Genero = "Pagode",
                AnoLancamento = 2000,
                Duracao = "3:35"
            }
        );

        await db.SaveChangesAsync();
    }
}

app.MapGet("/musicas", async (MusicaDb db) =>
    await db.Musicas.ToListAsync());

app.MapPost("/musicas", async (Musica musica, MusicaDb db) =>
{
    db.Musicas.Add(musica);
    await db.SaveChangesAsync();

    return Results.Created($"/musicas/{musica.Id}", musica);
});

app.Run();
