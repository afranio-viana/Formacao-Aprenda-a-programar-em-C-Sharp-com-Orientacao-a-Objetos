class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string NomeDoAlbum {get; set;}

    /*Foi utilizada uma expressão labmda para realizar
    a soma de todos as propriedade de Duração dentro
    da lista de músicas*/
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do Album '{NomeDoAlbum}':\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.NomeDaMusica}");
        }
        Console.WriteLine($"\nPara ouvir esse álbum inteiro, você precisa de {DuracaoTotal} segundos!");
    }

}