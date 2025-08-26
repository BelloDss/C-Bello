// indice Reverso
//Operador

List<string> str = new List<string>
{
    "Maçã",
    "Laranja",
    "Banana",
    "Melão",
    "Abaxaki"

};

Console.WriteLine(string.Join(", ", str));
Console.WriteLine(str[^2]); // Melão
Console.WriteLine(str[^3]); // Banana
Console.WriteLine(str[^4]); // Laranja
Console.WriteLine(str[^5]); // Maçã

Console.WriteLine(str[^1]); // Abaxaki
Console.WriteLine("\n--------------------------\n");

// Índice Reverso Strings

string str2 = "Lógica";

Console.WriteLine(str2[^1]); // A
Console.WriteLine(str2[^2]); // C
Console.WriteLine(str2[^3]); // I
Console.WriteLine(str2[^4]); // G
Console.WriteLine(str2[^5]); // Ó
Console.WriteLine(str2[^6]); // L

// Operação de Fatiamento com Índice Reverso
int[] arr = { 10, 20, 30, 40, 50, 60 };

//Pegando os 2 últimos elementos:
int[] fatia1 = arr[^2..]; // Sáida: {50, 60}

// Pegando os 3 ultimos elementos:
int[] fatia2 = arr[^3..];

// Pegando os 4 últimos elementos:
int[] fatia3 = arr[^4..]; // Sáida: {#0, 40, 50, 60}

Console.WriteLine(string.Join(",", fatia1));
Console.WriteLine(string.Join(",", fatia2));
Console.WriteLine(string.Join(",", fatia3));

Console.WriteLine("\n ----------------------------------- \n");

//Fatiando uma lista usando apenas o indice de incicio e fim

//Pegando os 2 ultimos elementos
int[] fati4 = arr[1..^1]; //saida {20,30,40,50}

int[] fatia5 = arr[1..^2];//Saindo: {20, 30, 40}

Console.WriteLine(string.Join(",", arr ));
Console.WriteLine(string.Join(",", fatia2));
Console.WriteLine(string.Join(",", fatia5));





















Console.ReadKey();