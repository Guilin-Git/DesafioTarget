using System;

namespace CalculateFibonacci
{
    internal class Fibonacci
    {
        public int A { get; set; }
        public int B { get; set; }

        public Fibonacci(int n)
        {
            A = 0;
            B = 1;
        }

        public void PertenceFibonacci(int n)
        {
            if (n == A || n == B)
            {
                Console.WriteLine("Número pertence à sequência de Fibonacci");
                return; 
            }

            int c = A + B;
            while (c <= n)
            {
                if (c == n)
                {
                    Console.WriteLine("Número pertence à sequência de Fibonacci");
                    return; 
                }

                A = B;
                B = c;
                c = A + B;
            }

            Console.WriteLine("Número não pertence à sequência de Fibonacci");
        }
    }
}