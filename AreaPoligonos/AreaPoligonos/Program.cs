using System.Globalization;

class program {
    static void Main(string[] args) {
        Console.WriteLine("CALCULAR ÁREA DOS POLÍGONOS (triângulo retângulo," +
            "círculo, trapézio, quadrado, retângulo");

        Console.WriteLine("Informe vaor de A, B e C, respectivamente: ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());


        Console.Write($"ÁREA DO TRIANGULO RETANGULO: {((a * c) / 2).ToString("F2", CultureInfo.InvariantCulture)}\n");

        Console.Write($"ÁREA DO CÍRCULO: {(c * Math.Pow(Math.PI, 2)).ToString("F2", CultureInfo.InvariantCulture)}\n");

        Console.Write($"ÁREA DO TRAPÉZIO: {(((a + b) * c) / 2).ToString("F2", CultureInfo.InvariantCulture)}\n");

        Console.Write($"ÁREA DO QUADRADO: {(Math.Pow(b, 2)).ToString("F2", CultureInfo.InvariantCulture)}\n");

        Console.Write($"ÁREA DO RETÂNGULO: {(a * b).ToString("F2", CultureInfo.InvariantCulture)}\n");

    }
}