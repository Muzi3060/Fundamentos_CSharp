// Exercicio Total de estoque


int[,] mapa = { {1,2,3}, {4,5,6}, {7,8,9} }; // Criando matrix de 3x3

for (int i = 0; i < mapa.GetLength(0); i++) // GetLength(0) retorna o número de linhas da matriz nesse caso 3 conforme os valores dentro de cada []
{
    for (int j = 0; j < mapa.GetLength(1); j++) // GetLength(1) retorna o número de colunas da matriz nesse caso 3 conforme cada []
    {
        Console.Write(mapa[i, j] + " "); // Imprimindo os valores da matriz com formatação de espaço entre eles
    }
    Console.WriteLine();
}

int somaTotal = 0;

for (int i = 0; i < mapa.GetLength(0); i++)
{
    for (int j = 0; j < mapa.GetLength(1); j++)
    {
        somaTotal += mapa[i, j];
    }
}

Console.WriteLine("Soma total: " + somaTotal);