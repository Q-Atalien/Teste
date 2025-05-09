using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes {
    internal class TesteQuatro {
        public static void Executar() {

            Dictionary<string, double> faturamentoPorEstado = new Dictionary<string, double>() {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double total = faturamentoPorEstado.Values.Sum();

            Console.WriteLine("-----Porcentuais da Distribuidora-----");

            foreach (var estado in faturamentoPorEstado) {
                double percentual = (estado.Value * 100) / total;
                Console.WriteLine($"{estado.Key} – {percentual:F2}%");
            }

        }
    }
}
