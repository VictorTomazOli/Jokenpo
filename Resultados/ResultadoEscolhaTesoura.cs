using System.Security.Cryptography;
using Jokenpo.Enums;
using Jokenpo.Placar;

namespace Jokenpo.Resultados;

public class ResultadoEscolhaTesoura : IResultado
{
    public string[] RetornarResultado()
    {
        var escolhaAdversario = RandomNumberGenerator.GetInt32(1, 4);

        if (escolhaAdversario == ((int)Ejogadas.Papel))
        {
            PlacarTotal.Vitorias++;
            return [$"{Ejogadas.Papel}", "Você ganhou"];
        }
        else if (escolhaAdversario == ((int)Ejogadas.Pedra))
        {
            PlacarTotal.Derrotas++;
            return [$"{Ejogadas.Pedra}", "Você perdeu"];
        }
        else
            return [$"{Ejogadas.Tesoura}", "O jogo empatou"];
    }
}