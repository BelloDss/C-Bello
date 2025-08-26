using System;

void Exercicio01()
{
    // Pessoas com idade entre 18 e 70 anos, inclusive, são obrigadas a votar.  
    // Crie um programa que solicite ao usuário que informe sua idade e, em seguida, verifique a idade informada e exiba uma das mensagens abaixo:

    // - Se a idade for maior ou igual a 18 E menor ou igual a 70, exiba:
    // >>> O voto é obrigatório.
    // - Senão, exiba:
    // >>> O voto não é obrigatório.


    Console.WriteLine("Digite a sua idade");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 18 & idade <= 70) 
    {
        Console.WriteLine("O voto é obrigatorio");
    }
    else
    {
        Console.WriteLine("Voto não é obrigatorio");
    }


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio01();



void Exercicio02()
{
    // Para determinar o tipo de ingresso adequado, o usuário deve informar seu perfil.
    // Crie um programa que solicite ao usuário que escolha uma das opções abaixo, digitando o número correspondente:

    // 1.Estudante
    // 2.Idoso
    // 3.PCD
    // 4.Público geral

    // Em seguida, verifique a condição escolhida:
    // - Se o usuário digitar 1, 2 ou 3, exiba:
    // >>> Ingresso com meia-entrada.
    // - Se o usuário digitar 4, exiba:
    // >>> Ingresso com valor integral.
    // - Senão, exiba:
    // >>> Opção inválida.

    Console.WriteLine(""""
        Escolha uma das opções abaixo: 

        1.Estudante
        2.idoso
        3.PCD
        4.Publico Geral
        """");
    int opc = Convert.ToInt32(Console.ReadLine());

    if (opc >=1 & opc <=3)
    {
        Console.WriteLine("Paga meia");
    }
    else if (opc == 4)
    {
        Console.WriteLine("Não paga meia");
    }
    else
    {
        Console.WriteLine("Opção invalida");
    }


}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio02();



void Exercicio03()
{
    // Crie um programa que solicite ao usuário que digite H se for do homem ou M se for mulher e, em seguida, peça que informe a sua idade.  
    // Com base nas informações fornecidas, verifique as seguintes condições:

    // - Se o usuário digitar H e tiver idade maior ou igual a 65 anos, exiba:
    // >>> Você pode se aposentar.
    // - Se o usuário digitar M e tiver idade maior ou igual a 62 anos, exiba:
    // >>> Você pode se aposentar.
    // - Senão, exiba:
    // >>> Você ainda precisa trabalhar.


    Console.Write("Digite seu sexo - M ou F: ");
    string sex = Console.ReadLine();

    Console.Write("Digite a sua idade: ");
    int year = Convert.ToInt32(Console.ReadLine());

    if (sex == "M" & year >= 65)
    {
        Console.WriteLine("Masulino, pode se aposentar");
    }
    else if (sex == "F" & year >= 62)
    {
        Console.WriteLine("Feminino, pode se aposentar");
    }
    else
    {
        Console.WriteLine("Não pode se aposentar");
    }   

    Console.ReadKey();


}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio03();



void Exercicio04()
{
    // Para ter direito à fila prioritária, o usuário deve se enquadrar em pelo menos uma das seguintes condições: idoso, gestante ou cadeirante.  
    // Crie um programa que solicite ao usuário que escolha uma das opções abaixo, digitando o número correspondente:

    // 1. Idoso
    // 2. Gestante
    // 3. Cadeirante
    // 4. Público geral

    // Em seguida, verifique a condição escolhida:
    // - Se o usuário digitar 1, 2 ou 3, exiba:
    // >>> Fila prioritária.
    // - Se o usuário digitar 4, exiba:
    // >>> Fila comum.
    // - Senão, exiba:
    // >>> Opção inválida.

    Console.WriteLine(""""
        Escolha uma das opções abaixo: 

        1.Idoso
        2.Gestante
        3.Cadeirante
        4.Publico geral
        """");
    int opc = Convert.ToInt32(Console.ReadLine());

    if (opc == 1 | opc == 2 | opc == 3 )
    {
        Console.WriteLine("Fila prioritária.");
    }
    else if (opc == 4)
    {
        Console.WriteLine("Fila comum.");
    }
    else
    {
        Console.WriteLine("Opção invalida");
    }


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie um programa que solicite ao usuário sua idade e se ele possui CNH (Carteira Nacional de Habilitação)
    // com base nas informações fornecidas, aplique a seguinte condição:

    // - Se o usuário tiver 18 anos ou mais e responder que possui CNH, exiba:
    // >>> Você está apto a dirigir.
    // - Senão, exiba:
    // >>> Você não está apto a dirigir.

    Console.WriteLine("Sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.Write("Tem carta? (Sim ou Não: ");
    string cnh = Console.ReadLine();


    if (idade >= 18 & cnh == "Sim")
    {
        Console.WriteLine("Pode dirigir");
    }
    else if (idade >= 18 & cnh == "Não")
    {
        Console.WriteLine("Tem idade, mas não tem carta. Não pode");
    }
    else
    {
        Console.WriteLine("Não pode mesmo, sem idade e sem cnh");
    }

    Console.ReadKey();

}
// Descomente o bloco de código abaixo para executar o exercício
Exercicio05();



void Exercicio06()
{
    // Crie um programa que solicite ao usuário que digite um login e uma senha. Após a entrada dos dados, verifique as informações e exiba uma das mensagens abaixo:

    // - Se o login for igual a admin e a senha for igual a 123456, exiba:
    // >>> SEJA BEM-VINDO, ADMIN!
    // - Senão, exiba:
    // >>> LOGIN OU SENHA INCORRETOS.


    Console.Write("Seu login: ");
    string adm = Console.ReadLine();

    Console.Write("Sua senha? : ");
    int senha = Convert.ToInt32(Console.ReadLine());


    if (adm == "admin" & senha == 1234)
    {
        Console.WriteLine("Logado.");
    }
    else
    {
        Console.WriteLine("Errados");
    }

    Console.ReadKey();



}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio06();



void Exercicio07()
{
    // Crie um programa que solicite ao usuário a nota final e o número de faltas de um aluno. 
    // Com base nas informações fornecidas, verifique a situação do aluno conforme as regras abaixo:

    // - Se a nota for maior ou igual a 5 e o número de faltas for menor ou igual a 5, exiba:
    // >>> Aluno aprovado.
    // - Senão, exiba:
    // >>> Aluno reprovado.

    Console.Write("Nota final do aluno: ");
    int notas = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Numero de faltas");
    int faltas = Convert.ToInt32(Console.ReadLine());

    if (notas >= 5 & faltas <= 5)
    {
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Aluno reprovado");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();



void Exercicio08()
{
    // Crie um programa que solicite ao usuário sua idade e se ele possui carteira de estudante, respondendo com **SIM** ou **NÃO**.
    // Com base nas informações fornecidas, aplique as seguintes regras:

    // - Se a idade for maior ou igual a 18 anos e o usuário responder SIM, exiba: 
    // >>> Ingresso com meia-entrada.
    // - Se a idade for maior ou igual a 18 anos e a resposta for NÃO, exiba:
    // >>> Ingresso com valor integral
    // - Senão, exiba:
    // >>> Venda não permitida.


    Console.Write("Sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.Write("Tem carteirda de estudadnte ");
    string cart = Console.ReadLine();


    if (idade == 18 & cart == "Sim")
    {
        Console.WriteLine("Paga meia");
    }
    else if (idade >= 18 & cart == "Não")
    {
        Console.WriteLine("Tem idade, mas não tem carteirinha. Não pode");
    }
    else
    {
        Console.WriteLine("Não pode mesmo, sem idade e sem carteirinha");
    }

    Console.ReadKey();


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();



void Exercicio09()
{
    // Crie um programa que solicite ao usuário o preço de um produto e,
    // com base no valor informado, classifique o produto em uma das categorias abaixo:

    // Se o preço for menor que R$ 50,00, classifique como: "Produto barato"
    // Se o preço estiver entre R$ 50,00 e R$ 150,00, classifique como: "Produto normal"
    // Se o preço estiver entre R$ 150,01 e R$ 300,00, classifique como: "Produto caro"
    // Se o preço for acima de R$ 300,00, classifique como: "Produto de luxo"


    Console.Write("Preço do produto");
    double precos = Convert.ToInt32(Console.ReadLine());

    if (precos < 50.00 )
    {
        Console.WriteLine($"Produto barato, valor: R${precos}");
    }
    else if (precos >= 50.00 & precos <= 150.00 )
    {
        Console.WriteLine($"Produto com o valor normal, valor: R${precos}");
    }
    else if (precos >= 150.01 & precos <= 300.00)
    {
        Console.WriteLine($"Produto caro, valor: R${precos}");
    }
    else if (precos >= 300.00)
    {
        Console.WriteLine($"Produto de luxo, valor: R${precos}");
    }


    Console.ReadKey ();

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();



void Exercicio10()
{
    // Crie um programa que solicite ao usuário a distância (em km) que ele deseja viajar e,
    // com base nessa distância, classifique o valor da passagem da seguinte maneira:

    // Se a distância for menor ou igual a 100 km, exiba: "Passagem econômica: R$ 50,00"
    // Se estiver entre 101 km e 300 km, exiba: "Passagem padrão: R$ 100,00"
    // Se for acima de 300 km, exiba: "Passagem executiva: R$ 200,00"





}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();



void Exercicio11()
{
    // Crie um programa que solicite ao usuário a temperatura corporal (em °C) e classifique a situação de acordo com os valores abaixo:

    // Se a temperatura for menor que 35°C, exiba: "Hipotermia"
    // Se estiver entre 35°C e 37°C, exiba: "Temperatura normal"
    // Se estiver entre 37,1°C e 38°C, exiba: "Estado febril leve"
    // Se for acima de 38°C, exiba: "Febre alta"



}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio11();



void Exercicio12()
{
    // Crie um programa que solicite ao usuário o consumo mensal de água (em metros cúbicos) de uma residência e,
    // com base no valor informado, classifique o consumo da seguinte forma:

    // Se o consumo for menor que 10 m³, exiba: "Baixo consumo"
    // Se o consumo estiver entre 10 e 20 m³, exiba: "Consumo dentro da média"
    // Se o consumo estiver entre 20,01 e 30 m³, exiba: "Consumo elevado"
    // Se o consumo for acima de 30 m³, exiba: "Alto consumo"



}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio12();