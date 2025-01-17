

class Program {
    static void Main(string[] args) {
        Salario servidor_1, servidor_2;
        
        servidor_1 = new Salario();
        servidor_2 = new Salario();

        Console.Write("Nome do funcionário: ");
        servidor_1.Nome = Console.ReadLine();

        Console.Write("Salário do funcionário: ");
        servidor_1.SalarioFuncionario = double.Parse(Console.ReadLine());

        Console.Write("Nome do funcionário: ");
        servidor_2.Nome = Console.ReadLine();

        Console.Write("Salário do funcionário: ");
        servidor_2.SalarioFuncionario = double.Parse(Console.ReadLine());

        double mediaSalario = (servidor_1.SalarioFuncionario + servidor_2.SalarioFuncionario) / 2;

        Console.Write("Salário Médio: " + mediaSalario);


    }
}