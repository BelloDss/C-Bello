// listas
// estrutura de dados, capaz de armazenar múltiplos valores em uma única variável.
// Diferente dos arrays, as listas possuem tamanho dinâmico, ou seja, podem crescer e diminuir conforme a necessidade do programa.
// As listas são definidas pela classe List<T>, onde T representa o tipo dos elementos que a lista irá armazenar.

// Exemplo 'básico de uso de listas em C#:

List<int> lista1 = new List<int>(); // Cria uma lista vazia de inteiros

List<string> lista2 = new List<string>(); // Cria uma lista vazia de strings
List<double> lista3 = new List<double>(); // Cria uma lista vazia de doubles
List<char> lista4 = new List<char>(); // Cria uma lista vazia de chars
List<bool> lista5 = new List<bool>(); // Cria uma lista vazia de bools
List<float> lista6 = new List<float>(); // Cria uma lista vazia de floats

//Itens para usar na lista:
lista1.Add(6); // Adiciona o elemento 6 ao final da lista
lista1.Remove(3); // Remove o elemento 3 da lista
lista1.Add(4);

// Lista Vazia
Console.WriteLine("Lista Vazia: " + lista1.Count); // Exibe a quantidade de elementos na lista (0)
Console.WriteLine("Lista Vazia: " + lista2.Count); // Exibe a quantidade de elementos na lista (0)

// Lista com valores
Console.WriteLine("Lista com valores: " + lista1.Count); // Exibe a quantidade de elementos na lista (3)
Console.WriteLine("Lista com valores: " + lista3.Count); // Exibe a quantidade de elementos na lista (3)

// Acessando elementos da lista
Console.WriteLine("Primeiro elemento da lista1: " + lista1[0]); // Exibe o primeiro elemento da lista (1)
Console.WriteLine("Segundo elemento da lista2: " + lista2[1]); // Exibe o segundo elemento da lista (banana)

// Adicionando valores na lista2

List<string> name = new List<string>
{
    "Catiuska",
        "João",
        "Maria",
        "Maikon"
};

// Imprimir valores da lista
foreach (string n in name)
{
    Console.WriteLine(n);
}

// Adicionando valores na lista3
List<double> valores = new List<double>
{
    1.5,
    2.3,
    3.7,
    4.1
};

// Podemos imprimir os valores da lista utilizando o string.Join
Console.WriteLine("Valores da lista3: " + string.Join(", ", valores));

// Imprimir um índice da lista

//Metodos de Lista

// Adicionando valores na lista4
List<char> letras = new List<char>
{
    'A',
    'B',
    'C',
    'D'
};

// .Add() - Adiciona um elemento ao final da lista
List<string> listaAdd = new List<string> { "Terra", "Fogo", "Água" };
listaAdd.Add("Ar");

Console.WriteLine(string.Join(", ", listaAdd));

//.Insert() - Insere um elemento em uma posição específica da lista
List<string> listaInsert = new List<string> { "Terra", "Fogo", "Água" };
listaInsert.Insert(1, "Ar");

Console.WriteLine(string.Join(", ", listaInsert));

// .Remove() - Remove o primeiro elemento encontrado na lista que corresponda ao valor especificado
List<string> listaRemove = new List<string> { "Terra", "Fogo", "Água" };
listaRemove.Remove("Fogo");

Console.WriteLine(string.Join(", ", listaRemove));

// RemoveAT() - Remove o elemento na posição especificada
List<string> listaRemoveAt = new List<string> { "Terra", "Fogo", "Água" };
listaRemoveAt.RemoveAt(1);

// lista[?] - Sobreescreve o elemento na posição especificada
List<string> listaSobre = new List<string> { "Terra", "Fogo", "Água" };

listaSobre[0] = "Escuridão";

Console.WriteLine(string.Join(", ", listaSobre));

//index0F - Retorna a posção de elemento informado
List<string> listaIndex = new List<string> { "Terra", "Fogo", "Agua", "Ar" };

Console.WriteLine( listaIndex.IndexOf("Fogo"));
Console.WriteLine(listaIndex.IndexOf("Agua"));


// Sort() - Ordena os elementos da lista em ordem crescente
List<int> listaSort = new List<int> { 3, 2, 4, 1 };
listaSort.Sort();

Console.WriteLine(string.Join(", ", listaSort));

// Reverse() - Ordena os elementos da lista em ordem crescente
List<int> listaReverse = new List<int> { 3, 2, 4, 1 };
listaSort.Reverse();

Console.WriteLine(string.Join(", ", listaReverse));


//AddRange - Concatena lista
List<int> listaRange1 = new List<int> { 1, 2, 3, 4 };
List<int> listaRange2 = new List<int> { 4, 5, 6, 7 };

listaRange1.AddRange(listaRange2);

Console.WriteLine(string.Join(", ",listaRange1));

//Metodos para operações aritmeticas básicas
List<double> listaValores = new List<double> { 1.5, 2.5, 3.5, 4.5 };

Console.WriteLine( listaValores.Sum());
Console.WriteLine( listaValores.Average()); // média
Console.WriteLine(listaValores.Max()); // maior valor
Console.WriteLine(listaValores.Min()); // menor valor
Console.WriteLine(listaValores.Count()); // qtd elementos


Console.ReadKey();
