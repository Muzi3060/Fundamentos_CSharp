// Exercicio Vip list do tibia

List<string> viplist = new List<string>();

viplist.Add("Rafael");
viplist.Add("Lucas");
viplist.Add("gojo");


while (true)
{
    
    Console.WriteLine("Digite o nome de um jogador que deseje verificar se está na vip list: ");
    string nomeJogador = Console.ReadLine();
    
    if (viplist.Contains(nomeJogador)) {
        Console.WriteLine($"Jogador {nomeJogador} encontrado. Removendo da vip list");
        viplist.Remove(nomeJogador);
    }else {
        Console.WriteLine($"Jogador {nomeJogador} não foi encontrado. Adicionando na vip list");
        viplist.Add(nomeJogador);
    }
    
    Console.WriteLine("Deseja continuar modificando a vip list? (s/n)");
    string resposta = Console.ReadLine();
    
    if (resposta.ToLower() == "n" || resposta.ToLower() == "não") {
        break;
    }
    
}

Console.WriteLine("===============================================");
Console.WriteLine("Lista de jogadores na vip list: ");
Console.WriteLine("Jogadores: \n");

foreach (string jogador in viplist) {
    
    Console.WriteLine(jogador);
}