class Genero
{
    public Genero (string nome){
        NomeDoGenero = nome;
    }
    public string NomeDoGenero {get;}
    List<Musica> musicas = new List<Musica> ();

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
        /*Sempre que uma múscia for adicionada a um gênero,
        o atributo gênero pode ser modificado*/
        musica.Genero = this;
    }

    public void ExibirMusicasDoGenero()
    {
        Console.WriteLine($"\nGênero Musical: {NomeDoGenero}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.NomeDaMusica} - {musica.Artista.NomeDaBanda}");
        }
    }
}