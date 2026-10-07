// Cofre

string senha = "1234";

while (true)
{
    Console.WriteLine("Digite a senha:");
    string entrada = Console.ReadLine();

    if (entrada == senha)
    {
        Console.WriteLine("Acesso concedido! Tenha um bom dia!");
        break;
    }
    
    Console.WriteLine("Senha incorreta! Tenta novamente.");
    
}

