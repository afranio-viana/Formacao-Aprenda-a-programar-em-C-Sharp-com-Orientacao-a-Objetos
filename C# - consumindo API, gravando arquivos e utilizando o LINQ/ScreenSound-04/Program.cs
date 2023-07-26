using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

Console.Clear();
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // foreach (Musica musica in musicas.OrderBy(mu => mu.Artista))
        // {
        //     musica.ExibirDetalhesDaMusica();
        // }
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

    }catch (Exception ex)
    {
        Console.WriteLine($"\n\nInfelizmente não funfou!!!\n\nMotivo: {ex.Message}");
    }
}