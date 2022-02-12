// See https://aka.ms/new-console-template for more information
Console.Clear();
//Divisao();
//Subtracao();
//Multiplicacao();
//Soma();

Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1-Soma");
    Console.WriteLine("2-Subtração");
    Console.WriteLine("3-Divisão");
    Console.WriteLine("4-Multiplicação");
    Console.WriteLine("5-Sair");

    Console.WriteLine("-----------------------");
    Console.WriteLine("Selecione uma opção");

    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;

        default: Menu(); break;
    }


}
static void Soma()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor:");
    var valor1_usr_tela = Console.ReadLine();
    float v1 = float.Parse(valor1_usr_tela);

    Console.WriteLine("Digite o segundo valor:");
    var valor2_usr_tela = Console.ReadLine();
    float v2 = float.Parse(valor2_usr_tela);

    var resultado = v1 + v2;

    //Console.WriteLine("O Resultado da soma é:" + " " + resultado);
    Console.WriteLine($"O Resultado da soma é: {resultado}");
    // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
    // Console.WriteLine("O resultado da soma é:" + " " + (v1 + v2));

    //faz com que a execução do programa não pare depois de executar a função
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor:");
    var valor1_sub = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    var valor2_sub = float.Parse(Console.ReadLine());

    var subtracao = valor1_sub - valor2_sub;

    Console.WriteLine($"O resultado da subtação é {subtracao}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor:");
    var valor1_mult = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    var valor2_mult = float.Parse(Console.ReadLine());

    var multiplicacao = valor1_mult * valor2_mult;

    Console.WriteLine($"O resultado da subtação é {multiplicacao}");
    Console.ReadKey();

    Menu();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor:");
    var valor1_div = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    var valor2_div = float.Parse(Console.ReadLine());

    var divisao = valor1_div / valor2_div;

    Console.WriteLine($"O resultado da subtação é {divisao}");
    Console.ReadKey();
    Menu();
}




