using ScreenSound02.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Saindo...");
        Thread.Sleep(2000); 
        Console.Clear();
        
    }
}