using System.Collections.Generic;

void Exercicio01()
{
    // Imprima o elemento de índice 3 da lista de frutas.

    List<string> frutas = new List<string> { "Maçã", "Banana", "Uva", "Melão", "Abacaxi" };
    Console.WriteLine(frutas[3]);

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio01();



void Exercicio02()
{
    // Imprima o elemento de índice 0 da lista de números.

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
    Console.WriteLine(numeros[0]);



}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio02();



void Exercicio03()
{
    // Substitua o valor 5 por -5 na lista de números.

    List<int> numeros = new List<int> { -1, -2, -3, -4, 5 };

    numeros[4] = 5;
    Console.WriteLine(String.Join(", ",numeros ));
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio03();



void Exercicio04()
{
    // Crie um programa que adicione o valor "Laranja" ao final da lista de frutas.

    List<string> frutas = new List<string> { "Maçã", "Banana", "Uva", "Melão", "Abacaxi" };
    frutas.Add("Orange");

    Console.WriteLine(string.Join(", ", frutas));





}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie um programa que adicione "Limão" na segunda posição da lista de frutas, mantendo os demais itens.
    // Exemplo: ["Maçã", "Limão", "Banana", "Uva", "Melão", "Abacaxi"]

    List<string> frutas = new List<string> { "Maçã", "Banana", "Uva", "Melão", "Abacaxi" };

    frutas.Insert(1, "Limão");
    Console.WriteLine(string.Join (", ", frutas));




}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio05();



void Exercicio06()
{
    // Utilize um método de lista para inserir o número 4 na quarta posição da lista de números, mantendo todos os demais elementos inalterados.
    // Exemplo: [1, 2, 3, 5]

    List<int> numeros = new List<int> { 1, 2, 3, 5 };

    numeros.Insert(3, 4);
    Console.WriteLine(string.Join(", ", numeros));

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio06();



void Exercicio07()
{
    // Crie um programa que removera os elementos conforme indicado na lista a seguir.

    // - lista1: Remova o valor "Banana"
    // - lista2: Remova o valor -5
    // - lista3: Remova o valor "João"

    List<string> lista1 = new List<string> { "Maçã", "Banana", "Uva", "Melão", "Abacaxi" };
    List<int> lista2 = new List<int> { 1, 2, 3, 4, 5, -5 };
    List<string> lista3 = new List<string> { "Maria", "José", "Ana", "Pedro", "Paula", "João" };

    lista1.Remove("Banana");
    lista2.Remove(-5);
    lista3.Remove("João");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();




void Exercicio08()
{
    // Crie um programa para obter o índice do nome "Pedro" na lista a seguir.

    List<string> nomes = new List<string> { "Maria", "José", "Ana", "Pedro", "Paula", "João" };

    Console.WriteLine(nomes.IndexOf("Pedro"));


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();



void Exercicio09()
{
    // Crie um programa para retornar a quantidade de elementos presentes na lista abaixo.

    List<int> numeros = new List<int> { 0, 1, 2, 3, 5, 6 };

    numeros.Count();
    Console.WriteLine(numeros);


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();



void Exercicio10()
{
    // Crie um programa para inverter a ordem dos elementos nas listas abaixo.

    List<string> frutas = new List<string> { "Maçã", "Banana", "Uva", "Melão", "Abacaxi" };
    List<int> numeros = new List<int> { 50, 70, 90, 10, 30, 20, 40, 60, 80 };

    frutas.Reverse();
    numeros.Reverse();

    Console.WriteLine("Frutas de trás para frente" + string.Join(", ", frutas));
    Console.WriteLine("Frutas de trás para frente" + string.Join(", ", numeros));



}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();



void Exercicio11()
{
    // Crie um programa que una as listas fornecidas para formar os exemplos abaixo.

    // lista1 - {'a', 'b', 'c', 'd', 'e', 'f'}
    // lista2 - {1, 2, 3, 4, 5, 6}

    List<string> lista1 = new List<string> { "a", "b", "c" };
    List<int> lista2 = new List<int> { 1, 2, 3 };
    List<string> lista3 = new List<string> { "d", "e", "f" };
    List<int> lista4 = new List<int> { 4, 5, 6 };

    lista1.AddRange(lista3);
    lista2.AddRange(lista4);

    Console.WriteLine("Frutas de trás para frente" + string.Join(", ", lista1));
    Console.WriteLine("Frutas de trás para frente" + string.Join(", ", lista2));




}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio11();



void Exercicio12()
{
    // Crie um programa para ordenar os elementos das listas abaixo em ordem crescente.

    List<string> meses = new List<string> { "Janeiro", "Fevereiro", "Março", "Abril", "Meses" };
    List<int> numeros = new List<int> { 50, 40, 30, 20, 10 };

    numeros.Sort();
    meses.Sort();

    Console.WriteLine(string.Join(", ", numeros));
    Console.WriteLine(string.Join(", ", meses));





}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio12();



void Exercicio13()
{
    // Crie um programa que peça ao usuário que digite um número inteiro e, em seguida, adicione o número informado ao final da lista.

    List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

    Console.WriteLine("Digite um numero");
    string bello = Console.ReadLine();

    lista.Add(int.Parse(bello));

    Console.WriteLine("Frutas de trás para frente" + string.Join(", ", bello));


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio13();



void Exercicio14()
{
    // Crie um programa que:

    // 1. Solicite ao usuário que digite um número de 0 a 4.
    // 2. Converta o valor digitado para o tipo int.
    // 3. Utilize o número como índice para acessar e retornar o nome correspondente de uma fruta da lista abaixo.

    List<string> frutas = new List<string> { "Maçã", "Banana", "Uva", "Melão", "Abacaxi" };

   


}

// Descomente o bloco de código abaixo para executar o exercício
// Exercicio14();



void Exercicio15()
{
    // Crie um programa para imprimir as ações indicadas na lista a seguir.

    // 1. Exiba a soma dos valores.
    // 2. Exiba o maior valor.
    // 3. Exiba o menor valor.
    // 4. Exiba a média dos valores.
    // 5. Exiba a quantidade de elementos contidos na lista.

    List<int> numeros = new List<int> { 5, 7, 8, 6, 9, 1, 4, 0, 3, 2 };

    Console.WriteLine(numeros.Sum());
    Console.WriteLine(numeros.Max()); // maior valor
    Console.WriteLine(numeros.Min()); // menor valor
    Console.WriteLine(numeros.Average()); // média
    Console.WriteLine(numeros.Count()); // qtd elementos






}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio15();

Console.ReadKey();