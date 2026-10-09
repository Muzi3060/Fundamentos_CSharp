// Exercicio catraca de estádio

HashSet<long> cpfs = new HashSet<long>
{
    12345678901,
    98765432100,
    11122233344
};

Console.WriteLine("Digite o seu cpf (somente números): ");
long cpf = long.Parse(Console.ReadLine());

if (cpfs.Contains(cpf)) {
    Console.WriteLine("Catraca Liberada!");
} else {
    Console.WriteLine("Catraca bloqueada!");
}