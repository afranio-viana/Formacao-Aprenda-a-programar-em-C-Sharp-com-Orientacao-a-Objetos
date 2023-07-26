using ScreenSound_04.Modelos;
using System.Text.Json;

Console.Clear();
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        foreach (Musica musica in musicas.OrderBy(mu => mu.Artista))
        {
            musica.ExibirDetalhesDaMusica();
        }
    }catch (Exception ex)
    {
        Console.WriteLine($"\n\nInfelizmente não funfou!!!\n\nMotivo: {ex.Message}");
    }
}