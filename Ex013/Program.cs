// Exercicio Inventário


string[] inventario = new string[5]; // criando um array com 5 posições

for (int i = 0; i < inventario.Length; i++) // Fazendo um loop para preencher o array
{
    Console.WriteLine($"Digite o item {i + 1} do inventário: ");
    inventario[i] = Console.ReadLine();
}

Console.WriteLine("==================");
Console.WriteLine("Itens do inventário:");

foreach (string item in inventario) // Fazendo um loop para exibir os itens do array
{
    Console.WriteLine($"Item: {item}");
}