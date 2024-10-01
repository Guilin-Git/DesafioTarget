
using CalculateFibonacci;
using System;
using System.Threading.Channels;

namespace program 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Olá, Deseja saber se um numero pertence a sequencia de Fibonacci? (s/n) ");
            char validate = char.Parse(Console.ReadLine());
            while (validate == 's')
            {
                Console.Write("Insira um valor inteiro para ver se ele pertence a sequência de Fibonacci: ");
                int n = int.Parse(Console.ReadLine());

                Fibonacci fib = new Fibonacci(n);
                Console.WriteLine();
                fib.PertenceFibonacci(n);
                Console.WriteLine();
                Console.Write("Deseja continuar? (s/n) ");
                validate = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Obrigado por usar o programa!!!");
        }

    }
}