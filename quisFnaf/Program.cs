#region Quiz Fnaf
int respostaCerta1 = 2;
int respostaCerta2 = 1;
int respostaCerta3 = 2;
int respostaCerta4 = 3;
int respostaCerta5 = 2;
int respostaCerta6 = 1;
int resposta1 = 0;
int resposta2 = 0;
int resposta3 = 0;
int resposta4 = 0;
int resposta5 = 0;
int resposta6 = 0;
string respostaSimOuNao = "";

Console.WriteLine($"Qual é o animatronic mais poderoso do Fnaf 1?\n" +
    $"1 - Puppet\n" +
    $"2 - Golden Freddy\n" +
    $"3 - Ballon Boy");
resposta1 = Convert.ToInt16(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Qual é o animatronic mais poderoso do Fnaf 2?\n" +
    $"1 - Puppet\n" +
    $"2 - Mangle\n" +
    $"3 - Toy Chica");
resposta2 = Convert.ToInt16(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Qual é o vilão do Fnaf?\n" +
    $"1 - Freddy\n" +
    $"2 - SpringTrap\n" +
    $"3 - Ballora");
resposta3 = Convert.ToInt16(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Como é o nome da alma que nao descansará sem sua vingança?\n" +
    $"1 - Gabriel\n" +
    $"2 - Charllote\n" +
    $"3 - Cassidy");
resposta4 = Convert.ToInt16(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Qual é o nome do animatronic mais rápido do primeiro Fnaf?\n" +
    $"1 - Bonnie\n" +
    $"2 - Foxy\n" +
    $"3 - Freddy");
resposta5 = Convert.ToInt16(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Qual é o animatronic que representa a imagem da pizzaria?\n" +
    $"1 - Freddy\n" +
    $"2 - Foxy\n" +
    $"3 - Chica");
resposta6 = Convert.ToInt16(Console.ReadLine());

Console.Clear();

if (resposta1 == respostaCerta1)
{
    Console.WriteLine($"Primeira pergunta: Certa resposta");
}
else if (resposta1 != respostaCerta1)
{
    Console.WriteLine($"Primeira pergunta: Resposta errada");
}


if (resposta2 == respostaCerta2)
{
    Console.WriteLine($"Segunda pergunta: Certa resposta");
}
else if (resposta2 != respostaCerta2)
{
    Console.WriteLine($"Segunda pergunta: Resposta errada");
}


if (resposta3 == respostaCerta3)
{
    Console.WriteLine($"Terceira pergunta: Certa resposta");
}
else if (resposta3 != respostaCerta3)
{
    Console.WriteLine($"Terceira pergunta: Resposta errada");
}

if (resposta4 == respostaCerta4)
{
    Console.WriteLine($"Quarta pergunta: Certa resposta");
}
else if (resposta4 != respostaCerta4)
{
    Console.WriteLine($"Quarta pergunta: Resposta errada");
}


if (resposta5 == respostaCerta5)
{
    Console.WriteLine($"Quinta pergunta: Certa resposta");
}
else if (resposta5 != respostaCerta5)
{
    Console.WriteLine($"Quinta pergunta: Resposta errada");
}


if (resposta6 == respostaCerta6)
{
    Console.WriteLine($"Sexta pergunta: Certa resposta");
}
else if (resposta6 != respostaCerta6)
{
    Console.WriteLine($"Sexta pergunta: Resposta errada");
}

Console.WriteLine($"Se errou alguma, quer ver as respostas certas?");
respostaSimOuNao = Console.ReadLine();

if (respostaSimOuNao.ToLower() == "sim")
{
    Console.WriteLine($"Respostas certas:\n" +
        $"1º - {respostaCerta1} / Golden Freddy | Sua resposta: {resposta1}\n" +
        $"2º - {respostaCerta2} / Puppet | Sua resposta: {resposta2}\n" +
        $"3º - {respostaCerta3} / SpringTrap | Sua resposta: {resposta3}\n" +
        $"4º - {respostaCerta4} / Cassidy | Sua resposta: {resposta4}\n" +
        $"5º - {respostaCerta5} / Foxy | Sua resposta: {resposta5}\n" +
        $"6º - {respostaCerta6} / Freddy | Sua resposta: {resposta6}");
}
#endregion
