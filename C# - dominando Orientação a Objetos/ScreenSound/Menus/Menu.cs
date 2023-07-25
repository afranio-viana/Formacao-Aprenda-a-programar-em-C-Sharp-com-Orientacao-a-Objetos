using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class Menu
{
    public static void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        char characterDecoration = '*';
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras+2, characterDecoration);
        Console.WriteLine($"\t\t{asteriscos}");
        Console.WriteLine($"\t\t{characterDecoration}{titulo}{characterDecoration}");
        Console.WriteLine($"\t\t{asteriscos}\n");
    }

    public static void BandaNaoEncontrada(string nomeDaBanda)
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}