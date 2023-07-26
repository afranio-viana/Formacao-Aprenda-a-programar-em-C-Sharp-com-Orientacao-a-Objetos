using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {

        var todosOsGenerosMusicais = musicas.OrderBy(generos => generos.Genero).Select(generos => generos.Genero).Distinct().ToList();
        foreach ( var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}