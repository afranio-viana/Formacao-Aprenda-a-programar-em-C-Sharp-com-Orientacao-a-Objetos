namespace ScreenSound_04.Modelos;
using ScreenSound_04.Modelos;
using System.Text.Json;

internal class MusicasPreferidas
{
    public string? Nome {get;}
    public List<Musica> ListaDeMusicasFavoritas{get;}

    public MusicasPreferidas (string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();  
    }

    public void AdicionarMusicasFavoritas (Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas do usuário >>> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($" - {musica.Nome} de {musica.Artista} ({musica.Ano})");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson ()
    {
        /*Aqui foi criado um objeto anônimo*/
        string json = JsonSerializer.Serialize(new 
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas,
        });
        string nomeDoArquivo = $"Documents/musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo {nomeDoArquivo}.json foi criado com sucesso!");
        
    }
}