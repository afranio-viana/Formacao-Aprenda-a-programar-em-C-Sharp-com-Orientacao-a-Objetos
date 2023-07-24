class Musica
{
    public string NomeDaMusica {get; set;}
    public string Artista {get; set;}
    public int Duracao {get; set;}

    /*Por convenção, properties iniciam com letra
    maiúscula*/
    public bool Disponivel {get; set;}

    /*Isso é uma expressão Lambda*/
    public string DescricaoResumida =>
            $"A múscia {NomeDaMusica} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {NomeDaMusica}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
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