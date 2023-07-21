//Screen Sound
string mensagemDeBoasVindas = "\t*Boas vindas ao Screen Sound!!!*";
Console.Clear();
/*A forma de criar listas no C# é semelhante a Java,
onde vocês precisa definir os tipos de elementos que 
serão agrupados na lista*/
//List<string> listaDasBandas = new List<string>();

/*Assim se cria uma lista já com alguns valores*/
/*List<string> listaDasBandas = new List<string>{"U2",
 "The Beatles", "Calypso"};*/

/*Assim se cria um dicionário em C#*/
 Dictionary <string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{10,9,8});
bandasRegistradas.Add("The Beatles", new List<int>());


void ExibirLogo()
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
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair:");


    Console.Write("\nDigite a sua opção: ");
    //Essa exclamação serve para não aceitar valores nulos
    string opcaoEscolhida = Console.ReadLine()!;
    //Parse é utilizada para realizar a conversão
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch(opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case -1: Console.WriteLine("Tchau ;)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("*Registro de Bandas*"); 
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    /*Essa é uma maneira simples de adicionar elementos
    ao final de uma lista*/
    bandasRegistradas.Add(nomeDaBanda,new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    //Essa função serve para fazer um delay em milissegundos
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("*Exibindo Bandas Registradas*");
    /*O for do C# é muito semelhante ao do C
    O Count() é usado para contar o número de elementos 
    dentro de uma lista*/
    /*for(int i=0;i<listaDasBandas.Count();i++)
    {
        Console.WriteLine($"Banda[{i+1}]: {listaDasBandas[i]}");
    }*/
    
    /*O foreach é utilizado para percorrer todos
    os elementos de uma lista*/
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine($"\nDigite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    /*Na opção empty, nos é permitido adicionar uma 
    quantidade de elementos a string através da 
    função PadLeft*/
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*');
    Console.WriteLine($"\t\t{asteriscos}");
    Console.WriteLine($"\t\t{titulo}");
    Console.WriteLine($"\t\t{asteriscos}\n");

}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("*Avaliar Banda*");
    Console.Write("Digite o nome da banda que deseha avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {

        Console.WriteLine($"Qual nota a banda {nomeDaBanda} merece:");
        int nota = int.Parse(Console.ReadLine()!);
        /*Utilizamos o [] para indexar o dicionário
        após isso, utilizando Add para adicionar elementos 
        na lista*/
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso ");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }else{
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();