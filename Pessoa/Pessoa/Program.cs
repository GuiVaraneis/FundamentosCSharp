using Pessoa;

class program {
    static void Main(string[] args) {

        Pessoa pessoa1, pessoa2;

        pessoa1 = new Pessoa();
        pessoa2 = new Pessoa(); 
        
        Console.Write("Nome: ");
        pessoa1.Nome = Console.ReadLine();
        
        Console.Write("Idade: ");
        pessoa1.Idade = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        pessoa2.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        pessoa2.Idade = int.Parse(Console.ReadLine());

        
        if (pessoa1.Idade > pessoa2.Idade) {
            Console.WriteLine($"{pessoa1.Nome} é mais velha(o) que {pessoa2.Nome} ");
        }
        else {
            Console.WriteLine($"{pessoa2.Nome} é mais velha(o) que {pessoa1.Nome} ");
        }

    }
}