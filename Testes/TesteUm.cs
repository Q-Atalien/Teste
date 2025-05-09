using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes {
    internal class TesteUm {
        public static void Executar() {
            Console.WriteLine("-----Valor da Soma-----");
            int indice = 13;
            int soma = 0;
            int k = 0;

            for (; k < indice;) {
                k = k + 1;
                soma = soma + k;
            }
            Console.WriteLine(soma);
        }
    }
}
