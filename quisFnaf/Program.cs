#region Quiz Fnaf
string respostaCerta1 = "Golden freddy";
string respostaCerta2 = "Puppet";
string respostaCerta3 = "SpringTrap";
string respostaCerta4 = "Cassidy";
string respostaCerta5 = "Foxy";
string respostaCerta6 = "Freddy";
string resposta1 = "";
string resposta2 = "";
string resposta3 = "";
string resposta4 = "";
string resposta5 = "";
string resposta6 = "";
string respostaSimOuNao = "";

Console.WriteLine($"Qual é o animatronic mais poderoso do Fnaf 1?");
resposta1 = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Qual é o animatronic mais poderoso do Fnaf 2?");
resposta2 = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Qual é o vilão do Fnaf?");
resposta3 = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Como é o nome da alma que nao descansará sem sua vingança?");
resposta4 = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Qual é o nome do animatronic mais rápido do primeiro Fnaf?");
resposta5 = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Qual é o animatronic que representa a imagem da pizzaria?");
resposta6 = Console.ReadLine();

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
        $"1º - {respostaCerta1} / Sua resposta: {resposta1}\n" +
        $"2º - {respostaCerta2} / Sua resposta: {resposta2}\n" +
        $"3º - {respostaCerta3} / Sua resposta: {resposta3}\n" +
        $"4º - {respostaCerta4} / Sua resposta: {resposta4}\n" +
        $"5º - {respostaCerta5} / Sua resposta: {resposta5}\n" +
        $"6º - {respostaCerta6} / Sua resposta: {resposta6}");
}
#endregion
