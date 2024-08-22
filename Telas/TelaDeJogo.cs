using Jokenpo.Enums;
using Jokenpo.Resultados;
using Jokenpo.Placar;

namespace Jokenpo.Telas;

public static class TelaDeJogo
{
    public static void IniciarJogo()
    {
        try
        {
            var escolha = new Ejogadas();
            Console.Clear();
            Console.WriteLine($"Placar: {PlacarTotal.Vitorias} X {PlacarTotal.Derrotas}");
            Console.WriteLine("Escolha a sua jogada: ");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            Console.WriteLine("Digite 0 para sair");
            var escolhaNumero = Convert.ToInt32(Console.ReadLine());

            switch (escolhaNumero)
            {
                case 1:
                    escolha = Ejogadas.Pedra;

                    var pedra = new ResultadoEscolhaPedra();
                    var resultadoPedra = pedra.RetornarResultado();
                    AnalisandoResultado();
                    Console.WriteLine($"Você escolheu {escolha} e o adversário escolheu {resultadoPedra[0]}");
                    Console.WriteLine(resultadoPedra[1]);
                    Console.ReadKey();
                    IniciarJogo();
                    break;

                case 2:
                    escolha = Ejogadas.Papel;

                    var papel = new ResultadoEscolhaPapel();
                    var resultadoPapel = papel.RetornarResultado();
                    AnalisandoResultado();
                    Console.WriteLine($"Você escolheu {escolha} e o adversário escolheu {resultadoPapel[0]}");
                    Console.WriteLine(resultadoPapel[1]);
                    Console.ReadKey();
                    IniciarJogo();
                    break;

                case 3:
                    escolha = Ejogadas.Tesoura;

                    var tesoura = new ResultadoEscolhaTesoura();
                    var resultadoTesoura = tesoura.RetornarResultado();
                    AnalisandoResultado();
                    Console.WriteLine($"Você escolheu {escolha} e o adversário escolheu {resultadoTesoura[0]}");
                    Console.WriteLine(resultadoTesoura[1]);
                    Console.ReadKey();
                    IniciarJogo();
                    break;

                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Valor invalido tente novamente");
                    Console.ReadKey();
                    IniciarJogo();
                    break;
            }
        }
        catch
        {
            Console.WriteLine("Um erro ocorreu");
            Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
            Console.ReadKey();
            TelaInicial.CriarTelaInicial();
        }
    }

    public static void AnalisandoResultado()
    {
        Console.Clear();
        Thread.Sleep(500);
        Console.WriteLine("JO...");
        Thread.Sleep(500);
        Console.WriteLine("KEN...");
        Thread.Sleep(500);
        Console.WriteLine("PO!");
    }

}