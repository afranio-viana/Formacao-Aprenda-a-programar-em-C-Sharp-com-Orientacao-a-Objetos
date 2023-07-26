using ScreenSound.Modelos;
namespace ScreenSound.Menu;
using OpenAI_API;

internal class MenuRegistrarBanda:Menu
{
    public override void Executar (Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar (bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(banda.Nome,banda);

        var client = new OpenAIAPI("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");

        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuama a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.");

        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = resposta;
        
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}