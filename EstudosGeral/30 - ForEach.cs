//Estruturas de reptição for each

//repetição sem for each
int[] arr = { 1, 2, 3, 4, 5, };

Console.WriteLine(arr[0] * 2);
Console.WriteLine(arr[1] * 2);
Console.WriteLine(arr[2] * 2);
Console.WriteLine(arr[3] * 2);
Console.WriteLine(arr[4] * 2);

Console.WriteLine("\n ---------------------- \n ");

//Repetição com for Each 
//for x in arr

foreach (int numero in arr)
    Console.WriteLine(numero * 2);

Console.WriteLine("\n -------------------------------- \n");

//For Each com mutiplas linhas precisa de chaves {}

foreach (int numero in arr)
{
    Console.WriteLine($"Numero Atual: {numero} ");
    Console.WriteLine($"Numero Atual: {numero * 2} ");
    Console.WriteLine();

}


Console.ReadKey();

Console.WriteLine("\n -------------------------------- \n");

//for Each com if/else:

foreach (int numero in arr)
{
    if (numero % 2 == 0)
        Console.WriteLine($"O Número {numero} é par");
    else
        Console.WriteLine($"O numero {numero} é par");
}

Console.WriteLine("\n ---------------------------- \n");

// For each strings - quando ele percorre letra por letra é char, pois vai pegar caracter por caracter

string palavra = "sapiu";

foreach (char letra in palavra)
{
    Console.Write(letra);
    Console.WriteLine(Char.ToUpper(letra));

}

Console.WriteLine("\n ---------------------------- \n");

//For Each com acumulador

int acumulador = 0;

foreach (int numero in arr)
    acumulador += numero;
    // Equivalente a;
    //Acumulador = acumulador + numero;




