
using CalculoDePontosCamp.CalculoDePontosCamp.Models;

namespace CalculoDePontosCamp.CalculoDePontosCamp.Menus;

internal class MenuAdicionarPontosPeloJogador : Menu
{
    internal override void Executar(Dictionary<string, Equipe> equipesRegistradas)
    {
        //Chamada da classe base
        base.Executar(equipesRegistradas);
        Console.Write("\nDigite o nome do jogador a que quer atribuir uma pontuação para equipe: ");
        string nomeDoJogador = Console.ReadLine()!;

        /*
         * Variável para encontrar o jogador pelo nome, este método foi criado com intenção de pesquisar um jogador pelo nome e utilizar a equipe.
         * Funcionamento:
         * É gerado uma lista com todos os jogadores de todas as equipes usando o método SelectMany(), depois é usado o FirstOrDefault para pegar o primeiro com o nome correspondente, 
         * caso não seja encontrado recebe o valor padrão (neste caso o valor padrão é NULL)
         */
        var jogadorEncontrado = equipesRegistradas.Values.SelectMany(equipe => equipe.jogadores).FirstOrDefault(jogador => jogador.Nome.Equals(nomeDoJogador));

        //Verifica se o jogador encontrado é diferente de null
        if (jogadorEncontrado != null)
        {
            Console.WriteLine("Jogador encontrado com sucesso!\n");
            Equipe equipeDoJogador = jogadorEncontrado.EquipeDoJogador;
            Console.Write($"Digite qual foi a posição que a equipe {jogadorEncontrado.EquipeDoJogador.Nome} ficou: ");
            bool possivelConverterPosicao = int.TryParse(Console.ReadLine()!, out int posicao);
            //Verfica se a nota é possível converter
            if (possivelConverterPosicao)
            {
                equipeDoJogador.AdicionarNota(posicao);
                Thread.Sleep(1000);
                Console.WriteLine("A posição foi registrada com sucesso!");
                Thread.Sleep(1000);
                //Faz a iteração dos jogadores da equipe para adição de kills
                foreach (Jogador jogador in equipeDoJogador.jogadores)
                {                    
                    while (true)
                    {
                        Console.Write($"\nO jogador {jogador.Nome} fez quantas kills: ");
                        bool possivelConverter = int.TryParse(Console.ReadLine(), out int kill);
                        if (possivelConverter)
                        {
                            jogador.AdicionarKill(kill);
                            Console.WriteLine("Número de kills foi adicionado com sucesso!");
                            equipeDoJogador.PontuacaoEquipe.AdicionarKillANota(kill);
                            Thread.Sleep(1000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Por favor, insira um número válido para as kills.");
                        }
                    }
                }
            }
            Menu.PrecionarTecla();
        }
        else
        {
            Console.WriteLine("O jogador não foi encontrado, tente outro nome");
            Menu.PrecionarTecla();
        }
    }
}