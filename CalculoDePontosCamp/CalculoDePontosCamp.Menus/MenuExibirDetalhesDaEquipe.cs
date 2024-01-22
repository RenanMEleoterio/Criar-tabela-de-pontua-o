using CalculoDePontosCamp.CalculoDePontosCamp.Models;

namespace CalculoDePontosCamp.CalculoDePontosCamp.Menus;

internal class MenuExibirDetalhesDaEquipe : Menu
{
    internal override void Executar(Dictionary<string, Equipe> equipesRegistradas)
    {
        base.Executar(equipesRegistradas);
        Console.Write("\nDigite o nome da equipe que será exibido os detalhes: ");
        string nomeDaEquipe = Console.ReadLine()!;
        if(equipesRegistradas.ContainsKey(nomeDaEquipe))
        {
            //Mostra os dados da equipe
            Console.WriteLine("A equipe foi encontrada com sucesso!\n");
            Equipe equipe = equipesRegistradas[nomeDaEquipe];
            string posicoesAnteriores = string.Join("º, ", equipe.PontuacaoEquipe.ultimasPosicoes);
            Console.WriteLine($"As suas ultimas posições foram: {posicoesAnteriores}\n");
            Console.WriteLine($"Nome da equipe: {nomeDaEquipe} sua pontuação é de {equipe.PontuacaoEquipe.pontuacaoTotal}\n");
            foreach(Jogador jogador in equipe.jogadores)
            {
                Console.WriteLine($"O jogador {jogador.Nome} fez {jogador.kills} kills");
            }
            Console.WriteLine("\n");
        }
        Menu.PrecionarTecla();
    }
}
