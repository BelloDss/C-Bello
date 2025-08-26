//For - Gera yna seqyebcua d eyneris 

//Sintaxe - for(Inicio, final e intervalo)

for (int i =1;i <= 10; i = i + 1)
    Console.WriteLine($"O valord atual: {i} ");

// range em python 

/*
Formas de incrementar uma variavel
i = i + 1
i += 1
1 ++
****/


//implementar com i++: exemplo para luiz 

for (int i = 0; i < 5; i++)
    Console.WriteLine($"Valor atual:{1} ");


//For com valores regressivos 

for (int i = 5; i > 0; i--)
    Console.WriteLine($"Valord Atual; {i}");

//For com RadLine - exemplo para o bello 

Console.WriteLine("Digite um numero de parada:");
int final = int.Parse( Console.ReadLine() );

for (int i = 1; i <= final; i++)
    Console.WriteLine($"Valor atual: {i}");

Console.WriteLine("\n ------------------------------------- \n ");

//Como percorrer uma coleção usando o For

string[] arr = { "A", "B", "C", "D" };
int tamanhoArr = arr.Length;

Console.WriteLine($"Tamanho do array: {tamanhoArr}");

for (int i = 0;i < tamanhoArr;i++)
{
    Console.WriteLine($"indice atual: {i}");
    Console.WriteLine($"O valor atual do array: {arr[i]}");
    Console.WriteLine();
}





