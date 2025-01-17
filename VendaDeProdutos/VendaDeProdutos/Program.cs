class Program {
    static void Main(string[] args) {

        Produto produto1 = new Produto("TV",500.00,10);
        produto1.Nome = "TV 4K";
        Console.WriteLine(produto1.ToString());

        Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());
        produto1.AdicionarProdutos(quantidade);

        Console.WriteLine("\nAtualização:");
        Console.WriteLine(produto1.ToString());

        Console.Write("Digite o número de produtos a ser removidos do estoque: ");
        quantidade = int.Parse(Console.ReadLine());
        produto1.RemoverProdutos(quantidade);

        Console.WriteLine("\nAtualização");
        Console.WriteLine(produto1);






    }
}