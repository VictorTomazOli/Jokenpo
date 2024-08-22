using System.Security.Cryptography;
using Jokenpo.Enums;
using Jokenpo.Placar;

namespace Jokenpo.Resultados;

public class ResultadoEscolhaPapel : IResultado
{
    public string[] RetornarResultado()
    {
        var escolhaAdversario = RandomNumberGenerator.GetInt32(1, 4);

        if (escolhaAdversario == ((int)Ejogadas.Pedra))
        {
            PlacarTotal.Vitorias++;
            return [$"{Ejogadas.Pedra}", "Você ganhou"];
        }
        else if (escolhaAdversario == ((int)Ejogadas.Tesoura))
        {
            PlacarTotal.Derrotas++;
            return [$"{Ejogadas.Tesoura}", "Você perdeu"];
        }
        else
            return [$"{Ejogadas.Papel}", "O jogo empatou"];
    }
}