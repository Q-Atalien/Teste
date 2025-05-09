using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes {
    internal class TesteDois {
        public static void Executar() {
            Console.WriteLine("-----Fibonacci-----");
            Console.WriteLine("Digite um valor");

            int valorFibonacci = int.Parse(Console.ReadLine());

            List<int> vetFibonacci = new List<int> { 0, 1 };


            while (vetFibonacci[vetFibonacci.Count - 1] <= valorFibonacci) {
                int fiboADD = vetFibonacci[vetFibonacci.Count - 1] + vetFibonacci[vetFibonacci.Count - 2];

                if (fiboADD <= valorFibonacci) {
                    vetFibonacci.Add(fiboADD);
                } else { break; }
            }

            foreach (var i in vetFibonacci) {
                Console.WriteLine(i + " ");
            }

        }
    }
}
