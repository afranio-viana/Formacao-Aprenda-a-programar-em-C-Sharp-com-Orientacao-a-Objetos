//Screen Sound
string mensagemDeBoasVindas = "\t*Boas vindas ao Screen Sound!!!*";


void ExibirMensagemDeBoasVindas()
{
    //Esse @ serve para exibir a string literal
    Console.WriteLine(@"
        ╭━━━┳━━━┳━━━┳━━━┳━━━┳━╮╱╭╮╭━━━┳━━━┳╮╱╭┳━╮╱╭┳━━━╮
        ┃╭━╮┃╭━╮┃╭━╮┃╭━━┫╭━━┫┃╰╮┃┃┃╭━╮┃╭━╮┃┃╱┃┃┃╰╮┃┣╮╭╮┃
        ┃╰━━┫┃╱╰┫╰━╯┃╰━━┫╰━━┫╭╮╰╯┃┃╰━━┫┃╱┃┃┃╱┃┃╭╮╰╯┃┃┃┃┃
        ╰━━╮┃┃╱╭┫╭╮╭┫╭━━┫╭━━┫┃╰╮┃┃╰━━╮┃┃╱┃┃┃╱┃┃┃╰╮┃┃┃┃┃┃
        ┃╰━╯┃╰━╯┃┃┃╰┫╰━━┫╰━━┫┃╱┃┃┃┃╰━╯┃╰━╯┃╰━╯┃┃╱┃┃┣╯╰╯┃
        ╰━━━┻━━━┻╯╰━┻━━━┻━━━┻╯╱╰━╯╰━━━┻━━━┻━━━┻╯╱╰━┻━━━╯
    ");
    Console.WriteLine("\t********************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("\t********************************");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");


    Console.Write("\nDigite a sua opção: ");
    //Essa exclamação serve para não aceitar valores nulos
    string opcaoEscolhida = Console.ReadLine()!;
    //Parse é utilizada para realizar a conversão
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch(opcaoEscolhidaNumerica)
    {
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case -1: Console.WriteLine("Tchau ;)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();