//Operados Lógicos
//Operador & - Operador and
//Retorna True se todas as condiçõs forem verdadeiras

int idade = 18;
bool temCNH = false;

if (idade >= 18 & temCNH)
{
    Console.WriteLine("Voce pod dirigir");
}
else
{
    Console.WriteLine("Voce não pode dirigir");
}

Console.WriteLine(idade >= 18 & temCNH
    ? "Voce pode dirigir"
    : "Voce não pode dirigir"
    );

//Tabela Verdade
Console.WriteLine(true & true); //true
Console.WriteLine( true & false); //false
Console.WriteLine(false & true); //false
Console.WriteLine(false & false); //false
Console.WriteLine(true & true & true & false); //false

Console.WriteLine("\n------------------------------------------\n");

//Operador | - Operador or
//Retorna True se ao menos uma doncição for verdadeira

int loja1 = 0;
int loja2 = 1;


if (loja1 > 0 | loja2 > 0)
{
    Console.WriteLine("O produto está disponivel");
}
else
{
    Console.WriteLine("O produto não está disponivel");
}

//Operador ternario
Console.WriteLine(loja1 > 0 | loja2 > 0
    ? "O produto está disponivel"
    : "O produto não está disponivel"
    );


Console.WriteLine("\n------------------------------------------\n");

//Operador ! Opradaor not
//inverte um valor booleano

//inativar aluno
bool alunoAtivo = true;
alunoAtivo = false;

Console.WriteLine($"sTATUS {alunoAtivo}");


Console.WriteLine("\n------------------------------------------\n");

//inativar aluno - com operador not
alunoAtivo = true;
alunoAtivo = !alunoAtivo;

Console.WriteLine($"Status{alunoAtivo}");

//Tabelaverdade - operador not
Console.WriteLine($"!true = {!true}");
Console.WriteLine($"!false = {!false}");


Console.WriteLine("\n------------------------------------------\n");




