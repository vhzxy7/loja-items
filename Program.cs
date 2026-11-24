Console.WriteLine("Por favor, digite a sua quantidade de moedas: ");
int moedas = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a quantidade de poções que você deseja comprar: ");
int qtdp = int.Parse(Console.ReadLine()!);

int ppoção = 15;

int total = qtdp * ppoção ;

if (moedas >= qtdp)
{
    Console.WriteLine($"Total da compra: R${total}");
    Console.WriteLine($"Saldo Restante: R${moedas - total}");
}
else
{
    Console.WriteLine($"Saldo insuficiente, você precisa de R${total}");
}