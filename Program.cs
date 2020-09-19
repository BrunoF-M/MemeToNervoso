using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string texto;


            Console.Write("Usuário, o que você pensa sobre mim? ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            texto = Console.ReadLine();
            Console.ResetColor();


            Console.WriteLine("- E sabe o que eu penso de você?");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{texto.Remove(10)}");
            Console.ResetColor();
            Console.Write("... NÃO, PERA.\nTô nervoso");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para finalizar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
