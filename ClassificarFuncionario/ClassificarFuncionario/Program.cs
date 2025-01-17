using ClassificarFuncionario.Entities;
using System.Globalization;

class Program {

    static void Main(string[] args) {
        List<FuncionarioPadrao> list = new List<FuncionarioPadrao>();

        Console.WriteLine("Entre com a quantidade de funcionários: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++) {
            Console.Write($"Dados do Funcionario #{i}: ");

            Console.Write("O funcionário é tercerizado?(s/n): ");
            char opc = char.Parse(Console.ReadLine());
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Horas: ");
            int horas = int.Parse(Console.ReadLine());
            
            Console.Write("Valor por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if(opc == 's') {
                Console.Write("Despesa Adicional: ");
                double salarioAdicional = double.Parse(Console.ReadLine());
                
                list.Add(new FuncionarioTercerizado(nome, horas, valorPorHora, salarioAdicional));

            }
            else {
                list.Add(new FuncionarioPadrao(nome, horas, valorPorHora));

            }
            
        }
        Console.WriteLine();
        Console.WriteLine("Pagamentos: ");

        foreach (FuncionarioPadrao func in list) {
            Console.WriteLine(func.Nome + " - $" + func.Pagamento().ToString("F2", CultureInfo.InvariantCulture));

        }



    }
}