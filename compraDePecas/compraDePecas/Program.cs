using System.Globalization;

static void Main(string[] args) {
    Console.Write("Código da peça 1: ");
    int codigo1 = int.Parse(Console.ReadLine());

    Console.Write("Quantidade de peças (peça 1): ");
    int qtd_peca1 = int.Parse(Console.ReadLine());

    Console.Write("Valor unitário (peça 1): ");
    double valorPeca1 = double.Parse(Console.ReadLine());

    Console.Write("Código da peça 2: ");
    int codigo2 = int.Parse(Console.ReadLine());

    Console.Write("Quantidade de peças (peça 2): ");
    int qtd_peca2 = int.Parse(Console.ReadLine());

    Console.Write("Valor unitário (peça 2): ");
    double valorPeca2 = double.Parse(Console.ReadLine());

    Console.WriteLine("RESULTADO FINAL: ");

    Console.WriteLine($"VALOR TOTAL: {((qtd_peca1 * valorPeca1) + (qtd_peca2 * valorPeca2)).ToString("F2", CultureInfo.InvariantCulture)}");
}