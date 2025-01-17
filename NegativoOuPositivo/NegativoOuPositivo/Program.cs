
class program {
    static void Main(string[] args) {
        Console.Write("Informe um número real: ");
        int num = int.Parse(Console.ReadLine());
        
        if (num < 0) {
            Console.WriteLine("NEGATIVO");
        } else if (num  > 0){
            Console.WriteLine("POSITIVO");
        }
        else {
            Console.WriteLine("ZERO");
        }


    }
}