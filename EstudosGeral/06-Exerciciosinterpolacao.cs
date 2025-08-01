void Exercicio01()
{
    // Crie um algoritmo que:
    // 1. Declare uma variável chamada 'usuario' do tipo string com o nome de um usuário.
    // 2. Use interpolação para exibir: "Bem-vindo ao sistema, [usuario]!"


    Console.Write("Digite seu nome de usario: ");
    string user = Console.ReadLine();
    Console.WriteLine(user);

    Console.WriteLine($"Bem vindo ao sistema {user}");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio01();


void Exercicio02()
{
    // Crie um algoritmo que:
    // 1. Declare uma variável chamada 'nome' do tipo string.
    // 2. Declare uma variável chamada 'idade' do tipo int.
    // 3. Use interpolação para exibir a mensagem: "Olá, meu nome é [nome] e tenho [idade] anos."


    Console.Write("Digite seu nome, bunda mole: ");
    string nome = Console.ReadLine();
    Console.WriteLine(nome);

    Console.Write("Digite a sua idade, big bunda.");
    string idade = Console.ReadLine();
    Console.WriteLine(idade);

    Console.WriteLine($"O nome do mano é:{nome} e a idade é {idade}");
}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio02();


void Exercicio03()
{
    // Crie um algoritmo que:
    // 1. Declare uma variável chamada 'produto' do tipo string.
    // 2. Declare uma variável chamada 'preco' do tipo double.
    // 3. Use interpolação para exibir: "O produto [produto] custa R$ [preco]."

    Console.Write("Digite o nom do seu produto: ");
    string produto = Console.ReadLine();
    Console.WriteLine(produto);

    Console.Write("Digite o nom do seu produto: ");
    double preco = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(preco);

    Console.WriteLine($"O produto: {produto} custa R$: {preco}");


}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio03(); 


void Exercicio04()
{
    // Crie um algoritmo que:
    // 1. Declare três variáveis chamadas 'nota1', 'nota2' do tipo double.
    // 2. Calcule a média das notas e armazene em uma variável 'media'.
    // 3. Use interpolação para exibir: "As notas foram: [nota1], [nota2]. A média final é [media]."


    double nota1 = 32;
    double nota2 = 43;

    double media1 = nota1 + nota2;
    double media2 = media1 / 2;

    Console.Write($"As notas foram: {nota1}, {nota2}. A média final é {media2}");


}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio04();


void Exercicio05()
{
    // Crie um algoritmo que:
    // 1. Declare as variáveis: 'nomeFuncionario' (string), 'cargo' (string), 'salario' (double).
    // 2. Use interpolação para exibir: "[nomeFuncionario] ocupa o cargo de [cargo] e recebe R$ [salario]."



    Console.Write("Nome do funcionario: ");
    string nome = Console.ReadLine();
    Console.WriteLine(nome);

    Console.Write("Cargo: ");
    string cargo = Console.ReadLine();
    Console.WriteLine(cargo);

    Console.Write("Salário: ");
    double salario = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(salario);

    Console.WriteLine($"Nome do funcionario é: {nome}, Cargo: {cargo}, Salário: {salario}");


}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio05();


void Exercicio06()
{
    // Crie um algoritmo que:
    // 1. Declare variáveis: 'marca' (string), 'modelo' (string) e 'ano' (int).
    // 2. Use interpolação para exibir: "Veículo: [marca] [modelo] - Ano [ano]."


    Console.Write("Digite a marca do veiculo: ");
    string marca = Console.ReadLine();
    Console.WriteLine(marca);

    Console.Write("Modelo: ");
    string modelo = Console.ReadLine();
    Console.WriteLine(modelo);


    Console.Write("Ano: ");
    int ano = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(ano);

    Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano: {ano}");

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio06();


void Exercicio07()
{
    // Crie um algoritmo que:
    // 1. Declare as variáveis: 'produto' (string), 'quantidade' (int), 'precoUnitario' (double).
    // 2. Calcule o total da compra e armazene em 'valorTotal'.
    // 3. Use interpolação para exibir: "[quantidade] x [produto] a R$ [precoUnitario] cada. Total: R$ [valorTotal]."

    string produto = "Lego f1";
    int quantidade = 6;
    double precoUnitario = 258.90;






}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();


void Exercicio08()
{
    // Arredonde o número abaixo para duas casas decimais e, em seguida, utilize interpolação de 
    // strings para substituir o texto "interpolacao" pelo valor da variável "interpolacao" no texto exibido.
    double interpoalacao = 129.99451654;

    Console.WriteLine("O valor final da sua compra é de: interpolacao");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();


void Exercicio09()
{
    // Arredonde o número abaixo para três casas decimais e, em seguida, utilize interpolação de 
    // strings para substituir o texto "interpolacao" pelo valor da variável "interpolacao" no texto exibido.
    double interpoalacao = 0.8754321;

    Console.Write($"O valor final da sua compra é de: {interpoalacao: #.##}");

    Console.WriteLine("A diferença entre os corredores foi de apenas: interpolacao");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();


void Exercicio10()
{
    // Arredonde o número abaixo para uma casa decimal e, em seguida, utilize interpolação de 
    // strings para substituir o texto "interpolacao" pelo valor da variável "interpolacao" no texto exibido.
    double interpoalacao = 0.629874;
    Console.WriteLine($"A piscina tem apenas {interpoalacao.ToString("F1")} metros de profundidade.");


}


// Descomente o bloco de código abaixo para executar o exercício
Exercicio10();