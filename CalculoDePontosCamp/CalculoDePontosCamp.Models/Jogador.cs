namespace CalculoDePontosCamp.CalculoDePontosCamp.Models;

internal class Jogador
{
    public string Nome { get; }
    public Equipe EquipeDoJogador;
    private int Kills = 0;
    public int kills => Kills; 
    public Jogador(string nome) {

        Nome = nome;
    }

    public void AdicionarEquipe(Equipe equipe)
    {
        EquipeDoJogador = equipe;
    }

    public void ExibirEquipe()
    {
        Console.WriteLine($"Nome da equipe {EquipeDoJogador.Nome!}");
    }
    public void AdicionarKill(int kill)
    {
        Kills += kill;
    }
}
