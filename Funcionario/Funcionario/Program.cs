
class program {
    static void Main(string[] args) {
        
        Console.Write("Número do Funcionário: ");
        int numFuncionario = int.Parse (Console.ReadLine());
        
        Console.Write("horas trabalhadas: ");
        int horasTrabalhadas = int.Parse (Console.ReadLine());
        
        Console.Write("Informe o valor que o funcionário recebe por hora trabalhada: ");
        double valorPorHoras = double.Parse (Console.ReadLine());

        Console.WriteLine($"Número do funcionário: {numFuncionario}");
        Console.WriteLine($"Salário calculado: {horasTrabalhadas * valorPorHoras}");
    }
}