// Contagem Regressiva

Console.WriteLine("Digite o número para a contagem regressiva: (Precisa ser positivo)");
int contador = int.Parse(Console.ReadLine());

if (contador > 0) { // só começa se for maior que 0
 
 Console.WriteLine("Iniciando contagem regressiva...");
 
 for (int i = contador;i >= 0; i--) {
  Console.WriteLine($"Contagem: {i}");
 }
 
 Console.WriteLine($"Parabéns! Voçê esperou todos os {contador} segundos!");
 Console.WriteLine("Tempo esgotado!");
} else {
 
 Console.WriteLine("Número inválido, precisa ser positivo!");
}