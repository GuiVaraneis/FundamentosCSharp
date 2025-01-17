using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Xml.Serialization;
using System.Globalization;
public class Program {
    public static void Main() {

        List<Funcionario> funcionarios = new List<Funcionario>();

        Console.Write("Quantos funcionários deseja cadastrar?: ");
        int quantidade = int.Parse(Console.ReadLine());
        int i;
        for (i = 0; i < quantidade; i++) {

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionarios.Add(new Funcionario(id, nome, salario));
        }
        Console.WriteLine("----Funcionários cadastrados----");
        int indice = 1;
        foreach (var obj in funcionarios) {
            Console.WriteLine($"Funcionário #{indice}");
            Console.WriteLine(obj);
            Console.WriteLine("\n");
            indice++;
        }

        Console.WriteLine("Informe o ID do funcionário que deseja aumentar o sálário: ");
        int func = int.Parse(Console.ReadLine());


        Funcionario funcionarioEncontrado = funcionarios.Find(f => f.Id == func);

        if (funcionarioEncontrado != null) {
            Console.WriteLine("entre com a porcentagem: ");
            float percent = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionarioEncontrado.implementarPorcentagem(percent);
            Console.WriteLine("Cadastro feito com sucesso!\n");
        }
        else {
            Console.WriteLine("Funcionario não encontrado");
        }

        Console.WriteLine("----Funcionários Atualzados----");
        foreach (var obj in funcionarios) {
            Console.WriteLine($"Funcionário #{indice}");
            Console.WriteLine(obj);
            Console.WriteLine("\n");
        }

    }
}