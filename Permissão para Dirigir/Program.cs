namespace Permissão_para_Dirigir_
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            bool temHabilitacao = true;

            if (idade >= 18 && temHabilitacao)
            {
                Console.WriteLine("Parabéns, você pode dirigir! ");
            }
            else
            {
                Console.WriteLine("Desculpe, você não pode dirigir.");
            }
        }
    }
}
