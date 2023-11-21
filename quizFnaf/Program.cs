string respostaCerta1 = "Golden freddy";
string respostaCerta2 = "Puppet";
string respostaCerta3 = "SpringTrap";
string resposta1 = "";
string resposta2 = "";
string resposta3 = "";
string respostaSimOuNao = "";

Console.WriteLine($"Qual é o animatronic mais poderoso do Fnaf 1?");
resposta1 = Console.ReadLine();

Console.WriteLine($"Qual é o animatronic mais poderoso do Fnaf 2?");
resposta2 = Console.ReadLine();

Console.WriteLine($"Qual é o vilão do Fnaf?");
resposta3 = Console.ReadLine();

if (resposta1 == respostaCerta1) 
{
    Console.WriteLine($"Certa resposta");
}
else if (resposta1 != respostaCerta1)
{
    Console.WriteLine($"Resposta errada");
}


if (resposta2 == respostaCerta2)
{
    Console.WriteLine($"Certa resposta");
}
else if (resposta2 != respostaCerta2)
{
    Console.WriteLine($"Resposta errada");
}


if (resposta3 == respostaCerta3)
{
    Console.WriteLine($"Certa resposta");
}
else if (resposta3 != respostaCerta3)
{
    Console.WriteLine($"Resposta errada");
}

Console.WriteLine($"Quer ver as respostas certas?");
respostaSimOuNao = Console.ReadLine();

if (respostaSimOuNao == "sim")
{
    Console.WriteLine($"Respostas certas:\n" +
        $"1º - Golden freddy\n" +
        $"2º - Puppet\n" +
        $"3º - SpringTrap");
}