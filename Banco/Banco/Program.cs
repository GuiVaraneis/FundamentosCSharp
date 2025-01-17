using Banco;
using System.Globalization;
class program {
    static void Main(string[] args) {

        ContaBancaria contaBancaria;
        Console.WriteLine("Cadastro de Conta Bancária");
        Console.WriteLine("No momento do cadastro, atente-se aos requisitos.");

        Console.WriteLine("Nome do Titular: ");
        string titular = Console.ReadLine();

        Console.WriteLine("\nFormato para criação do numero da conta: XXXX");
        Console.Write("Número da conta: ");

        int numeroDaConta = int.Parse(Console.ReadLine());
        contaBancaria = new ContaBancaria(titular, numeroDaConta);

        if (!contaBancaria.VerificaInformacoesDoUsuario(titular, numeroDaConta)) {
            Console.Write("Deseja depositar um valor inicial: S/N: ");
            char opcDeposito = char.Parse(Console.ReadLine());

            if (opcDeposito == 'S' || opcDeposito == 's') {
                Console.WriteLine("Quanto deseja depositar?: ");
                double primeiroDeposito = double.Parse(Console.ReadLine());
                
                contaBancaria = new ContaBancaria(titular, numeroDaConta, primeiroDeposito);

            }
        }
        else {
            Console.WriteLine("Não Foi Possivel completar a operação:\n" +
                "um dos campos não cumprem os requisitos para o cadastro");
            
        }


        Console.WriteLine(contaBancaria.ToString());

        Console.Write("Quanto deseja Depositar?: ");
        double deposito = double.Parse(Console.ReadLine());
        contaBancaria.Depositar(deposito);

        Console.WriteLine("Dados Atualizados: ");
        Console.WriteLine(contaBancaria.ToString());

        Console.Write("Quanto deseja sacar?: ");
        double saque = double.Parse(Console.ReadLine());
        contaBancaria.Sacar(saque);

        Console.WriteLine("Dados Atualizados: ");
        Console.WriteLine(contaBancaria.ToString());



    }
}