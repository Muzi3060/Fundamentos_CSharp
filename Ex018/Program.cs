// Exercicio Corredor mais pesado

int[,] corredores = new int[2, 3];

for (int i = 0; i < corredores.GetLength(0); i++)
{
    for (int j = 0; j < corredores.GetLength(1); j++)
    {
        Console.WriteLine($"Digite o peso do corredor {i + 1} na posição {j + 1}: ");
        corredores[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Corredor mais pesado: ");

for (int i = 0; i < corredores.GetLength(0); i++)
{
    int maisPesado = corredores[i, 0];
    for (int j = 1; j < corredores.GetLength(1); j++)
    {
        if (corredores[i, j] > maisPesado)
        {
            maisPesado = corredores[i, j];
            Console.WriteLine($"Corredor {i + 1} na posição {j + 1} é o mais pesado com {maisPesado} kg");
        }
        
        
    }
}