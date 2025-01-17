using System.Globalization;

class program {
    static void Main(string[] args) {

        Console.WriteLine("Fatorial");

        Console.WriteLine("Informe um número");
        int n = int.Parse(Console.ReadLine());

        int fat = 1;
        if (n > 0) {
            for (int i = 0; i <= n; i++) {
                fat = fat * n;
                n = n - 1;
            }
        }
        Console.WriteLine("Fatorial: " + fat);
    }
}
