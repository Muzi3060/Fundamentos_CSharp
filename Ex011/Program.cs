// Exercicio Números

int numeroSecreto = 42;
int numeroDigitado;

do
{
    Console.WriteLine("Digite um número entre 1 e 100: ");
    numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado < numeroSecreto && numeroDigitado >= 36 && numeroDigitado <= 41) {
        Console.WriteLine("Muito Perto!");
    } else if (numeroDigitado < numeroSecreto && numeroDigitado >= 42 && numeroDigitado <= 48) {
        Console.WriteLine("Perto!");
    } else if (numeroDigitado < numeroSecreto && numeroDigitado > 16 || numeroDigitado >= 60 && numeroDigitado <= 66) {
        Console.WriteLine("Longe!");
    } else if (numeroDigitado < numeroSecreto && numeroDigitado > 6 || numeroDigitado >= 66 && numeroDigitado < 80) {
        Console.WriteLine("Muito Longe!");
    } else if (numeroDigitado < numeroSecreto && numeroDigitado > 0 || numeroDigitado >= 80) {
        Console.WriteLine("Muito Muito Longe!");
    } else if (numeroDigitado == numeroSecreto) {
        Console.WriteLine("Parabéns! Você acertou o número secreto!");
    } else {
        Console.WriteLine("Número inválido. Tente novamente.");
    }
} while (numeroDigitado != 42);