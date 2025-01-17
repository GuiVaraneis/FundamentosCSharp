class program {
    static void Main(String[] args) {
        Console.WriteLine("Valor 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor 3: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor 4: ");
        int d = int.Parse(Console.ReadLine());

        int resultado = (a * b - c * d);

        Console.WriteLine($"Resultado: {resultado}");
    }
}