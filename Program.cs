// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Informe seu ano de nascimento:");
int anoNascimento = int.Parse(Console.ReadLine());

int anoAtual = DateTime.Now.Year;

int idade = (anoAtual - anoNascimento);
Console.WriteLine($"sua idade é {idade} anos.");

if (idade >= 16 && idade <= 70)
{
    Console.WriteLine($"Você poderá votar esse ano, obrigado !!");
}
else 
{
    Console.WriteLine($"Você não poderá votar esse ano, tente novamento no próximo.");
}