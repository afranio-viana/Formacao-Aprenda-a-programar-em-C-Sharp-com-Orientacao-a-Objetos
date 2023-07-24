class Episodio
{
    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }
    public int Duracao {get;}
    public int Ordem {get;}

    public string Titulo {get;}
    public List<string> convidadosDoPodcast = new List<string>();

    public void AdicionarConvidados (string convidados)
    {
        convidadosDoPodcast.Add(convidados);
    }

    public void Resumo()
    {
        Console.WriteLine($"{Ordem} - {Titulo} ({Duracao}): ");
        foreach(string convidado in convidadosDoPodcast)
        {
            Console.WriteLine($"{convidado}");
        }
    }

    
}