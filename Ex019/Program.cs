// Exercicio Carrinho de hardware

List<string> carrinho = new List<string>();

Console.WriteLine("Bem-vindo ao carrinho de hardware! Digite os itens que deseja adicionar ao carrinho. Digite '0' para finalizar.");

while (true)
{
    string nomePeça = Console.ReadLine();

    if (nomePeça == "0") {
        Console.WriteLine("Compra finalizado!");
        break;
    }
    
    carrinho.Add(nomePeça);
    Console.WriteLine($"Item '{nomePeça}' adicionado ao carrinho. (Digite 0 para finalizar)");
    
    if (carrinho.Count == 5) {
        Console.WriteLine("Carrinho já tem 5 itens, caso não deseje mais comprar algo, digite 0 para finalizar.");
    } else if (carrinho.Count == 10) {
        Console.WriteLine("Carrinho já tem 10 itens, está ficando grandinho, caso não deseje mais comprar algo, digite 0 para finalizar.");
    }
    
}

foreach (string item in carrinho) {
    Console.WriteLine($"Item: {item}");
    
}

Console.WriteLine("===============================================");
Console.WriteLine($"Total de itens no carrinho: {carrinho.Count}");