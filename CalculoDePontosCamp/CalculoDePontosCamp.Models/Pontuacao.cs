namespace CalculoDePontosCamp.CalculoDePontosCamp.Models;   

internal class Pontuacao
{
    private int nota = 0;
    private int kills = 0;
    public int Kills => kills;
    public int Nota => nota;
    //Faz a soma da nota da posição da equipe com as kills feitas por cada jogador
    private int PontuacaoTotal => nota + kills;
    public int pontuacaoTotal => PontuacaoTotal;

    public int PontuacaoEquipe { 
        get
        {
            return nota;
        } 
    }

    //Lista de posições obtidas pela equipe
    private List<int> posicoesAnteriores = new();
    public IEnumerable<int> ultimasPosicoes => posicoesAnteriores;
    public void AdicionarNotas(int posicao)
    {
        //Swith de posição, para adição das notas

        /*
         * Pode haver melhora neste trecho, pois as notas foram definidas de forma arbitrária pelas posições
         */
        posicoesAnteriores.Add(posicao);
        switch (posicao)
        {
            case 1:
                nota += 16;
                break;
            case 2:
                nota += 10;
                break;
            case 3:
                nota += 9;
                break;
            case 4:
            case 5:
                nota += 8;
                break;
            case 6:
            case 7:
                nota += 7;
                break;
            case 8:
            case 9:
                nota += 6;
                break;
            case 10:
            case 11:
                nota += 5;
                break;
            case 12:
            case 13:
                nota += 4;
                break;
            case 14:
            case 15:
                nota += 3;
                break;
            case 16:
            case 17:
                nota += 2;
                break;
            case 18:
            case 19:
            case 20:
                nota += 1;
                break;
            default:
                nota += 0;
                break;
        }

    }

    public void AdicionarKillANota(int numeroDeKill)
    {
        kills += numeroDeKill;
    }
}
