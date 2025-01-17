using System;
using System.Globalization;

class program {
    static void Main(string[] args) {
        Console.WriteLine("CALCULAR ÁREA DE UM CÍRCULO");
        Console.WriteLine("informe o valor do Raio do círculo: ");
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine($"Área do círculo: {area.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
