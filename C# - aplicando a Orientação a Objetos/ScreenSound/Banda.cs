class Banda
{
    public Banda(string nome)
    {
        NomeDaBanda = nome;
    }
    public List<Album> albuns= new List<Album>();
    public string NomeDaBanda {get;}

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\n\nA discografia da banda: {NomeDaBanda}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.NomeDoAlbum} ({album.DuracaoTotal}s)");
        }
    }
}