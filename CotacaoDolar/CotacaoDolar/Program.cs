//Programa que lê a cotação do dólar e depois um valor em dólares a ser comprado em reais. Informar quantos reais a pessoa vai pagar
//pelos dólares, considerando que a pessoa terá de pagar 6% do IOF sobre o valor do dólar

using CotacaoDolar;
using System.Globalization;
class Program {
    static void Main(string[] args) {
        
        Console.Write("Qual é a cotação do Dólar?: ");
        double cotacao = double.Parse(Console.ReadLine());
        
        Console.Write("Quantos dólares você vai comprar?: ");
        double dolaresAComprar = double.Parse(Console.ReadLine());

        double resultado = ConversorDeMoeda.DolarParaReal(cotacao, dolaresAComprar);

        Console.WriteLine("Valor convertido: " + resultado.ToString("F2", CultureInfo.InvariantCulture));



    }
}