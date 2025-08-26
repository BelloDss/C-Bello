//Formas de se declara uma string
using System.Globalization;

string s1 = "C#";
String s2 = "C#";

Console.WriteLine(s1);
Console.WriteLine(s2);


//Apelido Short
short s3 = 0;
Int16 s4 = 0;

//Apelido int
short n3 = 0;
Int32 n4 = 0;

//Apelido Long
long k3 = 0;
Int64 k4 = 0;




Console.WriteLine("\n-------------------------------------------------------\n");

//Métodos de String
//To.Upper() - Converte as letras para maiuscula 
Console.WriteLine("c# tem upper!".ToUpper() );

//ToLower() - Converte as letras para maiuscula 
Console.WriteLine("C# TEM LOWER".ToLower());

//Converte a primeira letra de cada palavra para maiucula 
string nome = "bello";
nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome);
Console.WriteLine(nome);



//Replace substitui um texto por outro
string ling = "Programação em Python";
Console.WriteLine(ling);
Console.WriteLine(ling.Replace("Python", "c#") );


//Remove - Remove um trecho da string
string rev2 = "0123456789";
string rev3 = "C#--------";
string rev1 = "C#--- é top";

Console.WriteLine (rev2.Remove(2));
Console.WriteLine (rev3.Remove(2, 3)) ;

//Substring - Mantem parte da string
string sub1 = "0123456789";
string sub2 = "----C#----";
string sub3 = "--Python--";

Console.WriteLine(rev2.Remove(4, 2) );
Console.WriteLine(rev3.Remove(2, 3) );


//index0F - Retorna a psoição inicial do caractere infomado 
string ind = "Programaçaõ em C#";
Console.WriteLine(ind);
Console.WriteLine(ind.IndexOf("#"));
Console.WriteLine(ind.IndexOf("@"));

//index0f com Estrutura Condicional If
string dds = "Seg, Ter, Qua, Qui, Sex";

Console.WriteLine("Digite o nome da um dia da semana: ");
string resposta = Console.ReadLine();

if (dds.IndexOf(resposta) >= 0)
    Console.WriteLine("Dia localizado");
else
    Console.WriteLine("Dia invalido");
Console.WriteLine("\n-------------------------------------------------------\n");

//Length - comprimento de uma string
//Length é uma propriedade
Console.WriteLine("Python");
Console.WriteLine("Python".Length);

Console.WriteLine("\n-------------------------------------------------------\n");
string letra1 = "A";
string letra2 = "B";
string letra3 = "C";

Console.WriteLine( letra1 + "B" + letra3 );
Console.WriteLine( "A" + letra2 + "C" );

//Join - Concatena strings utilizando o delimitador informado 
// String.Join(Delimitador, Texto1, Texto2, ...)













if (s1 == s2)
    Console.WriteLine("São Iguais");
else
    Console.WriteLine("não sao iguais");















