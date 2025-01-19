using ClassificarProduto.Entities;
using System.Globalization;

class Program {
    static void Main(string[] args) {
        List<Produto> produto = new List<Produto>();
        Console.Write("Entre com a quantidade de produtos: ");
        int qtdProdutos = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtdProdutos; i++) {
            Console.WriteLine($"Dados do produto #{i}");
            Console.Write("Comum, Usado ou importado?(c/u/i): ");
            char opc = char.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            if (opc == 'c') {
                produto.Add(new Produto(nome, preco));
                Produto produto1 = new Produto();

            }
            else if (opc == 'u') {
                Console.Write("Data da manufatura(DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                produto.Add(new ProdutoUsado(nome, preco, data));
            }
            else {
                Console.Write("Custo adicional: ");
                double custoAdicional = double.Parse(Console.ReadLine());
                produto.Add(new ProdutoImportado(nome, preco, custoAdicional));
            }

        }

        Console.WriteLine();
        Console.WriteLine("Classificação de preço dos produtos: ");
        foreach (Produto prod in produto) {
            Console.WriteLine(prod.DadosDoProduto());
        }
    }
}
