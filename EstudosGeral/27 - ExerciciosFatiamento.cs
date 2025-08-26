using System;

void Exercicio01()
{
    // Utilize a operação de slicing para obter do array abaixo apenas os elementos especificados:
    // Saída: "Melão, Abacaxi, Laranja, Kiwi"

    string[] arr = { "Maça", "Banana", "Uva", "Melão", "Abacaxi", "Laranja", "Kiwi" };


    Console.WriteLine(string.Join(",", arr[3..7]));
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio01();



void Exercicio02()
{
    // Utilize a operação de slicing para obter do array abaixo apenas os elementos especificados:
    // Saída: "1, 2, 3, 4"

    int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.WriteLine(string.Join(",", arr[1..5]));

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio02();



void Exercicio03()
{
    // Utilize a operação de slicing para obter do array abaixo apenas os elementos especificados:
    // Saída: "Banana, Uva"

    string[] arr = { "Maça", "Banana", "Uva", "Melão", "Abacaxi", "Laranja", "Kiwi" };
    Console.WriteLine(string.Join(",", arr[1..3]));


}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio03();



void Exercicio04()
{
    // Utilize a operação de slicing para obter do array abaixo apenas os elementos especificados:
    // Saída: "7, 8, 9, 10"

    int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Console.WriteLine(string.Join(",", arr[7..11]));

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio04();



void Exercicio05()
{
    // Utilize a operação de slicing para obter do array abaixo apenas os elementos especificados:
    // Saída: "5, 6, 7"

    int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Console.WriteLine(string.Join(",", arr[5..8]));

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio05();



void Exercicio06()
{
    // Utilize a operação de slicing para obter da string abaixo apenas os elementos especificados:
    // Saída: "C#"

    string frase = "C# é top!";

    Console.WriteLine(string.Join(",", frase[0..2]));


}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio06();



void Exercicio07()
{
    // Utilize a operação de slicing para obter do array abaixo apenas os dias da semana:
    // Saída: "SEG, TER, QUA, QUI, SEX"

    string[] arr = { "SEG", "TER", "QUA", "QUI", "SEX", "SAB", "DOM" };

    Console.WriteLine(string.Join(",", arr[0..5]));

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio07();



void Exercicio08()
{
    // Utilize a operação de slicing para obter do array abaixo apenas os dias de fim de semana:
    // Saída: "SAB, DOM"

    string[] arr = { "SEG", "TER", "QUA", "QUI", "SEX", "SAB", "DOM" };

    Console.WriteLine(string.Join(",", arr[6..8]));

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio08();



void Exercicio09()
{
    // Utilize a operação de slicing para obter do array abaixo apenas os meses do 1º Trimestre:
    // Saída: "Janeiro, Fevereiro, Março"

    string[] arr = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho" };

    Console.WriteLine(string.Join(",", arr[0..3]));

}
// Descomente o bloco de código abaixo para executar o exercício
 Exercicio09();



void Exercicio10()
{
    // Utilize a operação de slicing para obter do array abaixo apenas os meses do 2º Trimestre:
    // Saída: "Abril, Maio, Junho"

    string[] arr = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho" };

    Console.WriteLine(string.Join(",", arr[3..6]));
}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio10();

Console.ReadKey();