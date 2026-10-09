// Exercicio Lista empacotada

List<(string Nome, string Cargo)> funcionarios = new List<(string Nome, string Cargo)>
{
    ("Carlos", "Designer"),
    ("Azil", "Gamer"),
    ("Ricarda", "Marketing")
};

// Criamos acima uma lista de tuplas, que é uma coleção de elementos do mesmo tipo. Cada elemento da lista é uma tupla que contém dois valores: Nome e Cargo. A lista é inicializada com valores. 

funcionarios.Add(("João", "Desenvolvedor")); // Adicionamos um funcionário à lista, passando os valores para a tupla.
funcionarios.Add(("Maria", "Gerente")); // Adicionamos outro funcionário à lista, passando os valores para a tupla.

foreach (var funcionario in funcionarios)
{
    Console.WriteLine($"Nome: {funcionario.Nome}, Cargo: {funcionario.Cargo}");
}