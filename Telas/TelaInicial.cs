namespace Jokenpo.Telas;

public static class TelaInicial
{
    public static void CriarTelaInicial()
    {
        Console.Clear();
        Console.WriteLine("O classico jogo Jokenpo");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Thread.Sleep(100);
        TelaDeJogo.IniciarJogo();
    }
}