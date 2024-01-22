using CalculoDePontosCamp.CalculoDePontosCamp.Models;

namespace CalculoDePontosCamp.CalculoDePontosCamp.Menus;

internal class MenuAdicionarPontosPelaEquipe : Menu
{
    internal override void Executar(Dictionary<string, Equipe> equipesRegistradas)
    {
        base.Executar(equipesRegistradas);
        Console.Write("\nDigite o nome da equipe que será adicionado os pontos: ");
        string nomeDaEquipe = Console.ReadLine()!;
        //Pesquisa o nome da equipe pela chave do dicionário
        if (equipesRegistradas.ContainsKey(nomeDaEquipe))
        {
            Console.WriteLine("Equipe encontrada com sucesso!\n");
            Console.Write("Digite qual foi a posição que a equipe ficou: ");
            bool possivelConverterPosicao = int.TryParse(Console.ReadLine()!, out int posicao);
            //recebe a posição
            if(possivelConverterPosicao)
            {
                Equipe equipe = equipesRegistradas[nomeDaEquipe];
                equipe.AdicionarNota(posicao);
                Thread.Sleep(1000);
                Console.WriteLine("\nA posição foi registrada com sucesso!");
                Thread.Sleep(1000);
                //Itera os jogadores para adição de kills
                foreach (Jogador jogador in equipe.jogadores)
                { 
                    while (true)
                    {
                        Console.Write($"\nO jogador {jogador.Nome} fez quantas kills: ");
                        bool possivelConverter = int.TryParse(Console.ReadLine(), out int kill);
                        if (possivelConverter)
                        {
                            jogador.AdicionarKill(kill);
                            Console.WriteLine("Número de kills foi adicionado com sucesso!");
                            equipe.PontuacaoEquipe.AdicionarKillANota(kill);
                            Thread.Sleep(1000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Por favor, insira um número válido para as kills.\n");
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
            
            Menu.PrecionarTecla();
        }
        else
        {
            Console.WriteLine("A equipe não foi registrada ainda");
            Menu.PrecionarTecla();
        }
    }
}
