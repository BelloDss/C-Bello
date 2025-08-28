//for each - para cada (lista) estrutura de repetiçao que tem inico e final ( coleçaõ) 

//while roda enquanto uma condiçao verdadeira. 

//Estrutura de repetição while

void exemplo1()
{
    Console.WriteLine("Digite a sua senha: ");
    string senha = Console.ReadLine();

    while (senha != "senai")
    {
        Console.Write("Senha incorreta: ");
        Console.Write("Digite a sua senha: ");
        senha = Console.ReadLine();
    }
    Console.WriteLine("FIM");
}
//exemplo1();




void exemplo2()
{

    int acumulador = 0;

    while (acumulador <= 5)
    {
        acumulador++;
        Console.WriteLine($"Contador: {acumulador}");
        //o ++ adiciona novamente a variavel
    }

    Console.WriteLine("FIM");
}
//exemplo2();


void exemplo3()
{

    int acumulador = 5;

    while (acumulador < 5)
    {
        acumulador++;
        Console.WriteLine($"Contador: {acumulador}");
        //o ++ adiciona novamente a variavel
    }

    Console.WriteLine("FIM");
}
//exemplo3();

void exemplo4()
{

    int acumulador = 0;

    while (acumulador < 5)
    {
        //Nao executar, loop infinito
        //acumulador++;
        Console.WriteLine($"Contador: {acumulador}");
        //o ++ adiciona novamente a variavel
    }

    Console.WriteLine("FIM");
}
//exemplo4();


void exemplo5()
{

    int acumulador = 0;

    while (acumulador < 10)
    {

        acumulador++;
        Console.WriteLine($"Contador aum: {acumulador}");
        //o ++ adiciona novamente a variavel

        if (acumulador == 5)
            break;
    }

    Console.WriteLine("FIM");
}
//exemplo5();



//while com contador true + limitador
void exemplo6()
{

    while (true)
    {
        Console.WriteLine("Deseja sair do loop agora? {sim/não");
        string resposta = Console.ReadLine();

        if (resposta == "sim")
            break;

        Console.WriteLine("O loop deve continuar");

    }

    Console.WriteLine("FIM");
}
//exemplo6();



void exemplo7()
{

    int tentativas = 0;


    while (true)
    {
        tentativas++;

        Console.WriteLine("Deseja sair do loop agora? {sim/não]");
        string resposta = Console.ReadLine();


        //Para se digitar "sim"
        if (resposta.ToLower() == "sim")
            break;

        //Para se houver mais de 3 tentativas
        if (tentativas > 2)
        {
            Console.WriteLine("Voc estorou o limite de tentativas...");
            break;
        }


        Console.WriteLine("O loop deve continuar");

    }

    Console.WriteLine("FIM");
}
//exemplo7();

void exemplo8()
{
    int i = 0;

    while (1 < 5)
    {

        i++;
        int resto = 1 % 2;

        if (resto == 0)
            Console.WriteLine($"o numero é {i} é par");
        else
            Console.WriteLine($"O numero é {i} é impar");


    }

}
exemplo8();