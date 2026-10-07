// Exercicio GPS


Console.WriteLine("Digite a distancia total em km: ");
int distancia = int.Parse(Console.ReadLine());

while (distancia > 0)
{
    Console.WriteLine($"Distancia restante: {distancia}km\n");
    Console.WriteLine("--------------------------------");
    distancia -= 5;

    if (distancia <= 0) {
        Console.WriteLine("Você chegou ao destino!");
        break;
    }
    
    Console.WriteLine($"Dirigindo... Faltam {distancia}km");
}