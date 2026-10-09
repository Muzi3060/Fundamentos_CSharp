// Exercicio Rastreio da transportadora

Dictionary<string, string> rastreio = new Dictionary<string, string>
{
    {"BR123X", "Objeto em trânsito"},
    {"AL533X", "Objeto postado"},
    {"KJ444X", "Objeto entregue"}
};

Console.WriteLine($"Status atual do rastreio do objeto BR123X: {rastreio["BR123X"]}");
Console.WriteLine($"Status atual do rastreio do objeto AL533X: {rastreio["AL533X"]}");
Console.WriteLine($"Status atual do rastreio do objeto KJ444X: {rastreio["KJ444X"]}");

Console.WriteLine("=======================================");

Console.WriteLine($"Alteração no status do rastreio do objeto BR123X: {rastreio["BR123X"] = "Entregue"}");
Console.WriteLine($"Alteração no status do rastreio do objeto AL533X: {rastreio["AL533X"] = "Objeto em trânsito"}");
Console.WriteLine($"Alteração no status do rastreio do objeto KJ444X: {rastreio["KJ444X"] = "Objeto perdido"}");

