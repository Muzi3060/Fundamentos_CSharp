// Exercicio Roteirização logistica

List<double> pesos = new List<double>();
double pesoTotal = 0;

while (true)
{
    Console.WriteLine("Digite o peso de cada pacote (Digite um valor negativo para finalizar): ");

    double peso = double.Parse(Console.ReadLine());
    

    if (peso < 0) {
        break;
    }
    
    pesos.Add(peso);
}

foreach (double pacote in pesos) {
    pesoTotal += pacote;
}

Console.WriteLine($"Peso total dos pacotes: {pesoTotal}");