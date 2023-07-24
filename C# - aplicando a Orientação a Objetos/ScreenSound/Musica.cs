class Musica
{
    /*Isso é um construtor, sempre que um objeto música é criado,
    deve ser passado um objeto da classe banda como referência*/
    public Musica (Banda artista,string nome, Genero genero){
        Artista = artista;
        NomeDaMusica = nome;
        Genero = genero;
    }
    public string NomeDaMusica {get;}
    public Banda Artista {get;}
    public int Duracao {get; set;}
    public Genero Genero {get; set;}

    /*Por convenção, properties iniciam com letra
    maiúscula*/
    public bool Disponivel {get; set;}

    /*Isso é uma expressão Lambda*/
    public string DescricaoResumida =>
            $"A múscia {NomeDaMusica} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {NomeDaMusica}");
        Console.WriteLine($"Artista: {Artista.NomeDaBanda}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Gênero: {Genero.NomeDoGenero}");
        
        if(Disponivel)
        {
            Console.WriteLine($"A música '{NomeDaMusica}' está disponível!\n");
        }else
        {
            Console.WriteLine($"A música '{NomeDaMusica}' não está disponível no seu plano!\n");
        }
    }

    public void ExibirNomeMusicaArtista()
    {
        Console.WriteLine(DescricaoResumida);
    }

}