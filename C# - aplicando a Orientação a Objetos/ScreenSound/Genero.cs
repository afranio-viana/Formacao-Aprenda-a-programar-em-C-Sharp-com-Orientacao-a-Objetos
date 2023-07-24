class Genero
{
    public string NomeDoGenero {get; set;}
    List<Musica> musicas = new List<Musica> ();

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoGenero()
    {
        Console.WriteLine($"\nGênero Musical: {NomeDoGenero}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.NomeDaMusica} - {musica.Artista}");
        }
    }
}