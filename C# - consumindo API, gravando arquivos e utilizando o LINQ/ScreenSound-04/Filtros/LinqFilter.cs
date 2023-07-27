using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais (List<Musica> musicas)
    {

        var todosOsGenerosMusicais = musicas.OrderBy(generos => generos.Genero).Select(generos => generos.Genero).Distinct().ToList();
        foreach ( var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical (List<Musica> musicas, string genero)
    {

        var artistaPorGeneroMusical = musicas.Where (musica => musica.Genero!.Contains(genero)).OrderBy(musica=> musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistaPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }

    }

    public static void FiltrarMusicasDeUmArtista (List<Musica> musicas, string artista)
    {
        var musicaPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine($"Exibindo as músicas do artista >>> {artista}");
        foreach (var musica in musicaPorArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }    
    }

    public static void FiltrarMusicasPorAno (List<Musica> musicas, string ano)
    {
        //var musicaPorAno = musicas.Where(musica => Convert.ToInt32(musica.Ano!) > Convert.ToInt32(ano)).OrderBy(musica => musica.Ano).ToList();
        var musicaPorAno = musicas.Where(musica =>musica.Ano!.Equals(ano)).ToList();
        Console.WriteLine($"Exibindo as músicas do ano de >>> {ano}");
        foreach (var musica in musicaPorAno)
        {
            Console.WriteLine($"{musica.Ano} - {musica.Nome} - {musica.Artista}");
        }
    }

    public static void FiltrarMusicaPorTonalidade (List<Musica> musicas, string tonalidade)
    {
        var musicaPorTonalidade = musicas.Where(musica => musica.Tonalidade!.Equals(tonalidade)).ToList();
        Console.WriteLine($"Músicas na tonalidade >>> {tonalidade}\n\n");
        foreach (var musica in musicaPorTonalidade)
        {
            Console.WriteLine($"{musica.Tonalidade} - {musica.Nome} - {musica.Artista} - {musica.Ano}");
        }
    }
}