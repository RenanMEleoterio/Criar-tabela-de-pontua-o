using CalculoDePontosCamp.CalculoDePontosCamp.Models;

namespace CalculoDePontosCamp.CalculoDePontosCamp.Menus;

internal class MenuExibirTabela : Menu
{
    internal override void Executar(Dictionary<string, Equipe> equipesRegistradas)
    {
        base.Executar(equipesRegistradas);
        //Exibe a tabela de pontos em ordem descrescente
        var equipesOrdenadas = equipesRegistradas.Values.OrderByDescending(equipe => equipe.PontuacaoEquipe.pontuacaoTotal);
        int contador = 1;
        Console.WriteLine("Tabela:\n");
        foreach ( var equipe in equipesOrdenadas)
        {
            Console.WriteLine($"{contador}º: {equipe.Nome}  {equipe.PontuacaoEquipe.Nota}pts  {equipe.PontuacaoEquipe.Kills} -> Pontuação total: {equipe.PontuacaoEquipe.pontuacaoTotal}\n");
            contador++;
        }
        Menu.PrecionarTecla();
    }
}
