// Exercicio Múltiplos retornos com out

bool tryDividir(double a, double b, out double resultado)
{
    if (b == 0) {
        resultado = 0;
        return false;
    }
    
    resultado = a / b; // quem passa o argumento para o out é o próprio método, e não o chamador.
    return true;
    
}


if (tryDividir(10, 0, out double resultado)) { // aqui o resultado já está preenchido pelo método
    Console.WriteLine($"O resultado da divisão é: {resultado}");
} else {
    Console.WriteLine("Não é possível dividir por zero.");
}

// quem chama a função só atribui o valor de a e b, e o resultado é preenchido pelo método. O método retorna true ou false para indicar se a operação foi bem-sucedida ou não.
