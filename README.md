# 📘 Curso de C# - SENAI (2º Semestre)

Este repositório contém **anotações, exemplos e exercícios** do curso de **C#** no SENAI, segundo semestre, com foco em **conceitos, operadores, estruturas de decisão, repetição e manipulação de dados**.

---

## 1. Conceitos

- História do C#  
- Características principais  
- Estrutura de um programa  
- Tipos de projetos no Visual Studio  

Exemplo:
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, mundo!");
    }
}
```

---

## 2. Comandos Básicos

- Tipos de dados: `int`, `float`, `double`, `string`, `bool`, `char`, `decimal`  
- Variáveis e constantes
```csharp
int idade = 18;
const double PI = 3.1415;
```
- Entrada e saída de dados
```csharp
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}!");
```

---

## 3. Console - Guia Rápido

- `Console.WriteLine()` → escreve texto no console  
- `Console.ReadLine()` → lê texto do usuário  
- `Console.ReadKey()` → espera por uma tecla

---

## 4. Interpolação

```csharp
string nome = "Matheus";
int idade = 18;
Console.WriteLine($"Nome: {nome}, Idade: {idade}");
```

---

## 5. Textos de Múltiplas Linhas

```csharp
Console.WriteLine(@"Linha 1
Linha 2
Linha 3");
```

---

## 6. Arredondamento de Números

```csharp
double valor = 12.3456;
Console.WriteLine(Math.Round(valor, 2));  // 12,35
Console.WriteLine(Math.Floor(valor));      // 12
Console.WriteLine(Math.Ceiling(valor));    // 13
```

---

## 7. Formatos de Conversão

```csharp
string numero = "100";
int n = int.Parse(numero);
Console.WriteLine(n + 50); // 150

double d = Convert.ToDouble("12.34");
Console.WriteLine(d);
```

---

## 8. Estrutura de Dados

### Conversão entre Tipos de Dados
- `int.Parse()`, `double.Parse()`, `Convert.ToInt32()`, `Convert.ToDouble()`  

### Operadores Aritméticos
- `+`, `-`, `*`, `/`, `%`  

### Operadores de Incremento e Decremento
- `++`, `--`  

### Operadores de Atribuição
- `=`, `+=`, `-=`, `*=`, `/=`  

### Operadores Relacionais
- `==`, `!=`, `>`, `<`, `>=`, `<=`  

### Operadores Unários, Binários e Ternários
```csharp
int a = 5;
int b = 10;
int max = (a > b) ? a : b; // ternário
```

### Operadores Lógicos
- `&&`, `||`, `!`  

---

## 9. Estruturas Condicionais

### If/Else
```csharp
if(idade >= 18)
    Console.WriteLine("Maior de idade");
else
    Console.WriteLine("Menor de idade");
```

### Switch/Case
```csharp
string cor = "azul";
switch(cor)
{
    case "vermelho": Console.WriteLine("Cor quente"); break;
    case "azul": Console.WriteLine("Cor fria"); break;
    default: Console.WriteLine("Cor desconhecida"); break;
}
```

---

## 10. Strings

### Métodos, Propriedades e Operadores
```csharp
string texto = "C# é incrível!";
Console.WriteLine(texto.Length);          // 13
Console.WriteLine(texto.ToUpper());       // C# É INCRÍVEL!
Console.WriteLine(texto.Contains("C#"));  // True
```

---

## 11. Listas

### Criação e Métodos
```csharp
using System.Collections.Generic;

List<string> nomes = new List<string>();
nomes.Add("Matheus");
nomes.Add("João");
Console.WriteLine(nomes[1]); // João
```

---

## 12. Array

### Declaração e Acesso
```csharp
int[] numeros = {1,2,3,4,5};
Console.WriteLine(numeros[0]); // 1
```

### Métodos e Propriedades
```csharp
Console.WriteLine(numeros.Length); // 5
Array.Reverse(numeros);
```

---

## 13. Fatiamento (Slicing)
```csharp
string palavra = "Programacao";
Console.WriteLine(palavra.Substring(0,6)); // Progra
```

---

## 14. Índice Reverso
```csharp
Console.WriteLine(palavra[palavra.Length-1]); // última letra
```

---

## 15. Laços de Repetição

### For
```csharp
for(int i=0; i<5; i++)
    Console.WriteLine(i);
```

### Foreach
```csharp
string[] nomesArray = {"Ana","Bruno","Carlos"};
foreach(string n in nomesArray)
    Console.WriteLine(n);
```

### While
```csharp
int x=0;
while(x<5)
{
    Console.WriteLine(x);
    x++;
}
```

---

## 🏁 Conclusão

Este README contém **todos os conceitos e exemplos básicos de C#** do segundo semestre do SENAI, incluindo: tipos de dados, variáveis, operadores, estruturas condicionais, laços de repetição, arrays, listas, strings, conversões, interpolação e manipulação de números.

---

👨‍💻 Desenvolvido por **Matheus Bello**
