void Exercicio01()
{
    // Crie um programa que solicite ao usuário que informe sua idade e, em seguida, crie as condições abaixo.

    // - Se a idade for maior ou igual a 18 anos, exiba:
    // >>> Você é maior de idade.
    // - Senão, exiba:
    // >>> Você é menor de idade.


    Console.Write("Digite a sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 18)
    {
        Console.WriteLine("Maior de idade");
    }
    else
    {
        Console.WriteLine("Menor de idade");
    }


    Console.WriteLine(idade >= 18 ? "Maior de idade" : "Menor de idade");



}
// Descomente o bloco de código abaixo para executar o exercício
 Exercicio01();







void Exercicio02()
{
    // Crie um programa que solicite ao usuário que digite um número e, em seguida, crie as condições abaixo.

    // - Se o número for maior ou igual a zero, exiba:
    // >>> O número é positivo.
    // - Senão, exiba:
    // >>> O número é negativo.

    Console.Write("Digite um numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(numero >= 0 ? "Maior de 0" : "Menor de 0");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio02();





void Exercicio03()
{
    // Crie um programa que verifique se a senha informada pelo usuário está correta. A senha válida é: 1234.  
    // Após a entrada do usuário, exiba uma das seguintes mensagens:

    // - Se a senha estiver correta, exiba:
    // >>> ACESSO PERMITIDO
    // - Se a senha estiver incorreta, exiba:
    // >>> ACESSO NEGADO


    Console.Write("Write your password: ");
    int password = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(password >= 1234 ? "BEM VINDO AO SISTEMA" : "PULA FORA DOG");


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio03();



void Exercicio04()
{
    // Crie um programa que solicite ao usuário que digite uma senha e, em seguida, solicite que confirme a senha digitada.  
    // Compare as duas entradas e exiba a mensagem correspondente:

    // - Se as senhas forem iguais, exiba:
    // >>> SENHA CORRETA
    // - Se as senhas forem diferentes, exiba:
    // >>> SENHA INCORRETA

    Console.Write("Write your password: ");
    int password = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(password >= 1234 ? "BEM VINDO AO SISTEMA" : "PULA FORA DOG");


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie um programa que solicite ao usuário que informe a nota final do aluno e, em seguida, crie as condições abaixo.

    // - Se a nota final for maior ou igual a 5, exiba:
    // >>> Você está aprovado.
    // - Se a nota final for menor que 5, exiba:
    // >>> Você está reprovado.

    Console.Write("nota final do bunda ");
    int nota = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(nota >= 5 ? "passou" : "mamou");


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio05();



void Exercicio06()
{
    // Crie um programa que solicite ao usuário que digite dois números inteiros e, em seguida, crie as condições abaixo.

    // - Se os números forem iguais, exiba:
    // >>> Os números digitados são iguais.
    // - Caso contrário, exiba:
    // >>> Os números digitados são diferentes.

    Console.Write("Digite um numero: ");
    int numero3  = Convert.ToInt32(Console.ReadLine());


    Console.Write("Digite outro numero: ");
    int numero4 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(numero3 == numero4 ? "Igual" : "Diferente");


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio06();



void Exercicio07()
{
    // Crie um programa que solicite ao usuário que digite um ano e, em seguida, crie as condições abaixo.

    // - Se o ano informado for maior ou igual a 2001, exiba:
    // >>> Século 21.
    // - Caso contrário, exiba:
    // >>> Século 20 ou anterior.


    Console.Write("Digite um numero: ");
    int ano = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(ano >= 2001 ? "Seculo 21" : "Seculo 20");


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();



void Exercicio08()
{
    // Crie um programa que solicite ao usuário que digite o valor total da sua compra e, em seguida, crie as condições abaixo.

    // - Se o valor total da compra for maior ou igual a 150, exiba:
    // >>> Frete grátis!
    // - Caso contrário, exiba:
    // >>> Frete: R$ 20,00.


    Console.Write("Valor compra: ");
    int compra = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(compra >= 150 ? "Frete gratis " : "mangos: 20");


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();



void Exercicio09()
{
    // Crie um programa que solicite ao usuário que digite um número inteiro e, em seguida, crie as condições abaixo.

    // - Se o número for igual, exiba:
    // >>> É zero.
    // - Caso contrário, exiba:
    // >>> Não é zero.

    Console.Write("Numero: ");
    int compra = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(compra == 0 ? "é um zero " : "não é um zero");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();



void Exercicio10()
{
    // Crie um programa que solicite ao usuário que digite a velocidade de um veículo e, em seguida, crie as condições abaixo.

    // - Se a velocidade for maior ou igual a 61, exiba:
    // >>> Acima da velocidade permitida.
    // - Caso contrário, exiba:
    // >>> Dentro do limite.

    Console.Write("Numero: ");
    int velocidade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(velocidade >= 61 ? "multa" : "nao multa");




}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();