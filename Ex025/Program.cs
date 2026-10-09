// Exercicio filtro de e-mails

HashSet<string> emails = new HashSet<string>
{
    // Set com valores adicionados na inicialização
    // Poderia também ser feito com o método Add(), exemplo de uso: emails.Add(item)
    
    "user1@example.com", 
    "user2@example.com",
    "user3@example.com",
    "user1@example.com",
    "user2@example.com"
};

foreach (string email in emails)
{
    Console.WriteLine(email);
}
