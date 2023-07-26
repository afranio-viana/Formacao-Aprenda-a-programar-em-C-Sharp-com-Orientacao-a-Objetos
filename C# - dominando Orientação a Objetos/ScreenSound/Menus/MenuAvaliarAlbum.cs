using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Console.Write($"Qual a nota que o album {tituloAlbum} da(o) {nomeDaBanda} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum} da(o) {nomeDaBanda}");
                Thread.Sleep(2000);
                Console.Clear();

            }else
            {
                AlbumNaoEncontrado(tituloAlbum);
            }
            
        }
        else
        {
            BandaNaoEncontrada(nomeDaBanda);
        }
    }

}