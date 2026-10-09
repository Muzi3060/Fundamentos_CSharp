// Exercicio Sobrecarga de métodos


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GerarEtiqueta("Camiseta"));
        Console.WriteLine(GerarEtiqueta("Camiseta", 49.90));
    }

    static string GerarEtiqueta(string nome) {
        return "Produto: " + nome;
    }
    
    static string GerarEtiqueta(string nome, double preco) {
        return "Produto: " + nome + " - Preço: R$" + preco.ToString("F2");
    }
    
    
    // Sobrecarga de métodos com diferentes tipos de assinatura
    
    // perguntar sobre instruções de nivel superior que precisam ser chamadas no main. 
}



