class program {
    static void Main(string[] args) {
        string[] valores = Console.ReadLine().Split(' ');
        Console.WriteLine("informe coordenada X e Y: ");
        int x = int.Parse(valores[0]);;
        int y = int.Parse(valores[1]);

        while ((x != 0) || (y != 0)) {
            if (x > 0 && y > 0) {
                Console.WriteLine("Primeiro Quadrante");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Segundo Quadrante");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("Terceiro Quadrante");
            }
            else {
                Console.WriteLine("Quarto quadrante");
            }
            valores = Console.ReadLine().Split();
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
        }
        Console.WriteLine("Uma das coodenadas é zero\nProgrma encerrado");
        
    }
}