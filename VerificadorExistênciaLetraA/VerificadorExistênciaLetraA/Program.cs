using System;
using VerificadorExistênciaLetraA;

namespace program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContadorDeA cont;
            Console.Write("Digite sua String: ");
            string frase = Console.ReadLine();

            cont = new ContadorDeA();
            cont.VerificadorDeString(frase);
            Console.WriteLine();
            Console.WriteLine(cont);

        }
    }
}