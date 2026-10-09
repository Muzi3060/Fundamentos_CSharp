// Exercicio Método básico com retorno

double imc(double peso, double altura) {
    return peso / (altura * altura);
}

Console.WriteLine("Digite o seu peso e altura: ");
double peso = double.Parse(Console.ReadLine());
double altura = double.Parse(Console.ReadLine());

double resultado = imc(peso, altura);

Console.WriteLine($"O seu IMC é: {resultado}");