using System.Net.Http.Headers;

string Exercicio01(int num1, int num2, int num3)
{
    // Crie um método que receba três números como parâmetros, e que retorne a soma desses três números.
    int soma = num1 + num2 + num3;
    return $"A soma dos numeros é {soma}";

}
// Descomente o bloco de código abaixo para executar o exercício
//Console.WriteLine(Exercicio01(1, 2, 3));



string Exercicio02(int numes)
{
    // Crie um método que receba um número como parâmetro, e com uma condicional if/else crie a condição abaixo:

    // - Se o número informado for maior que 0, então retorne 'Positivo'
    // - Se o número informado for menor que 0, então retorne 'Negativo'
    // - Se o número informado for igual a zero, então retorne 'Neutro'

    if (numes > 0)
    {
        return $"{numes} é positivo";
    }
    else if (numes < 0)
    {
        return $"{numes} é negativo";
    }
    else
    {
        return $"{numes} é negativo";
    }

}
// Descomente o bloco de código abaixo para executar o exercício
//Console.WriteLine(Exercicio02(9));



string Exercicio03(int senna)
{
    // Crie um método que receba um número como parâmetro, e que retorne o dobro do número.
    return $"O dobro de{senna} é {senna * 2}";

}
// Descomente o bloco de código abaixo para executar o exercício
//Console.WriteLine(Exercicio03(5));



string Exercicio04(double arroba)
{
    // No Brasil, 1 arroba equivale a 15 kg.
    // Com base nessa informação, crie um método que receba um valor em quilogramas (kg) e retorne o valor correspondente em arrobas.

    // Entrada: 150 kgs
    // Saída: 10 arrobas

    double soma = arroba * 15.000;
    return $"O numeero {soma} tem a conversão em {arroba} arrobas ";


}
// Descomente o bloco de código abaixo para executar o exercício
//Console.WriteLine(Exercicio04(5));



string Exercicio05(int salario)
{
    // Crie um método que receba um valor de salário como parâmetro e retorne o valor do salário acrescido de um reajuste de 10%.

    // Dica:
    // 10%  * 1000 = 100 (Não é válido)
    // 0.10 * 1000 = 100 (Equivamente, é válido)
    double conta = 0.10 * 1000;
    return $"{salario + conta}";

}
// Descomente o bloco de código abaixo para executar o exercício
//Console.WriteLine(Exercicio05(500));



string Exercicio06(double nota1, double nota2, double nota3, double nota4)
{
    // Crie um método que:
    // 1. Receba quatro notas como parâmetros.
    // 2. Calcule a soma das quatro notas.
    // 3. Calcule a média aritmética das notas, dividindo a soma por 4.
    // 4. Retorne a média final.

    double somas = nota1 + nota2 + nota3 + nota4;
    return $"A média das notas é: {somas / 4}";

}
// Descomente o bloco de código abaixo para executar o exercício
//Console.WriteLine(Exercicio06(8,6,7,8));



string Exercicio07(double altura, double kg)
{
    // Crie um método que receba dois parâmetros: altura (em metros) e peso (em quilogramas).
    // O método deve calcular e retornar o valor do IMC(Índice de Massa Corporal), utilizando a seguinte fórmula:

    // Formúla: IMC = Peso / (Altura * Altura)

    double mediaPesos = kg / (altura * altura); // s colocar m () o calculo ele faz primeiro ele
    return $"O MDS do cira é: Altura {altura}, Peso: {kg} -- MDC: {mediaPesos}";


}
// Descomente o bloco de código abaixo para executar o exercício
//Console.WriteLine(Exercicio07(1.66, 64));



string Exercicio08(int temp)
{
    // Crie um método que receba uma temperatura em Celsius e retorne o valor convertido para Fahrenheit.

    // Fórmula: Fahrenheit = (Celsius * 9/5) + 32

    int calculoTemp = temp * 9 / 5 + 32;
    return $"Conversão de {temp} Graus é: {calculoTemp}";

}
// Descomente o bloco de código abaixo para executar o exercício
Console.WriteLine(Exercicio08(25));



void Exercicio09()
{
    // Crie um método que receba largura, altura e profundidade (em cm) e retorne o volume da caixa em litros.

    // Fórmula: volume = (largura × altura × profundidade) / 1000



}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();



void Exercicio10()
{
    // Crie um método que receba o valor total de uma compra e o número de parcelas,
    // e retorne o valor de cada parcela com duas casas decimais.



}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();

Console.ReadKey();