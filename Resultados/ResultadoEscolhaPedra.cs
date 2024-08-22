using System.Security.Cryptography;
using Jokenpo.Enums;
using Jokenpo.Placar;

namespace Jokenpo.Resultados;

public class ResultadoEscolhaPedra : IResultado
{
    public string[] RetornarResultado()
    {
        var escolhaAdversario = RandomNumberGenerator.GetInt32(1, 4);

        if (escolhaAdversario == ((int)Ejogadas.Tesoura))
        {
            PlacarTotal.Vitorias++;
            return [$"{Ejogadas.Tesoura}", "Você ganhou"];
        }
        else if (escolhaAdversario == ((int)Ejogadas.Papel))
        {
            PlacarTotal.Derrotas++;
            return [$"{Ejogadas.Papel}", "Você perdeu"];
        }
        else
            return [$"{Ejogadas.Pedra}", "O jogo empatou"];
    }
}