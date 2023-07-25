using System;

namespace EditorHtml 
{
    public static class Menu 
    {
        public static void Show()
        {
          Console.Clear();
          Console.BackgroundColor = ConsoleColor.White;
          Console.ForegroundColor = ConsoleColor.DarkGray;

          DrawScreen();
          WriteOptions();
          

          var option = short.Parse(Console.ReadLine());
          HandleMenuOption(option);

        }

        private static void DrawScreen()
        {
           Console.Write("+");
            for (int i = 0; i <= 30; i++)
            
                Console.Write("-");
                Console.Write("/n");

            for (int lines = 0; lines <= 10; lines++);
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++);
                Console.Write(" ");

                Console.Write("|");
                Console.Write("/n");
            }
              
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            
                Console.Write("-");
                Console.Write("/n");
        }
    
        public static void WriteOptions()
        {
            Console.SetCursorPosition(1,1);
            Console.WriteLine(" Editor HTML.");
            Console.SetCursorPosition(1,2);
            Console.WriteLine("============");
            Console.SetCursorPosition(1,3);
            Console.WriteLine(" Selecione uma opção abaixo.");
            Console.SetCursorPosition(1,5);
            Console.WriteLine(" 1 - Novo Arquivo.");
            Console.SetCursorPosition(1,6);
            Console.WriteLine(" 2 - Abrir.");
            Console.SetCursorPosition(1,8);
            Console.WriteLine(" 0 - Sair.");
            Console.SetCursorPosition(1,9);
            Console.Write(" Opção: ");

        }
    
        public static void HandleMenuOption(short option)
        {
           switch (option) 
           {
             case 1: Editor.Show(); break;
             case 2: Console.WriteLine("View"); break;
             case 0: {
                Console.Clear();
                Environment.Exit(0);
                break;
             }
             default: Show(); break;
           }
        }

    }

     

}


