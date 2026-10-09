// Exercicio Leitor de preços

Dictionary<string, double> produtos = new Dictionary<string, double>
{
    {"Placa de Vídeo", 2500.00},
    {"Processador", 1200.00},
    {"Memória RAM", 300.00}
    // criação de um dicionario com valores
};

while (true)
{
    Console.WriteLine("Digite o nome de um produto para ver a disponibilidade");
    string nomeProduto = Console.ReadLine();

    if (produtos.ContainsKey(nomeProduto)) {
        double preco = produtos[nomeProduto];
        Console.WriteLine($"O preço do produto é R$ {preco}");
    }else{
        Console.WriteLine("Produto não cadastrado.");
    }
    
    Console.WriteLine("Digite 'sair' para encerrar o programa, ou qualquer coisa para continuar.");
    string comando = Console.ReadLine();
    if (comando == "sair") {
        break;
    }
}