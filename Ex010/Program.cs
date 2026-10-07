// Exercicio Hardware

float orcamento = 3000f;
Console.WriteLine("Digite as peças de hardware que deseja comprar: ");

while (orcamento > 0)
{
        
    Console.WriteLine("Digite o nome da peça: ");
    string nomePeca = Console.ReadLine();
    
    if (nomePeca == "0")
    {
        Console.WriteLine("Compra finalizada.");
        break;
    }
    
    Console.WriteLine($"Digite o preço da peça ({nomePeca}): ");
    float precoPeca = float.Parse(Console.ReadLine());
    
    Console.WriteLine("===========================================");
    
    
    if (precoPeca > orcamento) {
        Console.WriteLine("Orçamento insuficiente.");
        continue;
    } 
    
    orcamento -= precoPeca;
    
    Console.WriteLine($"O valor atual do orçamento é: {orcamento}");
    
    if (orcamento == 0) {
        Console.WriteLine("Orcamento zerado. Não é possível comprar mais peças.");
        break;
    }
    
}