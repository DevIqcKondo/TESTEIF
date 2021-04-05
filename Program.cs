using System;

namespace TESTEIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int f;
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Determinando se um número é par ou ímpar");
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();
            Console.Write("Digite um número: ");
            Console.ForegroundColor=ConsoleColor.Green;
            num = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            f=(num%2);
            if (f==1){
                Console.ForegroundColor=ConsoleColor.Red;
                  Console.WriteLine("O número informado é ímpar.");
            } else{
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.WriteLine("O número informado é par.");
            }
            Console.ResetColor();
            Console.Beep();
        }
    }
}
