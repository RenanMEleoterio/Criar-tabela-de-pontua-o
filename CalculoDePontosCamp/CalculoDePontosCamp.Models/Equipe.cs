namespace CalculoDePontosCamp.CalculoDePontosCamp.Models;

internal class Equipe
{
    public string Nome { get; }
    private List<Jogador> Jogadores = new();
    public Pontuacao PontuacaoEquipe = new();
    //Lista de Jogares que ficará acessiva
    public IEnumerable<Jogador> jogadores => Jogadores;

    public Equipe(string nome) 
    { 
        Nome = nome;
    }
    public void AdicionarJogador(Jogador jogador)
    {
        Jogadores.Add(jogador);
        jogador.AdicionarEquipe(this);
    }

    public void ExibirJogadoresDaEquipe()
    {
        foreach(Jogador jogador in Jogadores)
        {
            Console.WriteLine(jogador.Nome );
        }
    }
    public void AdicionarNota(int posicao)
    {
        PontuacaoEquipe.AdicionarNotas(posicao);
    }
    public static bool ExisteEquipe(Dictionary<string, Equipe> equipesJaExistentes, string nomeDaEquipeASerPesquisada)
    {
        return equipesJaExistentes.ContainsKey(nomeDaEquipeASerPesquisada);
    }
}
