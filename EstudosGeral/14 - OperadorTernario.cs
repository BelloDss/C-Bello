//Operador +,-,*, /
//Operando: 1, 2, 3...(Valores)

//Operador unário
//Um operador unário trabalho em um operando.
int unario1 = +1;
int unario = -1;

//Operador binário
//Um operador binário trabalha em dois operandos (valores)
int binario1 = 2 + 3;
int binario2 = 5 - 2;

//Estrutura condicional if
int x = 5;
int y = 3;

if (x > y)
{
    Console.WriteLine("X é maior que y");
}
else
{
    Console.WriteLine("X é menor que y");
}

//Operador ternário
//Um operador ternário trabalho em tres operadores.

string resultado = x > y ? "x é maior que y" : "x é menor que y"; 
Console.Write(resultado);

Console.WriteLine("\n----------------------------------\n");

bool valor = true;
Console.WriteLine(valor ? "Verdadeiro" : "Falso");

Console.WriteLine("\n----------------------------------\n");

int z = 5;
string parImpar = z % 2 == 0 
    ? "Par" 
    : "Impar";

//"?" if e os ":" else
Console.WriteLine(parImpar);

Console.WriteLine("\n----------------------------------\n");

bool isVip = true;
double preco = 100.00;
double precoFinal = isVip ? preco * 0.8 : preco;

Console.WriteLine($"Preço: {precoFinal:C}");

Console.WriteLine("\n----------------------------------\n");

//Operador Ternário aninhado
int n = 0;
string resp = x > 0
    ? "x é maior que 0" : (x < 0)
    ? "x é maior que 0" : "x < 0";





