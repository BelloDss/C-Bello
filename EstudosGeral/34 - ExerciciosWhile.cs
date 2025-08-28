void Exercicio01()
{
    // Declare uma vari�vel e atribua a ela o valor 10 e, em seguida,
    // crie um programa que incremente essa vari�vel em 1 a cada itera��o,
    // o loop deve continuar enquanto o valor da vari�vel for menor ou igual a 20.

    int acumulador = 10;

    while (acumulador <= 20)
    {
        acumulador++;
        Console.WriteLine($"Contador: {acumulador}");
        //o ++ adiciona novamente a variavel
    }

    Console.WriteLine("FIM");


}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Exercicio01();



void Exercicio02()
{
    // Crie um programa que pergunte ao usu�rio se ele deseja continuar no loop e mantenha a execu��o enquanto a resposta for diferente de "sair".

    while (true)
    {
        Console.WriteLine("Deseja sair do loop agora? {sim/n�o");
        string resposta = Console.ReadLine();

        if (resposta == "sair")
            break;

        Console.WriteLine("O loop deve continuar");

    }


}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
// Exercicio02();



void Exercicio03()
{
    // Declare uma vari�vel e atribua a ela o valor 10 e, em seguida,
    // crie um programa que incremente essa vari�vel em 5 a cada itera��o,
    // o loop deve continuar enquanto o valor da vari�vel for menor ou igual a 50.

    int mclaren = 10;

    while (mclaren <= 50)
    {
        Console.WriteLine($"Contando at� {mclaren}");
        mclaren += 5;

    }

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Exercicio03();



void Exercicio04()
{
    // Crie um programa que imprima uma contagem regressiva de 10 at� 0.


    int mclaren = 10;

    while (mclaren >= 0)
    {
        Console.WriteLine($"Contando at� {mclaren}");
        mclaren--;

    }

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Exercicio04();



void Exercicio05()
{
    // Crie um programa que solicite a idade do usu�rio. Continue pedindo enquanto o valor n�o for um n�mero positivo.

    Console.Write("Digite a sua idad, jovem: ");
    int idade = Convert.ToInt32(Console.ReadLine());





}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Exercicio05();



void Exercicio06()
{
    // Crie um programa que solicite ao usu�rio a senha de acesso ao sistema e mantenha a execu��o do loop enquanto a resposta for diferente de "admin".

    Console.Write("Digite a sua senha: ");
    string senha = Console.ReadLine();

    while (senha != "admin")
    {
        Console.Write("Senha incorreta: ");
        Console.Write("Digite a sua senha: ");
        senha = Console.ReadLine();
    }
    Console.WriteLine("FIM");

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Exercicio06();



void Exercicio07()
{
    // Crie um programa que solicite ao usu�rio digitar a senha de acesso e continue pedindo enquanto a palavra digitada for diferente de "segredo".

    Console.Write("Digite a sua senha: ");
    string senha = Console.ReadLine();

    while (senha != "segredo")
    {
        Console.Write("Senha incorreta: ");
        Console.Write("Digite a sua senha: ");
        senha = Console.ReadLine();
    }
    Console.WriteLine("FIM");




}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
// Exercicio07();



void Exercicio08()
{
    // Crie um programa que imprima a frase "Programa��o em C#" cinco vezes.

    string nome = "Programa��o em C#";
    int contador = 1;

    while (contador <= 5)
    {
        Console.WriteLine(nome);
        contador++;
    }

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Exercicio08();



void Exercicio09()
{
    // Crie um programa que solicite ao usu�rio inserir um n�mero inteiro e continue pedindo enquanto o valor informado for maior ou igual a zero.


    Console.Write("Digite um n�mero inteiro: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    // Continua pedindo enquanto o n�mero for maior ou igual a 0
    while (numero >= 0)
    {
        Console.WriteLine("Voc� digitou: " + numero);

        // Solicita novamente
        Console.Write("Digite um n�mero inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("N�mero negativo informado. Programa encerrado.");

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Exercicio09();



void Exercicio10()
{
    // Crie um programa que pe�a ao usu�rio para digitar uma palavra e continue executando enquanto a palavra digitada tiver menos de 6 caracteres.
    // Dica: Utilize a propriedade Length para saber o n�mero de caracteres da palavra digitada.

    Console.WriteLine("Digite uma palaavra, ela precisa ter 6 caracteres");
    string pala = Console.ReadLine();

    while (pala.Length < 6)
    {
        Console.WriteLine("A palavra tem menos de 6 caracteres. Tente novamente:");
        pala = Console.ReadLine();
    }
    Console.WriteLine("Obrigado! A palavra digitada tem 6 ou mais caracteres.");


}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
Exercicio10();

Console.ReadKey();
