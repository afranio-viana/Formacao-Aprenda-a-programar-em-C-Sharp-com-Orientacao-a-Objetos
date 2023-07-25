class _Podcast
{
    public _Podcast(string nome, string podcast)
    {
        HostNome = nome;
        NomePodcast = podcast;
    }
    public string HostNome{get;}
    public string NomePodcast{get;}
    List<Episodio> episodios = new List<Episodio>();
    public int TotalDeEpisodios => episodios.Count();

    public void AdicionarEpisodio(Episodio episodio){
        episodios.Add(episodio);
    }

    public void ExibirDetalhes(){
        Console.WriteLine($"\n\nPodcast {NomePodcast} apresentado por {HostNome}");
        foreach(Episodio episodio in episodios.OrderBy(e=>e.Ordem)){
            Console.WriteLine($"{episodio.Resumo}");
        }
        Console.WriteLine($"Esse podcast possui {TotalDeEpisodios} episódios");
    }

}