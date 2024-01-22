using CalculoDePontosCamp.CalculoDePontosCamp.Models;

namespace CalculoDePontosCamp.CalculoDePontosCamp.Menus;

internal class MenuAdicionarJogadorAEquipe: Menu
{
    internal override void Executar(Dictionary<string, Equipe> equipesRegistradas)
    {
        base.Executar(equipesRegistradas);
        Console.Write("\nDigite o nome da equipe que deseja adicionar o jogador: ");
        string nomeDaEquipe = Console.ReadLine()!;
        if (equipesRegistradas.ContainsKey(nomeDaEquipe))
        {
            /*
             * Após as verificações de nome e equipe, adiciona o jogador se tudo estiver ok
             */
            Console.WriteLine("Equipe encontrada com sucesso!\n");
            Equipe equipe = equipesRegistradas[nomeDaEquipe];
            Console.Write($"Digite o nome do jogador para a equipe {nomeDaEquipe} ");
            string nomeDoJogador = Console.ReadLine()!;
            if (equipe.jogadores.Any(j => j.Nome.Equals(nomeDoJogador)))
            {
                Console.WriteLine("Este jogador já está cadastrado nessa equipe!");
                Menu.PrecionarTecla();
            }
            else
            {
                Jogador novoJogador = new(nomeDoJogador);
                equipe.AdicionarJogador(novoJogador);
                Thread.Sleep(1000);
                Console.WriteLine($"\nO jogador {nomeDoJogador} foi cadastrado à {nomeDaEquipe} com sucesso!");
                Menu.PrecionarTecla();
            }
        }
        else
        {
            Console.WriteLine("Equipe não encontrada!\n");
            Menu.PrecionarTecla();
        }
    }
}
