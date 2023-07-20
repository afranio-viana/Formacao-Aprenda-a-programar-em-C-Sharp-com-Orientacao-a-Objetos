//Declare um tipo random
Random rnd = new Random();
//Para números radômicos, o intervalo é fechado no início e aberto no final
int numeroAleatorio = rnd.Next(1,1001);
int tentativas=6;
int chute = 0;

do
{
    Console.WriteLine($"\nTentativas: {tentativas}");
    Console.WriteLine("\nAdivinhe o número: ");
    chute = int.Parse(Console.ReadLine()!);
    if(chute>numeroAleatorio)
    {
        Console.WriteLine("\nNúmero chutado é maior do que o número aleatório");
    }else if(chute<numeroAleatorio)
    {
        Console.WriteLine("\nNúmero chutado é menor do que número aleatório");
    }
    tentativas--;
}while(chute!=numeroAleatorio && tentativas>=1);

if(chute==numeroAleatorio)
{
    Console.WriteLine($"\nMeus parabéns!!!\nVocê acertou em {6-tentativas} tentativas, o número aleatório era: {numeroAleatorio}");
}else
{
    Console.WriteLine($"\nQue pena!!!\nVocê zerou as tentativas, o número aleatório era: {numeroAleatorio}");
}
