namespace TextEditor;
class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu() 
    {
       Console.Clear();
       Console.WriteLine("O que você deseja?");
       Console.WriteLine("1 - Abrir Arquivo");
       Console.WriteLine("2 - Criar novo Arquivo");
       Console.WriteLine("0 - Sair");
       short option = short.Parse(Console.ReadLine());

       switch(option) 
       {
         case 0: System.Environment.Exit(0); break;
         case 1: Abrir(); break;
         case 2: Editar(); break;
         default: Menu(); break;
       }
      
    }

    static void Abrir()
    {
        Console.Clear();
        Console.WriteLine("Qual o nome do Arquivo?");
        string patch = Console.ReadLine();

        using(var file = new StreamReader(patch))
        {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
        }
        Console.WriteLine("");
        Console.ReadLine();
        Menu();
    }

    static void Editar()
    {
      Console.Clear();
      Console.WriteLine("Digite o Texto abaixo (ESC para sair!)");
      Console.WriteLine("----------------------");
      string text = "";

      do 
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      }
      while(Console.ReadKey().Key != ConsoleKey.Escape);

      Salvar(text);
    }

    static void Salvar(string text) 
    {
       Console.Clear();
       Console.WriteLine("Como deseja salvar o Arquivo?");
       var patch = Console.ReadLine();

       using(var file = new StreamWriter(patch))
       {
         file.WriteLine(text); 
       }
       Console.WriteLine($"Arquivo {patch} salvo com sucesso!");
       Menu();
    }

}
