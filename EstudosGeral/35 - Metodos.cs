
//Metodosm- quivalente a um def (fun�oesno python)

/*
Sintaxe para declarar um m�todo 

tipoDoRetorno nomeDoM�todo (parametro)

{instru��o)
 


Se o metodo declarado na variavel for int - int e string, se tiver uma interpola��o vira tudo string


 */



//void � vazio, por isso ele retorna nada
using System.Diagnostics;

void exemplo1()
{
    Console.WriteLine("Meu primeiro Metodo");
}
//Executando o metodo
//exemplo1();


//Metos com retorno

int Exemplo2()
{
    //Acontece aqui dentro e morre aqui dentro (toda varivael ou qualqer declara��o qu estiver aqui fica aqui

    int a = 2;
    int b = 4;
    return a + b;

}
//Exemplo2();





/*
 Tipo do dado do retorno do mtodos precisa ser igual no inico da declara��o do metodo  apoa a instru��o "return"
 */

string Exemplo3()
{
    return "Retorna";
}
//Exemplo3();






//exemplo sem parametro

string Exemplo4()
{
    string nome = "Matheus Bello";
    string frase = $"Sja bem vinda(o) {nome}";
    return frase;

}
//Console.WriteLine(Exemplo4());
////ou 
//string retorna = Exemplo4();
//Console.WriteLine(retorna);







string Exemplo5(string nome)
{

    string frase = $"Sja bem vinda(o) {nome}";
    return frase;

}
//Console.WriteLine(Exemplo5("Thiago"));








//Exemplo com 2 parametros (string, int)

string Exemplo6(string nome, int idade)
{
    string frase = $"{nome} tem {idade} anos.";
    return frase;

}
//Console.WriteLine("Bello", 20);




//02 - Exmplo com 2 parametros (int, int)
string Exemplo602(int x, int y)
{
    string soma = $"x + y = {x + y}";
    return soma;
}
//Exemplo602(7, 8);





//Reutuiliza��o de metodos
int Exemplo7(int n)
{
    return n * 2;
}
int calculo = Exemplo7(2);
int calculo2 = Exemplo7(calculo);
//Console.WriteLine(calculo2);










//------------------------------------------------------------------------
//Atividade
string Notas(string nome, float nota, float nota2)
{
    float nota3 = nota + nota2;
    string frase = $"{nome} teve a media de {nota3 / 2}";

    return frase;

}
string resu = Notas("Thiago", 8, 9);
Console.WriteLine(resu);

//-------------------------------------------------------------------


//string Exemplo6(string nome, int idade)
//{
//    string frase = $"{nome} tem {idade} anos.";
//    return frase;

//}
////Console.WriteLine("Bello", 20);



Console.ReadKey();








