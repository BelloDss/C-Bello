using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

void Exercicio01()
{
    // Crie um programa que percorra a lista abaixo e retorne, para cada número, o resultado da multiplicação desse número por 2.

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


    foreach(int cont in numeros)
    Console.WriteLine(cont * 2);

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio01();



void Exercicio02()
{
    // Crie um programa que solicite ao usuário um número inteiro e, em seguida,
    // multiplique esse número por cada item da lista abaixo, exibindo os resultados.

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.WriteLine("Digite um numero inteiro");
    int nu = Convert.ToInt32(Console.ReadLine());


    foreach (int bello in numeros)
        Console.WriteLine(bello * bello);


}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio02();



void Exercicio03()
{
    // Crie um programa que percorra a lista abaixo e, para cada linguagem, exiba a frase: "Eu quero aprender {nome da linguagem}".

    List<string> linguagens = new List<string> { "C", "C#", "Java", "Python", "Javascript" };

    foreach (string percorre in linguagens)
        Console.WriteLine($"Eu quero aprender: {percorre}");

}
// Descomente o bloco de código abaixo para executar o exercício
 Exercicio03();



void Exercicio04()
{
    // Utilizando a estrutura de repetição For, crie um programa que imprima os números de 5 a 10.

    for (int i = 5; i < 10; i++) ;

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie um programa que percorra a lista de frutas abaixo e utilize uma estrutura condicional if/else para verificar cada item, sendo:

    // - Se o valor for igual a "Abacaxi", exiba a mensagem: "Eu gosto de Abacaxi"
    // - Senão a mensagem: "Eu não gosto de {nome da fruta}"

    List<string> frutas = new List<string> { "Maçã", "Banana", "Jaca", "Melão", "Abacaxi" };

    foreach (string xing in frutas)
    {
        if (xing == "Abacaxi")
            Console.WriteLine("BOU DOGAO");
        else
            Console.WriteLine($"Eu nao gosto de {xing}");

    }

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio05();



void Exercicio06()
{
    // Crie um programa que percorra a lista abaixo e exiba cada número convertido para seu valor negativo.
    // Exemplo: -1, -2, -3, -4, -5, -6, -7, -8, -9, -10

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    foreach (int numero in numeros)
        Console.WriteLine($"-{numero}");


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio06();



void Exercicio07()
{
    // Crie um programa que percorra a lista de números abaixo e, para cada item,
    // utilize uma estrutura condicional if/else para verificar se o número é maior ou menor do que 10.

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    foreach (int numero in numeros)
        if (numero < 10)
            Console.WriteLine($"{numero} é maior 10");

        else
            Console.WriteLine($"{numero} é menor que 10");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();



void Exercicio08()
{
    // Utilizando a estrutura de repetição For, crie um programa que imprima os números de 5 a 0, ou seja, em ordem decrescente.

    for (int i = 5; i >= 0; i--)
        Console.WriteLine($"numero: {i}");
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio08();



void Exercicio09()
{
    // Utilizando a estrutura de repetição For, crie um programa que imprima os números de 2 a 10, pulando de 2 em 2.
    // Exemplo: 2, 4, 6, 8, 10

    for (int i = 2; i <= 10; i += 2)
        Console.WriteLine($"Numero: {i}");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();



void Exercicio10()
{
    // Crie um programa que percorra a lista abaixo e exiba cada número elevado ao quadrado.
    // Fórmula: Math.Pow(n, 2)

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    foreach (int numero in numeros)
        Console.WriteLine($"{Math.Pow(numero, 2)}");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();



void Exercicio11()
{
    // Crie um programa que percorra a lista e exiba apenas os números menores que 7.

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int numeros1 = numeros.Count;

    for (int i = 0; i < 7; i++)
        Console.WriteLine(numeros[i]);

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio11();

Console.ReadKey();