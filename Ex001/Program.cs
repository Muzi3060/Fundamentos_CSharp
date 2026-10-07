// Exericico radar

Console.WriteLine("Digite a velocidade atual do carro em km: ");
double km = double.Parse(Console.ReadLine()); // double parse serve para converter a string digitada em número

if (km > 80) {
    Console.WriteLine("Você ultrapassou o limite de velocidade! Sua multa será de " + (km - 80) * 7);
    Console.WriteLine("Dirija com segurança!");
}
else {
    Console.WriteLine("Tenha uma boa viagem!");
}

