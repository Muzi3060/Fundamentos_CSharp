// Exercicio Confirmar Senha

Console.WriteLine("Digite uma senha: ");
string senha = Console.ReadLine();
string senhaConfirmada;

do
{
    Console.WriteLine("Confirme a senha: ");
    senhaConfirmada = Console.ReadLine();
    
    if (senhaConfirmada == senha)
    {
        Console.WriteLine("Conta criada com sucesso!");
    } else {
        Console.WriteLine("As senhas não coincidem. Tente novamente.");
    }
    
} while (senhaConfirmada != senha);