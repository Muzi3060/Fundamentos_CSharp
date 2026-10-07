// Exercicio Frete

float precoViagem = 10.00f;
Console.WriteLine("Custos de viagens até 10km\n");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Custo da viagem de {i}km é: R${precoViagem * i}");
}