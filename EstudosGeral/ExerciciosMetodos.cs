using System.Net.Http.Headers;

string Exercicio01(int num1, int num2, int num3)
{
    // Crie um m�todo que receba tr�s n�meros como par�metros, e que retorne a soma desses tr�s n�meros.
    int soma = num1 + num2 + num3;
    return $"A soma dos numeros � {soma}";

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Console.WriteLine(Exercicio01(1, 2, 3));



string Exercicio02(int numes)
{
    // Crie um m�todo que receba um n�mero como par�metro, e com uma condicional if/else crie a condi��o abaixo:

    // - Se o n�mero informado for maior que 0, ent�o retorne 'Positivo'
    // - Se o n�mero informado for menor que 0, ent�o retorne 'Negativo'
    // - Se o n�mero informado for igual a zero, ent�o retorne 'Neutro'

    if (numes > 0)
    {
        return $"{numes} � positivo";
    }
    else if (numes < 0)
    {
        return $"{numes} � negativo";
    }
    else
    {
        return $"{numes} � negativo";
    }

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Console.WriteLine(Exercicio02(9));



string Exercicio03(int senna)
{
    // Crie um m�todo que receba um n�mero como par�metro, e que retorne o dobro do n�mero.
    return $"O dobro de{senna} � {senna * 2}";

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Console.WriteLine(Exercicio03(5));



string Exercicio04(double arroba)
{
    // No Brasil, 1 arroba equivale a 15 kg.
    // Com base nessa informa��o, crie um m�todo que receba um valor em quilogramas (kg) e retorne o valor correspondente em arrobas.

    // Entrada: 150 kgs
    // Sa�da: 10 arrobas

    double soma = arroba * 15.000;
    return $"O numeero {soma} tem a convers�o em {arroba} arrobas ";


}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Console.WriteLine(Exercicio04(5));



string Exercicio05(int salario)
{
    // Crie um m�todo que receba um valor de sal�rio como par�metro e retorne o valor do sal�rio acrescido de um reajuste de 10%.

    // Dica:
    // 10%  * 1000 = 100 (N�o � v�lido)
    // 0.10 * 1000 = 100 (Equivamente, � v�lido)
    double conta = 0.10 * 1000;
    return $"{salario + conta}";

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Console.WriteLine(Exercicio05(500));



string Exercicio06(double nota1, double nota2, double nota3, double nota4)
{
    // Crie um m�todo que:
    // 1. Receba quatro notas como par�metros.
    // 2. Calcule a soma das quatro notas.
    // 3. Calcule a m�dia aritm�tica das notas, dividindo a soma por 4.
    // 4. Retorne a m�dia final.

    double somas = nota1 + nota2 + nota3 + nota4;
    return $"A m�dia das notas �: {somas / 4}";

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Console.WriteLine(Exercicio06(8,6,7,8));



string Exercicio07(double altura, double kg)
{
    // Crie um m�todo que receba dois par�metros: altura (em metros) e peso (em quilogramas).
    // O m�todo deve calcular e retornar o valor do IMC(�ndice de Massa Corporal), utilizando a seguinte f�rmula:

    // Form�la: IMC = Peso / (Altura * Altura)

    double mediaPesos = kg / (altura * altura); // s colocar m () o calculo ele faz primeiro ele
    return $"O MDS do cira �: Altura {altura}, Peso: {kg} -- MDC: {mediaPesos}";


}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
//Console.WriteLine(Exercicio07(1.66, 64));



string Exercicio08(int temp)
{
    // Crie um m�todo que receba uma temperatura em Celsius e retorne o valor convertido para Fahrenheit.

    // F�rmula: Fahrenheit = (Celsius * 9/5) + 32

    int calculoTemp = temp * 9 / 5 + 32;
    return $"Convers�o de {temp} Graus �: {calculoTemp}";

}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
Console.WriteLine(Exercicio08(25));



void Exercicio09()
{
    // Crie um m�todo que receba largura, altura e profundidade (em cm) e retorne o volume da caixa em litros.

    // F�rmula: volume = (largura � altura � profundidade) / 1000



}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
// Exercicio09();



void Exercicio10()
{
    // Crie um m�todo que receba o valor total de uma compra e o n�mero de parcelas,
    // e retorne o valor de cada parcela com duas casas decimais.



}
// Descomente o bloco de c�digo abaixo para executar o exerc�cio
// Exercicio10();

Console.ReadKey();