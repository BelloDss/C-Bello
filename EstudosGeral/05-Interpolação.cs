//interpolação
string linguagens = "C";

Console.WriteLine($"A gft vai me contratar por sabe {linguagens}");


Console.WriteLine("\n------------------------");


//Exibir entrada de dados em uma interpolação
Console.WriteLine("Digite a sua idade: ");
string idade = Console.ReadLine();

Console.WriteLine($"Eu tenho {idade} anos de idade");

Console.WriteLine("\n------------------------");



//Exibir entrada de dados em uma interpolação
int n1 = 12;
int n2 = 13;

Console.WriteLine($"Eu tenho {n1+n2} anos de idade");

Console.WriteLine("\n------------------------");


//Arrendonadr valores
double preco = 2.12345;

Console.WriteLine("Exmpleo de arredonamento");
Console.WriteLine(preco);
Console.WriteLine(Math.Round(preco, 1));
Console.WriteLine(Math.Round(preco, 2));

//Arredondar com interpolação
Console.WriteLine("Exemplo de camo arredondada com interpolação");
Console.WriteLine($"{preco}");
Console.WriteLine($"{preco:#.##}");
Console.WriteLine($"{preco:f2}");
Console.WriteLine($"{preco:c2}");

Console.WriteLine("\n------------------------");

//Converter numeros para uma string
Console.WriteLine("Converter Numeros para string; ");
Console.WriteLine(preco.ToString());
Console.WriteLine(preco.ToString("F2"));
Console.WriteLine(preco.ToString("C2"));

