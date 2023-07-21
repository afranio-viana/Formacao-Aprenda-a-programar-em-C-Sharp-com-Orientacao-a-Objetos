class Musica
{
    public string nomeDaMusica;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {nomeDaMusica}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if(disponivel)
        {
            Console.WriteLine($"A música '{nomeDaMusica}' está disponível!\n");
        }else
        {
            Console.WriteLine($"A música '{nomeDaMusica}' não está disponível no seu plano!\n");
        }
    }

    public void ExibirNomeMusicaArtista()
    {
        Console.WriteLine($"\n{nomeDaMusica} - {artista}\n");
    }
}