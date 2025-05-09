using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes {
    internal class TesteCinco {
        public static void Executar() {
            Console.WriteLine("-----Inverter String-----");

            Console.WriteLine("Digite uma palavra");

            string palavra = Console.ReadLine();
            string invertida = "";

            for (int i = palavra.Length - 1; i >= 0; i--) {
                invertida += palavra[i];
            }

            Console.WriteLine($"Palavra Correta: {palavra}");
            Console.WriteLine($"Palavra Invertida: {invertida}");

        }
    }
}
