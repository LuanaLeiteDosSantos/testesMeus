string Meta1 = "";
string Meta2 = "";
string Meta3 = "";
string nome = "";
string verMetas = "";

Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Olá {nome}! Escreva aqui suas top três metas para o ano!\n");

Console.WriteLine("Escreva top 1 meta para o ano!");
Meta1 = Console.ReadLine();
Console.WriteLine("Escreva top 2 meta para o ano!");
Meta2 = Console.ReadLine();
Console.WriteLine("Escreva top 3 meta para o ano!");
Meta3 = Console.ReadLine();

Console.Clear();

Console.WriteLine("Deseja ver o que você escreveu?");
Console.WriteLine("S - Sim");
Console.WriteLine("N - Não\n");
verMetas = Console.ReadLine();

if (verMetas == "S")
{
    Console.Clear();
    Console.WriteLine($"1º {Meta1}");
    Console.WriteLine($"2º {Meta2}");
    Console.WriteLine($"3º {Meta3}");
}
else if (verMetas == "N")
{
    Console.WriteLine("Ok.");
}