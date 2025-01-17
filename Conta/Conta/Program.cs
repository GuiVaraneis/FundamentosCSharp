
using Conta.Entities;
using System.Xml;

class Program {
        static void Main(string[] args) {
        ContaPadrao contaPadrao = new ContaPadrao(1001, "Guilherme", 0.0);
        ContaEmpresarial contaEmpresarial = new ContaEmpresarial(1002, "Maria", 0.0, 500.0);

        //upcasting

        ContaPadrao conta1 = contaEmpresarial;
        ContaPadrao conta2 = new ContaEmpresarial(1003, "bob", 0.0, 200.0);
        ContaPadrao conta3 = new ContaPoupanca(1003, "bob", 0.0, 0.01);
        Console.WriteLine(contaEmpresarial);
        Console.WriteLine();
        Console.WriteLine(conta1);
        Console.WriteLine();
        Console.WriteLine(conta3);
        //Downcasting

        ContaEmpresarial conta4 = (ContaEmpresarial)conta2;

        conta4.Emprestimo(100.0);
        Console.WriteLine();
        Console.WriteLine(conta4);

        //ContaEmpresarial conta5 = (ContaEmpresarial)conta3;

        if (conta3 is ContaEmpresarial) {
           // ContaEmpresarial conta5 = (ContaEmpresarial)conta3;
            ContaEmpresarial conta5 = conta3 as ContaEmpresarial;
            conta5.Emprestimo(200.0);
            Console.WriteLine("Empréstimo feito com sucesso!");

        }

        if(conta3 is ContaPoupanca) {
            //ContaPoupanca conta5 = (ContaPoupanca)conta3;
            ContaPoupanca conta5 = conta3 as ContaPoupanca;
            
            conta5.AtualizarSaldo();
            Console.WriteLine("Atualizado");
            Console.WriteLine(conta5) ;
        }



        }
    }
