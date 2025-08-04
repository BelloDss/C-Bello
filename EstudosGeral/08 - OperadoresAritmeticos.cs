----------------------------------------------------------------------------------- 8
//Operadores Artimeticos - 8

int n1 = 8;
int n2 = 16;

//Soma: -
Console.Write($"A soma de n1 + n2 é: {n1 + n2}");

//Subtração: -
Console.Write($"A soma de n1 + n2 é: {n1 - n2}");

//Divisão: /
Console.Write($"A soma de n1 + n2 é: {n1 / n2}");

//Multiplicação: *
Console.Write($"A soma de n1 + n2 é: {n1 * n2}");

//Modulo: %
Console.Write($"A soma de n1 + n2 é: {n1 % n2}");

//Potencia
int nBase  = 3;
int expoente = 4;


//Math.Pow(base, expoente)
int resultado = Math.Pow( nBase, expoente );

//---------------------------------

Console.WriteLine($"A potecnia de 2 é {resultado}");


Console.WriteLine("--------------------------");

Console.Write("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de produtos: ");
int qnt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{preco} x {qnt} = {preco * qnt}");

Console.WriteLine("\n------------------\n");


//Ordem procedencia 
//01 Parenteces
//02 Potencia
//03 Multiplicação e Divisão
//04 - Adição e Subtração

//Porcentagens
Console.Write($"O valor de 15% de 200 é {220 * 0.15}");
Console.Write($"O valor de 15% de 200 é {220 + (220 * 0.15)}");

