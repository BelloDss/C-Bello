void Exercicio01()
{
    // Crie um array com os nomes de 5 dias da semana (Segunda a Sexta) e exiba no console:
    // - O primeiro dia
    // - O terceiro dia
    // - O último dia

    string[] diasDaSemana = { "Segunda", "Terça", "Quarta","Quinta","Sexta" };
    
    Console.WriteLine(string.Join("|", diasDaSemana[0], diasDaSemana[2], diasDaSemana[4]));// imprimi a lista

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio01();



void Exercicio02()
{
    // Crie um programa que redimensione o array abaixo para incluir mais um elemento e adicione o valor "Laranja" ao final da lista de frutas.

    string[] frutas = { "Maçã", "Banana", "Uva", "Melão", "Abacaxi" };

    


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio02();



void Exercicio03()
{
    // Crie um programa para retornar a quantidade de elementos presentes no array abaixo.

    string[] carros = { "Volvo", "BMW", "Ford", "FIAT", "Hyundai" };

    int qtd = carros.Length;

    Console.WriteLine($"Quantidad de elementos: {qtd}");

}
// Descomente o bloco de código abaixo para executar o exercício
 Exercicio03();



void Exercicio04()
{
    // Crie um programa que copie todos os elementos de um array de números inteiros (int) para um novo array do tipo short."


    int[] numeros1 = { 1, 2, 3, 4, 5 };

    short[] numeros2 = new short[5];

    numeros1.CopyTo(numeros2, 0);
    Console.WriteLine(string.Join(",", numeros2));



}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie um programa que localize e exiba a posição da primeira e da última ocorrência da palavra "Creta" do array abaixo.

    string[] carros = { "HB20", "Creta", "Tucson", "Ioniq", "Creta", "HB20S" };

    int indice1 = Array.IndexOf(carros, "Creta");

    Console.WriteLine($"Posição do primeiro Creta: {indice1}");

    int indice2 = Array.LastIndexOf(carros, "Creta");

    Console.WriteLine($"Posição do ultimo creta: {indice2}");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio05();



void Exercicio06()
{
    // Converta a Lista e a String abaixo para o tipo Array

    List<string> lista = new List<string> { "Maria", "José", "Ana", "Pedro", "Paula" };
    string palavra = "Métodos";

    string[] arrLista = lista.ToArray();

    char[] arrPalavra = palavra.ToArray();

    Console.WriteLine(string.Join(",", arrLista, arrPalavra));

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio06();



void Exercicio07()
{
    // Crie um array com 5 nomes e exiba-os:
    // - Na ordem original
    // - Na ordem inversa

    string[] nomes = { "Matheus", "Henrique", "Bello", "Luiz", "Fernando" };

    Array.Reverse(nomes);

    Console.WriteLine(string.Join(",", nomes));

    Array.Sort(nomes);

    Console.WriteLine(string.Join(",", nomes));




}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();



void Exercicio08()
{
    // Crie um programa para ordenar os elementos dos arrays abaixo em ordem crescente.

    string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio" };
    int[] numeros = { 50, 40, 30, 20, 10 };

    Array.Sort(numeros);
    Array.Sort(meses);

    Console.WriteLine(string.Join("|", numeros));
    Console.WriteLine(string.Join("|", meses));
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();



void Exercicio09()
{
    // Crie um programa para imprimir as ações indicadas no array a seguir.

    // 1. Exiba a soma dos valores.
    // 2. Exiba o maior valor.
    // 3. Exiba o menor valor.
    // 4. Exiba a média dos valores.
    // 5. Exiba a quantidade de elementos contidos na lista.

    int[] numeros = { 5, 7, 8, 6, 9, 1, 4, 0, 3, 2 };

    Console.WriteLine(numeros.Sum());
    Console.WriteLine(numeros.Average());
    Console.WriteLine(numeros.Max());
    Console.WriteLine(numeros.Min());
    Console.WriteLine(numeros.Count());
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();



void Exercicio10()
{
    // Crie um programa que:
    // 1. Solicite ao usuário que informe o nome que deseja localizar no array de convidados.
    // 2. Verificar se o nome informado está presente na frase, sendo:

    // - Se o nome informado estiver presente no array de convidados, exiba:
    // >>> {nome} foi convidado(a).
    // - Senão, exiba:
    // >>> {nome} não foi convidado(a).

    string[] convidados = { "Maria", "José", "Ana", "Pedro", "Paula", "João" };

    Console.WriteLine("Digite um nome ai");
    string nome = Console.ReadLine();

    int nomee = Array.IndexOf(convidados, nome);

    Console.WriteLine(nomee >= 0
        ? $"O nome digitados esta entre convidados: {nome}"
        : $"é irmão esse nome não esta na lista de convidado {nome}");






}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();

Console.ReadKey();


// Descomente o bloco de código abaixo para executar o exercício
// Exercicio06();
