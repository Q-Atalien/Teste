using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Fat {
    [JsonPropertyName("dia")]
    public int Dia { get; set; }

    [JsonPropertyName("valor")]
    public double Valor { get; set; }
}

namespace Testes {
    internal class TesteTres {
        public static void Executar() {

            //XML

            Console.WriteLine("-----XML Faturamento-----");
            string dadosXML = @"Data\dadosXML.xml";

            XDocument xDados = XDocument.Load(dadosXML);

            var xFaturamento = xDados.Descendants("row").
                                Select(fat => new {
                                    Dia = fat.Element("dia")?.Value,
                                    Valor = double.Parse(fat.Element("valor")?.Value ?? "0", CultureInfo.InvariantCulture)
                                });

            double xMenorSemZero = xFaturamento.Where(f => f.Valor > 0).Min(f => f.Valor);
            double xMedia = xFaturamento.Where(f => f.Valor > 0).Average(f => f.Valor);
            int xDiasAcimaMedia = xFaturamento.Count(f => f.Valor > xMedia);

            Console.WriteLine($"Maior Faturamento: {xFaturamento.Max(f => f.Valor)}\nMenor Faturamento: {xMenorSemZero}\n" +
                $"Quantidade de dias acima da média: {xDiasAcimaMedia}");

            //JSON

            Console.WriteLine("-----JSON Faturamento-----");
            string dadosJSON = @"Data\dadosJSON.json";

            string jDados = System.IO.File.ReadAllText(dadosJSON);

            List<Fat> jFaturamento = JsonSerializer.Deserialize<List<Fat>>(jDados) ?? new List<Fat>();

            double jMenorSemZero = jFaturamento.Where(f => f.Valor > 0).Min(f => f.Valor);
            double jMedia = jFaturamento.Where(f => f.Valor > 0).Average(f => f.Valor);
            int jDiasAcimaMedia = jFaturamento.Count(f => f.Valor > jMedia);

            Console.WriteLine($"Maior Faturamento: {jFaturamento.Max(f => f.Valor)}\nMenor Faturamento: {jMenorSemZero}\n" +
                $"Quantidade de dias acima da média: {jDiasAcimaMedia}");
        }
    }
}
