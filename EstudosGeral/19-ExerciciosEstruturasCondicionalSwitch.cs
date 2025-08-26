void Exercicio01()
{
    // Crie um programa que solicite ao usuário que digite uma letra, em seguida, crie as condições abaixo.

    // - Se a letra for igual a F, exiba:
    // >>> Feminino
    // - Se a letra for igual a M, exiba:
    // >>> Masculino
    // - Qualquer outro valor, exiba:
    // >>> Opção inválido

    Console.Write("Digite uma letra M ou F: ");
    string sex = Console.ReadLine();

    switch (sex)
    {
        case "M":
            Console.WriteLine("Macho");
            break;
        case "F":
            Console.WriteLine("Mulher");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio01();



void Exercicio02()
{
    // Crie um programa que solicite ao usuário que digite seu login e, em seguida, retorne uma mensagem de acordo com o tipo de usuário:

    // - Se o login for "admin", exiba: SEJA BEM-VINDO, ADMIN!
    // - Se o login for "instr", exiba: SEJA BEM-VINDO, INSTRUTOR!
    // - Se o login for "sup", exiba: SEJA BEM-VINDO, SUPORTE!
    // - Se o login for "aluno", exiba: SEJA BEM-VINDO, ALUNO!
    // - Senão, exiba: LOGIN INCORRETO.




    Console.Write("""
    Digite o seu Login.
        
        - admin
        - instr
        - sup
        - aluno

    """);
    string login = Console.ReadLine();

    switch (login)
    {
        case "admin":
            Console.WriteLine("SEJA BEM-VINDO, ADMIN!");
            break;
        case "instr":
            Console.WriteLine("SEJA BEM-VINDO, INSTRUTOR!");
            break;
        case "sup":
            Console.WriteLine("SEJA BEM-VINDO, SUPORTE!");
            break;
        case "aluno":
            Console.WriteLine("SEJA BEM-VINDO, ALUNO!");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio02();



void Exercicio03()
{
    // Crie um programa que solicite ao usuário que informe o código correspondente ao idioma em que deseja ser recebido, conforme a lista abaixo:

    // - Digite 1 para receber a mensagem em Espanhol:  Bienvenido
    // - Digite 2 para receber a mensagem em Francês:    Bienvenue
    // - Digite 3 para receber a mensagem em Português: Bem-Vindo
    // - Digite 4 para receber a mensagem em Inglês: Welcome
    // - Para qualquer outro valor informado, exiba: Código inválido


    Console.Write("""
    Digite o seu Idioma.
        
    Digite 1 para receber a mensagem em Espanhol
    Digite 2 para receber a mensagem em Francês
    Digite 3 para receber a mensagem em Português
    Digite 4 para receber a mensagem em Inglês
   

    """);
    int login = Convert.ToInt32(Console.ReadLine());

    switch (login)
    {
        case 1:
            Console.WriteLine("SEJA BEM-VINDO, ADMIN!");
            break;
        case 2:
            Console.WriteLine("SEJA BEM-VINDO, INSTRUTOR!");
            break;
        case 3:
            Console.WriteLine("SEJA BEM-VINDO, SUPORTE!");
            break;
        case 4:
            Console.WriteLine("SEJA BEM-VINDO, ALUNO!");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio03();



void Exercicio04()
{
    // Crie um programa que solicite ao usuário que informe uma cor do semáforo e, em seguida, verifique a cor informada e exiba uma das mensagens abaixo:

    // - Se a cor for VERDE, exiba:
    // >>> Siga em frente
    // - Se a cor for AMARELO, exiba:
    // >>> Atenção
    // - Se a cor for VERMELHO, exiba:
    // >>> Pare o carro
    // - Para qualquer outra cor, exiba:
    // >>> Sinal inválido

    Console.Write(" Digite a cor do semafaro");

    string sema = Console.ReadLine();
    switch (sema)
    {
        case "VERDE":
            Console.WriteLine("Siga em frente");
            break;
        case "AMARELO":
            Console.WriteLine("Reduza a velocidade");
            break;
        case "VERMELHO":
            Console.WriteLine("Pare o carro.");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie um programa que solicite ao usuário que digite uma letra e, com base na entrada, exiba a ação correspondente:

    // - Se a letra digitada for I, exiba: Incluir
    // - Se a letra digitada for C, exiba: Consultar
    // - Se a letra digitada for A, exiba: Alterar
    // - Se a letra digitada for E, exiba: Excluir
    // - Para qualquer outro valor, exiba: Opção inválida

    Console.Write("""
         Digite uma das letras a seguir:
        
        I
        C
        A
        E


        """);

    string letra = Console.ReadLine();
    switch (letra.ToUpper())
    {
        case "I":
            Console.WriteLine("Incluir");
            break;
        case "C":
            Console.WriteLine("Consultar");
            break;
        case "A":
            Console.WriteLine("Alterar");
            break;
        case "E":
            Console.WriteLine("Excluir");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio05();


void Exercicio06()
{
    // Crie um programa que solicite ao usuário o número correspondente a um mês (de 1 a 12) e exiba a programação do calendário referente a esse mês.

    // - Se o mês for igual a 1, classifique como: "Férias"
    // - Se o mês entiver entre 2 e 6, classifique como: "1º Semestre letivo"
    // - Se o mês for igual a 7, classifique como: "Férias"
    // - Se o mês entiver entre 8 e 12, classifique como: "2º Semestre letivo"
    // - Para qualquer outro valor, classifique como: "Mês inválido"

    Console.Write("""
            Digite um numero de 1 a 12
            Meses do ano.
         """);
    int login = Convert.ToInt32(Console.ReadLine());

    switch (login)
    {
        case 1:
            Console.WriteLine("Janeiro - Ferias");
            break;
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
            Console.WriteLine("Primeiro semestre");
            break;
        case 7:
            Console.WriteLine("Ferias");
            break;
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
            Console.WriteLine("Segundo semestre");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }
}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio06();


void Exercicio07()
{
    // Para ter direito à fila prioritária, o usuário deve se enquadrar em pelo menos uma das seguintes condições: idoso, gestante ou cadeirante.  
    // Crie um programa que solicite ao usuário que escolha uma das opções abaixo, digitando o número correspondente:

    // 1. Idoso
    // 2. Gestante
    // 3. Cadeirante
    // 4. Público geral

    // Em seguida, verifique a condição escolhida:
    // - Se o usuário digitar 1, 2 ou 3, exiba:
    // >>> Fila prioritária.
    // - Se o usuário digitar 4, exiba:
    // >>> Fila comum.
    // - Senão, exiba:
    // >>> Opção inválida.

    Console.Write("""
        Digite se voce é algum desses 
        
        1. Idoso
        2. Gestante
        3. Cadeirante
        4. Público geral
        """);
    int publi = Convert.ToInt32(Console.ReadLine());

    switch (publi)
    {
        case 1:Console.WriteLine("Idoso - Fila prioritária.");
            break;
        case 2:
            Console.WriteLine("Gestante - Fila prioritária.");
            break;
        case 3:
            Console.WriteLine("Cadeirante - Fila prioritária.");
            break;
        case 4:
            Console.WriteLine("Publico Geral");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }

}
// Descomente o bloco de código abaixo para executar o exercício
 Exercicio07();



void Exercicio08()
{
    // Crie um programa que solicite ao usuário o dia da semana e, com base na entrada, o programa deve exibir uma das seguintes mensagens:

    // - Se o usuário digitar "Segunda", "Terça", "Quarta", "Quinta" ou "Sexta", exiba:
    // >>> Dia da semana.
    //

    // - Se o usuário digitar "Sábado" ou "Domingo", exiba:
    // >>> Final de semana.
    // - Senão, exiba:
    // >>> Dia inválido.

    Console.Write("Digite o dia da semana: ");
    string sema = Console.ReadLine();

    switch (sema)
    {
        case "Segunda":
        case "Terça":
        case "Quarta":
        case "Quinta":
        case "Sexta":
            Console.WriteLine("Dia de semana");
            break;
        case "Sabado":case "Domingo":
            Console.WriteLine("Final de semeana");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio8();



void Exercicio09()
    {
    // Crie um programa que solicite ao usuário o código de um alimento e, com base nesse código, exiba a sua classificação conforme as regras abaixo:

    // - Se o código for entre 1 e 3, classifique como: "Alimentos in natura"
    // - Se o código for entre 4 e 6, classifique como: "Alimentos processados"
    // - Se o código for entre 7 e 9, classifique como: "Alimentos ultraprocessados"
    // - Para qualquer outro valor, classifique como: "Código inválido"
    Console.Write("Numero de 1 a 7: ");
    int ali = Convert.ToInt32(Console.ReadLine());

    switch (ali)
    {
        case 1:
        case 2:
        case 3:
            Console.WriteLine("Alimentos in natura");
            break;
        case 4:
        case 5:
        case 6:
            Console.WriteLine("Alimentos processado");
            break;
        case 7:
        case 8:
        case 9:
            Console.WriteLine("Alimentos ultraprocessado");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }


}
    // Descomente o bloco de código abaixo para executar o exercício
    // Exercicio09();



    void Exercicio10()
    {
    // Para determinar o tipo de ingresso adequado, o usuário deve informar seu perfil.
    // Crie um programa que solicite ao usuário que escolha uma das opções abaixo, digitando o número correspondente:

    // 1. Estudante
    // 2. Idoso
    // 3. PCD
    // 4. Público geral

    // Em seguida, verifique a condição escolhida:
    // - Se o usuário digitar 1, 2 ou 3, exiba:
    // >>> Ingresso com meia-entrada.
    // - Se o usuário digitar 4, exiba:
    // >>> Ingresso com valor integral.
    // - Senão, exiba:
    // >>> Opção inválida.


    Console.WriteLine("Escolha o tipo de usuário:");
   
    int tipo = Convert.ToInt32(Console.ReadLine());

    switch (tipo)
    {
        case 1:
        case 2:
        case 3:
            Console.WriteLine("Ingresso com meia-entrada.");
            break;
        case 4:
            Console.WriteLine("Ingresso com valor integral.");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }



}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();


void Exercicio11()
    {
        // Crie um programa que solicite ao usuário o nome do mês e, com base na entrada, o programa deve exibir uma das seguintes mensagens:

        // - Se o usuário digitar "Janeiro", "Fevereiro", "Março" exiba:
        // >>> Verão!
        // - Se o usuário digitar "Abril", "Maior", "Junho" exiba:
        // >>> Outono!    
        // - Se o usuário digitar "Julho", "Agosto", "Setembro" exiba:
        // >>> Inver!
        // - Senão, exiba:
        // >>> Dia inválido.



    }
    // Descomente o bloco de código abaixo para executar o exercício
    // Exercicio11();

    Console.ReadKey();
   