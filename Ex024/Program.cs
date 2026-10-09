// Exercicio Tradutor de comandos

using System.Reflection.PortableExecutable;

Dictionary<string, string> tradutor = new Dictionary<string, string>
{
    {"Avance", "Forward"},
    {"Regressa", "Backward"},
    {"Esquerda", "Left"},
    {"Direita", "Right"},
    {"Parar", "Stop"}
};

foreach (var palavra in tradutor) {
    Console.WriteLine($"A palavra {palavra.Key} em inglês é {palavra.Value} ");
    
    // Usamos .Key para acessar a chave do dicionário e .Value para acessar o valor correspondente.
}

Console.WriteLine("=======================================");

foreach (KeyValuePair<string, string> palavra in tradutor)
{
    Console.WriteLine($"A palavra {palavra.Key} em inglês é {palavra.Value} ");
}

