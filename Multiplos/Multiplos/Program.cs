class program {
    static void Main(string[] args) {
        Console.WriteLine("Informe dois números: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        if (num1 % 2 == 0 && num2 % 2 == 0) {
            Console.WriteLine("Múltiplos");
        } else{
            Console.WriteLine("Não Múltiplos");
        }

    }
}