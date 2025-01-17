
class program {
    static void Main(string[] args) {
        Console.WriteLine("Digite o numero para saber o expoente de cada linha: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= 3; j++) {
                Console.Write(Math.Pow(i, j) + " ");
                
            }
            Console.WriteLine();
        }
    }
}
