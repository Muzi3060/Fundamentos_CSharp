// Exercicio Produto solto

(string Nome, int QtdEstoque, double precoUnitario) produto = ("Caneta", 10, 2.5); // Isso é uma ValueTuple, que é uma estrutura de dados que permite armazenar múltiplos valores em uma única variável. Mutável, mas não é uma classe. É útil para agrupar dados relacionados sem a necessidade de criar uma classe separada.

double ValorTotal = produto.QtdEstoque * produto.precoUnitario;

Console.WriteLine($"Nome do Produto: {produto.Nome}");
Console.WriteLine($"Quantidade total que ele representa no estoque: {ValorTotal}");