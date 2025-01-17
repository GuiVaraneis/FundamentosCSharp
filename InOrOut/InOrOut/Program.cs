

class program {
    static void Main(string[] args) {
        Console.Write("Insira a quantidade de valores que deseja inserir: ");
        int n = int.Parse(Console.ReadLine());

        int cont_in = 0;
        int cont_out = 0;

        for (int i = 0; i < n; i++) {
            Console.WriteLine("Insira um numero qualquer: ");
            int x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 20) {
                cont_in += 1;
            }
            else {
                cont_out += 1;
            }
        }Console.WriteLine();
        Console.WriteLine(cont_in + " in");
        Console.WriteLine(cont_out + " out");



    }



}
