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
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Lady Gaga");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2012");

        var musicasPreferidasDoAfranio =  new MusicasPreferidas("Afrânio");
        musicasPreferidasDoAfranio.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoAfranio.AdicionarMusicasFavoritas(musicas[9]);
        musicasPreferidasDoAfranio.AdicionarMusicasFavoritas(musicas[11]);
        musicasPreferidasDoAfranio.AdicionarMusicasFavoritas(musicas[60]);
        musicasPreferidasDoAfranio.AdicionarMusicasFavoritas(musicas[1000]);
        musicasPreferidasDoAfranio.ExibirMusicasFavoritas();
        musicasPreferidasDoAfranio.GerarArquivoJson();

     

        var musicasPreferidasDoViana = new MusicasPreferidas("Viana");
        musicasPreferidasDoViana.AdicionarMusicasFavoritas(musicas[89]);
        musicasPreferidasDoViana.AdicionarMusicasFavoritas(musicas[69]);
        musicasPreferidasDoViana.AdicionarMusicasFavoritas(musicas[912]);
        musicasPreferidasDoViana.AdicionarMusicasFavoritas(musicas[164]);
        musicasPreferidasDoViana.AdicionarMusicasFavoritas(musicas[921]);
        musicasPreferidasDoViana.ExibirMusicasFavoritas();
    
    }catch (Exception ex)
    {
        Console.WriteLine($"\n\nInfelizmente não funfou!!!\n\nMotivo: {ex.Message}");
    }
}