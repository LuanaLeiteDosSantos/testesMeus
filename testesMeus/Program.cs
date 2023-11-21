#region Calculadora
double num1 = 0;
double num2 = 0;
double numEscolha = 0;
double resultadoSoma = 0;
double resultadoSubtracao = 0;
double resultadoMultiplicacao = 0;
double resultadoDivisao = 0;
string nome = "";

Console.WriteLine($"Qual é seu nome?");
nome = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Olá {nome}, bem vindo(a)!\n");

Console.WriteLine($"Digite o primeiro número");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Digite o segundo número");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Temos quatro operações, qual você deseja fazer?\n" +
    $"1 - Soma\n" +
    $"2 - Subtração\n" +
    $"3 - Multiplicação\n" +
    $"4 - Divisão");
numEscolha = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (numEscolha == 1)
{
    resultadoSoma = num1 + num2;
    Console.WriteLine($"O resultado de {num1} + {num2} é: {resultadoSoma}. ");
}

else if (numEscolha == 2)
{
    resultadoSubtracao = num1 - num2;
    Console.WriteLine($"O resultado de {num1} - {num2} é: {resultadoSubtracao}. ");
}

else if (numEscolha == 3)
{
    resultadoMultiplicacao = num1 * num2;
    Console.WriteLine($"O resultado de {num1} x {num2} é: {resultadoMultiplicacao}. ");
}

else if (numEscolha == 4)
{
    resultadoDivisao = num1 / num2;
    Console.WriteLine($"O resultado de {num1} / {num2} é: {resultadoDivisao}. ");
}
#endregion

