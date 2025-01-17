using System.Globalization;
using System;
class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Número de quartos: ");
        int numQuartos = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Infome valor de um produto");
        double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.WriteLine("Seu último nome, idade e altura: ");
        string[] vet = Console.ReadLine().Split(' ');
        string ultimoNome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2]);
        Console.WriteLine("Resultados finais: \n\n");
        Console.WriteLine(nome);
        Console.WriteLine(numQuartos);
        Console.WriteLine(valorProduto.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(ultimoNome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        
    }
    
}