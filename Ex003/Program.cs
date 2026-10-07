// Exercicio calculadora

double num1, num2;

Console.WriteLine("Digite o primeiro número: ");
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação (+, -, x, /): ");
switch (Console.ReadLine())
{
    case "+" :
        Console.WriteLine("O resultado da soma é: " + (num1 + num2));
        break;
    case "-":
        Console.WriteLine("O resultado da subtração é: " + (num1 - num2));
        break;
    case "x" :
        Console.WriteLine("O resultado da multiplicação é: " + (num1 * num2));
        break;
    case "/":
        if (num2 != 0) {
            Console.WriteLine("O resultado da divisão é: " + (num1 / num2));
        }
        else {
            Console.WriteLine("Não é possível dividir por zero.");
        }
        break;
    default:
        Console.WriteLine("Operação inválida.");
        break;
        
}