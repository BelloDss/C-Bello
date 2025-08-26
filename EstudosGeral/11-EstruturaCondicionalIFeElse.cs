//Estrutura Condicional if/else

using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Hoje vai chover:");
string resposta = Console.ReadLine();
//case sensitive
if (resposta == "sim")
{
    Console.WriteLine("Nanias chora");
}

else
{
    Console.WriteLine("Nanias felix");
}


Console.WriteLine("Tem uma factor 2023 aqui?");
string resposta2  = Console.ReadLine();

bool temFactor = resposta2 == "sim";

if (temFactor)
{
    Console.WriteLine("sim");
}
else
{
    Console.WriteLine("nao");
}




Console.WriteLine("\n----------------------------\n");
// else if - Validar duas ou mais condições

Console.WriteLine("Digite o dia da entrega do trabalho:");
int dia = Convert.ToInt32(Console.ReadLine());

if (dia > 5)
{
    Console.WriteLine("O trabalho foi entregue com atraso");
}
else if (dia == 5)
{
    //senao - elif
    Console.WriteLine("O trabalho foi entregue dentro do prazo");
}
else
{
    Console.WriteLine("O trabalho foi entregue antecipado");
}