using System.Reflection.Metadata.Ecma335;

void Exercicio01()
{
    // Escreva um programa que solicite ao usuário um número e, em seguida, exiba o resultado da multiplicação desse número por 5.

    Console.Write("Digite um nomero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = num1 * 5;
    Console.WriteLine($"O numero é: {num2}");


}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio01();



void Exercicio02()
{
    // Escreva um programa que solicite dois números ao usuário, um por vez, e exiba a soma desses dois números ao final.

    Console.Write("Digite o primeiro numero: ");
    int nume1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(nume1 );

    Console.Write("Digite o segundo numero: ");
    int nume2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(nume2);

    Console.WriteLine($"A soma dos numeros é {nume1 + nume2}");


}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio02();



void Exercicio03()
{
    // Escreva um programa que solicite dois números ao usuário, um de cada vez, e exiba o resultado da subtração.

    Console.Write("Digite o primeiro numero: ");
    int nume1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(nume1);

    Console.Write("Digite o segundo numero: ");
    int nume2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(nume2);

    Console.WriteLine($"A soma dos numeros é {nume1 - nume2}");





}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio03();



void Exercicio04()
{
    // Crie o programa abaixo:
    // 1. Solicite ao usuário que informe duas notas semestrais, armazenando cada uma em uma variável distinta.
    // 2. Calcule a soma das duas notas.
    // 3. Calcule a média aritmética das notas, dividindo a soma por 2.
    // 4. Exiba a média final ao usuário.


    Console.Write("Digite a primeira nota: ");
    int nume1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(nume1);

    Console.Write("Digite a segunda nota: ");
    int nume2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(nume2);

    int soma = nume1 + nume2;

    Console.WriteLine($"A média das notas é {soma /2}");

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio04();



void Exercicio05()
{
    // Crie o programa abaixo:
    // 1. Solicite ao usuário que digite um valor em metros;
    // 2. Converta o valor informado para centímetros (multiplicando por 100);
    // 3. Exiba o resultado da conversão.

    Console.Write("Digite o valor em Metros: ");
    int metros = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(metros);


    Console.WriteLine($"A conversão de valores {metros * 100}cm");


}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio05();




void Exercicio06()
{
    // Crie o programa abaixo:
    // 1. Solicite ao usuário que digite um valor em centímetros;
    // 2. Converta o valor informado para metros (dividindo por 100);
    // 3. Exiba o resultado da conversão.

    Console.Write("Digite o valor em Metros: ");
    int metros = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(metros);


    Console.WriteLine($"A conversão de valores {metros / 100}cm");




}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio06();





void Exercicio07()
{
    // Crie um programa que:
    // 1. Solicite ao usuário o seu ano de nascimento.
    // 2. Calcule a idade atual com base no ano atual (considere que o usuário já fez aniversário este ano).
    // 3. Exiba uma mensagem informando a idade calculada.

    // Exemplo:
    // Se o ano atual for 2025 e o usuário informou o ano de nascimento 2005, o programa deve exibir:
    // Você tem 20 anos.



    Console.Write("Digite o seu ano de nascimento: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(idade);

    int niver = (idade - 2025);

    Console.WriteLine($"O ano do seu aniversario é: {niver}");



}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio07();


void Exercicio08()
{
    // Crie um programa que:
    // 1. Solicite ao usuário que digite um número inteiro.
    // 2. Calcule e exiba o número anterior e o número seguinte ao valor informado.
    // 3. Exiba o resultado da operação.

    // Entrada:  
    // Número: 10

    // Saída:  
    // Número anterior: 9
    // Número seguinte: 11


    Console.Write("Digite um numero: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num3);

    int numa = num3 - 1;
    int nump = num3 + 1;

    Console.WriteLine($"O numero é {num3}, o passado é {numa} e o porximo é {nump}");

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio08();



void Exercicio09()
{
    // Crie um programa que:
    // 1. Solicite ao usuário que informe uma quantidade de horas.
    // 2. Converta o valor informado para minutos (1 hora = 60 minutos).
    // 3. Exiba o resultado da conversão.

    Console.Write("Digite um horario: ");
    int horas = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(horas);

    int minutos = horas * 60;

    Console.Write($"O horario em minutos é {minutos}");



}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio09();



void Exercicio10()
{
    // Crie um programa que:
    // 1. Solicite ao cliente quantos quilos de maçã deseja comprar.
    // 2. Calcule o valor total da compra, considerando o preço por quilo da maçã é de 11.00;
    // 3. Exiba o valor final da compra.

    Console.Write("Quantos kg de maça vc quer");
    double maca = double.Parse(Console.ReadLine());
    double preco = 11.00;

    Console.WriteLine($"{maca * preco}");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();



void Exercicio11()
{
    // Crie um programa que:
    // 1. Solicite ao cliente a quantidade de litros de gasolina que deseja abastecer.
    // 2. Calcule o valor total da compra, considerando que o preço do litro de gasolina é de 5.50.
    // 3. Exiba o valor final da compra.

    Console.Write("Digite a quantidade de litros que deseja abastercer: ");
    double gas = double.Parse(Console.ReadLine());
    Console.WriteLine(gas);

    Console.WriteLine($"O preco total é {gas*5.50}");






}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio11();



//anotação importante

//double.Parse(1)
//double.Parse("1")

//Convert.ToDouble("1");
//Convert.ToDouble(1);









