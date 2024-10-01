using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorExistênciaLetraA
{
    internal class ContadorDeA
    {
        public int Contador;
        public string Frase;
        public ContadorDeA()
        {
            
        }
        public int VerificadorDeString(string frase)
        {
            Contador = 0;

            foreach (char c in frase)
            {
                if (c == 'a' || c == 'A')
                {
                    Contador++;
                }
            }
            return Contador;
        }

        public override string ToString()
        {
            return "A letra 'a' aparece " + Contador + " vezes na string !";
        }
    }
}
