using SalarioFuncionario.Entities.Enums;
using SalarioFuncionario.Entities;
using System.Globalization;

namespace SalarioFuncionario {
    class Program {
        static void Main(string[] args) {
            Console.Write("Nome do Departamento: ");
            string deptNome = Console.ReadLine();
            Console.Write("Nome do funcionário: ");
            string nomefunc = Console.ReadLine();
            Console.Write("Level(Junior/MidLevel/Senior): ");
            NivelFuncionario nivel = Enum.Parse<NivelFuncionario>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(deptNome);

            Funcionario funcionario = new Funcionario(nomefunc, nivel, salarioBase, dept);

            Console.WriteLine("Quantos contratos designados " +
                "para este funcionário?: ");

            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"entre com o contrato de Nº{i}: ");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração em horas: ");
                int horas = int.Parse(Console.ReadLine());
                ContratoHoras contrato = new ContratoHoras (date, valorPorHora, horas);
                
                funcionario.addContrato(contrato);
            }

            Console.WriteLine("Entre com o mês e o ano  atual " +
                "para calcular a sálario total (MM/AAAA): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring (3));

            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Departamento: " + funcionario.Departamento.Nome);
            Console.WriteLine("Salário Mensal atual: " + mesEAno + ": " + funcionario.SalarioTotal(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}