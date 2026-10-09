// Exercicio sistema de tags

HashSet<string> tags = new HashSet<string>
{
    "Eletrônico",
    "Promoção",
    "Celular"
};

Console.WriteLine("Digite uma tag para excluir do sistema: ");
string tag = Console.ReadLine();

if (tags.Contains(tag)) {
    tags.Remove(tag);
    Console.WriteLine($"Tag '{tag}' removida com sucesso!");
} else {
    Console.WriteLine($"Tag '{tag}' não encontrada no sistema.");
}

Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey(); // Aqui o programa aguarda o usuário pressionar uma tecla antes de continuar
Console.Clear();

foreach (string t in tags) {
    Console.WriteLine($"Tag: {t}");
}
