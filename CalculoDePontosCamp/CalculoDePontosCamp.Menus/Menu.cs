using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoDePontosCamp.CalculoDePontosCamp.Models;
namespace CalculoDePontosCamp.CalculoDePontosCamp.Menus;

internal class Menu
{
    //classe base dos menus
    internal virtual void Executar(Dictionary<string, Equipe> equipesRegistradas)
    {
        Console.Clear();
        UI.ImprimeLogo();
    }

    public static void PrecionarTecla()
    {
        Console.WriteLine("Digite um tecla para sair");
        Console.ReadKey();
    }

}
