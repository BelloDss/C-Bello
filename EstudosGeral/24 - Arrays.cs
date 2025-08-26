// Formas de se declarar um array em C# 

// 01 - Array vazio
using System.Net.Http.Headers;

string[] arrStr = { };
int[] arrInt = { };

// 02 - Array com valores
string[] arrStr2 = { "C#", "HTML", "Python" };
int[] arrInt2 = { 1, 2, 3, 4 };

// Imprimindo os valores do Array
Console.WriteLine(arrStr2); // Não imprimi a lista
Console.WriteLine(string.Join("|", arrInt2));// imprimi a lista


//Os Arrays, por padrão, não podem adicionar novos elementos
//arrStr2.Add("A");
//arrStr2.Insert("A");

// 03 - Declarar um Array vazio, mas com posições definidas
string[] arrElementos = new string[3];
arrElementos[0] = "Ar";
arrElementos[1] = "Água";
arrElementos[2] = "Terra";
//arrElementos[3] = "Fogo"; #Erro só pode ter no maximo 3 elementos por conta do limite

Console.WriteLine(string.Join("|", arrElementos));

// 04 - Declarar um Array com valores e com posições definidas
string[] arrElementos2 = new string[4] { "Ar", "Água", "Fogo", "Terra" };

Console.WriteLine("\n--------------------------------\n");

// Valores padrão do Array 
// Array de string são preenchidos com null
string[] arrStrVazio = new string[3]; // { null, null, null }
Console.WriteLine(arrStrVazio[0] == null);
Console.WriteLine(string.Join(",", arrStrVazio));

//Array de int são preenchidos com 0 
int[] arrIntVazio = new int[3]; // { 0, 0, 0 }
Console.WriteLine(arrIntVazio[0] == 0);
Console.WriteLine(string.Join(",", arrIntVazio));

//Array de bool são preenchidos com false
bool[] arrBoolVazio = new bool[3];
Console.WriteLine(arrBoolVazio[0] == false);

Console.WriteLine("\n---------------------------------\n");

// Como redimensionar um Array
string[] arrFolgas = { "Sexta", "Sabãdo" };

Array.Resize(ref arrFolgas, 3);

arrFolgas[2] = "Domingo";
Console.WriteLine(string.Join(",", arrFolgas));

Console.WriteLine("\n---------------------------------\n");

// Sobrescrever um valor do Array 
string[] arrSobre = { "A", "b", "C" };

arrSobre[1] = "B";

Console.WriteLine(string.Join(",", arrSobre));


Console.WriteLine("\n---------------------------------\n");

//// Formas de conversão
// Converter um Array para Lista
string[] arrMeses = { "Janeiro", "Fevereiro", "Março" };

List<string> listaMeses = new List<string>(arrMeses);
Console.WriteLine(string.Join(",", listaMeses));

Console.WriteLine("\n---------------------------------\n");

// Converter uma Lista para Array
List<int> listaNumeros = new List<int> { 1, 2, 3 };

int[] arrNumeros = listaNumeros.ToArray();
Console.WriteLine(string.Join(",", arrNumeros));

Console.WriteLine("\n---------------------------------\n");

// Converter uma String em um Array, converte para o tipo Char
char[] arrLetras1 = "Dificil".ToArray();
char[] arrLetras2 = "Facil".ToCharArray();

Console.WriteLine(string.Join(",", arrLetras1));
Console.WriteLine(string.Join(",", arrLetras2));

Console.WriteLine("\n---------------------------------\n");

//// MÉTODOS ESTÁTICOS
// .CopyTo() - Cria uma cópia de um Array

String[] arrCopy1 = { "C#", "HTML", "Python" };
string[] arrCopy2 = new string[3];

arrCopy1.CopyTo(arrCopy2, 0);
Console.WriteLine(string.Join(",", arrCopy2));

Console.WriteLine("\n---------------------------------\n");

// Reverse() - Inverte os elementos de uma Array
double[] arrReverse = { 1.5, 2.5, 3.5 };

Array.Reverse(arrReverse);

Console.WriteLine(string.Join(",", arrReverse));


Console.WriteLine("\n---------------------------------\n");

//Sort() - Ordena os elementos de um array
string[] arrSort = { "B", "D", "C", "A" };

Array.Sort(arrSort);

Console.Write(string.Join(",", arrSort));

Console.WriteLine("\n---------------------------------\n");

//indexOf - retorna o 1° elemento encontrado 
string[] nomes = { "Maria", "José", "Maria", "Pedro", "Maria" };

int indice1 = Array.IndexOf(nomes, "Maria");

Console.WriteLine($"Posição inicial: {indice1}");

//indexOf - retorna o ultimo elemento encontrado 
int indice2 = Array.IndexOf(nomes, "Maria");

Console.WriteLine($"Posição inicial: {indice2}");

Console.WriteLine("\n---------------------------------\n");

//Metodos para operações matematicas básicas 
int[] arrValores = { 10, 20, 30 };

Console.WriteLine( arrValores.Sum());
Console.WriteLine( arrValores.Average());
Console.WriteLine( arrValores.Max());
Console.WriteLine( arrValores.Min());
Console.WriteLine(arrValores.Count());

Console.WriteLine("\n---------------------------------\n");


//PROPRIEDADE
// LENGTH RETORNA A QUANTIDADE DE ELEMENTOS DO ARRAY
string[] arrTamanho = { "A", "B", "C", "D" };

int qtd = arrTamanho.Length;

Console.WriteLine($"Quantidad de elementos: {qtd}");
Console.WriteLine("\n---------------------------------\n");



//Clear - Remover os elementos array
int[] arrClear = { 1, 2, 3 };

//
Array.Clear(arrClear, 0,3);
Console.WriteLine(String.Join(",", arrClear));

Console.WriteLine("\n---------------------------------\n");











