List<int> listaDeNumeros = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int contador = 1;

Console.Clear();

for(int i=0; i<listaDeNumeros.Count();i++)
{
    if(listaDeNumeros[i]%2==0)
    {
        Console.WriteLine($"listaDeNumeros[{contador}]: {listaDeNumeros[i]}");
        contador++;
    }
}

Console.WriteLine("\n\n");
contador=1;
foreach(int numero in listaDeNumeros)
{
    if(numero%2==0)
    {
        Console.WriteLine($"listaDeNumeros[{contador}]: {numero}");
        contador++;
    }
}