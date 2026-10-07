// Exercicio Menu

int opcao;

do
{
    Console.WriteLine("1-Novo Jogo\n2-Carregar Jogo\n3-Configurações\n0-Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Iniciando um novov jogo...");
            break;
        case 2:
            Console.WriteLine("Carregando o seu jogo... Aguarde um momento.");
            break;
        case 3:
            Console.WriteLine("Acessando as configurações do jogo...");
            break;
        case 0:
            Console.WriteLine("Saindo do jogo... Até a próxima!");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }

} while (opcao != 0);