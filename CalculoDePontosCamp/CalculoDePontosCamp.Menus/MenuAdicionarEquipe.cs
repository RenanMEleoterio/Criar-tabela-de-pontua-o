using CalculoDePontosCamp.CalculoDePontosCamp.Models;

namespace CalculoDePontosCamp.CalculoDePontosCamp.Menus;

internal class MenuAdicionarEquipe : Menu
{
    internal override void Executar(Dictionary<string, Equipe> equipesRegistradas)
    {
        //Pesquisa a equipe pela chave, caso não exista a adiciona ao dicionário
        base.Executar(equipesRegistradas);
        Console.Write("\nDigite o nome da equipe que será cadastrada: ");
        string nomeDaEquipe = Console.ReadLine()!;
        if(!Equipe.ExisteEquipe(equipesRegistradas, nomeDaEquipe))
        {
            Equipe novaEquipe = new(nomeDaEquipe);
            equipesRegistradas.Add(nomeDaEquipe, novaEquipe);
            Thread.Sleep(1000);
            Console.WriteLine("\nA equipe foi registrada com sucesso!");
            Menu.PrecionarTecla();
        }
        else
        {
            Console.WriteLine("\nEsta equipe já foi criada!");
            Menu.PrecionarTecla();
        }
    }
}
