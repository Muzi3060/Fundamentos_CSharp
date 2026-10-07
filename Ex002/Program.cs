// Triangulo

double a,b,c;

Console.WriteLine("Digite o valor do lado A: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do lado B: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do lado C: ");
c = double.Parse(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b) { // A, B e C precisam ser menores que a soma dos outros dois lados
    Console.WriteLine("Os valores formam um triângulo.");
}
else {
    Console.WriteLine("os valores não formam um triângulo."); 
}