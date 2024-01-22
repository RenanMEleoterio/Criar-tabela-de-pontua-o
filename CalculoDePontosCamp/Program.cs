using CalculoDePontosCamp.CalculoDePontosCamp.Menus;
using CalculoDePontosCamp.CalculoDePontosCamp.Models;

//Dicionários de equipes
Dictionary<string, Equipe> EquipeCadastradas = new();
//Dicionário de menus
Dictionary<int, Menu> Menus = new();
Menus.Add(1, new MenuAdicionarEquipe());
Menus.Add(2, new MenuAdicionarJogadorAEquipe());
Menus.Add(3, new MenuAdicionarPontosPelaEquipe());
Menus.Add(4, new MenuAdicionarPontosPeloJogador());
Menus.Add(5, new MenuExibirTabela());
Menus.Add(6, new MenuExibirDetalhesDaEquipe());
//Classe main do programa
void main()
{
    Console.Clear();
    UI.ImprimeLogo();
    Console.WriteLine("\nDigite 1 para cadastrar uma equipe");
    Console.WriteLine("Digire 2 para cadastrar os jogadores a uma equipe");
    Console.WriteLine("Digite 3 para adicionar pontos a equipe");
    Console.WriteLine("Digire 4 para adicionar pontos a equipe informando o jogador");
    Console.WriteLine("Digite 5 para exibir a tabela de pontuação");
    Console.WriteLine("Digite 6 para exibir o detalhe da equipe");
    Console.WriteLine("Digire 0 para sair");

    Console.Write("\nDigite a sua escolha: ");
    bool opcaoValida = int.TryParse(Console.ReadLine()!, out int opcaoEscolhida);
    if (opcaoValida)
    {
        if(Menus.ContainsKey(opcaoEscolhida))
        {
            Menu MenuEscolhido = Menus[opcaoEscolhida];
            MenuEscolhido.Executar(EquipeCadastradas);
            if (opcaoEscolhida > 0) main();
        }
        else if(opcaoEscolhida == 0)
        {
            UI.Sair();
        }
        else
        {
            Console.WriteLine("Opção inválida");
            Menu.PrecionarTecla();
        }
    }
    else
    {
        Console.WriteLine("O que você digitou não é um número válido");
    }

}
main();