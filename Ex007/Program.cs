// Exercicio RPG

Console.WriteLine("Quantos turnos o veneno vai durar? ");
int turnos = int.Parse(Console.ReadLine());

Console.WriteLine("E quanto de dano vai aplicar por turno? ");
int dano = int.Parse(Console.ReadLine());

int totalDano = turnos * dano;

for (int t = 0; t < turnos; t++)
{
    Console.WriteLine($"Turno {t + 1} - Dano aplicado: {dano}");
}

Console.WriteLine($"------------------------------------\nTotal de dano aplicado: {totalDano}");