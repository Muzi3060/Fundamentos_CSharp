// Exercicio Rastreador

int[] codigos = {105, 204, 310, 498, 550}; // Array já preenchido com 5 valores

Console.WriteLine("Digite o código do item que deseja rastrear: ");

int codigoDigitado = int.Parse(Console.ReadLine());

foreach (int codigo in codigos) {
    if (codigo == codigoDigitado) {
        Console.WriteLine($"Código {codigoDigitado} encontrado no indice {Array.IndexOf(codigos, codigo)} do inventário.");
        break;
        
        // Aqui usamos o array.indexof para pegar o indice do item encontrado no array, e o break para sair do loop caso o item seja encontrado.
    }
    
}

if (!codigos.Contains(codigoDigitado)) {
    Console.WriteLine($"Código {codigoDigitado} não encontrado no inventário.");
    
    // Aqui usamos o contains para verificar se o item digitado está no array, caso não esteja, exibimos a mensagem de que o item não foi encontrado.
}



