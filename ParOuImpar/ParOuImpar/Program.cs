class program {
    static void Main(string[] args) {
        Console.WriteLine("Informe um número");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0) {
            Console.WriteLine("O NUMERO ESCOLHIDO É PAR");
        }
        else {
            Console.WriteLine("O NUMERO ESCOLHIDO É IMPAR: ");
        }

    }
}