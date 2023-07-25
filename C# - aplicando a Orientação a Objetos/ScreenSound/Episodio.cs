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
    /*Foi utilizado o Join para realizar a concatenação
    de todos os itens da lista*/
    public string Resumo => $"{Ordem} - {Titulo} ({Duracao}) min: - {string.Join(", ",convidadosDoPodcast)}";

    public void AdicionarConvidados (string convidados)
    {
        convidadosDoPodcast.Add(convidados);
    }
    
}