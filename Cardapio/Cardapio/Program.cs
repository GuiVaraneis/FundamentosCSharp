using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

class program {
    static void Main(string[] args) {

        
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("| Código | ESPECIFICAÇÃO   |  PREÇO  |");
        Console.WriteLine("|   1    | Cachorro-quente | R$ 4.00 |");
        Console.WriteLine("|   2    |    X-Salada     | R$ 4.50 |");
        Console.WriteLine("|   3    |    X-Bacon      | R$ 5.00 |");
        Console.WriteLine("|   4    | Torrada Simples | R$ 2.00 |");
        Console.WriteLine("|   5    |   Refrigerante  | R$ 1.50 |");
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("\n\n");
        Console.Write("informe o código do produto: ");

        Console.Write("Qual item deseja?(Informe o código correspondente do item): ");
        int codigoItem = int.Parse(Console.ReadLine());

        Console.Write("Informe a quantidade do produto: ");
        int qtd = int.Parse(Console.ReadLine());

        string nomeItem = "";
        double valor = 0.0;

        if(codigoItem == 1) {
            nomeItem = "Cachorro-Quente";
            valor = 4;
        
        }else if(codigoItem == 2){
            nomeItem = "X-Salada";
            valor = 4.5;
        
        }else if(codigoItem == 3) {
            nomeItem = "X-Bacon";
            valor = 5;
        
        }else if(codigoItem == 4) {
            nomeItem = "Torrada Simples";
            valor = 2.00;
        
        }else if(codigoItem == 5) {
            nomeItem = "Refrigerante";
            valor = 1.50;
        
        }else{

            Console.WriteLine("opção inválida");
            
        
        }

        Console.WriteLine($"Você selecionou {nomeItem}\nValor total: R$ {valor * qtd}");
        
        

    }
}