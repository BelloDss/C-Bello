// 01# - Texto de múltiplas linhas
Console.WriteLine("""
Texto de    
Múltiplcas
Linhas  
""");

Console.WriteLine("\n--------------\n");

// 02# - Texto de múltiplas linhas
Console.WriteLine(@"Texto de
Múltiplas
Linhas");

Console.WriteLine("\n--------------\n");

// Múltiplas linhas com interpolação
string nome = "Thiago";
string curso = "Programação em C#";

Console.WriteLine($"""
Nome: {nome}    
Curso: {curso}    
""");

Console.WriteLine("\n--------------\n");

// 03# - Texto de múltiplas linhas
Console.WriteLine("Texto de\nMúltiplcas\nLinhas");

Console.WriteLine("\n--------------\n");

// 04# - Texto de múltiplas linhas
Console.WriteLine("Texto de\n" +
"Múltiplcas\n" +
"Linhas");