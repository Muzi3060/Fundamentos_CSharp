// Exercicio Média de peso

double[] pesos = new double [4]; // criando um array com 4 posições
double pesoTotal = 0; // variável para armazenar o peso total


Console.WriteLine("Digite o peso de 4 caixas: ");

for (int i = 0; i < pesos.Length; i++) // Fazendo um loop para preencher o array
{
    Console.WriteLine($"Digite o peso da caixa {i + 1}: ");
    pesos[i] = double.Parse(Console.ReadLine());
}


for (int i = 0; i < pesos.Length; i++)
{
    pesoTotal += pesos[i]; // somando os pesos das caixas
}

Console.WriteLine($"O peso total das caixas é: {pesoTotal}\n");

Console.WriteLine($"A média dos pesos é: {pesoTotal / pesos.Length}");
