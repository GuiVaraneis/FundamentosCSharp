//analisando números de 0 a 1000 e
//exibindo todos os números ímpares
//nesse intervalo
class program {
    static void Main(string[] args) {

        Console.Write("Informe um valor: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i <= x; i++) { 
            if(i % 2 != 0) {
                Console.Write(i + " - ");
            }
        }
    }

}
