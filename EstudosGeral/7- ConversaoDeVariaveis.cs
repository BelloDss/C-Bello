//Somar dois números
Console.Write("Digite o 1 Numero: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o 2 Numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Resultado: {n1 + n2}");

/*
Convert.ToInt16() - Converte para o tipo short
Convert.ToInt32() - Converte para o tipo int
Convert.ToInt64() - Converte para o tipo long
Convert.ToBooLan() - Converte para o tipo bool
Convert.ToDouble() - Converte para o tipo double
                    
 
 */


/*
 
//Armazenar tipo double
Console.WriteLine("Digite um número: ");

//Forma correta de se converter
double numero = Convert.ToDouble (Console.ReadLine());

//Formas erradas de se converter
//string numeor = Convert.ToDouble(Console.ReadLine());
//double numero = Console.ReadLine();

//-----------------------------------------------------
 
 */

int nInteiro = int.Parse("5");
double nDouble = double.Parse("5.99");
float nFloat = float.Parse("5.99");
bool nBool = bool.Parse("5");
